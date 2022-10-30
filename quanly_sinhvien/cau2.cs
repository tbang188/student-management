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
    public partial class cau2 : Form
    {
        public static SqlCommand com;
        public static SqlDataAdapter ad;
        public static DataTable dt;
        private static SqlConnection mycon;
        private static string sqlconn = @"Data Source=DESKTOP-NT4NLQ5;Initial Catalog=QuanLySinhVien;Integrated Security=True";

        public static void hienthi(DataGridView db1)
        {
           try
            {
                string chuoi = "Select * from SINHVIEN";
                ad = new SqlDataAdapter(chuoi, sqlconn);
                dt = new DataTable();
                ad.Fill(dt);
                db1.DataSource = dt;
                db1.Columns[0].HeaderText = "Mã Sinh Viên";
                db1.Columns[1].HeaderText = "Họ và Tên";
                db1.Columns[2].HeaderText = "Số điện Thoại";
                db1.Columns[3].HeaderText = "Địa chỉ";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Kết nối thất bại" + ex);
            }
        }

        public static void timkiem(DataGridView db1, string tukhoa, string luachon)
        {
            try
            {
                string chuoi = "Select * from SINHVIEN where "+luachon+" like N'%"+tukhoa+"%'";
                ad = new SqlDataAdapter(chuoi, sqlconn);
                dt = new DataTable();
                ad.Fill(dt);
                db1.DataSource = dt;
                db1.Columns[0].HeaderText = "Mã Sinh Viên";
                db1.Columns[1].HeaderText = "Họ và Tên";
                db1.Columns[2].HeaderText = "Số điện thoại";
                db1.Columns[3].HeaderText = "Địa chỉ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại" + ex);
            }
        }
        public cau2()
        {
            InitializeComponent();
            hienthi(db1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {

            try
            {
                //string sql1 = "insert into SINHVIEN values ('"+masv_txt+ "',N'" + hoten_txt.Text + "',N'" + sdt_txt.Text + "',N'" + diachi_txt.Text + "')";
                string sql1 = "insert into SINHVIEN values ('" + masv_txt.Text + "',N'" + hoten_txt.Text + "','" + sdt_txt.Text + "','" + diachi_txt.Text + "')";
               if(masv_txt.Text=="" || hoten_txt.Text =="" || sdt_txt.Text =="" || diachi_txt.Text == "")
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
                    db1.DataSource = tb;
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                    hienthi(db1);
                    mycon.Close();
                }
            }
            catch(Exception ex) 
            { 
                MessageBox.Show("Thêm thất bại!", "Thất bại",MessageBoxButtons.OK); 
            }

        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            string sql = "update SINHVIEN set hoten=N'"+hoten_txt.Text+"',sdt='"+sdt_txt.Text+"',diachi=N'"+diachi_txt.Text+"'where masv='"+masv_txt.Text+"'";
            try
            {
               if(masv_txt.Text=="")
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
                    hienthi(db1);
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
            string sql = "delete SINHVIEN Where masv='"+masv_txt.Text+"' ";
            try
            {
                if (masv_txt.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thất bại", MessageBoxButtons.OK);
                }
                else if(MessageBox.Show("Bạn muốn xóa sinh viên có masv là: '" + masv_txt.Text + "'này không?", "Cảnh báo !", MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    mycon = new SqlConnection(sqlconn);
                    mycon.Open();
                    com = new SqlCommand(sql, mycon);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Xóa dữ liệu thành công sinh viên có masv là: '" + masv_txt.Text + "'!", "Thành công !", MessageBoxButtons.OK);
                    hienthi(db1);
                    bt_them.Enabled = true;
                    masv_txt.Enabled = true;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa dữ liệu thất bại", "Thất bại !", MessageBoxButtons.OK);
            }
        }

        private void cau2_Load(object sender, EventArgs e)
        {

        }

        private void db1_Click(object sender, EventArgs e)
        {
            int curow = db1.CurrentRow.Index;
            masv_txt.Text = db1.Rows[curow].Cells[0].Value.ToString();
            hoten_txt.Text = db1.Rows[curow].Cells[1].Value.ToString();
            sdt_txt.Text = db1.Rows[curow].Cells[2].Value.ToString();
            diachi_txt.Text = db1.Rows[curow].Cells[3].Value.ToString();
            bt_them.Enabled = false;
            masv_txt.Enabled = false;
            
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            masv_txt.Clear();
            hoten_txt.Clear();
            sdt_txt.Clear();
            diachi_txt.Clear();
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

        private void sdt_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            string tukhoa = search_txt.Text;
            if(cb_search.SelectedItem == "Mã Sinh Viên")
            {
                string luachon = "masv";
                timkiem(db1, tukhoa, luachon);
            }
            else if (cb_search.SelectedItem == "Họ và tên")
            {
                string luachon = "hoten";
                timkiem(db1, tukhoa, luachon);
            }
            else if (cb_search.SelectedItem == "Số điện thoại")
            {
                string luachon = "sdt";
                timkiem(db1, tukhoa, luachon);
            }
            else 
            {
                string luachon = "diachi";
                timkiem(db1, tukhoa, luachon);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void db1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kếtQuảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();


        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
