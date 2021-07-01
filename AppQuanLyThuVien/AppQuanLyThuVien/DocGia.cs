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
    public partial class DocGia : Form
    {
        DataBaseThuVien da = new DataBaseThuVien();
        public DocGia()
        {
            InitializeComponent();
        }

     
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_ThongTinDocGia.CurrentRow.Index;
            txb_MaDocGia.Text = dgv_ThongTinDocGia.Rows[i].Cells[0].Value.ToString();
            txb_TenDocGia.Text = dgv_ThongTinDocGia.Rows[i].Cells[1].Value.ToString();
            if (dgv_ThongTinDocGia.Rows[i].Cells[2].Value.ToString() == "Nam")
            {
                rbtn_Nam.Checked = true;
            }
            else
                rbtn_Nu.Checked = true;

            dtm_NgaySinh.Value = (DateTime)dgv_ThongTinDocGia.Rows[i].Cells[3].Value;
            txb_DiaChi.Text = dgv_ThongTinDocGia.Rows[i].Cells[4].Value.ToString();
            txb_SoDienThoai.Text = dgv_ThongTinDocGia.Rows[i].Cells[5].Value.ToString();
            txb_LoaiDocGia.Text = dgv_ThongTinDocGia.Rows[i].Cells[6].Value.ToString();


        }
        private void DocGia_Load(object sender, EventArgs e)
        {
            txb_MaDocGia.Enabled = false;
            txb_TenDocGia.Enabled = false;
            rbtn_Nam.Enabled = false;
            rbtn_Nu.Enabled = false;
            dtm_NgaySinh.Enabled = false;
            txb_DiaChi.Enabled = false;
            txb_SoDienThoai.Enabled = false;
            txb_LoaiDocGia.Enabled = false;

            var result = from c in da.DocGias select new { MaDocGia = c.maDG, TenDocGia = c.tenDG, GioiTinh = c.gioiTinh, NgaySinh = c.ngaySinh, DiaChi = c.diaChi, SDT = c.SDT, LoaiDocGia = c.loaiDG };
            dgv_ThongTinDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_ThongTinDocGia.DataSource = result.ToList();

            
        }

      
        private void btn_Xem_Click(object sender, EventArgs e)
        {
            txb_MaDocGia.Enabled = true;
            txb_TenDocGia.Enabled = true;
            rbtn_Nam.Enabled = true;
            rbtn_Nu.Enabled = true;
            dtm_NgaySinh.Enabled = true;
            txb_DiaChi.Enabled = true;
            txb_SoDienThoai.Enabled = true;
            txb_LoaiDocGia.Enabled = true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txb_MaDocGia.Enabled = true;
            txb_TenDocGia.Enabled = true;
            rbtn_Nam.Enabled = true;
            rbtn_Nu.Enabled = true;
            dtm_NgaySinh.Enabled = true;
            txb_DiaChi.Enabled = true;
            txb_SoDienThoai.Enabled = true;
            txb_LoaiDocGia.Enabled = true;

            txb_MaDocGia.Clear();
            txb_TenDocGia.Clear();
            txb_DiaChi.Clear();
            txb_SoDienThoai.Clear();
            txb_LoaiDocGia.Clear();

            
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            txb_MaDocGia.Enabled = false;
            txb_TenDocGia.Enabled = true;
            rbtn_Nam.Enabled = true;
            rbtn_Nu.Enabled = true;
            dtm_NgaySinh.Enabled = true;
            txb_DiaChi.Enabled = true;
            txb_SoDienThoai.Enabled = true;
            txb_LoaiDocGia.Enabled = true;
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn muốn Xóa Độc Giả ? ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(ConnectionString.str);
                con.Open();
                string tr = "DELETE FROM DocGia WHERE maDG = '" + txb_MaDocGia.Text + "' ";
                SqlCommand cmd = new SqlCommand(tr, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                DocGia_Load(1 ,e);

                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txb_MaDocGia.Enabled == true)
            {
                SqlConnection connect = new SqlConnection(ConnectionString.str);
                string tr1;

                try
                {
                    if (txb_MaDocGia.Text != "")
                    {
                        connect.Open();
                        if (rbtn_Nam.Text != null)
                        {
                            tr1 = "INSERT INTO DocGia VALUES( '" + txb_MaDocGia.Text + "', N'" + txb_TenDocGia.Text + "', N'" + rbtn_Nam.Text + "','" + dtm_NgaySinh.Text + "', N'" + txb_DiaChi.Text + "', '" + txb_SoDienThoai.Text + "', N'" + txb_LoaiDocGia.Text + "')";
                        }
                        else
                            tr1 = "INSERT INTO DocGia VALUES( '" + txb_MaDocGia.Text + "', N'" + txb_TenDocGia.Text + "', N'" + rbtn_Nu.Text + "','" + dtm_NgaySinh.Text + "', N'" + txb_DiaChi.Text + "', '" + txb_SoDienThoai.Text + "', N'" + txb_LoaiDocGia.Text + "')";

                        SqlCommand command = new SqlCommand(tr1, connect);
                        int kq = (int)command.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            //dgv_ThongTinDocGia.DataSource = da.DocGias.ToList();
                            DocGia_Load(1, e);
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
                        tr = "UPDATE DocGia " +
                            "SET tenDG = N'" + txb_TenDocGia.Text + "', gioiTinh = N'Nam', ngaySinh = '" + dtm_NgaySinh.Text + "', diaChi = N'" + txb_DiaChi.Text + "', SDT = '" + txb_SoDienThoai.Text + "', loaiDG = N'" + txb_LoaiDocGia.Text + "' WHERE maDG = '" + txb_MaDocGia.Text + "'";
                    }
                    else
                    {
                        tr = "UPDATE DocGia " +
                            "SET tenDG = N'" + txb_TenDocGia.Text + "', gioiTinh = N'Nữ', ngaySinh = '" + dtm_NgaySinh.Text + "', diaChi = N'" + txb_DiaChi.Text + "', SDT = '" + txb_SoDienThoai.Text + "', loaiDG = N'" + txb_LoaiDocGia.Text + "' WHERE maDG = '" + txb_MaDocGia.Text + "'";
                    }

                    SqlCommand cmd = new SqlCommand(tr, connect);
                    int k = (int)cmd.ExecuteNonQuery();
                    if (k > 0)
                    {
                        cmd.ExecuteNonQuery();
                        DocGia_Load(1, e);
                        //dgv_ThongTinDocGia.DataSource = da.DocGias.ToList();
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
