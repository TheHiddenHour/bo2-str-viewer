namespace cod_str_viewer {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ConnectButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AttachButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearListButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.StringsListBox = new System.Windows.Forms.ListBox();
            this.SetTextButton = new System.Windows.Forms.Button();
            this.StringTextInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DataInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.PointerInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.GetStringsButton = new System.Windows.Forms.Button();
            this.StringCountInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointerInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StringCountInput)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.ClearListButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectButton,
            this.AttachButton});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(39, 22);
            this.toolStripDropDownButton1.Text = "PS3";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(154, 22);
            this.ConnectButton.Text = "Connect Target";
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // AttachButton
            // 
            this.AttachButton.Name = "AttachButton";
            this.AttachButton.Size = new System.Drawing.Size(154, 22);
            this.AttachButton.Text = "Attach Process";
            this.AttachButton.Click += new System.EventHandler(this.AttachButton_Click);
            // 
            // ClearListButton
            // 
            this.ClearListButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ClearListButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearListButton.Image")));
            this.ClearListButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(59, 22);
            this.ClearListButton.Text = "Clear List";
            this.ClearListButton.Click += new System.EventHandler(this.ClearListButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 236);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Strings";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.StringsListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SetTextButton);
            this.splitContainer1.Panel2.Controls.Add(this.StringTextInput);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.DataInput);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.PointerInput);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.GetStringsButton);
            this.splitContainer1.Panel2.Controls.Add(this.StringCountInput);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(578, 217);
            this.splitContainer1.SplitterDistance = 335;
            this.splitContainer1.TabIndex = 0;
            // 
            // StringsListBox
            // 
            this.StringsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StringsListBox.FormattingEnabled = true;
            this.StringsListBox.Location = new System.Drawing.Point(0, 0);
            this.StringsListBox.Name = "StringsListBox";
            this.StringsListBox.Size = new System.Drawing.Size(333, 215);
            this.StringsListBox.TabIndex = 0;
            this.StringsListBox.SelectedIndexChanged += new System.EventHandler(this.StringsListBox_SelectedIndexChanged);
            // 
            // SetTextButton
            // 
            this.SetTextButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SetTextButton.Location = new System.Drawing.Point(0, 155);
            this.SetTextButton.Name = "SetTextButton";
            this.SetTextButton.Size = new System.Drawing.Size(237, 23);
            this.SetTextButton.TabIndex = 9;
            this.SetTextButton.Text = "Set Text";
            this.SetTextButton.UseVisualStyleBackColor = true;
            this.SetTextButton.Click += new System.EventHandler(this.SetTextButton_Click);
            // 
            // StringTextInput
            // 
            this.StringTextInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.StringTextInput.Location = new System.Drawing.Point(0, 135);
            this.StringTextInput.Name = "StringTextInput";
            this.StringTextInput.Size = new System.Drawing.Size(237, 20);
            this.StringTextInput.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "String Text";
            // 
            // DataInput
            // 
            this.DataInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataInput.Location = new System.Drawing.Point(0, 102);
            this.DataInput.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.DataInput.Name = "DataInput";
            this.DataInput.Size = new System.Drawing.Size(237, 20);
            this.DataInput.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Address";
            // 
            // PointerInput
            // 
            this.PointerInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.PointerInput.Location = new System.Drawing.Point(0, 69);
            this.PointerInput.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.PointerInput.Name = "PointerInput";
            this.PointerInput.Size = new System.Drawing.Size(237, 20);
            this.PointerInput.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pointer Address";
            // 
            // GetStringsButton
            // 
            this.GetStringsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.GetStringsButton.Location = new System.Drawing.Point(0, 33);
            this.GetStringsButton.Name = "GetStringsButton";
            this.GetStringsButton.Size = new System.Drawing.Size(237, 23);
            this.GetStringsButton.TabIndex = 2;
            this.GetStringsButton.Text = "Get Strings";
            this.GetStringsButton.UseVisualStyleBackColor = true;
            this.GetStringsButton.Click += new System.EventHandler(this.GetStringsButton_Click);
            // 
            // StringCountInput
            // 
            this.StringCountInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.StringCountInput.Location = new System.Drawing.Point(0, 13);
            this.StringCountInput.Maximum = new decimal(new int[] {
            27793,
            0,
            0,
            0});
            this.StringCountInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StringCountInput.Name = "StringCountInput";
            this.StringCountInput.Size = new System.Drawing.Size(237, 20);
            this.StringCountInput.TabIndex = 1;
            this.StringCountInput.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Strings to Read";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "cod-str-viewer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointerInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StringCountInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox StringsListBox;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem ConnectButton;
        private System.Windows.Forms.ToolStripMenuItem AttachButton;
        private System.Windows.Forms.ToolStripButton ClearListButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown StringCountInput;
        private System.Windows.Forms.Button SetTextButton;
        private System.Windows.Forms.TextBox StringTextInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown DataInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown PointerInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetStringsButton;
    }
}

