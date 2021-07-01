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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void tìmKiếmSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TimKiemSach tks = new TimKiemSach();
            this.Hide();
            tks.ShowDialog();
            this.Show();
        }

        private void tìmKiếmĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemDocGia tkdg = new TimKiemDocGia();
            this.Hide();
            tkdg.ShowDialog();
            this.Show();
        }

        private void xemSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TuaSach ts = new TuaSach();
            this.Hide();
            ts.ShowDialog();
            this.Show();
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuonSach ms = new MuonSach();
            this.Hide();
            ms.ShowDialog();
            this.Show();
        }

        private void cuốnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuonSach cs = new CuonSach();
            this.Hide();
            cs.ShowDialog();
            this.Show();
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocGia dg = new DocGia();
            this.Hide();
            dg.ShowDialog();
            this.Show();
        }

        private void đangMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeDocGiaDangMuon dm = new ThongKeDocGiaDangMuon();
            this.Hide();
            dm.ShowDialog();
            this.Show();
        }

        private void quáHạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeDocGiaQuaHan qh = new ThongKeDocGiaQuaHan();
            this.Hide();
            qh.ShowDialog();
            this.Show();
        }

        private void sáchĐangMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeSachDangMuon sdm = new ThongKeSachDangMuon();
            this.Hide();
            sdm.ShowDialog();
            this.Show();
        }

        private void sáchMượnTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeSachMuonTheoNgay mtn = new ThongKeSachMuonTheoNgay();
            this.Hide();
            mtn.ShowDialog();
            this.Show();
        }
    }
}
