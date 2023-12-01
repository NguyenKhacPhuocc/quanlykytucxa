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
using System.Configuration;

namespace WindowsFormsApp3
{
    public partial class quarlithuvien : Form
    {
        // khai bao bien toan cuc
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);


        public quarlithuvien()
        {
            InitializeComponent();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            //b1 laay du lieu dua vao bien
            //string p_manxb = txtmanxb.Text.Trim();
            string p_maloai= txtmaloai.Text.Trim();
            string p_tenloai= txttenloai.Text.Trim();
            string p_mota= txtmota.Text.Trim();

            //b2 knoi den db
            if (con.State == ConnectionState.Closed)
                con.Open();

            //b3 tao doi tuong command de chen du lieu vao bang loai sach
            string sql = "insert into loaisach values('" + p_maloai + "','" + p_tenloai + "','" + p_mota + "')";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            MessageBox.Show("them thanh cong");
        }
    }
}
