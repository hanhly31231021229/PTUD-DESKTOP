using System.Windows.Forms;
namespace BT_tuần_4
{
    partial class TreeView
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
            trvLoaiSanPham = new System.Windows.Forms.TreeView();
            dgSanPham = new System.Windows.Forms.DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgSanPham).BeginInit();
            SuspendLayout();
            // 
            // trvLoaiSanPham
            // 
            trvLoaiSanPham.Location = new Point(27, 58);
            trvLoaiSanPham.Name = "trvLoaiSanPham";
            trvLoaiSanPham.Size = new Size(208, 299);
            trvLoaiSanPham.TabIndex = 0;
            trvLoaiSanPham.AfterSelect += trvLoaiSanPham_AfterSelect;
            // 
            // dgSanPham
            // 
            dgSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSanPham.Location = new Point(241, 58);
            dgSanPham.Name = "dgSanPham";
            dgSanPham.RowHeadersWidth = 51;
            dgSanPham.Size = new Size(519, 299);
            dgSanPham.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 35);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 2;
            label1.Text = "Loại sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 35);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "Sản phẩm";
            // 
            // TreeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgSanPham);
            Controls.Add(trvLoaiSanPham);
            Name = "TreeView";
            Text = "TreeView";
            Load += TreeView_Load;
            ((System.ComponentModel.ISupportInitialize)dgSanPham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TreeView trvLoaiSanPham;
        private System.Windows.Forms.DataGridView dgSanPham;
        private Label label1;
        private Label label2;
    }
}