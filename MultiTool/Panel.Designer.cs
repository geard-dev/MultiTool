namespace MultiTool
{
    partial class Panel
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
            this.editMemory = new System.Windows.Forms.Button();
            this.lookupIP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.runPowershell = new System.Windows.Forms.Button();
            this.lookupPhone = new System.Windows.Forms.Button();
            this.wipFauxButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editMemory
            // 
            this.editMemory.Location = new System.Drawing.Point(70, 73);
            this.editMemory.Name = "editMemory";
            this.editMemory.Size = new System.Drawing.Size(167, 43);
            this.editMemory.TabIndex = 0;
            this.editMemory.Text = "Edit Memory";
            this.editMemory.UseVisualStyleBackColor = true;
            this.editMemory.Click += new System.EventHandler(this.editMemory_Click);
            // 
            // lookupIP
            // 
            this.lookupIP.Location = new System.Drawing.Point(302, 73);
            this.lookupIP.Name = "lookupIP";
            this.lookupIP.Size = new System.Drawing.Size(167, 43);
            this.lookupIP.TabIndex = 2;
            this.lookupIP.Text = "IP Lookup";
            this.lookupIP.UseVisualStyleBackColor = true;
            this.lookupIP.Click += new System.EventHandler(this.lookupIP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Multi-Tool by geard-dev#6274";
            // 
            // runPowershell
            // 
            this.runPowershell.Location = new System.Drawing.Point(538, 73);
            this.runPowershell.Name = "runPowershell";
            this.runPowershell.Size = new System.Drawing.Size(167, 43);
            this.runPowershell.TabIndex = 4;
            this.runPowershell.Text = "Powershell";
            this.runPowershell.UseVisualStyleBackColor = true;
            this.runPowershell.Click += new System.EventHandler(this.runPowershell_Click);
            // 
            // lookupPhone
            // 
            this.lookupPhone.Location = new System.Drawing.Point(70, 143);
            this.lookupPhone.Name = "lookupPhone";
            this.lookupPhone.Size = new System.Drawing.Size(167, 43);
            this.lookupPhone.TabIndex = 6;
            this.lookupPhone.Text = "Phone Lookup";
            this.lookupPhone.UseVisualStyleBackColor = true;
            this.lookupPhone.Click += new System.EventHandler(this.lookupPhone_Click);
            // 
            // wipFauxButton
            // 
            this.wipFauxButton.Location = new System.Drawing.Point(302, 143);
            this.wipFauxButton.Name = "wipFauxButton";
            this.wipFauxButton.Size = new System.Drawing.Size(403, 43);
            this.wipFauxButton.TabIndex = 7;
            this.wipFauxButton.Text = "Work in Progress";
            this.wipFauxButton.UseVisualStyleBackColor = true;
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 234);
            this.Controls.Add(this.wipFauxButton);
            this.Controls.Add(this.lookupPhone);
            this.Controls.Add(this.runPowershell);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lookupIP);
            this.Controls.Add(this.editMemory);
            this.Name = "Panel";
            this.Text = "Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editMemory;
        private System.Windows.Forms.Button lookupIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button runPowershell;
        private System.Windows.Forms.Button lookupPhone;
        private System.Windows.Forms.Button wipFauxButton;
    }
}