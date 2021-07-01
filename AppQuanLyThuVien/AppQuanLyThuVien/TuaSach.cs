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
    public partial class TuaSach : Form
    {
        DataBaseThuVien a = new DataBaseThuVien();
        
        public TuaSach()
        {
            InitializeComponent();
        }
        private void TuaSach_Load(object sender, EventArgs e)
        {
            txb_maTS.Enabled = false;
            txb_tenTS.Enabled = false;
            txb_namXB.Enabled = false;
            txb_giaSach.Enabled = false;
            txb_viTri.Enabled = false;
            txb_ngonNC.Enabled = false;
        
            txb_tomTatND.Enabled = false;
            cmb_maNXB.Enabled = false;

            dgv_TuaSach.DataSource = a.TuaSaches.ToList();
            var result = from c in a.TuaSaches select new { MaTuaSach = c.maTS, TenTuaSach = c.tenTS, NamXB = c.namXB, GiaSach = c.Gia, ViTri = c.viTri, NgonNgu = c.nnChinh, TomTat = c.noiDungTT, MaNXB = c.maNXB };
            dgv_TuaSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_TuaSach.DataSource = result.ToList();
        }

        private void dgv_TuaSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_TuaSach.CurrentRow.Index;
            txb_maTS.Text = dgv_TuaSach.Rows[i].Cells[0].Value.ToString();
            txb_tenTS.Text = dgv_TuaSach.Rows[i].Cells[1].Value.ToString();
            txb_namXB.Text = dgv_TuaSach.Rows[i].Cells[2].Value.ToString();
            txb_giaSach.Text = dgv_TuaSach.Rows[i].Cells[3].Value.ToString();
            txb_viTri.Text = dgv_TuaSach.Rows[i].Cells[4].Value.ToString();
            txb_ngonNC.Text = dgv_TuaSach.Rows[i].Cells[6].Value.ToString();
            cmb_maNXB.Text = dgv_TuaSach.Rows[i].Cells[7].Value.ToString();

        }

        public bool KiemTraTuaSach()
        {
            SqlConnection con = new SqlConnection(ConnectionString.str);
            con.Open();
            string tr = "SELECT maTS FROM TuaSach WHERE maTS = '"+txb_maTS+"'";
            SqlCommand cmd = new SqlCommand(tr, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txb_maTS.Enabled = true;
            txb_tenTS.Enabled = true;
            txb_namXB.Enabled = true;
            txb_giaSach.Enabled = true;
            txb_viTri.Enabled = true;
            txb_ngonNC.Enabled = true;
            txb_tomTatND.Enabled = true;
            cmb_maNXB.Enabled = true;


            txb_maTS.Clear();
            txb_tenTS.Clear();
            txb_namXB.Clear();
            txb_giaSach.Clear();
            txb_viTri.Clear();
            txb_ngonNC.Clear();
            txb_tomTatND.Clear();
            cmb_maNXB.Items.Clear();
           
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn muốn xóa Tựa Sách ? ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(thongbao == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(ConnectionString.str);
                con.Open();
                string tr = "DELETE FROM TuaSach WHERE maTS = '"+txb_maTS.Text+"' ";
                SqlCommand cmd = new SqlCommand(tr, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                dgv_TuaSach.DataSource = a.TuaSaches.ToList();

                con.Close();
            }
           
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            txb_maTS.Enabled = false;
            txb_tenTS.Enabled = true;
            txb_namXB.Enabled = true;
            txb_giaSach.Enabled = true;
            txb_viTri.Enabled = true;
            txb_ngonNC.Enabled = true;

            txb_tomTatND.Enabled = true;
            cmb_maNXB.Enabled = true;
           
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if(txb_maTS.Enabled == true)
            {
                SqlConnection connect = new SqlConnection(ConnectionString.str);

                try
                {
                    if (txb_maTS.Text != "")
                    {
                        connect.Open();
                        string tr1 = "INSERT INTO TuaSach VALUES( '" + txb_maTS.Text + "', N'" + txb_tenTS.Text + "','" + txb_namXB.Text + "','" + txb_giaSach.Text + "','" + txb_viTri.Text + "', N'" + txb_tomTatND.Text + "', N'" + txb_ngonNC.Text + "','" + cmb_maNXB.Text + "')";
                        SqlCommand command = new SqlCommand(tr1, connect);
                        int kq = (int)command.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            //dgv_TuaSach.DataSource = a.TuaSaches.ToList();
                            TuaSach_Load(1, e);
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
                    string tr = "UPDATE TuaSach " +
                    "SET maTS ='" + txb_maTS.Text + "', tenTS = N'" + txb_tenTS.Text + "', namXB = '" + txb_namXB.Text + "', Gia = '" + txb_giaSach.Text + "',viTri = '" + txb_viTri.Text + "' , noiDungTT =  N'" + txb_tomTatND.Text + "' , nnChinh = N'" + txb_ngonNC.Text + "',maNXB = '" + cmb_maNXB.Text + "'" +
                    " WHERE maTS ='" + txb_maTS.Text + "' ";
                    SqlCommand cmd = new SqlCommand(tr, connect);
                    int k = (int)cmd.ExecuteNonQuery();
                    if (k > 0)
                    {
                        //cmd.ExecuteNonQuery();
                        //dgv_TuaSach.DataSource = a.TuaSaches.ToList();
                        TuaSach_Load(1, e);
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
