using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQuanLyThuVien.KetNoi;

namespace AppQuanLyThuVien
{
    public partial class CuonSach : Form
    {
        DataBaseThuVien da = new DataBaseThuVien();
        public CuonSach()
        {
            InitializeComponent();
       
        }

        private void CuonSach_Load_1(object sender, EventArgs e)
        {
            txb_maCS.Enabled = false;
            cmb_TrangThai.Enabled = false;
            cmb_maTS.Enabled = false;
            cmb_tenTS.Enabled = false;

            var result = from c in da.CuonSaches select new {MaCuonSach = c.maCS, TrangThai = c.trangThai, MaTuaSach = c.maTS,  TenTuaSach = c.TuaSach.tenTS};
            dgv_ThongTinCuonSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_ThongTinCuonSach.DataSource = result.ToList();
        }

        private void dgv_ThongTinCuonSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_ThongTinCuonSach.CurrentRow.Index;
            txb_maCS.Text = dgv_ThongTinCuonSach.Rows[i].Cells[0].Value.ToString();
            cmb_TrangThai.Text = dgv_ThongTinCuonSach.Rows[i].Cells[1].Value.ToString();
            cmb_maTS.Text = dgv_ThongTinCuonSach.Rows[i].Cells[2].Value.ToString();
            cmb_tenTS.Text = dgv_ThongTinCuonSach.Rows[i].Cells[3].Value.ToString();
        }

       
        private void btn_Them_Click(object sender, EventArgs e)
        {
            txb_maCS.Enabled = true;
            cmb_TrangThai.Enabled = true;
            cmb_maTS.Enabled = true;
            cmb_tenTS.Enabled = true;
           
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            txb_maCS.Enabled = true;
            cmb_TrangThai.Enabled = true;
            cmb_maTS.Enabled = true;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            cmb_TrangThai.Enabled = true;
            cmb_maTS.Enabled = true;
            cmb_tenTS.Enabled = true;

           
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn muốn xóa Cuốn Sách ? ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(ConnectionString.str);
                con.Open();
                string tr = "DELETE FROM CuonSach WHERE maCS = '" + txb_maCS.Text + "' ";
                SqlCommand cmd = new SqlCommand(tr, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                var result = from c in da.CuonSaches select new { MaCuonSach = c.maCS, TrangThai = c.trangThai, MaTuaSach = c.maTS, TenTuaSach = c.TuaSach.tenTS };
                dgv_ThongTinCuonSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgv_ThongTinCuonSach.DataSource = result.ToList();

                con.Close();
            }
        }

        private void txb_maCS_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (int.TryParse(txb_maCS.Text, out i))
            {
                errorProviderCS.SetError(txb_maCS, "");
            } else
                errorProviderCS.SetError(txb_maCS, "Ma cuốn sách phải là số");
                        
        }

        private void btn_GhiNhan_Click(object sender, EventArgs e)
        {
            if(txb_maCS.Enabled == true)
            {
                SqlConnection connect = new SqlConnection(ConnectionString.str);
                try
                {
                    if (txb_maCS.Text != "")
                    {
                        connect.Open();
                        string tr1 = "INSERT INTO CuonSach VALUES( '" + txb_maCS.Text + "', N'" + cmb_TrangThai.Text + "', N'" + cmb_maTS.Text + "' )";
                        SqlCommand command = new SqlCommand(tr1, connect);
                        int kq = (int)command.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            //var result = from c in da.CuonSaches select new { MaCuonSach = c.maCS, TrangThai = c.trangThai, MaTuaSach = c.maTS, TenTuaSach = c.TuaSach.tenTS };
                            //dgv_ThongTinCuonSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                            //dgv_ThongTinCuonSach.DataSource = result.ToList();
                            CuonSach_Load_1(1, e);
                            MessageBox.Show("Thêm thành công");
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại");
                        }
                        connect.Close();

                    }
                    else
                    {
                        MessageBox.Show("Chưa nhập đủ dữ liệu");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
            }
            else
            {
                SqlConnection connect = new SqlConnection(ConnectionString.str);
                try
                {
                    connect.Open();

                    string tr = "UPDATE CuonSach " +
                         "SET trangThai = N'" + cmb_TrangThai.Text + "', maTS = '" + cmb_maTS.Text + "' WHERE maCS = '" + txb_maCS.Text + "'";

                    SqlCommand cmd = new SqlCommand(tr, connect);
                    int k = (int)cmd.ExecuteNonQuery();
                    if (k > 0)
                    {
                        CuonSach_Load_1(1, e);
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                        MessageBox.Show("Sửa thất bại");
                    connect.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("kết nối hỏng:" + ex.Message);
                }
            }
        }
    }
}
