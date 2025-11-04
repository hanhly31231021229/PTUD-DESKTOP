namespace BT_tuần_4
{
    partial class Filter
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
            cboLoaiSP = new System.Windows.Forms.ComboBox();
            btLoc = new Button();
            dgSanPham = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgSanPham).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 42);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 0;
            label1.Text = "CHỌN LOẠI SẢN PHẨM";
            // 
            // cboLoaiSP
            // 
            cboLoaiSP.FormattingEnabled = true;
            cboLoaiSP.Location = new Point(235, 38);
            cboLoaiSP.Name = "cboLoaiSP";
            cboLoaiSP.Size = new Size(307, 28);
            cboLoaiSP.TabIndex = 1;
            // 
            // btLoc
            // 
            btLoc.Location = new Point(582, 38);
            btLoc.Name = "btLoc";
            btLoc.Size = new Size(94, 29);
            btLoc.TabIndex = 2;
            btLoc.Text = "Lọc";
            btLoc.UseVisualStyleBackColor = true;
            btLoc.Click += btLoc_Click;
            // 
            // dgSanPham
            // 
            dgSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSanPham.Location = new Point(37, 133);
            dgSanPham.Name = "dgSanPham";
            dgSanPham.RowHeadersWidth = 51;
            dgSanPham.Size = new Size(725, 286);
            dgSanPham.TabIndex = 3;
            // 
            // Filter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgSanPham);
            Controls.Add(btLoc);
            Controls.Add(cboLoaiSP);
            Controls.Add(label1);
            Name = "Filter";
            Text = "Filter";
            Load += Filter_Load;
            ((System.ComponentModel.ISupportInitialize)dgSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private Button btLoc;
        private System.Windows.Forms.DataGridView dgSanPham;
    }
}