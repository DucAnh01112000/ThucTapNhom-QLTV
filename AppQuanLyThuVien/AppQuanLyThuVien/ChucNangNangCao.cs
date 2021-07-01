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
    public partial class ChucNangNangCao : Form
    {
        public ChucNangNangCao()
        {
            InitializeComponent();
        }

        private void quảnLýThủThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThuThu tt = new ThuThu();
            this.Hide();
            tt.ShowDialog();
            this.Show();
        }

        private void quảnLýNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            this.Hide();
            ncc.ShowDialog();
            this.Show();
        }
    }
}
