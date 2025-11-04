using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_tuần_4
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            this.Text = "About";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(400, 200);
            this.BackColor = Color.White;

            Label lblInfo = new Label();
            lblInfo.Text = "Tên: Lý Hồ Hiếu Hạnh\nMSSV: 31231021229";
            lblInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            lblInfo.Dock = DockStyle.Fill;

            this.Controls.Add(lblInfo);
        }

    }
     
}
