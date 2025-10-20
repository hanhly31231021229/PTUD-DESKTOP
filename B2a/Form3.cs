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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            dgvSanPham.Rows.Add(txtTenSP.Text, cboLoaiSP.Text, numSoLuong.Value);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenSP.Clear();
            cboLoaiSP.SelectedIndex = -1;
            numSoLuong.Value = 0;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow != null)
                dgvSanPham.Rows.Remove(dgvSanPham.CurrentRow);
        }
    }

}
