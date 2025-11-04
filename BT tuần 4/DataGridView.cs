using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BT_tuần_4
{
    public partial class DataGridView : Form
    {
        //Chuỗi kết nối
        string strConnectionString = "Data Source = LAPTOP-Q7DB2USJ\\SQLEXPRESS; Initial Catalog = QLBH; Integrated Security=True;TrustServerCertificate=True; User Id =sa; Password = 123456";
        // Đối tượng kết nối dữ liệu
        SqlConnection conn = null;
        // Đối tượng thực hiện vận chuyển dữ liệu  
        SqlDataAdapter da = null;
        // Đối tượng chứa dữ liệu trong bộ nhớ
        DataSet ds = null;

        public DataGridView()
        {
            InitializeComponent();
        }
        
        private void DataGridView_Load(object sender, EventArgs e)
        {
          
            try
            {

                //Khởi động kết nối
                conn = new SqlConnection(strConnectionString);
                //Mở kết nối
                conn.Open();
                // Vận chuyển dữ liệu
                da = new SqlDataAdapter("SELECT * FROM SanPham", conn);
                //Khởi tạo đối tượng chứa dữ liệu
                ds = new DataSet();
                //Đổ dữ liệu vào DataSet
                da.Fill(ds);
                // Đưa dữ liệu lên DataGridView
                dgSanPham.DataSource = ds.Tables[0];

                dgSanPham.Columns[0].HeaderText = "Mã sản phẩm";
                dgSanPham.Columns[1].HeaderText = "Tên sản phẩm";
                dgSanPham.Columns[2].HeaderText = "Đơn vị tính";
                dgSanPham.Columns[3].HeaderText = "Đơn giá";
                dgSanPham.Columns[4].HeaderText = "Mã loại sản phẩm";

            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu, có lỗi rồi!");
            }
            TimKiem(txtKeyWord.Text);


        }
        void TimKiem(string keyword)
        {
            try
            {
                //Khởi tạo kết nối
                conn = new SqlConnection(strConnectionString);
                //Mở kết nối
                conn.Open();

                //Khai báo câu truy vấn
                string sql = "";
                if (keyword != "")
                {
                    sql = "SELECT * FROM SanPham Where TenSP like N'%" + keyword + "%'";
                }
                else
                {
                    sql = "SELECT * FROM SanPham";
                }

                // Vận chuyển dữ liệu vào DataGridView dgSanPham
                da = new SqlDataAdapter(sql, conn);
                ds = new DataSet();
                da.Fill(ds, "ABC");
                dgSanPham.DataSource = ds.Tables["ABC"];

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được dữ liệu, có lỗi rồi!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiem(txtKeyWord.Text);
        }

        private void DataGridView_FormClosing(object sender, FormClosingEventArgs e)
        {
            ds.Dispose();
            ds = null;
            conn.Close();
            conn = null;
        }
    }
}

