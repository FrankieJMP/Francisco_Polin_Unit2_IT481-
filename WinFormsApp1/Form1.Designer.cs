﻿namespace WinFormsApp1
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(340, 89);
            button1.Name = "button1";
            button1.Size = new Size(94, 23);
            button1.TabIndex = 0;
            button1.Text = "Connect to DB";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(340, 209);
            button2.Name = "button2";
            button2.Size = new Size(130, 23);
            button2.TabIndex = 1;
            button2.Text = "Get Customer Count";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(340, 309);
            button3.Name = "button3";
            button3.Size = new Size(130, 23);
            button3.TabIndex = 2;
            button3.Text = "Get Customer Names";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 58);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 3;
            label1.Text = "Connect";
            label1.Click += Label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 191);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Count";
            label2.Click += Label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(340, 291);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 5;
            label3.Text = "Company Name";
            label3.Click += Label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 554);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}