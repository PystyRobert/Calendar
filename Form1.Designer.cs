﻿namespace Calendar1
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
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LBDATE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // daycontainer
            // 
            this.daycontainer.Location = new System.Drawing.Point(7, 175);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(1103, 755);
            this.daycontainer.TabIndex = 0;
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(1021, 936);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 23);
            this.btnnext.TabIndex = 1;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.Location = new System.Drawing.Point(940, 936);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(75, 23);
            this.btnprevious.TabIndex = 2;
            this.btnprevious.Text = "Previous";
            this.btnprevious.UseVisualStyleBackColor = true;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(51, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Luni";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(208, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(536, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Joi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(353, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Miercuri";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(825, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sambata";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(678, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Vineri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(985, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Duminica";
            // 
            // LBDATE
            // 
            this.LBDATE.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBDATE.Location = new System.Drawing.Point(212, 9);
            this.LBDATE.Name = "LBDATE";
            this.LBDATE.Size = new System.Drawing.Size(686, 55);
            this.LBDATE.TabIndex = 10;
            this.LBDATE.Text = "Luna An";
            this.LBDATE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 980);
            this.Controls.Add(this.LBDATE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnprevious);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.daycontainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel daycontainer;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LBDATE;
    }
}

