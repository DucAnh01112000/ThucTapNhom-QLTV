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
    public partial class ThuThu : Form
    {
        DataBaseThuVien da = new DataBaseThuVien();   
        public ThuThu()
        {
            InitializeComponent();
        }

        private void dgv_ThongTinThuThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_ThongTinThuThu.CurrentRow.Index;
            txb_MaThuThu.Text = dgv_ThongTinThuThu.Rows[i].Cells[0].Value.ToString();
            txb_TenThuThu.Text = dgv_ThongTinThuThu.Rows[i].Cells[1].Value.ToString();

            if (dgv_ThongTinThuThu.Rows[i].Cells[2].Value.ToString() == "Nam")
                rbtn_Nam.Checked = true;
            else
                rbtn_Nu.Checked = true;

            dtm_NgaySinh.Value = (DateTime)dgv_ThongTinThuThu.Rows[i].Cells[3].Value;
            txb_DiaChi.Text = dgv_ThongTinThuThu.Rows[i].Cells[4].Value.ToString();
            txb_SoDienThoai.Text = dgv_ThongTinThuThu.Rows[i].Cells[5].Value.ToString();
            if(dgv_ThongTinThuThu.Rows[i].Cells[6].Value == null)
            {
                txb_CapBac.Text = "";
            }
            else
                txb_CapBac.Text = dgv_ThongTinThuThu.Rows[i].Cells[6].Value.ToString();
        }

        private void ThuThu_Load(object sender, EventArgs e)
        {
            txb_MaThuThu.Enabled = false;
            txb_TenThuThu.Enabled = false;
            rbtn_Nam.Enabled = false;
            rbtn_Nu.Enabled = false;
            dtm_NgaySinh.Enabled = false;
            txb_DiaChi.Enabled = false;
            txb_SoDienThoai.Enabled = false;
            txb_CapBac.Enabled = false;
            var result = from c in da.ThuThus select new { MaThuThu = c.maTT, TenThuThu = c.tenTT, GioiTinh = c.gioiTinh, NgaySinh = c.ngaySinh, DiaChi = c.diaChi, SDT = c.SDT, CapBac = c.capBac };
            dgv_ThongTinThuThu.DataSource = result.ToList();
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            txb_MaThuThu.Enabled = true;
            txb_TenThuThu.Enabled = true;
            rbtn_Nam.Enabled = true;
            rbtn_Nu.Enabled = true;
            dtm_NgaySinh.Enabled = true;
            txb_DiaChi.Enabled = true;
            txb_SoDienThoai.Enabled = true;
            txb_CapBac.Enabled = true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txb_MaThuThu.Enabled = true;
            txb_TenThuThu.Enabled = true;
            rbtn_Nam.Enabled = true;
            rbtn_Nu.Enabled = true;
            dtm_NgaySinh.Enabled = true;
            txb_DiaChi.Enabled = true;
            txb_SoDienThoai.Enabled = true;
            txb_CapBac.Enabled = true;

            txb_MaThuThu.Clear();
            txb_TenThuThu.Clear();
            txb_DiaChi.Clear();
            txb_SoDienThoai.Clear();
            txb_CapBac.Clear();

           
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            txb_MaThuThu.Enabled = false;
            txb_TenThuThu.Enabled = true;
            rbtn_Nam.Enabled = true;
            rbtn_Nu.Enabled = true;
            dtm_NgaySinh.Enabled = true;
            txb_DiaChi.Enabled = true;
            txb_SoDienThoai.Enabled = true;
            txb_CapBac.Enabled = true;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn muốn xóa Thủ Thư ? ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(ConnectionString.str);
                con.Open();
                string tr = "DELETE FROM ThuThu WHERE maTT = '" + txb_MaThuThu.Text + "' ";
                SqlCommand cmd = new SqlCommand(tr, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                ThuThu_Load(1, e);
                //dgv_ThongTinThuThu.DataSource = da.ThuThus.ToList();

                con.Close();
            }
        }

        private void btn_GhiNhan_Click(object sender, EventArgs e)
        {
            if(txb_MaThuThu.Enabled == true)
            {
                SqlConnection connect = new SqlConnection(ConnectionString.str);
                string tr1;

                try
                {
                    if (txb_MaThuThu.Text != "")
                    {
                        connect.Open();
                        if (rbtn_Nam.Text != null)
                        {
                            tr1 = "INSERT INTO ThuThu VALUES( '" + txb_MaThuThu.Text + "', N'" + txb_TenThuThu.Text + "', N'" + rbtn_Nam.Text + "','" + dtm_NgaySinh.Text + "', N'" + txb_DiaChi.Text + "', '" + txb_SoDienThoai.Text + "', N'" + txb_CapBac.Text + "')";
                        }
                        else
                            tr1 = "INSERT INTO ThuThu VALUES( '" + txb_MaThuThu.Text + "', N'" + txb_TenThuThu.Text + "', N'" + rbtn_Nu.Text + "','" + dtm_NgaySinh.Text + "', N'" + txb_DiaChi.Text + "', '" + txb_SoDienThoai.Text + "', N'" + txb_CapBac.Text + "')";

                        SqlCommand command = new SqlCommand(tr1, connect);
                        int kq = (int)command.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            ThuThu_Load(1, e);
                            //dgv_ThongTinThuThu.DataSource = da.ThuThus.ToList();
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
                connect.Close();
            }
            else
            {
                string tr;
                SqlConnection connect = new SqlConnection(ConnectionString.str);

                try
                {
                    connect.Open();
                    if (rbtn_Nam.Text != null)
                    {
                        tr = "UPDATE ThuThu " +
                            "SET tenTT = N'" + txb_TenThuThu.Text + "', gioiTinh = N'Nam', ngaySinh = '" + dtm_NgaySinh.Text + "', diaChi = N'" + txb_DiaChi.Text + "', SDT = '" + txb_SoDienThoai.Text + "', capBac = N'" + txb_CapBac.Text + "' WHERE maTT = '" + txb_MaThuThu.Text + "'";
                    }
                    else
                    {
                        tr = "UPDATE ThuTHu " +
                            "SET tenTT = N'" + txb_TenThuThu.Text + "', gioiTinh = N'Nữ', ngaySinh = '" + dtm_NgaySinh.Text + "', diaChi = N'" + txb_DiaChi.Text + "', SDT = '" + txb_SoDienThoai.Text + "', capBac = N'" + txb_CapBac.Text + "' WHERE maTT = '" + txb_MaThuThu.Text + "'";
                    }

                    SqlCommand cmd = new SqlCommand(tr, connect);
                    int k = (int)cmd.ExecuteNonQuery();
                    if (k > 0)
                    {
                        ThuThu_Load(1, e);
                        //dgv_ThongTinThuThu.DataSource = da.ThuThus.ToList();
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
                connect.Close();
            }
        }
    }
}
