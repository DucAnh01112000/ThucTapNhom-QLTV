using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyThuVien
{
    public partial class LapPhieuMuonTra : Form
    {
        
        public LapPhieuMuonTra()
        {
            InitializeComponent();
        }

        public string temp;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txb_MaPhieuMuonTra.Text != "" && txb_MaThuThu.Text != "")
            {
                ThemSachMuon ctp = new ThemSachMuon();
                this.Hide();
                ctp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            MuonSach ms = new MuonSach();
            this.Hide();
            ms.Show();
        }

        private void LapPhieuMuonTra_Load(object sender, EventArgs e)
        {
            txb_MaDocGia.Text = temp;
        }
    }
}
