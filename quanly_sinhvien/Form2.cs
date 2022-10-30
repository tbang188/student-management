using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace quanly_sinhvien
{
    public partial class Form2 : Form
    {
        public static SqlCommand com;
        public static SqlDataAdapter ad;
        public static DataTable dt;
        private static SqlConnection mycon;
        private static string sqlconn = @"Data Source=DESKTOP-NT4NLQ5;Initial Catalog=QuanLySinhVien;Integrated Security=True";

        public static void hienthi(DataGridView db2)
        {
            try
            {
                string chuoikq = "SELECT SINHVIEN.hoten, KETQUA.MA_SINHVIEN, KETQUA.MA_MONHOC, KETQUA.DIEM FROM SINHVIEN, KETQUA";
                ad = new SqlDataAdapter(chuoikq, sqlconn);
                dt = new DataTable();
                ad.Fill(dt);
                db2.DataSource = dt;
                db2.Columns[0].HeaderText = "Họ và Tên";
                db2.Columns[1].HeaderText = "Mã Sinh Viên";
                db2.Columns[2].HeaderText = "Mã môn học";
                db2.Columns[3].HeaderText = "Điểm";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại" + ex);
            }
        }
        public static void timkiem(DataGridView db2, string tukhoa, string luachon)
        {
            try
            {
                string chuoi = "Select * from KETQUA where " + luachon + " like N'%" + tukhoa + "%'";
                ad = new SqlDataAdapter(chuoi, sqlconn);
                dt = new DataTable();
                ad.Fill(dt);
                db2.DataSource = dt;
                db2.Columns[0].HeaderText = "Mã Sinh Viên";                
                db2.Columns[1].HeaderText = "Mã Môn Học";
                db2.Columns[2].HeaderText = "Điểm";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại" + ex);
            }
        }

        public Form2()
        {
            InitializeComponent();
            hienthi(db2);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cb_search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {

            try
            {
                //string sql1 = "insert into SINHVIEN values ('"+masv_txt+ "',N'" + hoten_txt.Text + "',N'" + sdt_txt.Text + "',N'" + diachi_txt.Text + "')";
                string sql1 = "insert into KETQUA values ('" +  masv_txt.Text + "','" + mamon_txt.Text + "','" + diem_txt.Text + "')";
                if ( masv_txt.Text == "" || mamon_txt.Text == "" || diem_txt.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thất bại", MessageBoxButtons.OK);
                }
                else
                {
                    mycon = new SqlConnection(sqlconn);
                    com = new SqlCommand(sql1, mycon);
                    ad = new SqlDataAdapter(com);
                    DataTable tb = new DataTable();
                    ad.Fill(tb);
                    db2.DataSource = tb;
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                    hienthi(db2);
                    mycon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại!", "Thất bại", MessageBoxButtons.OK);
            }

        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            string sql = "update KETQUA set ma_monhoc='" + mamon_txt.Text + "',diem=N'" + diem_txt.Text + "'where ma_sinhvien='" + masv_txt.Text + "'";
            try
            {
                if (masv_txt.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thất bại", MessageBoxButtons.OK);
                }
                else
                {
                    mycon = new SqlConnection(sqlconn);
                    mycon.Open();
                    com = new SqlCommand(sql, mycon);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Sửa dữ liệu thành công sinh viên có masv là: '" + masv_txt.Text + "'!", "Thành công !", MessageBoxButtons.OK);
                    hienthi(db2);
                    bt_them.Enabled = true;
                    masv_txt.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa dữ liệu thất bại'" + ex + "'", "Thất bại !", MessageBoxButtons.OK);
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string sql = "delete KETQUA Where ma_sinhvien='" + masv_txt.Text + "' ";
            try
            {
                if (masv_txt.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thất bại", MessageBoxButtons.OK);
                }
                else if (MessageBox.Show("Bạn muốn xóa sinh viên có masv là: '" + masv_txt.Text + "'này không?", "Cảnh báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    mycon = new SqlConnection(sqlconn);
                    mycon.Open();
                    com = new SqlCommand(sql, mycon);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Xóa dữ liệu thành công sinh viên có masv là: '" + masv_txt.Text + "'!", "Thành công !", MessageBoxButtons.OK);
                    hienthi(db2);
                    bt_them.Enabled = true;
                    masv_txt.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa dữ liệu thất bại", "Thất bại !", MessageBoxButtons.OK);
            }
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            masv_txt.Clear();
            mamon_txt.Clear();
            diem_txt.Clear();
            masv_txt.Focus();
            bt_them.Enabled = true;
            masv_txt.Enabled = true;
        }

        private void bt_close_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
             string tukhoa = search_txt.Text;
                if (cb_search.SelectedItem == "Mã Sinh Viên")
                {
                    string luachon = "ma_sinhvien";
                    timkiem(db2, tukhoa, luachon);
                }
                else if (cb_search.SelectedItem == "Họ và tên")
                {
                    string luachon = "hoten";
                    timkiem(db2, tukhoa, luachon);
                }
                else if (cb_search.SelectedItem == "Mã Môn Học")
                {
                    string luachon = "ma_monhoc";
                    timkiem(db2, tukhoa, luachon);
                }
                else
                {
                    string luachon = "diem";
                    timkiem(db2, tukhoa, luachon);
                }
            
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            cau2 cau2 = new cau2();
            cau2.Show();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3(); 
            form3.Show();
        }

        private void db2_Click(object sender, EventArgs e)
        {
            int curow = db2.CurrentRow.Index;
            masv_txt.Text = db2.Rows[curow].Cells[1].Value.ToString();
            mamon_txt.Text = db2.Rows[curow].Cells[2].Value.ToString();
            diem_txt.Text = db2.Rows[curow].Cells[3].Value.ToString();
            bt_them.Enabled = false;
            masv_txt.Enabled = false;

        }
    }
}
