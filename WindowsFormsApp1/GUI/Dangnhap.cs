using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.BLL;

namespace WindowsFormsApp1
{
    public partial class Dangnhap : Form
    {
        tkxml Fxml = new tkxml();
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            trangchu trangchu = new trangchu();
            trangchu.Closed += (s, args) => this.Close();
            trangchu.Show();
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {
            XDocument XDoc = new XDocument(
                        new XDeclaration("1.0", "utf-8", "yes"),
                  new XComment("Thông tin tài khoản "),
                   new XElement("Table",
                       new XElement("user",
                       new XElement("taikhoan", "admin"),
                          new XElement("matkhau", "admin")),
                       new XElement("user",
                       new XElement("taikhoan", "admin1"),
                          new XElement("matkhau", "123")),
                       new XElement("user",
                       new XElement("taikhoan", "admin2"),
                          new XElement("matkhau", "123"))
                 )
                   );

            XDoc.Save(@"D:\121\QuanLyKhoHang\WindowsFormsApp1\bin\Debug\data\taikhoan.xml");
        }
    }
}
