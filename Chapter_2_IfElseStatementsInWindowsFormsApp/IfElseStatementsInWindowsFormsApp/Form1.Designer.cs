namespace IfElseStatementsInWindowsFormsApp
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
            this.changeText = new System.Windows.Forms.Button();
            this.enableCheckBox = new System.Windows.Forms.CheckBox();
            this.labelToChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // changeText
            // 
            this.changeText.AutoSize = true;
            this.changeText.Location = new System.Drawing.Point(35, 22);
            this.changeText.Name = "changeText";
            this.changeText.Size = new System.Drawing.Size(150, 23);
            this.changeText.TabIndex = 0;
            this.changeText.Text = "Change the label if checked";
            this.changeText.UseVisualStyleBackColor = true;
            this.changeText.Click += new System.EventHandler(this.changeText_Click);
            // 
            // enableCheckBox
            // 
            this.enableCheckBox.AutoSize = true;
            this.enableCheckBox.Checked = true;
            this.enableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableCheckBox.Location = new System.Drawing.Point(345, 27);
            this.enableCheckBox.Name = "enableCheckBox";
            this.enableCheckBox.Size = new System.Drawing.Size(131, 17);
            this.enableCheckBox.TabIndex = 1;
            this.enableCheckBox.Text = "Enable label changing";
            this.enableCheckBox.UseVisualStyleBackColor = true;
            
            // 
            // labelToChange
            // 
            this.labelToChange.Location = new System.Drawing.Point(9, 48);
            this.labelToChange.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.labelToChange.Name = "labelToChange";
            this.labelToChange.Size = new System.Drawing.Size(496, 34);
            this.labelToChange.TabIndex = 2;
            this.labelToChange.Text = "Press the button to change my text";
            this.labelToChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 91);
            this.Controls.Add(this.labelToChange);
            this.Controls.Add(this.enableCheckBox);
            this.Controls.Add(this.changeText);
            this.Name = "Form1";
            this.Text = "Tola\'s Desktop App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeText;
        private System.Windows.Forms.CheckBox enableCheckBox;
        private System.Windows.Forms.Label labelToChange;
    }
}

