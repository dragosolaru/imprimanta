﻿namespace imprimanta
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
            this.btnPrintText = new System.Windows.Forms.Button();
            this.textBoxNumeCompanie = new System.Windows.Forms.TextBox();
            this.textBoxSuma = new System.Windows.Forms.TextBox();
            this.textBoxAdresa = new System.Windows.Forms.TextBox();
            this.textBoxCUI = new System.Windows.Forms.TextBox();
            this.textBoxSeria = new System.Windows.Forms.TextBox();
            this.textBoxNr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNumeAgent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPrintText
            // 
            this.btnPrintText.Location = new System.Drawing.Point(13, 227);
            this.btnPrintText.Name = "btnPrintText";
            this.btnPrintText.Size = new System.Drawing.Size(75, 23);
            this.btnPrintText.TabIndex = 0;
            this.btnPrintText.Text = "Print Text";
            this.btnPrintText.UseVisualStyleBackColor = true;
            this.btnPrintText.Click += new System.EventHandler(this.btnPrintText_Click);
            // 
            // textBoxNumeCompanie
            // 
            this.textBoxNumeCompanie.Location = new System.Drawing.Point(100, 62);
            this.textBoxNumeCompanie.Multiline = true;
            this.textBoxNumeCompanie.Name = "textBoxNumeCompanie";
            this.textBoxNumeCompanie.Size = new System.Drawing.Size(172, 19);
            this.textBoxNumeCompanie.TabIndex = 1;
            this.textBoxNumeCompanie.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxSuma
            // 
            this.textBoxSuma.Location = new System.Drawing.Point(100, 137);
            this.textBoxSuma.Multiline = true;
            this.textBoxSuma.Name = "textBoxSuma";
            this.textBoxSuma.Size = new System.Drawing.Size(172, 19);
            this.textBoxSuma.TabIndex = 2;
            // 
            // textBoxAdresa
            // 
            this.textBoxAdresa.Location = new System.Drawing.Point(100, 112);
            this.textBoxAdresa.Multiline = true;
            this.textBoxAdresa.Name = "textBoxAdresa";
            this.textBoxAdresa.Size = new System.Drawing.Size(172, 19);
            this.textBoxAdresa.TabIndex = 3;
            // 
            // textBoxCUI
            // 
            this.textBoxCUI.Location = new System.Drawing.Point(100, 87);
            this.textBoxCUI.Multiline = true;
            this.textBoxCUI.Name = "textBoxCUI";
            this.textBoxCUI.Size = new System.Drawing.Size(172, 19);
            this.textBoxCUI.TabIndex = 4;
            // 
            // textBoxSeria
            // 
            this.textBoxSeria.Location = new System.Drawing.Point(100, 12);
            this.textBoxSeria.Multiline = true;
            this.textBoxSeria.Name = "textBoxSeria";
            this.textBoxSeria.Size = new System.Drawing.Size(172, 19);
            this.textBoxSeria.TabIndex = 5;
            // 
            // textBoxNr
            // 
            this.textBoxNr.Location = new System.Drawing.Point(100, 37);
            this.textBoxNr.Multiline = true;
            this.textBoxNr.Name = "textBoxNr";
            this.textBoxNr.Size = new System.Drawing.Size(172, 19);
            this.textBoxNr.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seria Doc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nume Comp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Numar Doc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Adresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Suma";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "CUI";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Agent";
            // 
            // textBoxNumeAgent
            // 
            this.textBoxNumeAgent.Location = new System.Drawing.Point(100, 162);
            this.textBoxNumeAgent.Multiline = true;
            this.textBoxNumeAgent.Name = "textBoxNumeAgent";
            this.textBoxNumeAgent.Size = new System.Drawing.Size(172, 19);
            this.textBoxNumeAgent.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNumeAgent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNr);
            this.Controls.Add(this.textBoxSeria);
            this.Controls.Add(this.textBoxCUI);
            this.Controls.Add(this.textBoxAdresa);
            this.Controls.Add(this.textBoxSuma);
            this.Controls.Add(this.textBoxNumeCompanie);
            this.Controls.Add(this.btnPrintText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrintText;
        private System.Windows.Forms.TextBox textBoxNumeCompanie;
        private System.Windows.Forms.TextBox textBoxSuma;
        private System.Windows.Forms.TextBox textBoxAdresa;
        private System.Windows.Forms.TextBox textBoxCUI;
        private System.Windows.Forms.TextBox textBoxSeria;
        private System.Windows.Forms.TextBox textBoxNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNumeAgent;
    }
}

