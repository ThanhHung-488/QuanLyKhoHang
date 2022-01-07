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
    public partial class trangchu : Form
    {
        public trangchu()
        {
            InitializeComponent();
        }

        private void danhSáchNhómHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new Nhomhang();
            f.Closed += (s, args) => this.Show();
            f.Show();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new Nhanvien();
            f.FormClosed += (s, args) => this.Show();
            f.Show();
        }

        private void quanLySanPhamToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new Quanlysanpham();
            f.FormClosed += (s, args) => this.Show();
            f.Show();
        }
    }
}
