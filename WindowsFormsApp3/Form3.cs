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
    public partial class formcapnhatnxb : Form

    {// khai bao bien toan cuc
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        public formcapnhatnxb()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Load_dgvNhaxuatban()
        {
            //b1 ket noi den db
            if (con.State == ConnectionState.Closed)
                con.Open();
            //b2 tao doi tuong command de lay du lieu tu bang nxb
            string sql = "select * from bangnxb";
            SqlCommand cmd = new SqlCommand(sql, con);

            //b3 tao doi tuong data adapter de lay dl tu command
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            //b4 ddo dl tu dataadapter vafo data table
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            //b5 hienthi datatable len datagrigview
            dgvds.DataSource = tb;
            dgvds.Refresh();
        
        
}
        private bool checktrungma(string p_manxb)
        {
            //b1 ketnoi db
            //con la bien ket noi
            if(con.State == ConnectionState.Closed)
                con.Open();
            //b2 tao doi tuong command
            string sql = "select count(*) from bangnxb where manxb='" + p_manxb + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            int kq= (int)cmd.ExecuteScalar();
            cmd.Dispose();
            con.Close() ;
            if(kq>0)return true;
            else return false;
        }   
        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                //b1 lat dl tu control dua vao bien

                string p_manxb = txtmanxb.Text.Trim();
                string p_tennxb = txttennxb.Text.Trim();
                string p_dienthoai = txtdienthoai.Text.Trim();
                string p_email = txtemail.Text.Trim();
                string p_diachi = txtdiachi.Text.Trim();
                string p_ghichu = txtghichu.Text.Trim();
                // kiemtra du lieu trong c1
                if (p_manxb == "")
                {
                    MessageBox.Show("ma nxb k dc rong");
                    txtmanxb.Focus();
                    return;
                }
                // c2 if(string.isnullor emmty(p_tennxb)){
                //messagenox.show("ten k dc rong");
                //txtmanxb.Focus() ;
                return;
                // }
                // kiemtra trung khoa chinh
                if (checktrungma(p_manxb))
                {
                    MessageBox.Show("ma nha xuat ban da ton tai");
                    txtmanxb.Focus();
                    return;
                }
                //b2 ket noi den db
                if (con.State == ConnectionState.Closed)
                    con.Open();
                //b3 tao doi tuong de chen du lieu vao bangnxb and thuc thi
                //casch 1 dong 67-68string sql = "insert bangnxb values('"+p_manxb+"',N'"+p_tennxb+"',N'"+p_dienthoai+"','"+p_email+"','"+p_diachi+"','"+p_ghichu+"')";
                //SqlCommand cmd = new SqlCommand(sql,con);
                //cach 2 dai bome 70-77
                string sql = "insert bangnxb values(@manxb,@tennxb,@dienthoai,@email,@diachi,@ghichu)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@manxb", SqlDbType.NVarChar, 50).Value = p_manxb;
                cmd.Parameters.Add("@tennxb", SqlDbType.NVarChar, 50).Value = p_tennxb;
                cmd.Parameters.Add("@dienthoai", SqlDbType.NVarChar, 50).Value = p_dienthoai;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = p_email;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 50).Value = p_diachi;
                cmd.Parameters.Add("@ghichu", SqlDbType.NVarChar, 50).Value = p_ghichu;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("them moi thanh cong");
                Load_dgvNhaxuatban();
                
            }
            catch
            {
                MessageBox.Show("loi hej thong  goi qtri vien");
            }
        }

        private void dgvds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmanxb.Text = dgvds.Rows[i].Cells[0].Value.ToString();
            txttennxb.Text = dgvds.Rows[i].Cells[1].Value.ToString();
            txtdienthoai.Text = dgvds.Rows[i].Cells[2].Value.ToString();
            txtemail.Text = dgvds.Rows[i].Cells[3].Value.ToString();
            txtdiachi.Text = dgvds.Rows[i].Cells[4].Value.ToString();
            txtghichu.Text = dgvds.Rows[i].Cells[5].Value.ToString();
        }

        private void txtmanxb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
