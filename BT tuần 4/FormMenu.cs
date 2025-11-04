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
        private void btnAbout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AboutForm());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var traloi = MessageBox.Show("Chắc không?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }
    }
}

