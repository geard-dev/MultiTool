namespace MultiTool
{
    partial class IPLookup
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.ipTextbox = new System.Windows.Forms.TextBox();
            this.searchIPButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // returnBtn
            // 
            this.returnBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.returnBtn.Location = new System.Drawing.Point(12, 521);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(209, 46);
            this.returnBtn.TabIndex = 0;
            this.returnBtn.Text = "< Return to Panel";
            this.returnBtn.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(450, 28);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(108, 25);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "IP Lookup";
            // 
            // ipTextbox
            // 
            this.ipTextbox.Location = new System.Drawing.Point(387, 80);
            this.ipTextbox.Name = "ipTextbox";
            this.ipTextbox.Size = new System.Drawing.Size(239, 31);
            this.ipTextbox.TabIndex = 2;
            // 
            // searchIPButton
            // 
            this.searchIPButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchIPButton.Location = new System.Drawing.Point(455, 140);
            this.searchIPButton.Name = "searchIPButton";
            this.searchIPButton.Size = new System.Drawing.Size(106, 41);
            this.searchIPButton.TabIndex = 3;
            this.searchIPButton.Text = "Lookup";
            this.searchIPButton.UseVisualStyleBackColor = true;
            this.searchIPButton.Click += new System.EventHandler(this.searchIPButton_Click);
            // 
            // IPLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1037, 579);
            this.Controls.Add(this.searchIPButton);
            this.Controls.Add(this.ipTextbox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.returnBtn);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "IPLookup";
            this.Text = "IP Lookup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox ipTextbox;
        private System.Windows.Forms.Button searchIPButton;
    }
}