using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Dangnhap : Form
    {
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
    }
}
