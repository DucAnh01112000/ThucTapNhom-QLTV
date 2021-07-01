using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AppQuanLyThuVien.KetNoi;

namespace AppQuanLyThuVien
{
    public partial class ThemSachMuon : Form
    {
        DataBaseThuVien da = new DataBaseThuVien();
        public ThemSachMuon()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void LoadCombobox()
        {
            //SqlConnection con = new  SqlConnection(ConnectionString.str);
            //var cmd = new SqlCommand("select maCS from CuonSach", con);
            //var dr = cmd.ExecuteReader();
            //var dt = new DataTable();
            //dt.Load(dr);
            //cmb_MaCuonSach.DisplayMember = "maCS";
            //cmb_MaCuonSach.DataSource = dt;
        }

        private void ThemSachMuon_Load(object sender, EventArgs e)
        {
            var result = da.CuonSaches.SqlQuery("select maCS from CuonSach").ToList();
            cmb_MaCuonSach.DataSource = result;
        }
    }
}
