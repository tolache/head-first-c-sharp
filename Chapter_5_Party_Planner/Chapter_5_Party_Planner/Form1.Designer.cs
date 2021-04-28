namespace Chapter_5_Party_Planner
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.fancyCheckBox = new System.Windows.Forms.CheckBox();
            this.healthyCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of People:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(15, 25);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(81, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // fancyCheckBox
            // 
            this.fancyCheckBox.AutoSize = true;
            this.fancyCheckBox.Checked = true;
            this.fancyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyCheckBox.Location = new System.Drawing.Point(15, 51);
            this.fancyCheckBox.Name = "fancyCheckBox";
            this.fancyCheckBox.Size = new System.Drawing.Size(115, 17);
            this.fancyCheckBox.TabIndex = 2;
            this.fancyCheckBox.Text = "Fancy Decorations";
            this.fancyCheckBox.UseVisualStyleBackColor = true;
            this.fancyCheckBox.CheckedChanged += new System.EventHandler(this.fancyCheckBox_CheckedChanged);
            // 
            // healthyCheckBox
            // 
            this.healthyCheckBox.AutoSize = true;
            this.healthyCheckBox.Location = new System.Drawing.Point(15, 74);
            this.healthyCheckBox.Name = "healthyCheckBox";
            this.healthyCheckBox.Size = new System.Drawing.Size(96, 17);
            this.healthyCheckBox.TabIndex = 3;
            this.healthyCheckBox.Text = "Healthy Option";
            this.healthyCheckBox.UseVisualStyleBackColor = true;
            this.healthyCheckBox.CheckedChanged += new System.EventHandler(this.healthyCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cost";
            // 
            // costLabel
            // 
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(50, 105);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(87, 18);
            this.costLabel.TabIndex = 5;
            this.costLabel.Text = "label3";
            this.costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(149, 144);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.healthyCheckBox);
            this.Controls.Add(this.fancyCheckBox);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox fancyCheckBox;
        private System.Windows.Forms.CheckBox healthyCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label costLabel;
    }
}

