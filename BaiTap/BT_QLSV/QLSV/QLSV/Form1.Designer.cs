namespace QLSV
{
    partial class Form1
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
            this.dgv_thongTinSinhVien = new System.Windows.Forms.DataGridView();
            this.txt_MSSV = new System.Windows.Forms.TextBox();
            this.txt_hoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.cbb_tenLop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongTinSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_thongTinSinhVien
            // 
            this.dgv_thongTinSinhVien.AllowUserToAddRows = false;
            this.dgv_thongTinSinhVien.AllowUserToDeleteRows = false;
            this.dgv_thongTinSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongTinSinhVien.Location = new System.Drawing.Point(349, 75);
            this.dgv_thongTinSinhVien.Name = "dgv_thongTinSinhVien";
            this.dgv_thongTinSinhVien.ReadOnly = true;
            this.dgv_thongTinSinhVien.RowTemplate.Height = 24;
            this.dgv_thongTinSinhVien.Size = new System.Drawing.Size(351, 315);
            this.dgv_thongTinSinhVien.TabIndex = 0;
            this.dgv_thongTinSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_thongTinSinhVien_CellClick);
            // 
            // txt_MSSV
            // 
            this.txt_MSSV.Location = new System.Drawing.Point(98, 75);
            this.txt_MSSV.Name = "txt_MSSV";
            this.txt_MSSV.Size = new System.Drawing.Size(200, 22);
            this.txt_MSSV.TabIndex = 1;
            // 
            // txt_hoTen
            // 
            this.txt_hoTen.Location = new System.Drawing.Point(96, 138);
            this.txt_hoTen.Name = "txt_hoTen";
            this.txt_hoTen.Size = new System.Drawing.Size(200, 22);
            this.txt_hoTen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "MSSV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(26, 274);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 29);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(129, 350);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 29);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(236, 350);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 29);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // cbb_tenLop
            // 
            this.cbb_tenLop.FormattingEnabled = true;
            this.cbb_tenLop.Location = new System.Drawing.Point(96, 198);
            this.cbb_tenLop.Name = "cbb_tenLop";
            this.cbb_tenLop.Size = new System.Drawing.Size(202, 24);
            this.cbb_tenLop.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên lớp";
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(129, 274);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 29);
            this.btn_luu.TabIndex = 5;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(236, 274);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 29);
            this.btn_huy.TabIndex = 6;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Location = new System.Drawing.Point(25, 350);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(75, 29);
            this.btn_lamMoi.TabIndex = 7;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(204, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "DANH SÁCH SINH VIÊN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 427);
            this.Controls.Add(this.btn_lamMoi);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.cbb_tenLop);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_hoTen);
            this.Controls.Add(this.txt_MSSV);
            this.Controls.Add(this.dgv_thongTinSinhVien);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongTinSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_thongTinSinhVien;
        private System.Windows.Forms.TextBox txt_MSSV;
        private System.Windows.Forms.TextBox txt_hoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.ComboBox cbb_tenLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_lamMoi;
        private System.Windows.Forms.Label label4;
    }
}

