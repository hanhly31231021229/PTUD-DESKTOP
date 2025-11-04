using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace BT_tuần_4
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        // Hàm mở form con trong panelMain
        private void OpenChildForm(Form child)
        {
            // Xóa form con cũ nếu có
            foreach (Control c in panelMain.Controls)
            {
                if (c is Form) ((Form)c).Close();
            }

            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panelMain.Controls.Add(child);
            panelMain.Tag = child;
            child.Show();
        }

        private void btnListBox_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ListBox());
        }

        private void btnComboBox_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ComboBox());
        }

        private void btnDataGridView_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DataGridView());
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Filter());
        }

        private void btnTreeView_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TreeView());
        }

        private void btnPhanTrang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhanTrang());
        }

        private void btnQuanLySanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLySanPham());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var traloi = MessageBox.Show("Chắc không?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }
    }
}

//namespace BT_tuần_4
//{
//    public partial class FormMenu : Form
//    {
//        public FormMenu()
//        {
//            InitializeComponent();
//        }

//        private void FormMenu_Load(object sender, EventArgs e)
//        {
//            this.IsMdiContainer = true;

//            // Gán sự kiện click cho các nút
//            button1.Click += (s, ev) => OpenChildForm(new ListBox());
//            button2.Click += (s, ev) => OpenChildForm(new ComboBox());
//            button3.Click += (s, ev) => OpenChildForm(new DataGridView());
//            button4.Click += (s, ev) => OpenChildForm(new Filter());
//            button5.Click += (s, ev) => OpenChildForm(new TreeView());
//            button6.Click += (s, ev) => OpenChildForm(new PhanTrang());
//            button7.Click += (s, ev) => OpenChildForm(new QuanLySanPham());
//        }

//        // Hàm mở form con
//        private void OpenChildForm(Form child)
//        {
//            ToggleButtons(false);
//            child.MdiParent = this;
//            child.FormClosed += (s, e) => ToggleButtons(true);
//            child.Show();
//        }

//        // Ẩn/hiện các nút menu
//        private void ToggleButtons(bool visible)
//        {
//            button1.Visible = visible;
//            button2.Visible = visible;
//            button3.Visible = visible;
//            button4.Visible = visible;
//            button5.Visible = visible;
//            button6.Visible = visible;
//            button7.Visible = visible;
//        }

       

//    }
    //public partial class FormMenu : Form
    //{
    //    public FormMenu()
    //    {
    //        InitializeComponent();
    //    }
    //    private void FormMenu_Load(object sender, EventArgs e)
    //    {
    //        this.IsMdiContainer = true;

    //        // Gán sự kiện click cho các nút
    //        button1.Click += (s, ev) => OpenChildForm(new ListBox());
    //        button2.Click += (s, ev) => OpenChildForm(new ComboBox());
    //        button3.Click += (s, ev) => OpenChildForm(new DataGridView());
    //        button4.Click += (s, ev) => OpenChildForm(new Filter());
    //        button5.Click += (s, ev) => OpenChildForm(new TreeView());
    //        button6.Click += (s, ev) => OpenChildForm(new PhanTrang());
    //        button7.Click += (s, ev) => OpenChildForm(new QuanLySanPham());
    //    }

    //    // Hàm mở form con chung
    //    private void OpenChildForm(Form child)
    //    {
    //        // Ẩn các nút khi mở form con
    //        ToggleButtons(false);

    //        child.MdiParent = this;
    //        child.FormClosed += (s, e) => ToggleButtons(true); // Khi đóng form con thì hiện lại nút
    //        child.Show();
    //    }

    //    // Ẩn/hiện các nút
    //    private void ToggleButtons(bool visible)
    //    {
    //        button1.Visible = visible;
    //        button2.Visible = visible;
    //        button3.Visible = visible;
    //        button4.Visible = visible;
    //        button5.Visible = visible;
    //        button6.Visible = visible;
    //        button7.Visible = visible;
    //    }

    //    private void mnuBai_ListBox_Click(object sender, EventArgs e)
    //    {
    //        OpenChildForm(new ListBox());
    //    }

    //    private void mnuBai_ComboBox_Click(object sender, EventArgs e)
    //    {
    //        OpenChildForm(new ComboBox());
    //    }

    //    private void mnuBai_DataGridView_Click(object sender, EventArgs e)
    //    {
    //        OpenChildForm(new DataGridView());
    //    }

    //    private void mnuBai_Filter_Click(object sender, EventArgs e)
    //    {
    //        OpenChildForm(new Filter());
    //    }

    //    private void mnuBai_TreeView_Click(object sender, EventArgs e)
    //    {
    //        OpenChildForm(new TreeView());
    //    }

    //    private void mnuBai_PhanTrang_Click(object sender, EventArgs e)
    //    {
    //        OpenChildForm(new PhanTrang());
    //    }

    //    private void mnuBai_QuanLySanPham_Click(object sender, EventArgs e)
    //    {
    //        OpenChildForm(new QuanLySanPham());
    //    }

    //    private void mnuThoat_Click(object sender, EventArgs e)
    //    {
    //        var traloi = MessageBox.Show("Chắc không?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
    //        if (traloi == DialogResult.OK) Application.Exit();
    //    }


    //}
//}
