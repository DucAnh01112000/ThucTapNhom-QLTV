
namespace AppQuanLyThuVien
{
    partial class NhaCungCap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_SoDienThoai = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_DiaChi = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_TenNCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_MaNCC = new System.Windows.Forms.TextBox();
            this.dgv_ThongTinNCC = new System.Windows.Forms.DataGridView();
            this.btn_GhiNhan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_GhiNhan);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 219);
            this.panel1.TabIndex = 3;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(659, 34);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 47);
            this.btn_Them.TabIndex = 14;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(659, 98);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 47);
            this.btn_Xoa.TabIndex = 13;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(528, 98);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 47);
            this.btn_Sua.TabIndex = 12;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.txb_SoDienThoai);
            this.panel7.Location = new System.Drawing.Point(262, 33);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(240, 53);
            this.panel7.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Số Điện Thoại";
            // 
            // txb_SoDienThoai
            // 
            this.txb_SoDienThoai.Location = new System.Drawing.Point(6, 26);
            this.txb_SoDienThoai.Name = "txb_SoDienThoai";
            this.txb_SoDienThoai.Size = new System.Drawing.Size(230, 22);
            this.txb_SoDienThoai.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.txb_DiaChi);
            this.panel6.Location = new System.Drawing.Point(16, 151);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 53);
            this.panel6.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Địa Chỉ";
            // 
            // txb_DiaChi
            // 
            this.txb_DiaChi.Location = new System.Drawing.Point(6, 26);
            this.txb_DiaChi.Name = "txb_DiaChi";
            this.txb_DiaChi.Size = new System.Drawing.Size(230, 22);
            this.txb_DiaChi.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txb_Email);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(262, 92);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 53);
            this.panel5.TabIndex = 4;
            // 
            // txb_Email
            // 
            this.txb_Email.Location = new System.Drawing.Point(7, 25);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(230, 22);
            this.txb_Email.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txb_TenNCC);
            this.panel3.Location = new System.Drawing.Point(16, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 53);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Nhà Cung Cấp";
            // 
            // txb_TenNCC
            // 
            this.txb_TenNCC.Location = new System.Drawing.Point(6, 26);
            this.txb_TenNCC.Name = "txb_TenNCC";
            this.txb_TenNCC.Size = new System.Drawing.Size(230, 22);
            this.txb_TenNCC.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "THÔNG TIN NHÀ CUNG CẤP";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txb_MaNCC);
            this.panel2.Location = new System.Drawing.Point(16, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 53);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhà Cung Cấp";
            // 
            // txb_MaNCC
            // 
            this.txb_MaNCC.Location = new System.Drawing.Point(6, 26);
            this.txb_MaNCC.Name = "txb_MaNCC";
            this.txb_MaNCC.Size = new System.Drawing.Size(230, 22);
            this.txb_MaNCC.TabIndex = 0;
            // 
            // dgv_ThongTinNCC
            // 
            this.dgv_ThongTinNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongTinNCC.Location = new System.Drawing.Point(12, 237);
            this.dgv_ThongTinNCC.Name = "dgv_ThongTinNCC";
            this.dgv_ThongTinNCC.RowHeadersWidth = 51;
            this.dgv_ThongTinNCC.RowTemplate.Height = 24;
            this.dgv_ThongTinNCC.Size = new System.Drawing.Size(776, 201);
            this.dgv_ThongTinNCC.TabIndex = 17;
            // 
            // btn_GhiNhan
            // 
            this.btn_GhiNhan.Location = new System.Drawing.Point(528, 39);
            this.btn_GhiNhan.Name = "btn_GhiNhan";
            this.btn_GhiNhan.Size = new System.Drawing.Size(75, 47);
            this.btn_GhiNhan.TabIndex = 16;
            this.btn_GhiNhan.Text = "Ghi nhận";
            this.btn_GhiNhan.UseVisualStyleBackColor = true;
            this.btn_GhiNhan.Click += new System.EventHandler(this.btn_GhiNhan_Click);
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_ThongTinNCC);
            this.Controls.Add(this.panel1);
            this.Name = "NhaCungCap";
            this.Text = "NhaCungCap";
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinNCC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_SoDienThoai;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_DiaChi;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_TenNCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_MaNCC;
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.DataGridView dgv_ThongTinNCC;
        private System.Windows.Forms.Button btn_GhiNhan;
    }
}