using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myProgram;
using System.Text.RegularExpressions;
namespace addOrderNameSpace
{
    public partial class addOrder : Form
    {
        public addOrder()
        {
            InitializeComponent();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
        bool bNum, bMoney;
        private void button1_Click(object sender, EventArgs e)
        {
            string addGoodsName = textBox2.Text;
            string[] addGoodsNum = { textBox1.Text };
            string[] addGoodsMoney = { textBox4.Text };
            string addGuestName = textBox3.Text;
            string addGoodsNumExample = @"^[1-2]{1}[0-9]{7}[0-9]{3}$";
            string addGoodsMoneyExample = @"^[0-9]{5}$";
            Regex rx = new Regex(addGoodsNumExample);
            Regex rx2 = new Regex(addGoodsMoneyExample);
            foreach (string s in addGoodsNum)
            {
                Match m = rx.Match(s);
                if (m.Success)
                {
                    bNum = true;
                    label5.Text = "";
                }
                else
                {
                    label5.Text = "订单编号格式错误，如年月日加流水号！";
                }
            }
            foreach (string s in addGoodsMoney)
            {
                Match m = rx2.Match(s);
                if (m.Success)
                {
                    bMoney = true;
                    label6.Text = "";
                }
                else
                {
                    label6.Text = "商品价格在10000至99999！";
                }
            }
            if (bNum == true && bMoney == true && addGoodsName != "" && addGuestName != "")
            {
                OrderServer.Inf.Add(new Order(textBox1.Text, addGoodsName, addGuestName, int.Parse(textBox4.Text)));
                Dispose();
            }
        }
        private void addOrder_Load(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}