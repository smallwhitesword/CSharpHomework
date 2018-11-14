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
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
namespace homework7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = OrderServer.Inf;
            bs.Add(OrderServer.Inf[0]);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<Order> Inf2 = new List<Order>();
            string findGoodsNum;
            string findGuestName;
            string findGoodsName;
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "")
            {
                if (textBox1.Text != "")
                {
                    findGoodsNum = textBox1.Text;
                    var search = from n in OrderServer.Inf
                                 where n.orderNum == findGoodsNum
                                 select n;
                    if (search != null)
                    {
                        foreach (var m in search)
                        {
                            Inf2.Add(new Order(m.orderNum, m.goodsName, m.guestName, m.goodsMoney));
                        }
                    }
                }
                if (textBox2.Text != "")
                {
                    findGuestName = textBox2.Text;
                    var search = from n in OrderServer.Inf
                                 where n.guestName == findGuestName
                                 select n;
                    if (search != null)
                    {
                        foreach (var m in search)
                        {
                            Inf2.Add(new Order(m.orderNum, m.goodsName, m.guestName, m.goodsMoney));
                        }
                    }
                }
                if (textBox3.Text != "")
                {
                    findGoodsName = textBox3.Text;
                    var search = from n in OrderServer.Inf
                                 where n.goodsName == findGoodsName
                                 select n;
                    if (search != null)
                    {
                        foreach (var m in search)
                        {
                            Inf2.Add(new Order(m.orderNum, m.goodsName, m.guestName, m.goodsMoney));
                        }
                    }
                }
                if (Inf2.Count != 0)
                {
                    label5.Text = "";
                    dataGridView1.DataSource = Inf2;
                    bs.Add(Inf2[0]);
                }
                else
                {
                    label5.Text = "Not Found!";
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            addOrderNameSpace.addOrder addOrderForm = new addOrderNameSpace.addOrder();
            addOrderForm.Show();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = OrderServer.Inf;
            bs.Add(OrderServer.Inf[0]);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button4_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("myXmlFile.xml", FileMode.Create))
            {
                xmlser.Serialize(fs, OrderServer.Inf);
            }
            Console.WriteLine(File.ReadAllText("myXmlFile.xml"));
            //从XML文件中载入文件
            using (FileStream fs = new FileStream("myXmlFile.xml", FileMode.Open))
            {
                List<Order> persons3 = (List<Order>)xmlser.Deserialize(fs);
                foreach (Order mine in persons3)
                {
                    Console.WriteLine(mine);
                }
            }
            bool bFile = File.Exists("myXmlFile.xml");
            if (bFile)
            {
                label6.Text = "导出成功！";
            }
            else
            {
                label6.Text = "导出失败！";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"D:\C#Homework\CSharpHomework\homework1\homework7\program1\bin\Debug\myXmlFile.xml");
                XPathNavigator nav = doc.CreateNavigator();
                nav.MoveToRoot();
                XslCompiledTransform xt = new XslCompiledTransform();
                xt.Load(@"D:\C#Homework\CSharpHomework\homework1\homework7\program1\bin\Debug\myXmlFile.xslt");
                FileStream outFileStream = File.OpenWrite(@"D:\C#Homework\CSharpHomework\homework1\homework7\program1\BoolList.html");
                XmlTextWriter writer =
                    new XmlTextWriter(outFileStream, System.Text.Encoding.UTF8);
                xt.Transform(nav, null, writer);
            }
        }
    }
}