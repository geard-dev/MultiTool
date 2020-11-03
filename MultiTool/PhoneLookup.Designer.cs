namespace MultiTool
{
    partial class PhoneLookup
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
            this.textBoxLabel = new System.Windows.Forms.Label();
            this.responceTextBox = new System.Windows.Forms.RichTextBox();
            this.searchPhoneButton = new System.Windows.Forms.Button();
            this.phoneTextbox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.returnBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.AutoSize = true;
            this.textBoxLabel.Location = new System.Drawing.Point(223, 135);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(155, 25);
            this.textBoxLabel.TabIndex = 11;
            this.textBoxLabel.Text = "Phone Number";
            // 
            // responceTextBox
            // 
            this.responceTextBox.Location = new System.Drawing.Point(664, 28);
            this.responceTextBox.Name = "responceTextBox";
            this.responceTextBox.ReadOnly = true;
            this.responceTextBox.Size = new System.Drawing.Size(339, 516);
            this.responceTextBox.TabIndex = 10;
            this.responceTextBox.Text = "Results will show up here...";
            // 
            // searchPhoneButton
            // 
            this.searchPhoneButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchPhoneButton.Location = new System.Drawing.Point(284, 223);
            this.searchPhoneButton.Name = "searchPhoneButton";
            this.searchPhoneButton.Size = new System.Drawing.Size(106, 41);
            this.searchPhoneButton.TabIndex = 9;
            this.searchPhoneButton.Text = "Lookup";
            this.searchPhoneButton.UseVisualStyleBackColor = true;
            this.searchPhoneButton.Click += new System.EventHandler(this.searchPhoneButton_Click);
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Location = new System.Drawing.Point(217, 163);
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(239, 31);
            this.phoneTextbox.TabIndex = 8;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(441, 28);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(151, 25);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Phone Lookup";
            // 
            // returnBtn
            // 
            this.returnBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.returnBtn.Location = new System.Drawing.Point(12, 521);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(209, 46);
            this.returnBtn.TabIndex = 6;
            this.returnBtn.Text = "< Return to Panel";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "*PHONE NUMBER MUST INCLUDE COUNTRY CODE*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "*COUNTRY CODE FOR US AND CANADA IS 1*";
            // 
            // PhoneLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1037, 579);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.responceTextBox);
            this.Controls.Add(this.searchPhoneButton);
            this.Controls.Add(this.phoneTextbox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.returnBtn);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "PhoneLookup";
            this.Text = "Phone Lookup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textBoxLabel;
        private System.Windows.Forms.RichTextBox responceTextBox;
        private System.Windows.Forms.Button searchPhoneButton;
        private System.Windows.Forms.TextBox phoneTextbox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}