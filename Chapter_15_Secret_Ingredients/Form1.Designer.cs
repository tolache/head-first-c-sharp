namespace Chapter_15_Secret_Ingredients
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.useIngredient = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.NumericUpDown();
            this.getSuzanne = new System.Windows.Forms.Button();
            this.getAmy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.SuspendLayout();
            // 
            // useIngredient
            // 
            this.useIngredient.Location = new System.Drawing.Point(31, 14);
            this.useIngredient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.useIngredient.Name = "useIngredient";
            this.useIngredient.Size = new System.Drawing.Size(165, 29);
            this.useIngredient.TabIndex = 0;
            this.useIngredient.Text = "Get the ingredient";
            this.useIngredient.UseVisualStyleBackColor = true;
            this.useIngredient.Click += new System.EventHandler(this.useIngredient_Click);
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(202, 15);
            this.amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(69, 27);
            this.amount.TabIndex = 1;
            // 
            // getSuzanne
            // 
            this.getSuzanne.Location = new System.Drawing.Point(31, 48);
            this.getSuzanne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getSuzanne.Name = "getSuzanne";
            this.getSuzanne.Size = new System.Drawing.Size(240, 29);
            this.getSuzanne.TabIndex = 2;
            this.getSuzanne.Text = "Get Suzanne\'s delegate";
            this.getSuzanne.UseVisualStyleBackColor = true;
            this.getSuzanne.Click += new System.EventHandler(this.getSuzanne_Click);
            // 
            // getAmy
            // 
            this.getAmy.Location = new System.Drawing.Point(31, 81);
            this.getAmy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getAmy.Name = "getAmy";
            this.getAmy.Size = new System.Drawing.Size(240, 29);
            this.getAmy.TabIndex = 3;
            this.getAmy.Text = "Get Amy\'s delegate";
            this.getAmy.UseVisualStyleBackColor = true;
            this.getAmy.Click += new System.EventHandler(this.getAmy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 132);
            this.Controls.Add(this.getAmy);
            this.Controls.Add(this.getSuzanne);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.useIngredient);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Secret Ingredients";
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button useIngredient;
        private System.Windows.Forms.NumericUpDown amount;
        private System.Windows.Forms.Button getSuzanne;
        private System.Windows.Forms.Button getAmy;
    }
}

