using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_tuần_4
{
    public partial class ComboBox : Form
    {

        // Chuỗi kết nối
        string strConnectionString = "Data Source = LAPTOP-Q7DB2USJ\\SQLEXPRESS; Initial Catalog = QLBH; Integrated Security=True;TrustServerCertificate=True; User Id =sa; Password = 123456";
        // Đối tượng kết nối dữ liệu
        SqlConnection conn = null;
        // Đối tượng thực hiện vận chuyển dữ liệu  
        SqlDataAdapter da = null;
        // Đối tượng chứa dữ liệu trong bộ nhớ
        DataSet ds = null;
        public ComboBox()
        {
            InitializeComponent();
        }
        private void ComboBox_Load(object sender, EventArgs e)
        {
            try
            {

                conn = new SqlConnection(strConnectionString);
                //Mở kết nối
                conn.Open();
                // Vận chuyển dữ liệu
                da = new SqlDataAdapter("SELECT * FROM SanPham", conn);
                //Khởi tạo đối tượng chứa dữ liệu
                ds = new DataSet();
                //Đổ dữ liệu vào DataSet
                da.Fill(ds);

                // Đưa dữ liệu lên ComboBox
                cboSanPham.DataSource = ds.Tables[0];
                cboSanPham.DisplayMember = "TenSP";
                cboSanPham.ValueMember = "MaSP";


            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu, có lỗi rồi!");
            }

        }
        private void ComboBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            ds.Dispose();
            ds = null;
            conn.Close();
            conn = null;

        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK) Application.Exit();
        }
    }
}

