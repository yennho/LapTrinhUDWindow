namespace BT_Onl_Buoi3_15_04_2020
{
    partial class frm_chuongTrinh
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
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoaHet = new System.Windows.Forms.Button();
            this.btn_thongTin = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(12, 334);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(83, 33);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(115, 334);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(83, 33);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(223, 334);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(83, 33);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xoaHet
            // 
            this.btn_xoaHet.Location = new System.Drawing.Point(341, 334);
            this.btn_xoaHet.Name = "btn_xoaHet";
            this.btn_xoaHet.Size = new System.Drawing.Size(83, 33);
            this.btn_xoaHet.TabIndex = 1;
            this.btn_xoaHet.Text = "Xóa hết";
            this.btn_xoaHet.UseVisualStyleBackColor = true;
            // 
            // btn_thongTin
            // 
            this.btn_thongTin.Location = new System.Drawing.Point(449, 334);
            this.btn_thongTin.Name = "btn_thongTin";
            this.btn_thongTin.Size = new System.Drawing.Size(83, 33);
            this.btn_thongTin.TabIndex = 1;
            this.btn_thongTin.Text = "Thông tin";
            this.btn_thongTin.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(25, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(247, 196);
            this.listBox1.TabIndex = 2;
            // 
            // frm_chuongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 386);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_thongTin);
            this.Controls.Add(this.btn_xoaHet);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Name = "frm_chuongTrinh";
            this.Text = "Chương Trình Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoaHet;
        private System.Windows.Forms.Button btn_thongTin;
        private System.Windows.Forms.ListBox listBox1;
    }
}

