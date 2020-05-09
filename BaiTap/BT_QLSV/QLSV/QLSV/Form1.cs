using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class Form1 : Form
    {
        KNCSDL conn;
        public Form1()
        {
            InitializeComponent();
            conn = new KNCSDL();
            txt_MSSV.Enabled = false;        
                    
            btn_luu.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_huy.Enabled = false;

            if (conn.Moketnoi())
            {
                string str = "select * from Lop";
                
                cbb_tenLop.DataSource = conn.LayBang(str);
                cbb_tenLop.DisplayMember = "TenLop";
                cbb_tenLop.ValueMember = "MaLop";
                

                str = "select * from SinhVien";
                dgv_thongTinSinhVien.DataSource = conn.LayBang(str);
            }
            refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hienThiLuoi()
        {         
            string str = "SELECT * FROM SinhVien";          
            dgv_thongTinSinhVien.DataSource = conn.LayBang(str);
        }

        private void refresh()
        {
            txt_MSSV.Clear();
            txt_hoTen.Clear();
            cbb_tenLop.SelectedIndex = -1;
            cbb_tenLop.Text = "";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            refresh();         
            txt_MSSV.Enabled = true;
            txt_hoTen.Enabled = true;
            cbb_tenLop.Enabled = true;
            btn_luu.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_huy.Enabled = true;
            btn_them.Enabled = false;
            txt_MSSV.Focus();
           
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

            if (txt_hoTen.Text == "" || cbb_tenLop.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo!");
                return;
            }
            string str = "update SinhVien set HoTen = N'" + txt_hoTen.Text.Trim() + "', MaLop = '" + cbb_tenLop.SelectedValue.ToString() + "' where MSSV = '" + txt_MSSV.Text.Trim() + "'";
            conn.CapnhatCSDL(str);
            refresh();
            hienThiLuoi();     
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_MSSV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo!");
                return;
            }
            string str = "delete from SinhVien where MSSV = " + txt_MSSV.Text.Trim();
            conn.CapnhatCSDL(str);
            refresh();
            hienThiLuoi();
        }

        private void dgv_thongTinSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MSSV.Text = dgv_thongTinSinhVien[0, e.RowIndex].Value.ToString();
            txt_hoTen.Text = dgv_thongTinSinhVien[1, e.RowIndex].Value.ToString();  
            cbb_tenLop.SelectedValue = dgv_thongTinSinhVien[2, e.RowIndex].Value.ToString();
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_MSSV.Text == "" || txt_hoTen.Text == "" || cbb_tenLop.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo!");
                return;
            }
            string str = "insert into SinhVien values('" + txt_MSSV.Text.Trim() + "',N'" + txt_hoTen.Text.Trim() + "','" + cbb_tenLop.SelectedValue.ToString() + "')";
            conn.CapnhatCSDL(str);
            refresh();
            hienThiLuoi();
                       
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            refresh();
            txt_MSSV.Enabled = false;
            txt_hoTen.Enabled = true;
            btn_luu.Enabled = false;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
            btn_huy.Enabled = false;
            btn_them.Enabled = true;
            
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
