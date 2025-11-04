using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BT_tuần_4
{

    public partial class Form1 : Form
    {
        // Chuỗi kết nối
        string strConnectionString = "Data Source = LAPTOP-Q7DB2USJ\\SQLEXPRESS; Initial Catalog = QLBH; Integrated Security=True;TrustServerCertificate=True ";
        // Đối tượng kết nối dữ liệu
        SqlConnection conn = null;
        // Đối tượng thực hiện vận chuyển dữ liệu  
        SqlDataAdapter da = null;
        // Đối tượng chứa dữ liệu trong bộ nhớ
        DataSet ds = null;
        // Khởi động kết nối

        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(strConnectionString);
            //Mở kết nối 
            conn.Open();
            // Vận chuyển dữ liệu vào đối tượng DataSet ds
            da = new SqlDataAdapter("SELECT * FROM HoaDon", conn);
            ds = new DataSet();
            da.Fill(ds);
            da = new SqlDataAdapter("SELECT * FROM ChiTietHoaDon", conn);
            ds = new DataSet();
            da.Fill(ds);
            da = new SqlDataAdapter("SELECT * FROM KhachHang", conn);
            ds = new DataSet();
            da.Fill(ds);
            da = new SqlDataAdapter("SELECT * FROM LoaiSanPham", conn);
            ds = new DataSet();
            da.Fill(ds);
            da = new SqlDataAdapter("SELECT * FROM NhanVien", conn);
            ds = new DataSet();
            da.Fill(ds);
            da = new SqlDataAdapter("SELECT * FROM SanPham", conn);
            ds = new DataSet();
            da.Fill(ds);


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên 
            ds.Dispose();
            ds = null;
            // Đóng và hủy kết nối
            conn.Close();
            conn = null;
        }
    }
}

