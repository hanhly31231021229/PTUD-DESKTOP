namespace BT_tuần_4
{
    partial class PhanTrang
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
            txtMaSP = new TextBox();
            txtTenSP = new TextBox();
            txtDVT = new TextBox();
            txtDonGia = new TextBox();
            cboLoaiSP = new System.Windows.Forms.ComboBox();
            btFirst = new Button();
            btPrevious = new Button();
            btNext = new Button();
            btLast = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 35);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã sản phẩm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 79);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên sản phẩm: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 126);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 2;
            label3.Text = "Đơn vị tính:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 176);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Đơn giá:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 222);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 4;
            label5.Text = "Loại sản phẩm:";
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(161, 32);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(260, 27);
            txtMaSP.TabIndex = 5;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(161, 76);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(260, 27);
            txtTenSP.TabIndex = 6;
            // 
            // txtDVT
            // 
            txtDVT.Location = new Point(161, 119);
            txtDVT.Name = "txtDVT";
            txtDVT.Size = new Size(260, 27);
            txtDVT.TabIndex = 7;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(161, 169);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(260, 27);
            txtDonGia.TabIndex = 8;
            // 
            // cboLoaiSP
            // 
            cboLoaiSP.FormattingEnabled = true;
            cboLoaiSP.Location = new Point(161, 221);
            cboLoaiSP.Name = "cboLoaiSP";
            cboLoaiSP.Size = new Size(260, 28);
            cboLoaiSP.TabIndex = 9;
            // 
            // btFirst
            // 
            btFirst.Location = new Point(38, 292);
            btFirst.Name = "btFirst";
            btFirst.Size = new Size(94, 29);
            btFirst.TabIndex = 10;
            btFirst.Text = "<<";
            btFirst.UseVisualStyleBackColor = true;
            btFirst.Click += btFirst_Click;
            // 
            // btPrevious
            // 
            btPrevious.Location = new Point(161, 292);
            btPrevious.Name = "btPrevious";
            btPrevious.Size = new Size(94, 29);
            btPrevious.TabIndex = 11;
            btPrevious.Text = "<";
            btPrevious.UseVisualStyleBackColor = true;
            btPrevious.Click += btPrevious_Click;
            // 
            // btNext
            // 
            btNext.Location = new Point(285, 292);
            btNext.Name = "btNext";
            btNext.Size = new Size(94, 29);
            btNext.TabIndex = 12;
            btNext.Text = ">";
            btNext.UseVisualStyleBackColor = true;
            btNext.Click += btNext_Click;
            // 
            // btLast
            // 
            btLast.Location = new Point(407, 292);
            btLast.Name = "btLast";
            btLast.Size = new Size(94, 29);
            btLast.TabIndex = 13;
            btLast.Text = ">>";
            btLast.UseVisualStyleBackColor = true;
            btLast.Click += btLast_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btLast);
            Controls.Add(btNext);
            Controls.Add(btPrevious);
            Controls.Add(btFirst);
            Controls.Add(cboLoaiSP);
            Controls.Add(txtDonGia);
            Controls.Add(txtDVT);
            Controls.Add(txtTenSP);
            Controls.Add(txtMaSP);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PhanTrang";
            Text = "PhanTrang";
            Load += PhanTrang_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaSP;
        private TextBox txtTenSP;
        private TextBox txtDVT;
        private TextBox txtDonGia;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private Button btFirst;
        private Button btPrevious;
        private Button btNext;
        private Button btLast;
    }
}