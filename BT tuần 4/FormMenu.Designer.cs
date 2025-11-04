namespace BT_tuần_4
{
    partial class FormMenu
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelMenu;
        private Panel panelMain;
        private Button btnListBox, btnComboBox, btnDataGridView, btnFilter, btnTreeView, btnPhanTrang, btnQuanLySanPham, btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMenu = new Panel();
            this.panelMain = new Panel();
            this.btnListBox = new Button();
            this.btnComboBox = new Button();
            this.btnDataGridView = new Button();
            this.btnFilter = new Button();
            this.btnTreeView = new Button();
            this.btnPhanTrang = new Button();
            this.btnQuanLySanPham = new Button();
            this.btnThoat = new Button();

            // ===== Form =====
            this.SuspendLayout();
            this.ClientSize = new Size(1200, 700);
            this.Text = "Form Menu";
            this.Load += new EventHandler(this.FormMenu_Load);
            this.MinimumSize = new Size(900, 600);

            // ===== Panel Menu =====
            this.panelMenu.Dock = DockStyle.Left;
            this.panelMenu.Width = 220;
            this.panelMenu.BackColor = Color.FromArgb(40, 40, 60);
            this.panelMenu.Padding = new Padding(10, 20, 10, 10);
            this.panelMenu.AutoScroll = true;

            // ===== Panel Main =====
            this.panelMain.Dock = DockStyle.Fill;
            this.panelMain.BackColor = Color.FromArgb(245, 245, 250);

            // ===== Buttons =====
            Font btnFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            Color btnColor = Color.FromArgb(60, 60, 90);

            Button[] buttons = {
                btnListBox, btnComboBox, btnDataGridView, btnFilter,
                btnTreeView, btnPhanTrang, btnQuanLySanPham, btnThoat
            };
            string[] texts = {
                "ListBox", "ComboBox", "DataGridView",
                "Filter","TreeView", "Phân Trang",
                "Quản Lý Sản Phẩm", "Thoát"
            };
            EventHandler[] handlers = {
                btnListBox_Click, btnComboBox_Click, btnDataGridView_Click,
                btnFilter_Click, btnTreeView_Click, btnPhanTrang_Click,
                btnQuanLySanPham_Click, btnThoat_Click
            };

            int top = 20;
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = texts[i];
                buttons[i].Font = btnFont;
                buttons[i].ForeColor = Color.White;
                buttons[i].BackColor = btnColor;
                buttons[i].FlatStyle = FlatStyle.Flat;
                buttons[i].FlatAppearance.BorderSize = 0;
                buttons[i].Width = 200;
                buttons[i].Height = 45;
                buttons[i].Top = top;
                buttons[i].Left = 10;
                buttons[i].Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                buttons[i].Click += handlers[i];
                buttons[i].Cursor = Cursors.Hand;
                buttons[i].FlatAppearance.MouseOverBackColor = Color.MediumSlateBlue;
                this.panelMenu.Controls.Add(buttons[i]);
                top += 55;
            }

            // ===== Add Controls =====
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.ResumeLayout(false);
        }
    }

  
}