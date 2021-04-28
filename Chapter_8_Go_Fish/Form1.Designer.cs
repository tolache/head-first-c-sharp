namespace Chapter_8_Go_Fish
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
            this.labelName = new System.Windows.Forms.Label();
            this.labeHand = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelProgress = new System.Windows.Forms.Label();
            this.labelBooks = new System.Windows.Forms.Label();
            this.textProgress = new System.Windows.Forms.TextBox();
            this.textBooks = new System.Windows.Forms.TextBox();
            this.listHand = new System.Windows.Forms.ListBox();
            this.buttonAsk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(2, 10);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Your name";
            // 
            // labeHand
            // 
            this.labeHand.AutoSize = true;
            this.labeHand.Location = new System.Drawing.Point(324, 10);
            this.labeHand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeHand.Name = "labeHand";
            this.labeHand.Size = new System.Drawing.Size(61, 15);
            this.labeHand.TabIndex = 1;
            this.labeHand.Text = "Your hand";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(7, 30);
            this.textName.Margin = new System.Windows.Forms.Padding(2);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(179, 23);
            this.textName.TabIndex = 2;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(191, 30);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(121, 24);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start the game!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(5, 54);
            this.labelProgress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(86, 15);
            this.labelProgress.TabIndex = 4;
            this.labelProgress.Text = "Game progress";
            // 
            // labelBooks
            // 
            this.labelBooks.AutoSize = true;
            this.labelBooks.Location = new System.Drawing.Point(2, 283);
            this.labelBooks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBooks.Name = "labelBooks";
            this.labelBooks.Size = new System.Drawing.Size(39, 15);
            this.labelBooks.TabIndex = 5;
            this.labelBooks.Text = "Books";
            // 
            // textProgress
            // 
            this.textProgress.Location = new System.Drawing.Point(7, 70);
            this.textProgress.Margin = new System.Windows.Forms.Padding(2);
            this.textProgress.Multiline = true;
            this.textProgress.Name = "textProgress";
            this.textProgress.ReadOnly = true;
            this.textProgress.Size = new System.Drawing.Size(312, 211);
            this.textProgress.TabIndex = 6;
            // 
            // textBooks
            // 
            this.textBooks.Location = new System.Drawing.Point(7, 300);
            this.textBooks.Margin = new System.Windows.Forms.Padding(2);
            this.textBooks.Multiline = true;
            this.textBooks.Name = "textBooks";
            this.textBooks.ReadOnly = true;
            this.textBooks.Size = new System.Drawing.Size(312, 200);
            this.textBooks.TabIndex = 7;
            // 
            // listHand
            // 
            this.listHand.FormattingEnabled = true;
            this.listHand.ItemHeight = 15;
            this.listHand.Location = new System.Drawing.Point(329, 30);
            this.listHand.Margin = new System.Windows.Forms.Padding(2);
            this.listHand.Name = "listHand";
            this.listHand.Size = new System.Drawing.Size(151, 424);
            this.listHand.TabIndex = 8;
            this.listHand.DoubleClick += new System.EventHandler(this.buttonAsk_Click);
            // 
            // buttonAsk
            // 
            this.buttonAsk.Enabled = false;
            this.buttonAsk.Location = new System.Drawing.Point(329, 456);
            this.buttonAsk.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAsk.Name = "buttonAsk";
            this.buttonAsk.Size = new System.Drawing.Size(152, 45);
            this.buttonAsk.TabIndex = 9;
            this.buttonAsk.Text = "Gief card plox";
            this.buttonAsk.UseVisualStyleBackColor = true;
            this.buttonAsk.Click += new System.EventHandler(this.buttonAsk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 509);
            this.Controls.Add(this.buttonAsk);
            this.Controls.Add(this.listHand);
            this.Controls.Add(this.textBooks);
            this.Controls.Add(this.textProgress);
            this.Controls.Add(this.labelBooks);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labeHand);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Go Fish!";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labeHand;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Label labelBooks;
        private System.Windows.Forms.TextBox textProgress;
        private System.Windows.Forms.TextBox textBooks;
        private System.Windows.Forms.ListBox listHand;
        private System.Windows.Forms.Button buttonAsk;
    }
}

