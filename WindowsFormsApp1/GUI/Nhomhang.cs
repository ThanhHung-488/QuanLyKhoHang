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
    public partial class Nhomhang : Form
    {
        public Nhomhang()
        {
            InitializeComponent();
        }

        private void themNhomhangbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new Themnhomhang();
            f.Closed += (s, args) => this.Show();
            f.Show();
        }
    }
}
