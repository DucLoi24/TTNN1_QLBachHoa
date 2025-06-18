using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTNN1_QLBachHoa.Services;

namespace TTNN1_QLBachHoa
{
    public partial class Login : Form
    {
        private readonly NhanVienService _nvService = new NhanVienService();

        public Login()
        {
            InitializeComponent();
            LoadNhanVien();
            cbNhanVien.SelectedIndexChanged += cbNhanVien_SelectedIndexChanged;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.Enabled = false;
        }

        private void LoadNhanVien()
        {
            var list = _nvService.GetAll();
            cbNhanVien.DataSource = list;
            cbNhanVien.DisplayMember = "MaNV";
            cbNhanVien.ValueMember = "MaNV";
            cbNhanVien.SelectedIndex = -1;
        }

        private void cbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            var maNV = cbNhanVien.SelectedValue?.ToString();
            if (maNV == "ADMIN")
            {
                txtMatKhau.Enabled = true;
            }
            else
            {
                txtMatKhau.Enabled = false;
                txtMatKhau.Text = "";
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var maNV = cbNhanVien.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (maNV == "ADMIN")
            {
                if (txtMatKhau.Text != "1234")
                {
                    MessageBox.Show("Mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Đăng nhập admin
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.FormClosed += (s, args) => this.Close(); // Đóng Login khi AdminMenu đóng
                adminMenu.Show();
                this.Hide();
            }
            else
            {
                // Đăng nhập nhân viên thường
                var staffMenu = new StaffMenu(maNV);
                staffMenu.FormClosed += (s, args) => this.Close(); // Đóng Login khi StaffMenu đóng
                staffMenu.Show();
                this.Hide();
            }
        }
    }
}
