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
using System.ComponentModel.DataAnnotations;

namespace AppQuanLyThuVien
{
    public partial class Login : Form
    {
        DataBaseThuVien dt = new DataBaseThuVien();
       
        public Login()
        {
            InitializeComponent();
        }

        
        private void KiemTraDangNhap()
        {
            if (string.IsNullOrEmpty(txb_TenDangNhap.Text))
            {
                errorProvider.SetError(txb_TenDangNhap, "Nhập tên đăng nhập");
            }
            else
            {
                errorProvider.SetError(txb_TenDangNhap, "");
            }
            if (string.IsNullOrEmpty(txb_MatKhau.Text))
            {
                errorProvider.SetError(txb_MatKhau, "Nhập mật khẩu");
            }
            else
            {
                errorProvider.SetError(txb_MatKhau, "");
            }
            if(true)
            {
                try
                {
                    SqlConnection connect = new SqlConnection(ConnectionString.str);
                    SqlConnection connect1 = new SqlConnection(ConnectionString.str);
                    connect.Open();
                    connect1.Open();
                    string tr = "SELECT * FROM Account WHERE Users = '" + txb_TenDangNhap.Text + "' and  pass = '" + txb_MatKhau.Text + "' and Status = 1 ";
                    string tr1 = "SELECT * FROM Account WHERE Users = '" + txb_TenDangNhap.Text + "' and  pass = '" + txb_MatKhau.Text + "' and Status = 0";
                    var cmd = new SqlCommand(tr, connect);
                    var cmd1 = new SqlCommand(tr1, connect1);

                    SqlDataReader dt = cmd.ExecuteReader();
                    SqlDataReader dt1 = cmd1.ExecuteReader();
                    if (dt.Read() == true)
                    {
                        MessageBox.Show("Chào mừng Quản Trị Viên");
                        QuanLy ql = new QuanLy();
                        this.Hide();
                        ql.ShowDialog();
                        this.Show();

                    }
                    else if (dt1.Read() == true)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        Menu me = new Menu();
                        this.Hide();
                        me.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại");
                    }
                    connect.Close();
                    connect1.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối : " + ex.Message);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Menu m = new Menu();
            //this.Hide();
            //m.ShowDialog();
            //this.Show();
            KiemTraDangNhap();

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_DangNhap.PerformClick();
            }
         
        }
    }
}
