using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B2a
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
                errorProvider1.SetError(txtTen, "Tên sản phẩm không được để trống!");
            else if (numSoLuong.Value <= 0)
                errorProvider1.SetError(numSoLuong, "Số lượng phải > 0!");
            else
            {
                errorProvider1.Clear();
                dgvSanPham.Rows.Add(txtTen.Text, cboLoai.Text, numSoLuong.Value, rdoCon.Checked ? "Còn" : "Hết");
                statusLabel.Text = $"Tổng: {dgvSanPham.Rows.Count}";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow != null)
                dgvSanPham.Rows.Remove(dgvSanPham.CurrentRow);
            statusLabel.Text = $"Tổng: {dgvSanPham.Rows.Count}";
        }
    }
}
