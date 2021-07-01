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
    public partial class MuonSach : Form
    {
        DataBaseThuVien da = new DataBaseThuVien();
        public MuonSach()
        {
            InitializeComponent();
        }
      
        

        private void MuonSach_Load(object sender, EventArgs e)
        {
            txb_MaDocGia1.Enabled = true;
            txb_TenDocGia.Enabled = false;
            dtm_NgaySinh.Enabled = false;
            txb_SoDienThoai.Enabled = false;
            rbtn_Nam.Enabled = false;
            rbtn_Nu.Enabled = false;
            txb_LoaiDocGia.Enabled = false;
            txb_MaDocGia2.Enabled = false;
            txb_SoPhieuMuonTra.Enabled = false;
            dtm_NgayLap.Enabled = false;
            dtm_NgayHenTra.Enabled = false;
            
            dtm_NgayTra.Enabled = false;
            txb_MaThuThu.Enabled = false;
            //dgv_ThongTinDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dgv_ThongTinDocGia.DataSource = da.DocGias.ToList();
            //dgv_ThongTinPhieuMuonTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dgv_ThongTinPhieuMuonTra.DataSource = da.PhieuMuonTras.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgv_ThongTinPhieuMuonTra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_ThongTinPhieuMuonTra.CurrentRow.Index;
            txb_SoPhieuMuonTra.Text = dgv_ThongTinPhieuMuonTra.Rows[i].Cells[0].Value.ToString();
            dtm_NgayLap.Value = (DateTime)dgv_ThongTinPhieuMuonTra.Rows[i].Cells[1].Value;
            dtm_NgayHenTra.Value = (DateTime)dgv_ThongTinPhieuMuonTra.Rows[i].Cells[2].Value;
            if (dgv_ThongTinPhieuMuonTra.Rows[i].Cells[3].Value != null)
            {
                dtm_NgayTra.Value = (DateTime)dgv_ThongTinPhieuMuonTra.Rows[i].Cells[3].Value;
            }
            else
            {
                dtm_NgayTra.Value = DateTime.Today; 
            }
            
            txb_MaDocGia2.Text = dgv_ThongTinPhieuMuonTra.Rows[i].Cells[4].Value.ToString();
            txb_MaThuThu.Text = dgv_ThongTinPhieuMuonTra.Rows[i].Cells[5].Value.ToString();

            var result = da.ChiTietMuons.SqlQuery("select *from ChiTietMuon Where soPMT = '" + txb_SoPhieuMuonTra.Text + "'").ToList();
            dgv_ChiTietMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_ChiTietMuon.DataSource = result;
        }

        private void dtm_NgayHenTra_ValueChanged(object sender, EventArgs e)
        {
            DateTime a;
            a = dtm_NgayLap.Value;
            DateTime b = dtm_NgayHenTra.Value;

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn muốn xóa Cuốn Sách ? ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(ConnectionString.str);
                con.Open();
                string tr = "DELETE FROM PhieuMuonTra WHERE soPMT = '" + txb_SoPhieuMuonTra.Text + "' ";
                SqlCommand cmd = new SqlCommand(tr, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                MuonSach_Load(1, e);
               
                con.Close();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            txb_MaDocGia2.Enabled = true;
            txb_SoPhieuMuonTra.Enabled = false;
            dtm_NgayLap.Enabled = true;
            dtm_NgayHenTra.Enabled = true;

            dtm_NgayTra.Enabled = true;
            txb_MaThuThu.Enabled = true;
            
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            if(txb_MaDocGia1.Text != "")
            {
                SqlConnection connect = new SqlConnection(ConnectionString.str);
                connect.Open();
                string tr = "Select * from DocGia Where maDG = '"+txb_MaDocGia1.Text+"'";
                string tr1 = "select * from PhieuMuonTra Where maDG = '" +txb_MaDocGia1.Text+"'";
                SqlCommand cmd = new SqlCommand(tr, connect);
                SqlDataReader dt = cmd.ExecuteReader();
               

                if (dt.Read() == true)
                {
                   // hiển thị đọc giả lên datagridview 
                    var result = da.DocGias.SqlQuery(tr).ToList();
                    dgv_ThongTinDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgv_ThongTinDocGia.DataSource = result;

                    int i;
                    i = dgv_ThongTinDocGia.CurrentRow.Index;
                    txb_MaDocGia1.Text = dgv_ThongTinDocGia.Rows[i].Cells[0].Value.ToString();
                    txb_TenDocGia.Text = dgv_ThongTinDocGia.Rows[i].Cells[1].Value.ToString();
                    if (dgv_ThongTinDocGia.Rows[i].Cells[2].Value.ToString() == "Nam")
                    {
                        rbtn_Nam.Checked = true;
                    }
                    else if (dgv_ThongTinDocGia.Rows[i].Cells[2].Value.ToString() == "Nữ")
                    {
                        rbtn_Nu.Checked = true;
                    }
                    dtm_NgaySinh.Value = (DateTime)dgv_ThongTinDocGia.Rows[i].Cells[3].Value;
                    txb_SoDienThoai.Text = dgv_ThongTinDocGia.Rows[i].Cells[5].Value.ToString();
                    txb_LoaiDocGia.Text = dgv_ThongTinDocGia.Rows[i].Cells[6].Value.ToString();


                    // hiện thị phiêu mượn trả
                    var result1 = da.PhieuMuonTras.SqlQuery(tr1).ToList();
                    dgv_ThongTinPhieuMuonTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgv_ThongTinPhieuMuonTra.DataSource = result1;

                    //int y;
                    //y = dgv_ThongTinPhieuMuonTra.CurrentRow.Index;
                    //string soPMT = dgv_ThongTinPhieuMuonTra.Rows[i].Cells[0].Value.ToString();





                }
                else
                    MessageBox.Show("Không có độc giả này");


            }
            else
            {
                MessageBox.Show("Chưa nhập thông tin độc giả");
            }
        }

        private void btn_MuonSach_Click(object sender, EventArgs e)
        {
            if (txb_MaDocGia1.Text == "")
            {
                MessageBox.Show("bạn chưa chọn độc giả nào");
            }
            else
            {
                LapPhieuMuonTra lp = new LapPhieuMuonTra();
                this.Hide();
                lp.temp = txb_MaDocGia1.Text;
                lp.ShowDialog();
                  
            }
        }
        public string MaDocGia()
        {
            return txb_MaDocGia1.Text;
        }

        private void btn_TraSach_Click(object sender, EventArgs e)
        {
            if (txb_MaDocGia1.Text == "")
            {
                MessageBox.Show("bạn chưa chọn độc giả nào");
            }
            else
            {
                if(txb_SoPhieuMuonTra.Text == "")
                {
                    MessageBox.Show("Độc giả chưa mượn sách");
                }
                else
                {
                    dtm_NgayTra.Enabled = true;
                }
                
                
            }
        }

        private void btn_GhiNhan_Click(object sender, EventArgs e)
        {
            txb_LoaiDocGia.Enabled = false;
            txb_MaDocGia2.Enabled = false;
            txb_SoPhieuMuonTra.Enabled = false;
            dtm_NgayLap.Enabled = false;
            dtm_NgayHenTra.Enabled = false;

            dtm_NgayTra.Enabled = false;
            txb_MaThuThu.Enabled = false;
            SqlConnection connect = new SqlConnection(ConnectionString.str);
            try
            {
                connect.Open();
                string tr = "UPDATE PhieuMuonTra " +
                "SET ngayLap = '" + dtm_NgayLap.Value.ToString() + "', ngayHTra = '" + dtm_NgayHenTra.Value.ToString() + "', ngayTra = '" + dtm_NgayTra.Value.ToString() + "', maDG = '" + txb_MaDocGia2.Text + "' , maTT =  '" + txb_MaThuThu.Text +
                "' WHERE soPMT ='" + txb_SoPhieuMuonTra.Text + "' ";
                SqlCommand cmd = new SqlCommand(tr, connect);
                int k = (int)cmd.ExecuteNonQuery();
                if (k > 0)
                {
                    //var result = from c in da.PhieuMuonTras select new { SoPhieuMuonTra = c.soPMT, NgayLap = c.ngayLap, NgayHenTra = c.ngayHTra, NgayTra = c.ngayTra, MaDocGia = c.maDG, MaThuThu = c.maTT };
                    //dgv_ThongTinPhieuMuonTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    //dgv_ThongTinPhieuMuonTra.DataSource = result.ToList();
                    var result1 = da.PhieuMuonTras.SqlQuery(tr).ToList();
                    dgv_ThongTinPhieuMuonTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgv_ThongTinPhieuMuonTra.DataSource = result1;

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

            //SqlConnection connect = new SqlConnection(ConnectionString.str);

            //try
            //{
            //    if (txb_SoPhieuMuonTra.Text != "")
            //    {
            //        connect.Open();
            //        string tr1 = "INSERT INTO PhieuMuonTra VALUES( '" + txb_SoPhieuMuonTra.Text + "', '" + dtm_NgayLap.Value.ToString() + "','" + dtm_NgayHenTra.Value.ToString() + "','" + dtm_NgayTra.Value.ToString() + "','" + txb_MaDocGia2.Text + "', N'" + txb_MaThuThu.Text + "')";

            //        string tr2 = "update ";
            //        SqlCommand command = new SqlCommand(tr1, connect);
            //        int kq = (int)command.ExecuteNonQuery();
            //        if (kq > 0)
            //        {
            //            MuonSach_Load(1, e);
            //            MessageBox.Show("Cập nhập thành công");
            //        }
            //        else
            //        {
            //            MessageBox.Show(" thất bại");
            //        }
            //        connect.Close();

            //    }
            //    else
            //    {
            //        MessageBox.Show("Chưa đủ dữ liệu");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi kết nối: " + ex.Message);
            //}
            //if (txb_MaDocGia2.Text == "")
            //{
            //    MessageBox.Show("bạn chưa chọn phiếu mượn trả nào");
            //}
            //else
            //{
            //    SqlConnection connect = new SqlConnection(ConnectionString.str);
            //    connect.Open();
            //    string tr = "UPDATE PhieuMuonTra SET soPMT = '"+txb_SoPhieuMuonTra.Text+", NgayLap = '"+dtm_NgayLap.Text+"'" +
            //        " NgayHTra = '"+dtm_NgayHenTra.Text+"', NgayTra = '"+dtm_NgayTra.Text+"', maTT ='"+txb_MaThuThu.Text+"' WHERE  maDG = '"+txb_MaDocGia2.Text+"' ;";
            //    SqlCommand cmd = new SqlCommand(tr, connect);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Ghi nhận thành công");
            //    MuonSach_Load(1, e);
            //    connect.Close();
            //}
        }
    }
}

