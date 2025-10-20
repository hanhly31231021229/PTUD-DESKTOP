namespace B2a
{
    partial class Form3
    {
       
        private System.ComponentModel.IContainer components = null;
        private TextBox txtTenSP;
        private ComboBox cboLoaiSP;
        private NumericUpDown numSoLuong;
        private Button btnLuu, btnXoa, btnLamMoi;
        private DataGridView dgvSanPham;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            txtTenSP = new TextBox() { PlaceholderText = "Tên sản phẩm", Location = new System.Drawing.Point(30, 20), Width = 200 };
            cboLoaiSP = new ComboBox() { Location = new System.Drawing.Point(30, 60), Width = 200 };
            cboLoaiSP.Items.AddRange(new object[] { "Cà phê", "Trà", "Nước ngọt" });
            numSoLuong = new NumericUpDown() { Location = new System.Drawing.Point(30, 100), Width = 200 };

            btnLuu = new Button() { Text = "Lưu", Location = new System.Drawing.Point(30, 140) };
            btnLuu.Click += btnLuu_Click;

            btnXoa = new Button() { Text = "Xóa", Location = new System.Drawing.Point(110, 140) };
            btnXoa.Click += btnXoa_Click;

            btnLamMoi = new Button() { Text = "Làm mới", Location = new System.Drawing.Point(190, 140) };
            btnLamMoi.Click += btnLamMoi_Click;

            dgvSanPham = new DataGridView() { Location = new System.Drawing.Point(30, 180), Width = 300, Height = 150 };
            dgvSanPham.Columns.Add("Ten", "Tên sản phẩm");
            dgvSanPham.Columns.Add("Loai", "Loại sản phẩm");
            dgvSanPham.Columns.Add("SL", "Số lượng");

            Controls.AddRange(new Control[] { txtTenSP, cboLoaiSP, numSoLuong, btnLuu, btnXoa, btnLamMoi, dgvSanPham });
            Text = "Đăng ký sản phẩm";
            ClientSize = new System.Drawing.Size(380, 370);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        #endregion
    }
}