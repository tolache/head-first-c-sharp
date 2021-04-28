namespace Elephants
{
    partial class Form1
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
            this.lloydButton = new System.Windows.Forms.Button();
            this.lucindaButton = new System.Windows.Forms.Button();
            this.transcendSoulsButton = new System.Windows.Forms.Button();
            this.fuckupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lloydButton
            // 
            this.lloydButton.Location = new System.Drawing.Point(22, 12);
            this.lloydButton.Name = "lloydButton";
            this.lloydButton.Size = new System.Drawing.Size(102, 23);
            this.lloydButton.TabIndex = 0;
            this.lloydButton.Text = "Lloyd";
            this.lloydButton.UseVisualStyleBackColor = true;
            this.lloydButton.Click += new System.EventHandler(this.lloydButton_Click);
            // 
            // lucindaButton
            // 
            this.lucindaButton.Location = new System.Drawing.Point(22, 41);
            this.lucindaButton.Name = "lucindaButton";
            this.lucindaButton.Size = new System.Drawing.Size(102, 23);
            this.lucindaButton.TabIndex = 1;
            this.lucindaButton.Text = "Lucinda";
            this.lucindaButton.UseVisualStyleBackColor = true;
            this.lucindaButton.Click += new System.EventHandler(this.lucindaButton_Click);
            // 
            // transcendSoulsButton
            // 
            this.transcendSoulsButton.Location = new System.Drawing.Point(22, 70);
            this.transcendSoulsButton.Name = "transcendSoulsButton";
            this.transcendSoulsButton.Size = new System.Drawing.Size(102, 23);
            this.transcendSoulsButton.TabIndex = 2;
            this.transcendSoulsButton.Text = "Transcend souls";
            this.transcendSoulsButton.UseVisualStyleBackColor = true;
            this.transcendSoulsButton.Click += new System.EventHandler(this.transcendSoulsButton_Click);
            // 
            // fuckupButton
            // 
            this.fuckupButton.Location = new System.Drawing.Point(22, 99);
            this.fuckupButton.Name = "fuckupButton";
            this.fuckupButton.Size = new System.Drawing.Size(102, 23);
            this.fuckupButton.TabIndex = 3;
            this.fuckupButton.Text = "Fuck things up";
            this.fuckupButton.UseVisualStyleBackColor = true;
            this.fuckupButton.Click += new System.EventHandler(this.fuckupButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(147, 138);
            this.Controls.Add(this.fuckupButton);
            this.Controls.Add(this.transcendSoulsButton);
            this.Controls.Add(this.lucindaButton);
            this.Controls.Add(this.lloydButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Elephants";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lloydButton;
        private System.Windows.Forms.Button lucindaButton;
        private System.Windows.Forms.Button transcendSoulsButton;
        private System.Windows.Forms.Button fuckupButton;
    }
}

