using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQuanLyThuVien.KetNoi;
using System.Data.SqlClient;

namespace AppQuanLyThuVien
{
    public partial class NhaCungCap : Form
    {
        DataBaseThuVien db = new DataBaseThuVien();
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            txb_MaNCC.Enabled = false;
            txb_TenNCC.Enabled = false;
            txb_DiaChi.Enabled = false;
            txb_SoDienThoai.Enabled = false;
            txb_Email.Enabled = false;
            var a = from c in db.NCCs select new { MaNhaCC = c.maNCC, TenNCC = c.tenNCC, DiaChi = c.diaChi, SDT = c.SDT, Email = c.email };
            dgv_ThongTinNCC.DataSource = a.ToList();
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            txb_MaNCC.Enabled = true;
            txb_TenNCC.Enabled = true;
            txb_DiaChi.Enabled = true;
            txb_SoDienThoai.Enabled = true;
            txb_Email.Enabled = true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txb_MaNCC.Enabled = true;
            txb_TenNCC.Enabled = true;
            txb_DiaChi.Enabled = true;
            txb_SoDienThoai.Enabled = true;
            txb_Email.Enabled = true;

            txb_MaNCC.Clear();
            txb_TenNCC.Clear();
            txb_DiaChi.Clear();
            txb_SoDienThoai.Clear();
            txb_Email.Clear();

           
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            txb_MaNCC.Enabled = false;
            txb_TenNCC.Enabled = true;
            txb_DiaChi.Enabled = true;
            txb_SoDienThoai.Enabled = true;
            txb_Email.Enabled = true;

         
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa Nhà cung cấp ? ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(thongbao == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(ConnectionString.str);
                con.Open();
                string tr = "DELETE FROM NCC WHERE maNCC = '" + txb_MaNCC.Text + "'";
                SqlCommand command = new SqlCommand(tr, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                NhaCungCap_Load(1, e);
                con.Close();
            }
        }

        private void btn_GhiNhan_Click(object sender, EventArgs e)
        {
            if(txb_MaNCC.Enabled == true)
            {
                SqlConnection connect = new SqlConnection(ConnectionString.str);
                connect.Open();
                string tr1;
                try
                {
                    if (txb_MaNCC.Text != "")
                    {

                        tr1 = "INSERT INTO NCC VALUES('" + txb_MaNCC.Text + "',N'" + txb_TenNCC.Text + "', N'" + txb_DiaChi.Text + "', N'" + txb_SoDienThoai.Text + "', N'" + txb_Email.Text + "')";
                        SqlCommand command = new SqlCommand(tr1, connect);
                        int kq = (int)command.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            NhaCungCap_Load(1, e);
                            MessageBox.Show("Thêm thành công");
                        }
                        else
                            MessageBox.Show("Thêm thất bại");
                    }
                    else
                        MessageBox.Show("Chưa nhập đủ dữ liệu");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
                connect.Close();
            }
            else
            {
                string tr;
                SqlConnection connect = new SqlConnection(ConnectionString.str);
                connect.Open();
                try
                {
                    tr = "UPDATE NCC " +
                        "SET tenNCC = N'" + txb_TenNCC.Text + "',diaChi =  N'" + txb_DiaChi.Text + "', SDT = '" + txb_SoDienThoai.Text + "', email = N'" + txb_Email.Text + "'";
                    SqlCommand command = new SqlCommand(tr, connect);
                    int k = (int)command.ExecuteNonQuery();
                    if (k > 0)
                    {
                        NhaCungCap_Load(1, e);
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                        MessageBox.Show("Sửa thất bại");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối: " + ex.Message);
                }
                connect.Close();
            }
        }
    }
}
