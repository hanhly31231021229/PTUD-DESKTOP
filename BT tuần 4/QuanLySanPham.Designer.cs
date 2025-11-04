namespace BT_tuần_4
{
    partial class QuanLySanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dgSanPham = new System.Windows.Forms.DataGridView();
            txtMaSP = new TextBox();
            txtTenSP = new TextBox();
            txtDVT = new TextBox();
            txtDonGia = new TextBox();
            cboLoaiSP = new System.Windows.Forms.ComboBox();
            btThem = new Button();
            btLuu = new Button();
            btSua = new Button();
            btXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgSanPham).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 35);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã sản phẩm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 78);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên sản phẩm: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 121);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 2;
            label3.Text = "Đơn vị tính:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 165);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Đơn giá:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 208);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 4;
            label5.Text = "Loại sản phẩm";
            // 
            // dgSanPham
            // 
            dgSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSanPham.Location = new Point(41, 252);
            dgSanPham.Name = "dgSanPham";
            dgSanPham.RowHeadersWidth = 51;
            dgSanPham.Size = new Size(718, 377);
            dgSanPham.TabIndex = 5;
            dgSanPham.CellContentClick += dgSanPham_RowEnter;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(172, 35);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(255, 27);
            txtMaSP.TabIndex = 6;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(172, 78);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(255, 27);
            txtTenSP.TabIndex = 7;
            // 
            // txtDVT
            // 
            txtDVT.Location = new Point(172, 121);
            txtDVT.Name = "txtDVT";
            txtDVT.Size = new Size(255, 27);
            txtDVT.TabIndex = 8;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(172, 165);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(255, 27);
            txtDonGia.TabIndex = 9;
            // 
            // cboLoaiSP
            // 
            cboLoaiSP.FormattingEnabled = true;
            cboLoaiSP.Location = new Point(173, 213);
            cboLoaiSP.Name = "cboLoaiSP";
            cboLoaiSP.Size = new Size(254, 28);
            cboLoaiSP.TabIndex = 10;
            // 
            // btThem
            // 
            btThem.Location = new Point(531, 31);
            btThem.Name = "btThem";
            btThem.Size = new Size(94, 29);
            btThem.TabIndex = 11;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // btLuu
            // 
            btLuu.Location = new Point(531, 78);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(94, 29);
            btLuu.TabIndex = 12;
            btLuu.Text = "Lưu";
            btLuu.UseVisualStyleBackColor = true;
            btLuu.Click += btLuu_Click;
            // 
            // btSua
            // 
            btSua.Location = new Point(531, 121);
            btSua.Name = "btSua";
            btSua.Size = new Size(94, 29);
            btSua.TabIndex = 13;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += btSua_Click;
            // 
            // btXoa
            // 
            btXoa.Location = new Point(531, 165);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(94, 29);
            btXoa.TabIndex = 14;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // QuanLySanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 641);
            Controls.Add(btXoa);
            Controls.Add(btSua);
            Controls.Add(btLuu);
            Controls.Add(btThem);
            Controls.Add(cboLoaiSP);
            Controls.Add(txtDonGia);
            Controls.Add(txtDVT);
            Controls.Add(txtTenSP);
            Controls.Add(txtMaSP);
            Controls.Add(dgSanPham);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "QuanLySanPham";
            Text = "Form8";
            Load += QuanLySanPham_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private System.Windows.Forms.DataGridView dgSanPham;
        private TextBox txtMaSP;
        private TextBox txtTenSP;
        private TextBox txtDVT;
        private TextBox txtDonGia;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private Button btThem;
        private Button btLuu;
        private Button btSua;
        private Button btXoa;
    }
}