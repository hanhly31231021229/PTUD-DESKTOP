namespace BT_tuần_4
{
    partial class DataGridView
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
            dgSanPham = new System.Windows.Forms.DataGridView();
            txtKeyWord = new TextBox();
            label2 = new Label();
            btnTimKiem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgSanPham).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 32);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC SẢN PHẨM";
            // 
            // dgSanPham
            // 
            dgSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSanPham.Location = new Point(40, 122);
            dgSanPham.Name = "dgSanPham";
            dgSanPham.RowHeadersWidth = 51;
            dgSanPham.Size = new Size(718, 302);
            dgSanPham.TabIndex = 1;
            // 
            // txtKeyWord
            // 
            txtKeyWord.Location = new Point(252, 78);
            txtKeyWord.Name = "txtKeyWord";
            txtKeyWord.Size = new Size(347, 27);
            txtKeyWord.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 81);
            label2.Name = "label2";
            label2.Size = new Size(191, 20);
            label2.TabIndex = 3;
            label2.Text = "Nhập tên sản phẩm cần tìm";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(613, 78);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // DataGridView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTimKiem);
            Controls.Add(label2);
            Controls.Add(txtKeyWord);
            Controls.Add(dgSanPham);
            Controls.Add(label1);
            Name = "DataGridView";
            Text = "DataGridView";
            FormClosing += DataGridView_FormClosing;
            Load += DataGridView_Load;
            ((System.ComponentModel.ISupportInitialize)dgSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.DataGridView dgSanPham;
        private TextBox txtKeyWord;
        private Label label2;
        private Button btnTimKiem;
    }
}