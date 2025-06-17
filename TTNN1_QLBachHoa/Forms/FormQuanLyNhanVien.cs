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
    public partial class FormQuanLyNhanVien : Form
    {
        private readonly NhanVienService _service = new NhanVienService();
        private bool _isAdding = false;

        public FormQuanLyNhanVien()
        {
            InitializeComponent();
            LoadData();
            SetInputState(false);
        }

        // Load danh sách nhân viên lên DataGridView
        private void LoadData(string keyword = "")
        {
            var data = string.IsNullOrWhiteSpace(keyword)
                ? _service.GetAll()
                : _service.GetAll().Where(nv =>
                    (nv.TenNV != null && nv.TenNV.ToLower().Contains(keyword.ToLower())) ||
                    (nv.MaNV != null && nv.MaNV.ToLower().Contains(keyword.ToLower())) ||
                    (nv.ChucVu != null && nv.ChucVu.ToLower().Contains(keyword.ToLower()))
                ).ToList();
            dgvNhanVien.DataSource = data;
            dgvNhanVien.ClearSelection();
            ClearInput();
            SetInputState(false);
        }

        // Xóa nội dung các trường nhập liệu
        private void ClearInput()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtChucVu.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            dtpNgayVaoLam.Value = DateTime.Now;
            txtMaNV.Enabled = false;
        }

        // Bật/tắt trạng thái nhập liệu
        private void SetInputState(bool enable)
        {
            txtTenNV.Enabled = enable;
            txtChucVu.Enabled = enable;
            txtSDT.Enabled = enable;
            txtEmail.Enabled = enable;
            dtpNgayVaoLam.Enabled = enable;
            btnLuu.Enabled = enable;
        }

        // Khi click "Thêm mới"
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            ClearInput();
            SetInputState(true);
            _isAdding = true;
            txtMaNV.Enabled = false; // Mã NV tự sinh hoặc không cho nhập
            txtTenNV.Focus();
        }

        // Khi click "Lưu"
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra nhập liệu
            if (string.IsNullOrWhiteSpace(txtTenNV.Text) ||
                string.IsNullOrWhiteSpace(txtChucVu.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                // Sinh mã nhân viên tự động (ví dụ: NV001, NV002,...)
                string newMaNV = GenerateMaNV();
                var nv = new NHAN_VIEN
                {
                    MaNV = newMaNV,
                    TenNV = txtTenNV.Text,
                    ChucVu = txtChucVu.Text,
                    SDT = txtSDT.Text,
                    Email = txtEmail.Text,
                    NgayVaoLam = dtpNgayVaoLam.Value
                };
                try
                {
                    _service.Add(nv);
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtMaNV.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var nv = _service.GetById(txtMaNV.Text);
                if (nv == null)
                {
                    MessageBox.Show("Không tìm thấy nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                nv.TenNV = txtTenNV.Text;
                nv.ChucVu = txtChucVu.Text;
                nv.SDT = txtSDT.Text;
                nv.Email = txtEmail.Text;
                nv.NgayVaoLam = dtpNgayVaoLam.Value;
                try
                {
                    _service.Update(nv);
                    MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadData();
            _isAdding = false;
        }

        // Khi click "Xóa"
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var nv = _service.GetById(txtMaNV.Text);
            if (nv == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Có thể kiểm tra ràng buộc với đơn hàng hoặc phiếu nhập nếu cần
            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _service.Delete(txtMaNV.Text);
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvNhanVien.Rows.Count > e.RowIndex)
            {
                var row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNV"].Value?.ToString();
                txtTenNV.Text = row.Cells["TenNV"].Value?.ToString();
                txtChucVu.Text = row.Cells["ChucVu"].Value?.ToString();
                txtSDT.Text = row.Cells["SDT"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                if (row.Cells["NgayVaoLam"].Value != null && DateTime.TryParse(row.Cells["NgayVaoLam"].Value.ToString(), out DateTime ngayVaoLam))
                    dtpNgayVaoLam.Value = ngayVaoLam;
                else
                    dtpNgayVaoLam.Value = DateTime.Now;
                SetInputState(true);
                txtMaNV.Enabled = false;
                _isAdding = false;
            }
        }

        // Khi click "Tìm kiếm"
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadData(txtTimKiem.Text.Trim());
        }

        // Sinh mã nhân viên tự động (NV001, NV002, ...)
        private string GenerateMaNV()
        {
            var all = _service.GetAll();
            int max = 0;
            foreach (var nv in all)
            {
                if (nv.MaNV != null && nv.MaNV.StartsWith("NV"))
                {
                    if (int.TryParse(nv.MaNV.Substring(2), out int num))
                        if (num > max) max = num;
                }
            }
            return "NV" + (max + 1).ToString("D3");
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
