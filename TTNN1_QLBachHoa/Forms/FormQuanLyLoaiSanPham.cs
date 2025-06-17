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
    public partial class FormQuanLyLoaiSanPham : Form
    {
        private readonly LoaiSanPhamService _service = new LoaiSanPhamService();
        private bool _isAdding = false;

        public FormQuanLyLoaiSanPham()
        {
            InitializeComponent();
            LoadData();
            SetInputState(false);
        }

        // Load danh sách loại sản phẩm lên DataGridView
        private void LoadData(string keyword = "")
        {
            var data = string.IsNullOrWhiteSpace(keyword)
                ? _service.GetAll()
                : _service.GetAll().Where(l => l.TenLoai != null && l.TenLoai.ToLower().Contains(keyword.ToLower())).ToList();
            dgvLoaiSanPham.DataSource = data;
            dgvLoaiSanPham.ClearSelection();
            ClearInput();
            SetInputState(false);
        }

        // Xóa nội dung các trường nhập liệu
        private void ClearInput()
        {
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
            txtMoTa.Text = "";
            txtMaLoai.Enabled = false;
        }

        // Bật/tắt trạng thái nhập liệu
        private void SetInputState(bool enable)
        {
            txtMaLoai.Enabled = enable;
            txtTenLoai.Enabled = enable;
            txtMoTa.Enabled = enable;
            btnLuu.Enabled = enable;
        }

        // Khi click "Thêm mới"
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            ClearInput();
            SetInputState(true);
            _isAdding = true;
            txtMaLoai.Enabled = true;
            txtMaLoai.Focus();
        }

        // Khi click "Lưu"
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLoai.Text) || string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã Loại và Tên Loại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_isAdding)
            {
                // Kiểm tra trùng mã
                if (_service.GetById(txtMaLoai.Text) != null)
                {
                    MessageBox.Show("Mã loại đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var loai = new LOAI_SAN_PHAM
                {
                    MaLoai = txtMaLoai.Text,
                    TenLoai = txtTenLoai.Text,
                    MoTa = txtMoTa.Text
                };
                _service.Add(loai);
                MessageBox.Show("Thêm loại sản phẩm thành công!", "Thông báo");
            }
            else
            {
                var loai = _service.GetById(txtMaLoai.Text);
                if (loai == null)
                {
                    MessageBox.Show("Không tìm thấy loại sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                loai.TenLoai = txtTenLoai.Text;
                loai.MoTa = txtMoTa.Text;
                _service.Update(loai);
                MessageBox.Show("Cập nhật loại sản phẩm thành công!", "Thông báo");
            }
            LoadData();
            _isAdding = false;
        }

        // Khi click "Xóa"
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLoai.Text))
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var loai = _service.GetById(txtMaLoai.Text);
            if (loai == null)
            {
                MessageBox.Show("Không tìm thấy loại sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra ràng buộc sản phẩm
            if (loai.SAN_PHAM != null && loai.SAN_PHAM.Any())
            {
                MessageBox.Show("Không thể xóa loại sản phẩm đang có sản phẩm thuộc loại này.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa loại sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _service.Delete(txtMaLoai.Text);
                MessageBox.Show("Xóa loại sản phẩm thành công!", "Thông báo");
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
        private void dgvLoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvLoaiSanPham.Rows.Count > e.RowIndex)
            {
                var row = dgvLoaiSanPham.Rows[e.RowIndex];
                txtMaLoai.Text = row.Cells["MaLoai"].Value?.ToString();
                txtTenLoai.Text = row.Cells["TenLoai"].Value?.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value?.ToString();
                SetInputState(true);
                txtMaLoai.Enabled = false;
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
