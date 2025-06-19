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
    public partial class FormQuanLySanPham : Form
    {
        private SanPhamService _spService = new SanPhamService();
        private readonly LoaiSanPhamService _loaiService = new LoaiSanPhamService();
        private readonly NhaCungCapService _nccService = new NhaCungCapService();
        private bool _isAdding = false;

        public FormQuanLySanPham()
        {
            InitializeComponent();
            LoadComboboxes();
            LoadData();
            SetInputState(false);
        }

        // Load dữ liệu sản phẩm lên DataGridView
        private void LoadData()
        {
            _spService = new SanPhamService();
            var data = _spService.GetAll();
            dgvSanPham.DataSource = data;
            dgvSanPham.ClearSelection();
            ClearInput();
            SetInputState(false);
        }

        // Load dữ liệu cho các combobox
        private void LoadComboboxes()
        {
            // Loại sản phẩm
            var loaiList = _loaiService.GetAll();
            cbLoaiSP.DataSource = loaiList;
            cbLoaiSP.DisplayMember = "TenLoai";
            cbLoaiSP.ValueMember = "MaLoai";

            // Tạo danh sách lọc loại sản phẩm với "Tất cả"
            var loaiLocList = new List<LOAI_SAN_PHAM>
            {
                new LOAI_SAN_PHAM { MaLoai = "", TenLoai = "Tất cả" }
            };
            loaiLocList.AddRange(loaiList);
            cbLocLoaiSP.DataSource = loaiLocList;
            cbLocLoaiSP.DisplayMember = "TenLoai";
            cbLocLoaiSP.ValueMember = "MaLoai";
            cbLocLoaiSP.SelectedIndex = 0;

            // Nhà cung cấp
            var nccList = _nccService.GetAll();
            cbNCC.DataSource = nccList;
            cbNCC.DisplayMember = "TenNCC";
            cbNCC.ValueMember = "MaNCC";

            // Tạo danh sách lọc nhà cung cấp với "Tất cả"
            var nccLocList = new List<NHA_CUNG_CAP>
            {
                new NHA_CUNG_CAP { MaNCC = "", TenNCC = "Tất cả" }
            };
            nccLocList.AddRange(nccList);
            cbLocNCC.DataSource = nccLocList;
            cbLocNCC.DisplayMember = "TenNCC";
            cbLocNCC.ValueMember = "MaNCC";
            cbLocNCC.SelectedIndex = 0;
        }

        // Xóa nội dung các trường nhập liệu
        private void ClearInput()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaBan.Text = "";
            txtGiaNhap.Text = "";
            txtSoLuongTon.Text = "";
            txtDonViTinh.Text = "";
            cbLoaiSP.SelectedIndex = -1;
            cbNCC.SelectedIndex = -1;
            txtMaSP.Enabled = false;
        }

        // Bật/tắt trạng thái nhập liệu
        private void SetInputState(bool enable)
        {
            txtMaSP.Enabled = enable && _isAdding;
            txtTenSP.Enabled = enable;
            txtGiaBan.Enabled = enable;
            txtGiaNhap.Enabled = enable;
            txtSoLuongTon.Enabled = enable;
            txtDonViTinh.Enabled = enable;
            cbLoaiSP.Enabled = enable;
            cbNCC.Enabled = enable;
            btnLuu.Enabled = enable;
        }

        // Khi click "Thêm mới"
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            ClearInput();
            SetInputState(true);
            _isAdding = true;
            txtMaSP.Enabled = true;
            txtMaSP.Focus();
        }

        // Khi click "Lưu"
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra nhập liệu
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) ||
                string.IsNullOrWhiteSpace(txtTenSP.Text) ||
                string.IsNullOrWhiteSpace(txtGiaBan.Text) ||
                string.IsNullOrWhiteSpace(txtGiaNhap.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuongTon.Text) ||
                string.IsNullOrWhiteSpace(txtDonViTinh.Text) ||
                cbLoaiSP.SelectedIndex < 0 ||
                cbNCC.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtGiaBan.Text, out decimal giaBan) || giaBan < 0 ||
                !decimal.TryParse(txtGiaNhap.Text, out decimal giaNhap) || giaNhap < 0 ||
                !int.TryParse(txtSoLuongTon.Text, out int soLuong) || soLuong < 0)
            {
                MessageBox.Show("Giá bán, giá nhập phải là số >= 0. Số lượng tồn phải là số nguyên >= 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_isAdding)
            {
                if (_spService.GetById(txtMaSP.Text) != null)
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var sp = new SAN_PHAM
                {
                    MaSP = txtMaSP.Text,
                    TenSP = txtTenSP.Text,
                    GiaBan = giaBan,
                    GiaNhap = giaNhap,
                    SoLuongTon = soLuong,
                    DonViTinh = txtDonViTinh.Text,
                    MaLoai = cbLoaiSP.SelectedValue?.ToString(),
                    MaNCC = cbNCC.SelectedValue?.ToString(),
                    NgayCapNhat = DateTime.Now
                };
                try
                {
                    _spService.Add(sp);
                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo");
                    _isAdding = false;
                    SetInputState(false);
                    LoadData();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                {
                    var sb = new StringBuilder();
                    foreach (var eve in ex.EntityValidationErrors)
                    {
                        sb.AppendLine($"Entity \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\" has the following validation errors:");
                        foreach (var ve in eve.ValidationErrors)
                        {
                            sb.AppendLine($"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
                        }
                    }
                    MessageBox.Show("Lỗi khi thêm sản phẩm:\n" + sb.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                var sp = _spService.GetById(txtMaSP.Text);
                if (sp == null)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                sp.TenSP = txtTenSP.Text;
                sp.GiaBan = giaBan;
                sp.GiaNhap = giaNhap;
                sp.SoLuongTon = soLuong;
                sp.DonViTinh = txtDonViTinh.Text;
                sp.MaLoai = cbLoaiSP.SelectedValue?.ToString();
                sp.MaNCC = cbNCC.SelectedValue?.ToString();
                sp.NgayCapNhat = DateTime.Now;
                try
                {
                    _spService.Update(sp);
                    MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadData();
            _isAdding = false;
        }

        // Khi click "Xóa"
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa sản phẩm đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvSanPham.SelectedRows)
                {
                    var maSP = row.Cells["MaSP"].Value?.ToString();
                    var sp = _spService.GetById(maSP);
                    if (sp == null) continue;
                    // Kiểm tra ràng buộc
                    if ((sp.CHI_TIET_DON_HANG != null && sp.CHI_TIET_DON_HANG.Any()) ||
                        (sp.CHI_TIET_PHIEU_NHAP != null && sp.CHI_TIET_PHIEU_NHAP.Any()))
                    {
                        MessageBox.Show($"Không thể xóa sản phẩm {maSP} đang có trong đơn hàng hoặc phiếu nhập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }
                    try
                    {
                        _spService.Delete(maSP);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                LoadData();
                MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo");
            }
        }

        // Khi click "Làm mới"
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
            _isAdding = false;
        }

        // Khi chọn dòng trên DataGridView
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSanPham.Rows.Count > e.RowIndex)
            {
                var row = dgvSanPham.Rows[e.RowIndex];
                txtMaSP.Text = row.Cells["MaSP"].Value?.ToString();
                txtTenSP.Text = row.Cells["TenSP"].Value?.ToString();
                txtGiaBan.Text = row.Cells["GiaBan"].Value?.ToString();
                txtGiaNhap.Text = row.Cells["GiaNhap"].Value?.ToString();
                txtSoLuongTon.Text = row.Cells["SoLuongTon"].Value?.ToString();
                txtDonViTinh.Text = row.Cells["DonViTinh"].Value?.ToString();
                cbLoaiSP.SelectedValue = row.Cells["MaLoai"].Value?.ToString();
                cbNCC.SelectedValue = row.Cells["MaNCC"].Value?.ToString();
                SetInputState(true);
                txtMaSP.Enabled = false;
                _isAdding = false;
            }
        }

        // Khi click "Tìm kiếm"
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();
            var data = _spService.GetAll().Where(sp =>
                (sp.TenSP != null && sp.TenSP.ToLower().Contains(keyword)) ||
                (sp.MaSP != null && sp.MaSP.ToLower().Contains(keyword))
            ).ToList();
            dgvSanPham.DataSource = data;
            dgvSanPham.ClearSelection();
        }

        // Khi lọc theo loại sản phẩm
        private void cbLocLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        // Khi lọc theo nhà cung cấp
        private void cbLocNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        // Lọc dữ liệu theo loại SP và NCC
        private void FilterData()
        {
            var data = _spService.GetAll().AsQueryable();
            if (cbLocLoaiSP.SelectedIndex > 0)
            {
                var maLoai = cbLocLoaiSP.SelectedValue?.ToString();
                data = data.Where(sp => sp.MaLoai == maLoai);
            }
            if (cbLocNCC.SelectedIndex > 0)
            {
                var maNCC = cbLocNCC.SelectedValue?.ToString();
                data = data.Where(sp => sp.MaNCC == maNCC);
            }
            dgvSanPham.DataSource = data.ToList();
            dgvSanPham.ClearSelection();
        }
    }
}
