using System;
using System.Windows.Forms;
using System.Drawing;
namespace Homework1
{
    partial class program2 : Form
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
            this.SuspendLayout();
            // 
            // program2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 434);
            this.Name = "program2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.program2_Load);
            this.ResumeLayout(false);

        }
        #endregion
        TextBox txt1 = new TextBox();
        TextBox txt2 = new TextBox();
        Button btn = new Button();
        Label lbl = new Label();
        public void init()
        {
            this.Controls.Add(txt1);
            this.Controls.Add(txt2);
            this.Controls.Add(btn);
            this.Controls.Add(lbl);
            txt1.Dock = System.Windows.Forms.DockStyle.Left;
            txt2.Dock = System.Windows.Forms.DockStyle.Right;
            btn.Dock = System.Windows.Forms.DockStyle.Fill;
            lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            btn.Text = "两个数字的积是：";
            lbl.Text = "用于显示结果的标签";
            btn.Click += new System.EventHandler(this.buttonl_Clink);
        }
        public void buttonl_Clink(object sender, EventArgs e)
        {
            string s = txt1.Text;
            int a = Int32.Parse(s);
            s = txt2.Text;
            int b = Int32.Parse(s);
            int result = a * b;
            lbl.Text = "两数乘积为：" + result;
        }
        static void Main()
        {
            program2 i = new program2();
            i.Text = "program2";
            i.init();
            Application.Run(i);
        }
    }
}