﻿namespace Chapter_7_Hide_and_Seek
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
            this.description = new System.Windows.Forms.TextBox();
            this.goHere = new System.Windows.Forms.Button();
            this.goThroughDoor = new System.Windows.Forms.Button();
            this.exits = new System.Windows.Forms.ComboBox();
            this.check = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(13, 13);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(276, 248);
            this.description.TabIndex = 0;
            // 
            // goHere
            // 
            this.goHere.Location = new System.Drawing.Point(12, 267);
            this.goHere.Name = "goHere";
            this.goHere.Size = new System.Drawing.Size(86, 23);
            this.goHere.TabIndex = 1;
            this.goHere.Text = "Go here:";
            this.goHere.UseVisualStyleBackColor = true;
            this.goHere.Visible = false;
            this.goHere.Click += new System.EventHandler(this.goHere_Click);
            // 
            // goThroughDoor
            // 
            this.goThroughDoor.Location = new System.Drawing.Point(13, 298);
            this.goThroughDoor.Name = "goThroughDoor";
            this.goThroughDoor.Size = new System.Drawing.Size(277, 23);
            this.goThroughDoor.TabIndex = 2;
            this.goThroughDoor.Text = "Go through the door";
            this.goThroughDoor.UseVisualStyleBackColor = true;
            this.goThroughDoor.Visible = false;
            this.goThroughDoor.Click += new System.EventHandler(this.goThroughDoor_Click);
            // 
            // exits
            // 
            this.exits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exits.FormattingEnabled = true;
            this.exits.Location = new System.Drawing.Point(104, 269);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(185, 21);
            this.exits.TabIndex = 3;
            this.exits.Visible = false;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(13, 327);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(276, 23);
            this.check.TabIndex = 4;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Visible = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // hide
            // 
            this.hide.Location = new System.Drawing.Point(12, 356);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(277, 23);
            this.hide.TabIndex = 5;
            this.hide.Text = "Hide!";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 387);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.check);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.goThroughDoor);
            this.Controls.Add(this.goHere);
            this.Controls.Add(this.description);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button goHere;
        private System.Windows.Forms.Button goThroughDoor;
        private System.Windows.Forms.ComboBox exits;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button hide;
    }
}