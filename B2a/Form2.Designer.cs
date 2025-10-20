namespace B2a
{
    partial class Form2
    {

        private System.ComponentModel.IContainer components = null;
        private Panel panelLeft, panelRight;
        private TextBox txtTen;
        private ComboBox cboLoai;
        private NumericUpDown numSoLuong;
        private RadioButton rdoCon, rdoHet;
        private GroupBox grpTinhTrang;
        private Button btnThem, btnXoa;
        private DataGridView dgvSanPham;
        private ErrorProvider errorProvider1;
        private ToolTip toolTip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;

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
            components = new System.ComponentModel.Container();
            panelLeft = new Panel() { Dock = DockStyle.Left, Width = 250 };
            panelRight = new Panel() { Dock = DockStyle.Fill };

            txtTen = new TextBox() { PlaceholderText = "Tên sản phẩm", Location = new System.Drawing.Point(30, 30), Width = 180 };
            cboLoai = new ComboBox() { Location = new System.Drawing.Point(30, 70), Width = 180 };
            cboLoai.Items.AddRange(new object[] { "Cà phê", "Trà", "Nước ngọt" });
            numSoLuong = new NumericUpDown() { Location = new System.Drawing.Point(30, 110), Width = 180 };

            grpTinhTrang = new GroupBox() { Text = "Tình trạng", Location = new System.Drawing.Point(30, 150), Width = 180, Height = 70 };
            rdoCon = new RadioButton() { Text = "Còn", Checked = true, Location = new System.Drawing.Point(10, 25) };
            rdoHet = new RadioButton() { Text = "Hết", Location = new System.Drawing.Point(90, 25) };
            grpTinhTrang.Controls.AddRange(new Control[] { rdoCon, rdoHet });

            btnThem = new Button() { Text = "Thêm", Location = new System.Drawing.Point(30, 240) };
            btnThem.Click += btnThem_Click;
            btnXoa = new Button() { Text = "Xóa", Location = new System.Drawing.Point(120, 240) };
            btnXoa.Click += btnXoa_Click;

            panelLeft.Controls.AddRange(new Control[] { txtTen, cboLoai, numSoLuong, grpTinhTrang, btnThem, btnXoa });

            dgvSanPham = new DataGridView() { Dock = DockStyle.Fill, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
            dgvSanPham.Columns.Add("Ten", "Tên sản phẩm");
            dgvSanPham.Columns.Add("Loai", "Loại sản phẩm");
            dgvSanPham.Columns.Add("SL", "Số lượng");
            dgvSanPham.Columns.Add("TinhTrang", "Tình trạng");
            panelRight.Controls.Add(dgvSanPham);

            errorProvider1 = new ErrorProvider(components);
            toolTip1 = new ToolTip(components);
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel() { Text = "Tổng: 0" };
            statusStrip1.Items.Add(statusLabel);

            Controls.AddRange(new Control[] { panelLeft, panelRight, statusStrip1 });
            Text = "Quản lý sản phẩm cửa hàng Việt Nam";
            ClientSize = new System.Drawing.Size(700, 400);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        #endregion
    }
}