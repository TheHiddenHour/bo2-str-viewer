using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using PS3Lib;
using Newtonsoft.Json;
using System.IO;

namespace cod_str_viewer {
    public partial class MainForm : Form {

        public struct StringEntry {
            public uint PointerAddress, DataAddress;
            public string Text;
        }

        public MainForm() {
            InitializeComponent();
        }

        private const uint StringPointersBegin = 0x133f06c; // Beginning of string pointers list 
        private List<StringEntry> StringsList; // List of string entries 
        private PS3API PS3;

        private void ClearStrings() {
            // Clear items from listbox and stringlist 
            StringsListBox.Items.Clear();
            StringsList.Clear();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            StringsList = new List<StringEntry>();
            PS3 = new PS3API(SelectAPI.TargetManager);
        }

        private void GetStringsButton_Click(object sender, EventArgs e) {
            if(!SearchBgWorker.IsBusy) {
                ClearStrings();
                SearchBgWorker.RunWorkerAsync();
            }
        }

        private void StringsListBox_SelectedIndexChanged(object sender, EventArgs e) {
            StringEntry entry = StringsList[StringsListBox.SelectedIndex];

            PointerInput.Value = entry.PointerAddress;
            DataInput.Value = entry.DataAddress;
            StringTextInput.MaxLength = entry.Text.Length;
            StringTextInput.Text = entry.Text;
        }

        private void ConnectButton_Click(object sender, EventArgs e) {
            if(PS3.ConnectTarget()) {
                MessageBox.Show("Connected to target", "Connected", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else {
                MessageBox.Show("Could not connect to target", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void AttachButton_Click(object sender, EventArgs e) {
            if(PS3.AttachProcess()) {
                MessageBox.Show("Attached to process", "Attached", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                groupBox2.Enabled = true;
            }
            else {
                MessageBox.Show("Could not attach to process", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void ClearListButton_Click(object sender, EventArgs e) {
            ClearStrings();
        }

        private void SetTextButton_Click(object sender, EventArgs e) {
            StringEntry entry = StringsList[StringsListBox.SelectedIndex];

            PS3.Extension.WriteString(entry.DataAddress, StringTextInput.Text);
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e) {
            BackgroundWorker worker = sender as BackgroundWorker;

            uint pointerAddress = StringPointersBegin;
            StringEntry entry;

            /* For some reason, we have to reconnect and reattach here */
            PS3.ConnectTarget();
            PS3.AttachProcess();

            for (int i = 0; i < StringCountInput.Value; i++) {
                // Get string entry 
                uint dataAddress = PS3.Extension.ReadUInt32(pointerAddress);
                string str = PS3.Extension.ReadString(dataAddress);
                entry = new StringEntry {
                    PointerAddress = pointerAddress,
                    DataAddress = dataAddress,
                    Text = str
                };

                StringsList.Add(entry); // Add string to list 
                pointerAddress += 4; // Move address to pointer in memory 
                worker.ReportProgress((int)(i / StringCountInput.Value * 100)); // Report precent progress 
            }
        }

        private void BgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            SearchProgressBar.Value = e.ProgressPercentage;
            SearchPercentLabel.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if(e.Error != null) {
                MessageBox.Show("Could not fetch strings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else {
                foreach(StringEntry entry in StringsList) { // Populate strings listbox 
                    StringsListBox.Items.Add(entry.Text);
                }
                SearchProgressBar.Value = 0; // Clear progress bar
                SearchPercentLabel.Text = "0%"; // Reset progress percentage 

                MessageBox.Show("Fetched all strings", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void SaveStringsButton_Click(object sender, EventArgs e) {
            SaveFileDialog saveDialog = new SaveFileDialog {
                Filter = "json files (*.json)|*.json|All Files (*.*)|*.*",
                FilterIndex = 0,
                RestoreDirectory = true
            };

            if(saveDialog.ShowDialog() == DialogResult.OK) {
                string jsonStr = JsonConvert.SerializeObject(StringsList, Formatting.Indented);
                File.WriteAllText(saveDialog.FileName, jsonStr);
                MessageBox.Show("Saved results to JSON", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
