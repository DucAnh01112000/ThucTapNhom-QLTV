
namespace AppQuanLyThuVien
{
    partial class LapPhieuMuonTra
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_MaPhieuMuonTra = new System.Windows.Forms.TextBox();
            this.txb_MaThuThu = new System.Windows.Forms.TextBox();
            this.txb_MaDocGia = new System.Windows.Forms.TextBox();
            this.dtm_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.dtm_NgayHenTra = new System.Windows.Forms.DateTimePicker();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_TiepTuc = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phiếu Mượn Trả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Độc Giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Lập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Hẹn Trả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Thủ Thư";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txb_MaPhieuMuonTra
            // 
            this.txb_MaPhieuMuonTra.Location = new System.Drawing.Point(213, 94);
            this.txb_MaPhieuMuonTra.Name = "txb_MaPhieuMuonTra";
            this.txb_MaPhieuMuonTra.Size = new System.Drawing.Size(279, 22);
            this.txb_MaPhieuMuonTra.TabIndex = 5;
            // 
            // txb_MaThuThu
            // 
            this.txb_MaThuThu.Location = new System.Drawing.Point(213, 301);
            this.txb_MaThuThu.Name = "txb_MaThuThu";
            this.txb_MaThuThu.Size = new System.Drawing.Size(279, 22);
            this.txb_MaThuThu.TabIndex = 6;
            // 
            // txb_MaDocGia
            // 
            this.txb_MaDocGia.Location = new System.Drawing.Point(213, 147);
            this.txb_MaDocGia.Name = "txb_MaDocGia";
            this.txb_MaDocGia.Size = new System.Drawing.Size(279, 22);
            this.txb_MaDocGia.TabIndex = 7;
            // 
            // dtm_NgayLap
            // 
            this.dtm_NgayLap.Location = new System.Drawing.Point(213, 193);
            this.dtm_NgayLap.Name = "dtm_NgayLap";
            this.dtm_NgayLap.Size = new System.Drawing.Size(279, 22);
            this.dtm_NgayLap.TabIndex = 8;
            // 
            // dtm_NgayHenTra
            // 
            this.dtm_NgayHenTra.Location = new System.Drawing.Point(213, 245);
            this.dtm_NgayHenTra.Name = "dtm_NgayHenTra";
            this.dtm_NgayHenTra.Size = new System.Drawing.Size(279, 22);
            this.dtm_NgayHenTra.TabIndex = 9;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(275, 367);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(98, 34);
            this.btn_Thoat.TabIndex = 10;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_TiepTuc
            // 
            this.btn_TiepTuc.Location = new System.Drawing.Point(394, 367);
            this.btn_TiepTuc.Name = "btn_TiepTuc";
            this.btn_TiepTuc.Size = new System.Drawing.Size(98, 34);
            this.btn_TiepTuc.TabIndex = 11;
            this.btn_TiepTuc.Text = "Tiếp Tục";
            this.btn_TiepTuc.UseVisualStyleBackColor = true;
            this.btn_TiepTuc.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(130, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "LẬP PHIẾU MƯỢN TRẢ";
            // 
            // LapPhieuMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 444);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_TiepTuc);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.dtm_NgayHenTra);
            this.Controls.Add(this.dtm_NgayLap);
            this.Controls.Add(this.txb_MaDocGia);
            this.Controls.Add(this.txb_MaThuThu);
            this.Controls.Add(this.txb_MaPhieuMuonTra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LapPhieuMuonTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LapPhieuMuonTra";
            this.Load += new System.EventHandler(this.LapPhieuMuonTra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_MaPhieuMuonTra;
        private System.Windows.Forms.TextBox txb_MaThuThu;
        private System.Windows.Forms.TextBox txb_MaDocGia;
        private System.Windows.Forms.DateTimePicker dtm_NgayLap;
        private System.Windows.Forms.DateTimePicker dtm_NgayHenTra;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_TiepTuc;
        private System.Windows.Forms.Label label6;
    }
}