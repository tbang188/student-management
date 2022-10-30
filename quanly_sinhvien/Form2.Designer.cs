namespace quanly_sinhvien
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.db2 = new System.Windows.Forms.DataGridView();
            this.mamon_txt = new System.Windows.Forms.TextBox();
            this.diem_txt = new System.Windows.Forms.TextBox();
            this.masv_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtQuảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::quanly_sinhvien.Properties.Resources.logo__2_;
            this.pictureBox1.Location = new System.Drawing.Point(50, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(648, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // search_txt
            // 
            this.search_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_txt.Location = new System.Drawing.Point(601, 93);
            this.search_txt.Multiline = true;
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(313, 34);
            this.search_txt.TabIndex = 41;
            this.search_txt.Text = "Nhập từ khóa";
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // cb_search
            // 
            this.cb_search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Items.AddRange(new object[] {
            "Mã Sinh Viên",
            "Họ và tên",
            "Mã môn học",
            "Điểm"});
            this.cb_search.Location = new System.Drawing.Point(320, 93);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(221, 34);
            this.cb_search.TabIndex = 40;
            this.cb_search.Text = "--Lựa chọn tìm kiếm";
            this.cb_search.SelectedIndexChanged += new System.EventHandler(this.cb_search_SelectedIndexChanged);
            // 
            // bt_close
            // 
            this.bt_close.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_close.Location = new System.Drawing.Point(957, 405);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(110, 41);
            this.bt_close.TabIndex = 39;
            this.bt_close.Text = "Thoát";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_clear.Location = new System.Drawing.Point(799, 405);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(115, 41);
            this.bt_clear.TabIndex = 38;
            this.bt_clear.Text = "Làm mới";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_delete.Location = new System.Drawing.Point(648, 405);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(108, 41);
            this.bt_delete.TabIndex = 37;
            this.bt_delete.Text = "Xóa";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_edit.Location = new System.Drawing.Point(479, 405);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(106, 41);
            this.bt_edit.TabIndex = 36;
            this.bt_edit.Text = "Sửa";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_them
            // 
            this.bt_them.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_them.Location = new System.Drawing.Point(304, 405);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(103, 41);
            this.bt_them.TabIndex = 35;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // db2
            // 
            this.db2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db2.Location = new System.Drawing.Point(560, 145);
            this.db2.Name = "db2";
            this.db2.RowHeadersWidth = 51;
            this.db2.RowTemplate.Height = 29;
            this.db2.Size = new System.Drawing.Size(569, 227);
            this.db2.TabIndex = 34;
            this.db2.Click += new System.EventHandler(this.db2_Click);
            // 
            // mamon_txt
            // 
            this.mamon_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mamon_txt.Location = new System.Drawing.Point(279, 236);
            this.mamon_txt.Multiline = true;
            this.mamon_txt.Name = "mamon_txt";
            this.mamon_txt.Size = new System.Drawing.Size(245, 38);
            this.mamon_txt.TabIndex = 33;
            // 
            // diem_txt
            // 
            this.diem_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.diem_txt.Location = new System.Drawing.Point(279, 301);
            this.diem_txt.Multiline = true;
            this.diem_txt.Name = "diem_txt";
            this.diem_txt.Size = new System.Drawing.Size(245, 38);
            this.diem_txt.TabIndex = 32;
            // 
            // masv_txt
            // 
            this.masv_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.masv_txt.Location = new System.Drawing.Point(279, 170);
            this.masv_txt.Multiline = true;
            this.masv_txt.Name = "masv_txt";
            this.masv_txt.Size = new System.Drawing.Size(245, 38);
            this.masv_txt.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(165, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 26);
            this.label5.TabIndex = 29;
            this.label5.Text = "Điểm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(143, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 26);
            this.label4.TabIndex = 28;
            this.label4.Text = "Mã Môn ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(91, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 26);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mã số sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(224, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 53);
            this.label1.TabIndex = 25;
            this.label1.Text = "Quản Lý Kết Quả";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1151, 28);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinSinhViênToolStripMenuItem,
            this.kếtQuảToolStripMenuItem,
            this.lớpToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // thôngTinSinhViênToolStripMenuItem
            // 
            this.thôngTinSinhViênToolStripMenuItem.Name = "thôngTinSinhViênToolStripMenuItem";
            this.thôngTinSinhViênToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.thôngTinSinhViênToolStripMenuItem.Text = "Thông Tin Sinh Viên";
            this.thôngTinSinhViênToolStripMenuItem.Click += new System.EventHandler(this.thôngTinSinhViênToolStripMenuItem_Click);
            // 
            // kếtQuảToolStripMenuItem
            // 
            this.kếtQuảToolStripMenuItem.Name = "kếtQuảToolStripMenuItem";
            this.kếtQuảToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.kếtQuảToolStripMenuItem.Text = "Kết Quả";
            // 
            // lớpToolStripMenuItem
            // 
            this.lớpToolStripMenuItem.Name = "lớpToolStripMenuItem";
            this.lớpToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.lớpToolStripMenuItem.Text = "Lớp";
            this.lớpToolStripMenuItem.Click += new System.EventHandler(this.lớpToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.cb_search);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.db2);
            this.Controls.Add(this.mamon_txt);
            this.Controls.Add(this.diem_txt);
            this.Controls.Add(this.masv_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox search_txt;
        private ComboBox cb_search;
        private Button bt_close;
        private Button bt_clear;
        private Button bt_delete;
        private Button bt_edit;
        private Button bt_them;
        private DataGridView db2;
        private TextBox diachi_txt;
        private TextBox sdt_txt;
        private TextBox masv_txt;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem thôngTinSinhViênToolStripMenuItem;
        private ToolStripMenuItem kếtQuảToolStripMenuItem;
        private ToolStripMenuItem lớpToolStripMenuItem;
        private TextBox mamon_txt;
        private TextBox diem_txt;
    }
}