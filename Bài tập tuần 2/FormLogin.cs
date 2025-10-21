using System.Windows.Forms;

namespace Bài_tập_tuần_2
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
                errorProvider1.SetError(txtUsername, "Vui lòng nhập Username!");
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
                errorProvider1.SetError(txtPassword, "Vui lòng nhập Password!");

            if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                FormDangKySanPham frm = new FormDangKySanPham();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi");
            }
        }

    }

}
