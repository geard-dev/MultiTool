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
            // IPLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1037, 579);
            this.Controls.Add(this.returnBtn);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "IPLookup";
            this.Text = "IP Lookup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button returnBtn;
    }
}