namespace CPU_Scheduler
{
    partial class ProcessEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pickProcesscombobox = new System.Windows.Forms.ComboBox();
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.processNameLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.processArraytextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pickProcesscombobox
            // 
            this.pickProcesscombobox.FormattingEnabled = true;
            this.pickProcesscombobox.Items.AddRange(new object[] {
            "P1",
            "P2",
            "P3",
            "P4",
            "P5",
            "P6",
            "P7",
            "P8",
            "P9"});
            this.pickProcesscombobox.Location = new System.Drawing.Point(37, 52);
            this.pickProcesscombobox.MaxDropDownItems = 9;
            this.pickProcesscombobox.Name = "pickProcesscombobox";
            this.pickProcesscombobox.Size = new System.Drawing.Size(114, 21);
            this.pickProcesscombobox.TabIndex = 0;
            this.pickProcesscombobox.SelectedIndexChanged += new System.EventHandler(this.pickProcesscombobox_SelectedIndexChanged);
            this.pickProcesscombobox.SelectionChangeCommitted += new System.EventHandler(this.pickProcesscombobox_SelectionChangeCommitted);
            // 
            // inputTextbox
            // 
            this.inputTextbox.Location = new System.Drawing.Point(38, 93);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(112, 20);
            this.inputTextbox.TabIndex = 1;
            this.inputTextbox.TextChanged += new System.EventHandler(this.inputTextbox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add CPU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(166, 197);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(132, 34);
            this.doneButton.TabIndex = 3;
            this.doneButton.Text = "Finish";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // processNameLabel
            // 
            this.processNameLabel.AutoSize = true;
            this.processNameLabel.Location = new System.Drawing.Point(35, 143);
            this.processNameLabel.Name = "processNameLabel";
            this.processNameLabel.Size = new System.Drawing.Size(74, 13);
            this.processNameLabel.TabIndex = 4;
            this.processNameLabel.Text = "Process name";
            this.processNameLabel.Click += new System.EventHandler(this.processNameLabel_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(319, 42);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(95, 39);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "delete last";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // processArraytextBox
            // 
            this.processArraytextBox.Location = new System.Drawing.Point(37, 171);
            this.processArraytextBox.Name = "processArraytextBox";
            this.processArraytextBox.ReadOnly = true;
            this.processArraytextBox.Size = new System.Drawing.Size(389, 20);
            this.processArraytextBox.TabIndex = 6;
            this.processArraytextBox.TextChanged += new System.EventHandler(this.processArraytextBox_TextChanged);
            // 
            // ProcessEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 249);
            this.Controls.Add(this.processArraytextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.processNameLabel);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputTextbox);
            this.Controls.Add(this.pickProcesscombobox);
            this.Name = "ProcessEditor";
            this.Text = "ProcessEditor";
            this.Load += new System.EventHandler(this.ProcessEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pickProcesscombobox;
        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Label processNameLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox processArraytextBox;
    }
}