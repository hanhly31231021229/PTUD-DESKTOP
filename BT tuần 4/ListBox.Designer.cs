namespace BT_tuần_4
{
    partial class ListBox
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
            label2 = new Label();
            lstSanPham = new System.Windows.Forms.ListBox();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 50);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 0;
            label2.Text = "DANH MỤC SẢN PHẨM";
            // 
            // lstSanPham
            // 
            lstSanPham.FormattingEnabled = true;
            lstSanPham.Location = new Point(44, 96);
            lstSanPham.Name = "lstSanPham";
            lstSanPham.Size = new Size(307, 204);
            lstSanPham.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(435, 96);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // ListBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(lstSanPham);
            Controls.Add(label2);
            Name = "ListBox";
            Text = "Đưa dữ liệu vào ListBox";
            FormClosing += ListBox_FormClosing;
            Load += ListBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private System.Windows.Forms.ListBox lstSanPham;
        private Button btnThoat;
    }
}