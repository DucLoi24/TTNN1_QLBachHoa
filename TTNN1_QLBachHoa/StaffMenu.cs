using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTNN1_QLBachHoa.Forms;

namespace TTNN1_QLBachHoa
{
    public partial class StaffMenu : Form
    {
        private string _maNV;
        public StaffMenu(string maNV)
        {
            InitializeComponent();
            _maNV = maNV;
        }

        private void btnTaoDonHang_Click(object sender, EventArgs e)
        {
            // Mở form tạo đơn hàng
            FormTaoDonHang formTaoDonHang = new FormTaoDonHang(_maNV);
            formTaoDonHang.Show();
        }

        private void btnTaoPhieuNhapKho_Click(object sender, EventArgs e)
        {
            // Mở form tạo phiếu nhập kho
            FormTaoPhieuNhapKho formTaoPhieuNhapKho = new FormTaoPhieuNhapKho(_maNV);
            formTaoPhieuNhapKho.Show();
        }
    }
}
