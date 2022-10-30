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
    public partial class Form3 : Form
    {
        public static SqlCommand com;
        public static SqlDataAdapter ad;
        public static DataTable dt;
        private static SqlConnection mycon;
        private static string sqlconn = @"Data Source=DESKTOP-NT4NLQ5;Initial Catalog=QuanLySinhVien;Integrated Security=True";

        public static void hienthi(DataGridView db3)
        {
            try
            {
                string chuoi = "Select * from LOP";
                ad = new SqlDataAdapter(chuoi, sqlconn);
                dt = new DataTable();
                ad.Fill(dt);
                db3.DataSource = dt;
                db3.Columns[0].HeaderText = "Mã Lớp";
                db3.Columns[1].HeaderText = "Mã Khóa Học";
                db3.Columns[2].HeaderText = "Mã Khoa";
                db3.Columns[3].HeaderText = "Mã Chương Trình";
                db3.Columns[4].HeaderText = "Số Thứ Tự";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại" + ex);
            }
        }
        public static void timkiem(DataGridView db3, string tukhoa, string luachon)
        {
            try
            {
                string chuoi = "Select * from LOP where " + luachon + " like N'%" + tukhoa + "%'";
                ad = new SqlDataAdapter(chuoi, sqlconn);
                dt = new DataTable();
                ad.Fill(dt);
                db3.DataSource = dt;
                db3.Columns[0].HeaderText = "Mã lớp";
                db3.Columns[1].HeaderText = "Mã Khóa Học";
                db3.Columns[2].HeaderText = "Mã Khoa";
                db3.Columns[3].HeaderText = "Mã Chương Trình";
                db3.Columns[3].HeaderText = "Số thứ tự";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại" + ex);
            }
        }
        public Form3()
        {
            InitializeComponent();
            hienthi(db3);
        }

        private void db1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            try
            {
                //string sql1 = "insert into SINHVIEN values ('"+masv_txt+ "',N'" + hoten_txt.Text + "',N'" + sdt_txt.Text + "',N'" + diachi_txt.Text + "')";
                string sql1 = "insert into LOP values ('" + malop_txt.Text + "','" + makh_txt.Text + "','" + makhoa_txt.Text + "','" + mact_txt.Text + "','" + stt_txt.Text + "')";
                if (malop_txt.Text == "" || makh_txt.Text == "" || makhoa_txt.Text == "" || mact_txt.Text == "" || stt_txt.Text == "") { 
                    MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thất bại", MessageBoxButtons.OK);
                }
                else
                {
                    mycon = new SqlConnection(sqlconn);
                    com = new SqlCommand(sql1, mycon);
                    ad = new SqlDataAdapter(com);
                    DataTable tb = new DataTable();
                    ad.Fill(tb);
                    db3.DataSource = tb;
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                    hienthi(db3);
                    mycon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại!", "Thất bại", MessageBoxButtons.OK);
            }
        }

        private void mact_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            string sql = "update LOP set sothutu='" + stt_txt.Text + "',machuongtrinh='" + mact_txt.Text + "',makhoa='" + makhoa_txt.Text + "',makhoahoc=N'" + makh_txt.Text + "'where malop='" + malop_txt.Text + "'";
            try
            {
                if (malop_txt.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thất bại", MessageBoxButtons.OK);
                }
                else
                {
                    mycon = new SqlConnection(sqlconn);
                    mycon.Open();
                    com = new SqlCommand(sql, mycon);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Sửa dữ liệu thành công sinh viên có malop là: '" + malop_txt.Text + "'!", "Thành công !", MessageBoxButtons.OK);
                    hienthi(db3);
                    bt_them.Enabled = true;
                    malop_txt.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa dữ liệu thất bại'" + ex + "'", "Thất bại !", MessageBoxButtons.OK);
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {

            string sql = "delete LOP Where malop='" + malop_txt.Text + "' ";
            try
            {
                if (malop_txt.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thất bại", MessageBoxButtons.OK);
                }
                else if (MessageBox.Show("Bạn muốn xóa sinh viên có masv là: '" + malop_txt.Text + "'này không?", "Cảnh báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    mycon = new SqlConnection(sqlconn);
                    mycon.Open();
                    com = new SqlCommand(sql, mycon);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Xóa dữ liệu thành công sinh viên có malop là: '" + malop_txt.Text + "'!", "Thành công !", MessageBoxButtons.OK);
                    hienthi(db3);
                    bt_them.Enabled = true;
                    malop_txt.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa dữ liệu thất bại", "Thất bại !", MessageBoxButtons.OK);
            }
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            malop_txt.Clear();
            makh_txt.Clear();
            makhoa_txt.Clear();
            mact_txt.Clear();
            stt_txt.Clear();
            malop_txt.Focus();
            bt_them.Enabled = true;
            malop_txt.Enabled = true;
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            cau2 cau2 = new cau2();
            cau2.Show();
        }

        private void kếtQuảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = search_txt.Text;
            if (cb_search.SelectedItem == "Mã Lớp")
            {
                string luachon = "malop";
                timkiem(db3, tukhoa, luachon);
            }
            else if (cb_search.SelectedItem == "Mã Khoa")
            {
                string luachon = "makhoa";
                timkiem(db3, tukhoa, luachon);
            }
            else if (cb_search.SelectedItem == "Mã Khóa Học")
            {
                string luachon = "makhoahoc";
                timkiem(db3, tukhoa, luachon);
            }
            else if (cb_search.SelectedItem == "Mã Chương Trình")
            {
                string luachon = "machuongtrinh";
                timkiem(db3, tukhoa, luachon);
            }
            else
            {
                string luachon = "STT";
                timkiem(db3, tukhoa, luachon);
            }
        }

        private void db3_Click(object sender, EventArgs e)
        {

            int curow = db3.CurrentRow.Index;
            malop_txt.Text = db3.Rows[curow].Cells[0].Value.ToString();
            makh_txt.Text = db3.Rows[curow].Cells[1].Value.ToString();
            makhoa_txt.Text = db3.Rows[curow].Cells[2].Value.ToString();
            mact_txt.Text = db3.Rows[curow].Cells[3].Value.ToString();
            stt_txt.Text = db3.Rows[curow].Cells[4].Value.ToString();
            bt_them.Enabled = false;
            malop_txt.Enabled = false;
        }
    }
}
