namespace MultiTool
{
    partial class MemoryEdit
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
            this.returnBtn = new System.Windows.Forms.Button();
            this.topLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.valueTypeLabel = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.setButton = new System.Windows.Forms.Button();
            this.processNameTextBox = new System.Windows.Forms.TextBox();
            this.processNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnBtn
            // 
            this.returnBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.returnBtn.Location = new System.Drawing.Point(12, 406);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(209, 46);
            this.returnBtn.TabIndex = 1;
            this.returnBtn.Text = "< Return to Panel";
            this.returnBtn.UseVisualStyleBackColor = true;
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Location = new System.Drawing.Point(366, 9);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(151, 25);
            this.topLabel.TabIndex = 2;
            this.topLabel.Text = "Memory Editor";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(331, 82);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(217, 31);
            this.addressTextBox.TabIndex = 3;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(331, 150);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(217, 31);
            this.valueTextBox.TabIndex = 4;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(335, 54);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(91, 25);
            this.addressLabel.TabIndex = 6;
            this.addressLabel.Text = "Address";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(335, 122);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(67, 25);
            this.valueLabel.TabIndex = 7;
            this.valueLabel.Text = "Value";
            // 
            // valueTypeLabel
            // 
            this.valueTypeLabel.AutoSize = true;
            this.valueTypeLabel.Location = new System.Drawing.Point(335, 195);
            this.valueTypeLabel.Name = "valueTypeLabel";
            this.valueTypeLabel.Size = new System.Drawing.Size(121, 25);
            this.valueTypeLabel.TabIndex = 8;
            this.valueTypeLabel.Text = "Value Type";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(331, 223);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(217, 31);
            this.typeTextBox.TabIndex = 9;
            // 
            // setButton
            // 
            this.setButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.setButton.Location = new System.Drawing.Point(371, 337);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(122, 45);
            this.setButton.TabIndex = 10;
            this.setButton.Text = "Change";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // processNameTextBox
            // 
            this.processNameTextBox.Location = new System.Drawing.Point(331, 289);
            this.processNameTextBox.Name = "processNameTextBox";
            this.processNameTextBox.Size = new System.Drawing.Size(217, 31);
            this.processNameTextBox.TabIndex = 12;
            // 
            // processNameLabel
            // 
            this.processNameLabel.AutoSize = true;
            this.processNameLabel.Location = new System.Drawing.Point(335, 261);
            this.processNameLabel.Name = "processNameLabel";
            this.processNameLabel.Size = new System.Drawing.Size(152, 25);
            this.processNameLabel.TabIndex = 11;
            this.processNameLabel.Text = "Process Name";
            // 
            // MemoryEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(923, 464);
            this.Controls.Add(this.processNameTextBox);
            this.Controls.Add(this.processNameLabel);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.valueTypeLabel);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.returnBtn);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "MemoryEdit";
            this.Text = "Memory Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label valueTypeLabel;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.TextBox processNameTextBox;
        private System.Windows.Forms.Label processNameLabel;
    }
}