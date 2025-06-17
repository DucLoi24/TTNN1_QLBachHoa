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

namespace TTNN1_QLBachHoa.Forms
{
    public partial class FormQuanLyKhachHang : Form
    {
        private readonly KhachHangService _service = new KhachHangService();
        private bool _isAdding = false;

        public FormQuanLyKhachHang()
        {
            InitializeComponent();
            LoadData();
            SetInputState(false);
        }

        // Load danh sách khách hàng lên DataGridView
        private void LoadData(string keyword = "")
        {
            var data = string.IsNullOrWhiteSpace(keyword)
                ? _service.GetAll()
                : _service.GetAll().Where(kh =>
                    (kh.TenKH != null && kh.TenKH.ToLower().Contains(keyword.ToLower())) ||
                    (kh.SDT != null && kh.SDT.Contains(keyword))
                ).ToList();
            dgvKhachHang.DataSource = data;
            dgvKhachHang.ClearSelection();
            ClearInput();
            SetInputState(false);
        }

        // Xóa nội dung các trường nhập liệu
        private void ClearInput()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtDiemTichLuy.Text = "";
            txtMaKH.Enabled = false;
        }

        // Bật/tắt trạng thái nhập liệu
        private void SetInputState(bool enable)
        {
            txtTenKH.Enabled = enable;
            txtSDT.Enabled = enable;
            txtDiaChi.Enabled = enable;
            txtEmail.Enabled = enable;
            btnLuu.Enabled = enable;
        }

        // Khi click "Thêm mới"
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            ClearInput();
            SetInputState(true);
            _isAdding = true;
            txtTenKH.Focus();
        }

        // Khi click "Lưu"
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsValidPhone(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_isAdding)
            {
                // Sinh mã khách hàng tự động (ví dụ: KH001, KH002,...)
                string newMaKH = GenerateMaKH();
                var kh = new KHACH_HANG
                {
                    MaKH = newMaKH,
                    TenKH = txtTenKH.Text,
                    SDT = txtSDT.Text,
                    DiaChi = txtDiaChi.Text,
                    Email = txtEmail.Text,
                    DiemTichLuy = 0
                };
                try
                {
                    _service.Add(kh);
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtMaKH.Text))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var kh = _service.GetById(txtMaKH.Text);
                if (kh == null)
                {
                    MessageBox.Show("Không tìm thấy khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                kh.TenKH = txtTenKH.Text;
                kh.SDT = txtSDT.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.Email = txtEmail.Text;
                try
                {
                    _service.Update(kh);
                    MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadData();
            _isAdding = false;
        }

        // Khi click "Xóa"
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var kh = _service.GetById(txtMaKH.Text);
            if (kh == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Có thể kiểm tra ràng buộc với đơn hàng nếu cần
            if (kh.DON_HANG != null && kh.DON_HANG.Any())
            {
                MessageBox.Show("Không thể xóa khách hàng đã có đơn hàng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _service.Delete(txtMaKH.Text);
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Khi click "Làm mới"
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
            _isAdding = false;
        }

        // Khi chọn dòng trên DataGridView
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvKhachHang.Rows.Count > e.RowIndex)
            {
                var row = dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKH"].Value?.ToString();
                txtTenKH.Text = row.Cells["TenKH"].Value?.ToString();
                txtSDT.Text = row.Cells["SDT"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtDiemTichLuy.Text = row.Cells["DiemTichLuy"].Value?.ToString();
                SetInputState(true);
                txtMaKH.Enabled = false;
                _isAdding = false;
            }
        }

        // Khi click "Tìm kiếm"
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadData(txtTimKiem.Text.Trim());
        }

        // Khi click "Xem lịch sử"
        private void btnLichSu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xem lịch sử.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Mở form lịch sử mua hàng (giả sử đã có FormLichSuMuaHang)
            var frm = new FormLichSuMuaHang(txtMaKH.Text, txtTenKH.Text);
            frm.ShowDialog();
        }

        // Sinh mã khách hàng tự động (KH001, KH002, ...)
        private string GenerateMaKH()
        {
            var all = _service.GetAll();
            int max = 0;
            foreach (var kh in all)
            {
                if (kh.MaKH != null && kh.MaKH.StartsWith("KH"))
                {
                    if (int.TryParse(kh.MaKH.Substring(2), out int num))
                        if (num > max) max = num;
                }
            }
            return "KH" + (max + 1).ToString("D3");
        }

        // Kiểm tra email hợp lệ
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Kiểm tra số điện thoại hợp lệ (chỉ số, độ dài 9-11)
        private bool IsValidPhone(string phone)
        {
            return phone.All(char.IsDigit) && phone.Length >= 9 && phone.Length <= 11;
        }
    }
}
