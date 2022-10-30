namespace quanly_sinhvien
{
    partial class Form3
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
            this.db3 = new System.Windows.Forms.DataGridView();
            this.stt_txt = new System.Windows.Forms.TextBox();
            this.makhoa_txt = new System.Windows.Forms.TextBox();
            this.makh_txt = new System.Windows.Forms.TextBox();
            this.malop_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtQuảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mact_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::quanly_sinhvien.Properties.Resources.logo__2_;
            this.pictureBox1.Location = new System.Drawing.Point(42, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(860, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 61;
            // 
            // search_txt
            // 
            this.search_txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_txt.Location = new System.Drawing.Point(797, 88);
            this.search_txt.Multiline = true;
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(313, 34);
            this.search_txt.TabIndex = 60;
            this.search_txt.Text = "Nhập từ khóa";
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // cb_search
            // 
            this.cb_search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Items.AddRange(new object[] {
            "Mã Lớp",
            "Mã Khoa",
            "Mã Khóa Học",
            "Mã Chương Trình",
            "STT"});
            this.cb_search.Location = new System.Drawing.Point(541, 88);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(221, 34);
            this.cb_search.TabIndex = 59;
            this.cb_search.Text = "--Lựa chọn tìm kiếm";
            // 
            // bt_close
            // 
            this.bt_close.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_close.Location = new System.Drawing.Point(940, 431);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(110, 41);
            this.bt_close.TabIndex = 58;
            this.bt_close.Text = "Thoát";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_clear.Location = new System.Drawing.Point(780, 431);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(115, 41);
            this.bt_clear.TabIndex = 57;
            this.bt_clear.Text = "Làm mới";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_delete.Location = new System.Drawing.Point(629, 431);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(108, 41);
            this.bt_delete.TabIndex = 56;
            this.bt_delete.Text = "Xóa";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_edit.Location = new System.Drawing.Point(456, 431);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(106, 41);
            this.bt_edit.TabIndex = 55;
            this.bt_edit.Text = "Sửa";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_them
            // 
            this.bt_them.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_them.Location = new System.Drawing.Point(285, 431);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(103, 41);
            this.bt_them.TabIndex = 54;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // db3
            // 
            this.db3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db3.Location = new System.Drawing.Point(541, 140);
            this.db3.Name = "db3";
            this.db3.RowHeadersWidth = 51;
            this.db3.RowTemplate.Height = 29;
            this.db3.Size = new System.Drawing.Size(569, 227);
            this.db3.TabIndex = 53;
            this.db3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.db1_CellContentClick);
            this.db3.Click += new System.EventHandler(this.db3_Click);
            // 
            // stt_txt
            // 
            this.stt_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stt_txt.Location = new System.Drawing.Point(241, 368);
            this.stt_txt.Multiline = true;
            this.stt_txt.Name = "stt_txt";
            this.stt_txt.Size = new System.Drawing.Size(245, 38);
            this.stt_txt.TabIndex = 52;
            // 
            // makhoa_txt
            // 
            this.makhoa_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.makhoa_txt.Location = new System.Drawing.Point(241, 259);
            this.makhoa_txt.Multiline = true;
            this.makhoa_txt.Name = "makhoa_txt";
            this.makhoa_txt.Size = new System.Drawing.Size(245, 38);
            this.makhoa_txt.TabIndex = 51;
            // 
            // makh_txt
            // 
            this.makh_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.makh_txt.Location = new System.Drawing.Point(241, 206);
            this.makh_txt.Multiline = true;
            this.makh_txt.Name = "makh_txt";
            this.makh_txt.Size = new System.Drawing.Size(245, 38);
            this.makh_txt.TabIndex = 50;
            // 
            // malop_txt
            // 
            this.malop_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.malop_txt.Location = new System.Drawing.Point(241, 153);
            this.malop_txt.Multiline = true;
            this.malop_txt.Name = "malop_txt";
            this.malop_txt.Size = new System.Drawing.Size(245, 38);
            this.malop_txt.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(53, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 26);
            this.label5.TabIndex = 48;
            this.label5.Text = "Số Thứ Tự";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(53, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 26);
            this.label4.TabIndex = 47;
            this.label4.Text = "Mã Khoa";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(53, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 26);
            this.label3.TabIndex = 46;
            this.label3.Text = "Mã Khóa Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(53, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 26);
            this.label2.TabIndex = 45;
            this.label2.Text = "Mã Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(416, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 53);
            this.label1.TabIndex = 44;
            this.label1.Text = "Quản Lý Lớp";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1132, 28);
            this.menuStrip1.TabIndex = 63;
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
            this.menuToolStripMenuItem.Text = "Menu";
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
            this.kếtQuảToolStripMenuItem.Click += new System.EventHandler(this.kếtQuảToolStripMenuItem_Click);
            // 
            // lớpToolStripMenuItem
            // 
            this.lớpToolStripMenuItem.Name = "lớpToolStripMenuItem";
            this.lớpToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.lớpToolStripMenuItem.Text = "Lớp";
            // 
            // mact_txt
            // 
            this.mact_txt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mact_txt.Location = new System.Drawing.Point(241, 312);
            this.mact_txt.Multiline = true;
            this.mact_txt.Name = "mact_txt";
            this.mact_txt.Size = new System.Drawing.Size(245, 38);
            this.mact_txt.TabIndex = 65;
            this.mact_txt.TextChanged += new System.EventHandler(this.mact_txt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(53, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 26);
            this.label6.TabIndex = 64;
            this.label6.Text = "Mã Chương Trình";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 532);
            this.Controls.Add(this.mact_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.cb_search);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.db3);
            this.Controls.Add(this.stt_txt);
            this.Controls.Add(this.makhoa_txt);
            this.Controls.Add(this.makh_txt);
            this.Controls.Add(this.malop_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db3)).EndInit();
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
        private DataGridView db3;
        private TextBox stt_txt;
        private TextBox makhoa_txt;
        private TextBox makh_txt;
        private TextBox malop_txt;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem thôngTinSinhViênToolStripMenuItem;
        private ToolStripMenuItem kếtQuảToolStripMenuItem;
        private ToolStripMenuItem lớpToolStripMenuItem;
        private TextBox mact_txt;
        private Label label6;
    }
}