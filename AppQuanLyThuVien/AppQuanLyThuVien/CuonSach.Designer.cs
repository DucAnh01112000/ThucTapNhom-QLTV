
namespace AppQuanLyThuVien
{
    partial class CuonSach
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_GhiNhan = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmb_maTS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmb_TrangThai = new System.Windows.Forms.ComboBox();
            this.abc = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmb_tenTS = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txb_MaCuonSach = new System.Windows.Forms.Label();
            this.txb_maCS = new System.Windows.Forms.TextBox();
            this.dgv_ThongTinCuonSach = new System.Windows.Forms.DataGridView();
            this.errorProviderCS = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinCuonSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_GhiNhan);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btn_Xoa);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 236);
            this.panel1.TabIndex = 0;
            // 
            // btn_GhiNhan
            // 
            this.btn_GhiNhan.Location = new System.Drawing.Point(43, 159);
            this.btn_GhiNhan.Name = "btn_GhiNhan";
            this.btn_GhiNhan.Size = new System.Drawing.Size(75, 43);
            this.btn_GhiNhan.TabIndex = 10;
            this.btn_GhiNhan.Text = "Ghi nhận";
            this.btn_GhiNhan.UseVisualStyleBackColor = true;
            this.btn_GhiNhan.Click += new System.EventHandler(this.btn_GhiNhan_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cmb_maTS);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(387, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 53);
            this.panel5.TabIndex = 9;
            // 
            // cmb_maTS
            // 
            this.cmb_maTS.FormattingEnabled = true;
            this.cmb_maTS.Items.AddRange(new object[] {
            "0000000001",
            "0000000002",
            "0000000003",
            "0000000004",
            "0000000005",
            "0000000006",
            "0000000007",
            "0000000008",
            "0000000009",
            "0000000010"});
            this.cmb_maTS.Location = new System.Drawing.Point(0, 26);
            this.cmb_maTS.Name = "cmb_maTS";
            this.cmb_maTS.Size = new System.Drawing.Size(236, 24);
            this.cmb_maTS.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Tựa Sách";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(552, 159);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 43);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(387, 159);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 43);
            this.btn_Sua.TabIndex = 6;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(208, 157);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 43);
            this.btn_Them.TabIndex = 5;
            this.btn_Them.Text = "Thêm ";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmb_TrangThai);
            this.panel4.Controls.Add(this.abc);
            this.panel4.Location = new System.Drawing.Point(43, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 53);
            this.panel4.TabIndex = 2;
            // 
            // cmb_TrangThai
            // 
            this.cmb_TrangThai.FormattingEnabled = true;
            this.cmb_TrangThai.Items.AddRange(new object[] {
            "Tốt",
            "Không Tốt"});
            this.cmb_TrangThai.Location = new System.Drawing.Point(0, 26);
            this.cmb_TrangThai.Name = "cmb_TrangThai";
            this.cmb_TrangThai.Size = new System.Drawing.Size(236, 24);
            this.cmb_TrangThai.TabIndex = 3;
            // 
            // abc
            // 
            this.abc.AutoSize = true;
            this.abc.Location = new System.Drawing.Point(3, 6);
            this.abc.Name = "abc";
            this.abc.Size = new System.Drawing.Size(78, 17);
            this.abc.TabIndex = 1;
            this.abc.Text = "Trạng Thái";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmb_tenTS);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(387, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 53);
            this.panel3.TabIndex = 3;
            // 
            // cmb_tenTS
            // 
            this.cmb_tenTS.FormattingEnabled = true;
            this.cmb_tenTS.Items.AddRange(new object[] {
            "Tôi Thấy Hoa Vàng Trên Cỏ Xanh",
            "Vẫn Cứ Thích Em",
            "Yêu Em Từ Cái Nhìn Đầu Tiên",
            "Tắt Đèn",
            "Cô Gái Năm Ấy Chúng Ta Cùng Theo Đuổi",
            "Chàng Trai Năm Ấy",
            "Ngày Trôi Về Phía Cũ",
            "Chiêc Lá Cuối Cùng",
            "Chí Phèo",
            "Lão Hạc"});
            this.cmb_tenTS.Location = new System.Drawing.Point(0, 26);
            this.cmb_tenTS.Name = "cmb_tenTS";
            this.cmb_tenTS.Size = new System.Drawing.Size(236, 24);
            this.cmb_tenTS.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Tựa Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "THÔNG TIN CUỐN SÁCH";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txb_MaCuonSach);
            this.panel2.Controls.Add(this.txb_maCS);
            this.panel2.Location = new System.Drawing.Point(43, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 53);
            this.panel2.TabIndex = 1;
            // 
            // txb_MaCuonSach
            // 
            this.txb_MaCuonSach.AutoSize = true;
            this.txb_MaCuonSach.Location = new System.Drawing.Point(3, 6);
            this.txb_MaCuonSach.Name = "txb_MaCuonSach";
            this.txb_MaCuonSach.Size = new System.Drawing.Size(100, 17);
            this.txb_MaCuonSach.TabIndex = 1;
            this.txb_MaCuonSach.Text = "Mã Cuốn Sách";
            // 
            // txb_maCS
            // 
            this.txb_maCS.Location = new System.Drawing.Point(0, 26);
            this.txb_maCS.Name = "txb_maCS";
            this.txb_maCS.Size = new System.Drawing.Size(236, 22);
            this.txb_maCS.TabIndex = 0;
            this.txb_maCS.TextChanged += new System.EventHandler(this.txb_maCS_TextChanged);
            // 
            // dgv_ThongTinCuonSach
            // 
            this.dgv_ThongTinCuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongTinCuonSach.Location = new System.Drawing.Point(12, 232);
            this.dgv_ThongTinCuonSach.Name = "dgv_ThongTinCuonSach";
            this.dgv_ThongTinCuonSach.RowHeadersWidth = 51;
            this.dgv_ThongTinCuonSach.RowTemplate.Height = 24;
            this.dgv_ThongTinCuonSach.Size = new System.Drawing.Size(674, 240);
            this.dgv_ThongTinCuonSach.TabIndex = 1;
            this.dgv_ThongTinCuonSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ThongTinCuonSach_CellContentClick);
            // 
            // errorProviderCS
            // 
            this.errorProviderCS.ContainerControl = this;
            // 
            // CuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 484);
            this.Controls.Add(this.dgv_ThongTinCuonSach);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CuonSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CuonSach";
            this.Load += new System.EventHandler(this.CuonSach_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinCuonSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label abc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txb_MaCuonSach;
        private System.Windows.Forms.TextBox txb_maCS;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dgv_ThongTinCuonSach;
        private System.Windows.Forms.ComboBox cmb_TrangThai;
        private System.Windows.Forms.ComboBox cmb_tenTS;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmb_maTS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderCS;
        private System.Windows.Forms.Button btn_GhiNhan;
    }
}