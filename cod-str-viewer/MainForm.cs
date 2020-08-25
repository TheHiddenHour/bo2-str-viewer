using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PS3Lib;

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
            Console.WriteLine("Dumping strings...");
            ClearStrings();

            uint pointerAddress = StringPointersBegin;
            StringEntry entry;

            for(int i = 0; i < StringCountInput.Value; i++) {
                uint dataAddress = PS3.Extension.ReadUInt32(pointerAddress);
                string str = PS3.Extension.ReadString(dataAddress);
                entry = new StringEntry {
                    PointerAddress = pointerAddress,
                    DataAddress = dataAddress,
                    Text = str
                };

                StringsList.Add(entry);
                pointerAddress += 4; // Move address to pointer in memory 
            }

            // Populate listbox with entries 
            foreach(StringEntry item in StringsList) {
                StringsListBox.Items.Add(item.Text);
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
                MessageBox.Show("Connected", "Connected to target", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else {
                MessageBox.Show("Error", "Could not connect to target", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void AttachButton_Click(object sender, EventArgs e) {
            if(PS3.AttachProcess()) {
                MessageBox.Show("Attached", "Attached to process", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else {
                MessageBox.Show("Error", "Could not attach to process", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void ClearListButton_Click(object sender, EventArgs e) {
            ClearStrings();
        }

        private void SetTextButton_Click(object sender, EventArgs e) {
            StringEntry entry = StringsList[StringsListBox.SelectedIndex];

            PS3.Extension.WriteString(entry.DataAddress, StringTextInput.Text);
        }
    }
}
