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
using System.Diagnostics;
using System.Xml;
using System.IO;
using System.Collections;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1
{
    public partial class Quanlysanpham : Form
    {
        public static XmlDocument xmlDoc = new XmlDocument();
        public XmlNodeList list;
        int current = 0; // index của list hiện thời
        int total = 0; // tổng số node của list
        public int maxRow = 0;
        public static String scode; // dùng trao đổi giữa các form
        public static String sname; //-nt-
        public static XmlElement student;
        public Quanlysanpham()
        {
           
            InitializeComponent();
        }
        private QLsanphamBLL qLsanphamBLL = new QLsanphamBLL();
        private QLsanphamDTO qLsanphamDTO= new QLsanphamDTO();

        private void Quanlysanpham_Load(object sender, EventArgs e)
        {

            XDocument XDoc = new XDocument(
                         new XDeclaration("1.0", "utf-8", "yes"),
                   new XComment("Thông tin sản phẩm "),
                    new XElement("Table",
                        new XElement("hanghoa",
                        new XElement("masp", "sp001"),
                           new XElement("tensp", "Bia Sài Gòn"),
                           new XElement("gia", 100000),
                           new XElement("donvitinh", "thùng"),
                           new XElement("manhomhang", "NH001")),
                        new XElement("hanghoa",
                           new XElement("masp", "sp002"),
                           new XElement("tensp", "Coca"),
                           new XElement("gia", 20000),
                           new XElement("donvitinh", "thùng"),
                           new XElement("manhomhang", "NH003")),
                         new XElement("hanghoa",
                            new XElement("masp", "sp003"),
                           new XElement("tensp", "Pepsi"),
                           new XElement("gia", 1000),
                           new XElement("donvitinh", "thùng"),
                           new XElement("manhomhang", "NH003")),
                        new XElement("hanghoa",
                            new XElement("masp", "sp004"),
                           new XElement("tensp", "Nước lọc"),
                           new XElement("gia", 40000),
                           new XElement("donvitinh", "thùng"),
                           new XElement("manhomhang", "NH005"))

                        )
                    );

                XDoc.Save(@"D:\121\QuanLyKhoHang\WindowsFormsApp1\bin\Debug\data\hanghoa.xml");
           
            initDGV("All");
            intCombobox();
        }
        public void intCombobox()
        {
            
            loadXML();
            String group;
            String tmp = "";
            foreach (XmlElement ele in list)
            {
                group = ele.GetAttribute("manhomhang");
                if (!tmp.Contains(group))
                {
                    tmp += group;
                    cbo_manhomhang.Items.Add(group);
                }

            }
        }

        private void dgv_sanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            int numrow;
            numrow = e.RowIndex;
            txt_masp.Text = dgv_sanpham.Rows[numrow].Cells[0].Value.ToString();
            txt_tensp.Text = dgv_sanpham.Rows[numrow].Cells[1].Value.ToString();
            txt_gia.Text = dgv_sanpham.Rows[numrow].Cells[2].Value.ToString();
            txt_dvt.Text = dgv_sanpham.Rows[numrow].Cells[3].Value.ToString();
            cbo_manhomhang.Text = dgv_sanpham.Rows[numrow].Cells[4].Value.ToString();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            qLsanphamBLL.HienThi(dgv_sanpham);
        }
        public void loadXML()
        {

            xmlDoc.Load("./data/hanghoa.xml");
            list = xmlDoc.GetElementsByTagName("hanghoa");
            total = list.Count;
        }

        public void initDGV(String cgroup)
        {
            dgv_sanpham.Rows.Clear();
            dgv_sanpham.ColumnCount = 5;
            dgv_sanpham.Columns[0].Name = "Mã SP";
            dgv_sanpham.Columns[0].Width = 85;
            dgv_sanpham.Columns[1].Name = "Tên SP";
            dgv_sanpham.Columns[1].Width = 200;
            dgv_sanpham.Columns[2].Name = "Giá";
            dgv_sanpham.Columns[2].Width = 120;
            dgv_sanpham.Columns[3].Name = "Đơn vị tính";
            dgv_sanpham.Columns[3].Width = 120;
            dgv_sanpham.Columns[4].Name = "Mã nhóm hàng";
            dgv_sanpham.Columns[4].Width = 120;

            loadXML();
            String masp, tensp, group, gia, dvt, mnh;
            foreach (XmlElement ele in list)
            {
                group = ele.GetAttribute("mnh");
                if (cgroup == "All" || cgroup == group)
                {
                    masp= ele.GetAttribute("tensp");
                    tensp = ele.GetAttribute("name");
                    gia= ele.GetAttribute("gia");
                    dvt = ele.GetAttribute("donvitinh");
                    mnh = ele.GetAttribute("manhomhang");

                    dgv_sanpham.Rows.Add(masp, tensp, group, gia, dvt, mnh);
                }
               
            }
        }
         
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_masp.Text.Trim() != "")
            {
                //gán dữ liệu vào DTO
                qLsanphamDTO.Masp = txt_masp.Text.ToLower();
                qLsanphamDTO.Tensp = txt_tensp.Text;
                qLsanphamDTO.Gia= int.Parse(txt_gia.Text);
                qLsanphamDTO.Dvt = txt_dvt.Text;
                qLsanphamDTO.Mannh = cbo_manhomhang.Text;
                //gọi BLL thực hiện
                qLsanphamBLL.Them(qLsanphamDTO);
                //hiện lên dgv
                qLsanphamBLL.HienThi(dgv_sanpham);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_masp.Text.Trim() != "")
            {
                qLsanphamDTO.Masp = txt_masp.Text.ToLower();
                qLsanphamDTO.Tensp = txt_tensp.Text;
                qLsanphamDTO.Gia = int.Parse(txt_gia.Text);
                qLsanphamDTO.Dvt = txt_dvt.Text;
                qLsanphamDTO.Mannh = cbo_manhomhang.Text;
                //gọi BLL thực hiện
                qLsanphamBLL.Sua(qLsanphamDTO);
                //hiện lên dgv
                qLsanphamBLL.HienThi(dgv_sanpham);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes && txt_masp.Text.Trim() != "")
            {
                //gán dữ liệu vào DTO
                qLsanphamDTO.Masp = txt_masp.Text.ToLower();

                //gọi BLL thực hiện
                qLsanphamBLL.Xoa(qLsanphamDTO);
                //hiện lên dgv
                qLsanphamBLL.HienThi(dgv_sanpham);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_masp.Text.Trim() != "")
            {
                //gán dữ liệu vào DTO
                qLsanphamDTO.Masp = txt_masp.Text.ToLower();
                //gọi BLL thực hiện
                var hhTim = qLsanphamBLL.TimKiem2(qLsanphamDTO, dgv_sanpham);
                //khác null là tìm thấy, thực hiện bind lên ui
                if (hhTim != null)
                {
                    txt_masp.Text= hhTim.Masp;
                    txt_tensp.Text=hhTim.Tensp;
                    txt_gia.Text = hhTim.Gia.ToString();
                    txt_dvt.Text = hhTim.Dvt;
                    cbo_manhomhang.Text = hhTim.Mannh;
                }
                else
                {
                    //không thấy thì xóa trăng
                    txt_masp.Text = txt_tensp.Text = txt_gia.Text = txt_dvt.Text = cbo_manhomhang.Text  = string.Empty;
                }
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_masp.Text = " ";
            txt_tensp.Text= " ";
            txt_gia.Text = " ";
            cbo_manhomhang.Text = "";
            txt_dvt.Text = "";
        }
    }
}
