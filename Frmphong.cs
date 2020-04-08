using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace quanlykhachsan
{
    
    public partial class Frmphong : Form
    {
        SqlConnection con = new SqlConnection();
        public Frmphong()
        {
            InitializeComponent();
        }

        private void tenphong_Click(object sender, EventArgs e)
        {

        }

        private void Frmphong_Load(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=quanlykhachsan;Integrated Security=True";
            con.ConnectionString = connectionstring;
            con.Open();
            string SQL = "select * from phong";
            SqlDataAdapter dataadp = new SqlDataAdapter(SQL, con);
            DataTable tblPhong = new DataTable();
            dataadp.Fill(tblPhong);
            dataGridView1.DataSource = tblPhong;
            LoadDaTa();

           
        }
        private void LoadDaTa()
        {
           
            string SQL = "select * from phong";
            SqlDataAdapter dataadp = new SqlDataAdapter(SQL, con);
            DataTable tblPhong = new DataTable();
            dataadp.Fill(tblPhong);
            dataGridView1.DataSource = tblPhong;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaphong.Text = dataGridView1.CurrentRow.Cells["maphong"].Value.ToString();
            txttenphong.Text = dataGridView1.CurrentRow.Cells["tenphong"].Value.ToString();
            txtdonggia.Text = dataGridView1.CurrentRow.Cells["donggia"].Value.ToString();
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            txtmaphong.Text = "";
            txttenphong.Text = "";
            txtdonggia.Text = "";
        }

        private void sua_Click(object sender, EventArgs e)
        {
            string SQL;
            SQL = " Update phong Set tenphong=N'" + txttenphong.Text + "',donggia=N'" + txtdonggia.Text + "'" +
            "Where maphong=N'" + txtmaphong.Text + "'";
            
            SqlCommand com = new SqlCommand(SQL, con);
            com.ExecuteNonQuery();
            
            LoadDaTa();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string SQL = "Delete from phong where maphong='" + txtmaphong.Text + "'";
            SqlCommand command = new SqlCommand(SQL, con);
            command.ExecuteNonQuery();

            LoadDaTa();
        }

        private void luu_Click(object sender, EventArgs e)
        {

            string SQL;
            SQL = "select maphong from phong WHere maphong='" + txtmaphong.Text + "'";
            SqlDataAdapter adap = new SqlDataAdapter(SQL, con);
            DataTable tbphong = new DataTable();
            adap.Fill(tbphong);
            if (tbphong.Rows.Count > 0)
            {
                MessageBox.Show("mã phòng này đã tồn tại");
                txtmaphong.Focus();
                return;
            }
            SQL = "insert into phong Values('" + txtmaphong.Text + "','" + txttenphong.Text + "'";
            if (txtdonggia.Text != "")
                SQL = SQL + "," + txtdonggia.Text.Trim();
            SQL = SQL + ")";
            SqlCommand command = new SqlCommand(SQL, con);
            command.ExecuteNonQuery();
            
            LoadDaTa();
            
            
            

        }

        private void huy_Click(object sender, EventArgs e)
        {
            huy.Enabled = false;
            bntThem.Enabled = true;
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
            
           
        }

        private void txtdonggia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13)))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }   
            
            
    }
}
