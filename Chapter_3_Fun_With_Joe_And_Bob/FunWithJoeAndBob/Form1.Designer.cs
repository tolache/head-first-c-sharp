﻿﻿namespace FunWithJoeAndBob
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
             this.joesCashLabel = new System.Windows.Forms.Label();
             this.bobsCashLabel = new System.Windows.Forms.Label();
             this.bankCashLabel = new System.Windows.Forms.Label();
             this.button1 = new System.Windows.Forms.Button();
             this.button2 = new System.Windows.Forms.Button();
             this.bobGivesToJoe = new System.Windows.Forms.Button();
             this.joeGivesToBob = new System.Windows.Forms.Button();
             this.saveJoe = new System.Windows.Forms.Button();
             this.loadJoe = new System.Windows.Forms.Button();
             this.SuspendLayout();
             // 
             // joesCashLabel
             // 
             this.joesCashLabel.AutoSize = true;
             this.joesCashLabel.Location = new System.Drawing.Point(14, 10);
             this.joesCashLabel.Name = "joesCashLabel";
             this.joesCashLabel.Size = new System.Drawing.Size(38, 15);
             this.joesCashLabel.TabIndex = 0;
             this.joesCashLabel.Text = "label1";
             // 
             // bobsCashLabel
             // 
             this.bobsCashLabel.AutoSize = true;
             this.bobsCashLabel.Location = new System.Drawing.Point(14, 48);
             this.bobsCashLabel.Name = "bobsCashLabel";
             this.bobsCashLabel.Size = new System.Drawing.Size(38, 15);
             this.bobsCashLabel.TabIndex = 1;
             this.bobsCashLabel.Text = "label2";
             // 
             // bankCashLabel
             // 
             this.bankCashLabel.AutoSize = true;
             this.bankCashLabel.Location = new System.Drawing.Point(14, 87);
             this.bankCashLabel.Name = "bankCashLabel";
             this.bankCashLabel.Size = new System.Drawing.Size(38, 15);
             this.bankCashLabel.TabIndex = 2;
             this.bankCashLabel.Text = "label3";
             // 
             // button1
             // 
             this.button1.Location = new System.Drawing.Point(17, 123);
             this.button1.Name = "button1";
             this.button1.Size = new System.Drawing.Size(98, 43);
             this.button1.TabIndex = 3;
             this.button1.Text = "Give $10 to Joe";
             this.button1.UseVisualStyleBackColor = true;
             this.button1.Click += new System.EventHandler(this.button1_Click);
             // 
             // button2
             // 
             this.button2.Location = new System.Drawing.Point(122, 123);
             this.button2.Name = "button2";
             this.button2.Size = new System.Drawing.Size(98, 43);
             this.button2.TabIndex = 4;
             this.button2.Text = "Receive $5 from Bob";
             this.button2.UseVisualStyleBackColor = true;
             this.button2.Click += new System.EventHandler(this.button2_Click);
             // 
             // bobGivesToJoe
             // 
             this.bobGivesToJoe.Location = new System.Drawing.Point(122, 173);
             this.bobGivesToJoe.Name = "bobGivesToJoe";
             this.bobGivesToJoe.Size = new System.Drawing.Size(98, 43);
             this.bobGivesToJoe.TabIndex = 6;
             this.bobGivesToJoe.Text = "Bob  gives $5 to Joe";
             this.bobGivesToJoe.UseVisualStyleBackColor = true;
             this.bobGivesToJoe.Click += new System.EventHandler(this.bobGivesToJoe_Click);
             // 
             // joeGivesToBob
             // 
             this.joeGivesToBob.Location = new System.Drawing.Point(17, 173);
             this.joeGivesToBob.Name = "joeGivesToBob";
             this.joeGivesToBob.Size = new System.Drawing.Size(98, 43);
             this.joeGivesToBob.TabIndex = 5;
             this.joeGivesToBob.Text = "Joe gives $10 to Bob";
             this.joeGivesToBob.UseVisualStyleBackColor = true;
             this.joeGivesToBob.Click += new System.EventHandler(this.joeGivesToBob_Click);
             // 
             // saveJoe
             // 
             this.saveJoe.Location = new System.Drawing.Point(17, 242);
             this.saveJoe.Name = "saveJoe";
             this.saveJoe.Size = new System.Drawing.Size(98, 23);
             this.saveJoe.TabIndex = 7;
             this.saveJoe.Text = "Save Joe";
             this.saveJoe.UseVisualStyleBackColor = true;
             this.saveJoe.Click += new System.EventHandler(this.saveJoe_Click);
             // 
             // loadJoe
             // 
             this.loadJoe.Location = new System.Drawing.Point(122, 242);
             this.loadJoe.Name = "loadJoe";
             this.loadJoe.Size = new System.Drawing.Size(98, 23);
             this.loadJoe.TabIndex = 8;
             this.loadJoe.Text = "Load Joe";
             this.loadJoe.UseVisualStyleBackColor = true;
             this.loadJoe.Click += new System.EventHandler(this.loadJoe_Click);
             // 
             // Form1
             // 
             this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
             this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
             this.ClientSize = new System.Drawing.Size(244, 288);
             this.Controls.Add(this.loadJoe);
             this.Controls.Add(this.saveJoe);
             this.Controls.Add(this.bobGivesToJoe);
             this.Controls.Add(this.joeGivesToBob);
             this.Controls.Add(this.button2);
             this.Controls.Add(this.button1);
             this.Controls.Add(this.bankCashLabel);
             this.Controls.Add(this.bobsCashLabel);
             this.Controls.Add(this.joesCashLabel);
             this.MaximizeBox = false;
             this.MinimizeBox = false;
             this.Name = "Form1";
             this.Text = "Fun with Joe and Bob";
             this.ResumeLayout(false);
             this.PerformLayout();
         }

         #endregion

         private System.Windows.Forms.Label joesCashLabel;
         private System.Windows.Forms.Label bobsCashLabel;
         private System.Windows.Forms.Label bankCashLabel;
         private System.Windows.Forms.Button button1;
         private System.Windows.Forms.Button button2;
         private System.Windows.Forms.Button bobGivesToJoe;
         private System.Windows.Forms.Button joeGivesToBob;
         private System.Windows.Forms.Button loadJoe;
         private System.Windows.Forms.Button saveJoe;
     }
 }