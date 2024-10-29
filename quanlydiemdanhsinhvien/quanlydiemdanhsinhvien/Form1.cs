using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlydiemdanhsinhvien
{
   
    public partial class Form1 : Form
    {
        private List<SinhVien> dsSinhVien;
        private void hienthiDanhSachSinhVien()
        {
            dataGridView1.DataSource = dsSinhVien.ToList();
        }
        private SinhVien timSinhVien(string ma)
        {
            foreach (SinhVien n in dsSinhVien)
                if (n.MaSoSinhVien == ma) return n;
            return null;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void danhSáchSinhViênCấmThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            danhsachsinhviencamthi f = new danhsachsinhviencamthi();
            f.ShowDialog();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanlymonhoc f = new quanlymonhoc();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinhVien n = new SinhVien();
            n.MaSoSinhVien = txbMaSoSinhVien.Text;
            n.HoVaTen = txbHoVaTen.Text;
            n.Lop = txbLop.Text;
            n.NgayDiemDanh = dtpkNgayDiemDanh.Value;
            n.GioiTinh = rdbtNam.Checked;
            //
            if (timSinhVien(n.MaSoSinhVien) == null)
            {
                dsSinhVien.Add(n);
                hienthiDanhSachSinhVien();
            }
            else
            {
                MessageBox.Show("Sinh Viên" + n.HoVaTen + "Đã Tồn Tại !");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ma = txbMaSoSinhVien.Text;
            if (timSinhVien(ma) != null)
            {
                dsSinhVien.Remove(timSinhVien(ma));
                hienthiDanhSachSinhVien();
            }
            else
                MessageBox.Show("Sinh Viên Không Tồn Tại !");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsSinhVien = new List<SinhVien>();
            hienthiDanhSachSinhVien();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SinhVien ketqua = timSinhVien(txbMaSoSinhVien.Text);
            if (ketqua != null)
            {
                ketqua.HoVaTen = txbHoVaTen.Text;
                ketqua.MaSoSinhVien = txbMaSoSinhVien.Text;
                ketqua.NgayDiemDanh = DateTime.Now;
                ketqua.GioiTinh = rdbtNam.Checked;
                //ketqua.MonHoc = cbbMonHoc.Created;
                hienthiDanhSachSinhVien();
            }
            else
                MessageBox.Show("null !");
        }

        private void dvgSinhVien(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex].Name== "GioiTinh")
            {
                if(e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Nam" : "Nu";
                    e.FormattingApplied = true;
                }
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Bạn Có Muốn Thoát Chương Trình !";
            string title = "Thông Báo";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;//gán button = 2 gtri yes or no
            DialogResult result = MessageBox.Show(message, title, buttons); // hiện cái vừa gán ra
            if (result == DialogResult.Yes)
            {
                Close();
            }
            else
            {

            }
        }
    }
}
