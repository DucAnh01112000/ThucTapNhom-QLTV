
namespace AppQuanLyThuVien
{
    partial class ThemSachMuon
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
            this.txb_TienCoc = new System.Windows.Forms.TextBox();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dgv_ThemSachMuon = new System.Windows.Forms.DataGridView();
            this.btn_KetThuc = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.cmb_MaCuonSach = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThemSachMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(201, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM SÁCH MƯỢN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Cuốn Sách";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiền Cọc";
            // 
            // txb_TienCoc
            // 
            this.txb_TienCoc.Location = new System.Drawing.Point(164, 115);
            this.txb_TienCoc.Name = "txb_TienCoc";
            this.txb_TienCoc.Size = new System.Drawing.Size(277, 22);
            this.txb_TienCoc.TabIndex = 4;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(471, 102);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(78, 33);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(585, 102);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(78, 33);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dgv_ThemSachMuon
            // 
            this.dgv_ThemSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThemSachMuon.Location = new System.Drawing.Point(50, 159);
            this.dgv_ThemSachMuon.Name = "dgv_ThemSachMuon";
            this.dgv_ThemSachMuon.RowHeadersWidth = 51;
            this.dgv_ThemSachMuon.RowTemplate.Height = 24;
            this.dgv_ThemSachMuon.Size = new System.Drawing.Size(613, 206);
            this.dgv_ThemSachMuon.TabIndex = 7;
            // 
            // btn_KetThuc
            // 
            this.btn_KetThuc.Location = new System.Drawing.Point(576, 394);
            this.btn_KetThuc.Name = "btn_KetThuc";
            this.btn_KetThuc.Size = new System.Drawing.Size(87, 33);
            this.btn_KetThuc.TabIndex = 8;
            this.btn_KetThuc.Text = "Kết Thúc";
            this.btn_KetThuc.UseVisualStyleBackColor = true;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(471, 394);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(78, 33);
            this.btn_Huy.TabIndex = 9;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            // 
            // cmb_MaCuonSach
            // 
            this.cmb_MaCuonSach.FormattingEnabled = true;
            this.cmb_MaCuonSach.Location = new System.Drawing.Point(164, 70);
            this.cmb_MaCuonSach.Name = "cmb_MaCuonSach";
            this.cmb_MaCuonSach.Size = new System.Drawing.Size(277, 24);
            this.cmb_MaCuonSach.TabIndex = 10;
            this.cmb_MaCuonSach.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ThemSachMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 449);
            this.Controls.Add(this.cmb_MaCuonSach);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_KetThuc);
            this.Controls.Add(this.dgv_ThemSachMuon);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.txb_TienCoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemSachMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemSachMuon";
            this.Load += new System.EventHandler(this.ThemSachMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThemSachMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_TienCoc;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dgv_ThemSachMuon;
        private System.Windows.Forms.Button btn_KetThuc;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.ComboBox cmb_MaCuonSach;
    }
}