
namespace AppQuanLyThuVien
{
    partial class ThongKeSachMuonTheoNgay
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
            this.dgv_SachMuonTheoNgay = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtm_NgayMuon = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SachMuonTheoNgay)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_SachMuonTheoNgay
            // 
            this.dgv_SachMuonTheoNgay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SachMuonTheoNgay.Location = new System.Drawing.Point(12, 143);
            this.dgv_SachMuonTheoNgay.Name = "dgv_SachMuonTheoNgay";
            this.dgv_SachMuonTheoNgay.RowHeadersWidth = 51;
            this.dgv_SachMuonTheoNgay.RowTemplate.Height = 24;
            this.dgv_SachMuonTheoNgay.Size = new System.Drawing.Size(776, 295);
            this.dgv_SachMuonTheoNgay.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 125);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG SÁCH MƯỢN THEO NGÀY";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtm_NgayMuon);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(247, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 64);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày Mượn";
            // 
            // dtm_NgayMuon
            // 
            this.dtm_NgayMuon.CustomFormat = "dd/MM/yyyy";
            this.dtm_NgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtm_NgayMuon.Location = new System.Drawing.Point(18, 30);
            this.dtm_NgayMuon.Name = "dtm_NgayMuon";
            this.dtm_NgayMuon.Size = new System.Drawing.Size(223, 22);
            this.dtm_NgayMuon.TabIndex = 1;
            this.dtm_NgayMuon.Value = new System.DateTime(2021, 4, 14, 22, 32, 54, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thống Kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThongKeSachMuonTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_SachMuonTheoNgay);
            this.Controls.Add(this.panel1);
            this.Name = "ThongKeSachMuonTheoNgay";
            this.Text = "ThongKeSachMuonTheoNgay";
            this.Load += new System.EventHandler(this.ThongKeSachMuonTheoNgay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SachMuonTheoNgay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_SachMuonTheoNgay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtm_NgayMuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}