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
    public partial class FormQuanLyNhaCungCap : Form
    {
        private readonly NhaCungCapService _service = new NhaCungCapService();
        private bool _isAdding = false;

        public FormQuanLyNhaCungCap()
        {
            InitializeComponent();
            LoadData();
            SetInputState(false);
        }

        // Load danh sách nhà cung cấp lên DataGridView
        private void LoadData(string keyword = "")
        {
            var data = string.IsNullOrWhiteSpace(keyword)
                ? _service.GetAll()
                : _service.GetAll().Where(ncc => ncc.TenNCC != null && ncc.TenNCC.ToLower().Contains(keyword.ToLower())).ToList();
            dgvNhaCungCap.DataSource = data;
            dgvNhaCungCap.ClearSelection();
            ClearInput();
            SetInputState(false);
        }

        // Xóa nội dung các trường nhập liệu
        private void ClearInput()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtMaNCC.Enabled = false;
        }

        // Bật/tắt trạng thái nhập liệu
        private void SetInputState(bool enable)
        {
            txtMaNCC.Enabled = enable;
            txtTenNCC.Enabled = enable;
            txtDiaChi.Enabled = enable;
            txtSDT.Enabled = enable;
            txtEmail.Enabled = enable;
            btnLuu.Enabled = enable;
        }

        // Khi click "Thêm mới"
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            ClearInput();
            SetInputState(true);
            _isAdding = true;
            txtMaNCC.Enabled = true;
            txtMaNCC.Focus();
        }

        // Khi click "Lưu"
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNCC.Text) || string.IsNullOrWhiteSpace(txtTenNCC.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã NCC và Tên NCC.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_isAdding)
            {
                // Kiểm tra trùng mã
                if (_service.GetById(txtMaNCC.Text) != null)
                {
                    MessageBox.Show("Mã nhà cung cấp đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var ncc = new NHA_CUNG_CAP
                {
                    MaNCC = txtMaNCC.Text,
                    TenNCC = txtTenNCC.Text,
                    DiaChi = txtDiaChi.Text,
                    SDT = txtSDT.Text,
                    Email = txtEmail.Text
                };
                _service.Add(ncc);
                MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo");
            }
            else
            {
                var ncc = _service.GetById(txtMaNCC.Text);
                if (ncc == null)
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ncc.TenNCC = txtTenNCC.Text;
                ncc.DiaChi = txtDiaChi.Text;
                ncc.SDT = txtSDT.Text;
                ncc.Email = txtEmail.Text;
                _service.Update(ncc);
                MessageBox.Show("Cập nhật nhà cung cấp thành công!", "Thông báo");
            }
            LoadData();
            _isAdding = false;
        }

        // Khi click "Xóa"
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNCC.Text))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var ncc = _service.GetById(txtMaNCC.Text);
            if (ncc == null)
            {
                MessageBox.Show("Không tìm thấy nhà cung cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra ràng buộc sản phẩm hoặc phiếu nhập
            if ((ncc.SAN_PHAM != null && ncc.SAN_PHAM.Any()) ||
                (ncc.PHIEU_NHAP_KHO != null && ncc.PHIEU_NHAP_KHO.Any()))
            {
                MessageBox.Show("Không thể xóa nhà cung cấp đang có sản phẩm hoặc phiếu nhập liên quan.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _service.Delete(txtMaNCC.Text);
                MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo");
                LoadData();
            }
        }

        // Khi click "Làm mới"
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
            _isAdding = false;
        }

        // Khi chọn dòng trên DataGridView
        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvNhaCungCap.Rows.Count > e.RowIndex)
            {
                var row = dgvNhaCungCap.Rows[e.RowIndex];
                txtMaNCC.Text = row.Cells["MaNCC"].Value?.ToString();
                txtTenNCC.Text = row.Cells["TenNCC"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                txtSDT.Text = row.Cells["SDT"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                SetInputState(true);
                txtMaNCC.Enabled = false;
                _isAdding = false;
            }
        }

        // Khi click "Tìm kiếm"
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadData(txtTimKiem.Text.Trim());
        }
    }
}
