using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.BLL
{
    class QLsanphamBLL
    {
        private XmlDocument doc = new XmlDocument();
        private XmlElement root;
        private string fileName = @"D:\121\QuanLyKhoHang\WindowsFormsApp1\bin\Debug\data\hanghoa.xml";

        public QLsanphamBLL()
        {
            doc.Load(fileName);
            root = doc.DocumentElement;
        }
        public void Them(QLsanphamDTO hhThem)
        {

            XmlNode hh = doc.CreateElement("hanghoa");


            XmlElement masp = doc.CreateElement("masp");
            masp.InnerText = hhThem.Masp;
            hh.AppendChild(masp);

            XmlElement tensp = doc.CreateElement("tensp");
            tensp.InnerText = hhThem.Tensp;
            hh.AppendChild(tensp);

            XmlElement gia = doc.CreateElement("gia");
            gia.InnerText = hhThem.Gia.ToString();
            hh.AppendChild(gia);

            XmlElement dvt = doc.CreateElement("donvitinh");
            dvt.InnerText = hhThem.Dvt;
            hh.AppendChild(dvt);

            XmlElement manh = doc.CreateElement("manhomhang");
            manh.InnerText = hhThem.Mannh;
            hh.AppendChild(manh);

            root.AppendChild(hh);
            doc.Save(fileName);
        }

        public void Sua(QLsanphamDTO hhSua)
        {

            XmlNode hhCu = root.SelectSingleNode("hanghoa[masp ='" + hhSua.Masp + "']");
            if (hhCu != null)
            {
                XmlNode hhSuaMoi = doc.CreateElement("hanghoa");


                XmlElement masp = doc.CreateElement("masp");
                masp.InnerText = hhSua.Masp;
                hhSuaMoi.AppendChild(masp);

                XmlElement tensp = doc.CreateElement("tensp");
                tensp.InnerText = hhSua.Tensp;
                hhSuaMoi.AppendChild(tensp);

                XmlElement gia = doc.CreateElement("gia");
                gia.InnerText = hhSua.Gia.ToString();
                hhSuaMoi.AppendChild(gia);

                XmlElement dvt = doc.CreateElement("donvitinh");
                dvt.InnerText = hhSua.Dvt;
                hhSuaMoi.AppendChild(dvt);

                XmlElement manh = doc.CreateElement("manhomhang");
                manh.InnerText = hhSua.Mannh;
                hhSuaMoi.AppendChild(manh);


                root.ReplaceChild(hhSuaMoi, hhCu);
                doc.Save(fileName);
            }
        }

        public void Xoa(QLsanphamDTO hhXoa)
        {
            XmlNode csdCanXoa = root.SelectSingleNode("hanghoa[masp ='" + hhXoa.Masp + "']");
            if (csdCanXoa != null)
            {
                root.RemoveChild(csdCanXoa);

                doc.Save(fileName);
            }
        }

        /// <summary>
        /// Tìm và trả về đối tượng sách tìm thấy, không thấy = null
        /// </summary>
        /// <param name="sachTim">Đối tượng chứa thông tin tìm kiếm</param>
        /// <param name="dgv">grid view hiển thị</param>
        /// <returns>tìm thấy nếu khác null</returns>
        public QLsanphamDTO TimKiem2(QLsanphamDTO hhTim, DataGridView dgv)
        {
            QLsanphamDTO ketQua = null;
            dgv.Rows.Clear();
            XmlNode hhCanTim = root.SelectSingleNode("hanghoa[masp ='" + hhTim.Masp + "']"); ;
            if (hhCanTim != null)
            {
                dgv.ColumnCount = 5;//khai báo số cột
                dgv.Rows.Add();//thêm một dòng mới

                //đưa dữ liệu vào dòng vừa tạo
                dgv.Rows[0].Cells[0].Value = hhTim.Masp = hhCanTim.SelectSingleNode("masp").InnerText;
                dgv.Rows[0].Cells[1].Value = hhCanTim.SelectSingleNode("tensp").InnerText;
                dgv.Rows[0].Cells[2].Value = hhCanTim.SelectSingleNode("gia").InnerText;
                dgv.Rows[0].Cells[3].Value = hhCanTim.SelectSingleNode("donvitinh").InnerText;
                dgv.Rows[0].Cells[4].Value = hhCanTim.SelectSingleNode("manhomhang").InnerText;

                ketQua = new QLsanphamDTO();

                ketQua.Masp = hhCanTim.SelectSingleNode("masp").InnerText;
                ketQua.Tensp = hhCanTim.SelectSingleNode("tensp").InnerText;
                ketQua.Gia = int.Parse(hhCanTim.SelectSingleNode("gia").InnerText);
                ketQua.Dvt = hhCanTim.SelectSingleNode("donvitinh").InnerText;
                ketQua.Mannh = hhCanTim.SelectSingleNode("manhomhang").InnerText;
            }

            return ketQua;
        }


        public void HienThi(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 5;

            XmlNodeList ds = root.SelectNodes("hanghoa");
            int sd = 0;//lưu chỉ số dòng
            foreach (XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = item.SelectSingleNode("masp").InnerText;
                dgv.Rows[sd].Cells[1].Value = item.SelectSingleNode("tensp").InnerText;
                dgv.Rows[sd].Cells[2].Value = item.SelectSingleNode("gia").InnerText;
                dgv.Rows[sd].Cells[3].Value = item.SelectSingleNode("donvitinh").InnerText;
                dgv.Rows[sd].Cells[4].Value = item.SelectSingleNode("manhomhang").InnerText;
                sd++;
            }
        }
    }

}
