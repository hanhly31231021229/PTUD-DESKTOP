namespace BT_tuần_4
{
    partial class ComboBox
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
            btnThoat = new Button();
            label2 = new Label();
            cboSanPham = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(446, 92);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 46);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 3;
            label2.Text = "DANH MỤC SẢN PHẨM";
            // 
            // cboSanPham
            // 
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(66, 110);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(307, 28);
            cboSanPham.TabIndex = 5;
            // 
            // ComboBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboSanPham);
            Controls.Add(btnThoat);
            Controls.Add(label2);
            Name = "ComboBox";
            Text = "ComboBox";
            Load += ComboBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThoat;
        private Label label2;
        private System.Windows.Forms.ComboBox cboSanPham;

    }
}