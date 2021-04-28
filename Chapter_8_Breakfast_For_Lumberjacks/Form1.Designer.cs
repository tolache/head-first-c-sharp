namespace Chapter_8_Breakfast_For_Lumberjacks
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
            this.name = new System.Windows.Forms.TextBox();
            this.addLumberjack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nextInLine = new System.Windows.Forms.Label();
            this.nextLumberjack = new System.Windows.Forms.Button();
            this.addFlapjacks = new System.Windows.Forms.Button();
            this.banana = new System.Windows.Forms.RadioButton();
            this.browned = new System.Windows.Forms.RadioButton();
            this.soggy = new System.Windows.Forms.RadioButton();
            this.crispy = new System.Windows.Forms.RadioButton();
            this.howMany = new System.Windows.Forms.NumericUpDown();
            this.line = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.howMany)).BeginInit();
            this.SuspendLayout();
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lumberjack name";
            this.name.Location = new System.Drawing.Point(122, 15);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(119, 23);
            this.name.TabIndex = 1;
            this.name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.name_KeyDown);
            this.addLumberjack.Location = new System.Drawing.Point(12, 44);
            this.addLumberjack.Name = "addLumberjack";
            this.addLumberjack.Size = new System.Drawing.Size(230, 23);
            this.addLumberjack.TabIndex = 2;
            this.addLumberjack.Text = "Add lumberjack";
            this.addLumberjack.UseVisualStyleBackColor = true;
            this.addLumberjack.Click += new System.EventHandler(this.addLumberjack_Click);
            this.groupBox1.Controls.Add(this.nextInLine);
            this.groupBox1.Controls.Add(this.nextLumberjack);
            this.groupBox1.Controls.Add(this.addFlapjacks);
            this.groupBox1.Controls.Add(this.banana);
            this.groupBox1.Controls.Add(this.browned);
            this.groupBox1.Controls.Add(this.soggy);
            this.groupBox1.Controls.Add(this.crispy);
            this.groupBox1.Controls.Add(this.howMany);
            this.groupBox1.Location = new System.Drawing.Point(122, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 286);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feed a lumberjack";
            this.nextInLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nextInLine.Location = new System.Drawing.Point(6, 197);
            this.nextInLine.Name = "nextInLine";
            this.nextInLine.Size = new System.Drawing.Size(140, 40);
            this.nextInLine.TabIndex = 7;
            this.nextLumberjack.Location = new System.Drawing.Point(6, 253);
            this.nextLumberjack.Name = "nextLumberjack";
            this.nextLumberjack.Size = new System.Drawing.Size(140, 23);
            this.nextLumberjack.TabIndex = 4;
            this.nextLumberjack.Text = "Next lumberjack";
            this.nextLumberjack.UseVisualStyleBackColor = true;
            this.nextLumberjack.Click += new System.EventHandler(this.nextLumberjack_Click);
            this.addFlapjacks.Location = new System.Drawing.Point(6, 171);
            this.addFlapjacks.Name = "addFlapjacks";
            this.addFlapjacks.Size = new System.Drawing.Size(140, 23);
            this.addFlapjacks.TabIndex = 6;
            this.addFlapjacks.Text = "Add flapjacks";
            this.addFlapjacks.UseVisualStyleBackColor = true;
            this.addFlapjacks.Click += new System.EventHandler(this.addFlapjacks_Click);
            this.banana.Location = new System.Drawing.Point(6, 141);
            this.banana.Name = "banana";
            this.banana.Size = new System.Drawing.Size(104, 24);
            this.banana.TabIndex = 5;
            this.banana.Text = "Banana";
            this.banana.UseVisualStyleBackColor = true;
            this.browned.Location = new System.Drawing.Point(6, 111);
            this.browned.Name = "browned";
            this.browned.Size = new System.Drawing.Size(104, 24);
            this.browned.TabIndex = 4;
            this.browned.Text = "Browned";
            this.browned.UseVisualStyleBackColor = true;
            this.soggy.Location = new System.Drawing.Point(6, 81);
            this.soggy.Name = "soggy";
            this.soggy.Size = new System.Drawing.Size(104, 24);
            this.soggy.TabIndex = 3;
            this.soggy.Text = "Soggy";
            this.soggy.UseVisualStyleBackColor = true;
            this.crispy.Checked = true;
            this.crispy.Location = new System.Drawing.Point(6, 51);
            this.crispy.Name = "crispy";
            this.crispy.Size = new System.Drawing.Size(104, 24);
            this.crispy.TabIndex = 2;
            this.crispy.TabStop = true;
            this.crispy.Text = "Crispy";
            this.crispy.UseVisualStyleBackColor = true;
            this.howMany.Location = new System.Drawing.Point(6, 22);
            this.howMany.Name = "howMany";
            this.howMany.Size = new System.Drawing.Size(65, 23);
            this.howMany.TabIndex = 1;
            this.howMany.Value = new decimal(new int[] {1, 0, 0, 0});
            this.howMany.KeyDown += new System.Windows.Forms.KeyEventHandler(this.howMany_KeyDown);
            this.line.FormattingEnabled = true;
            this.line.ItemHeight = 15;
            this.line.Location = new System.Drawing.Point(6, 110);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(110, 259);
            this.line.TabIndex = 4;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Breakfast line";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 378);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.line);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addLumberjack);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.howMany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox line;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addFlapjacks;
        private System.Windows.Forms.Button addLumberjack;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button nextLumberjack;
        private System.Windows.Forms.RadioButton banana;
        private System.Windows.Forms.RadioButton browned;
        private System.Windows.Forms.RadioButton soggy;
        private System.Windows.Forms.RadioButton crispy;
        private System.Windows.Forms.NumericUpDown howMany;
        private System.Windows.Forms.Label nextInLine;
    }
}