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

namespace AppQuanLyThuVien
{
    public partial class ThongKeSachMuonTheoNgay : Form
    {
        SqlConnection connect = new SqlConnection(ConnectionString.str);
        public ThongKeSachMuonTheoNgay()
        {
            InitializeComponent();
        }

        private void ThongKeSachMuonTheoNgay_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var cmd = new SqlCommand("tksachmuontrongngay ", connect);
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = Convert.ToDateTime(dtm_NgayMuon.Value);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                data.Fill(table);
                dgv_SachMuonTheoNgay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_SachMuonTheoNgay.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("không có dữ liệu:" + ex.Message);
            }
        }
    }
}
