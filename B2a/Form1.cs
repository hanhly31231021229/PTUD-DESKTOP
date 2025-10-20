using System.Windows.Forms;

namespace B2a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
                errorProvider1.SetError(txtUsername, "Vui lòng nhập tên đăng nhập!");
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
                errorProvider1.SetError(txtPassword, "Vui lòng nhập mật khẩu!");

            if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            {
                MessageBox.Show("Đăng nhập thành công!");
                new Form2().Show();
                this.Hide();
            }
            else if (!string.IsNullOrWhiteSpace(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
