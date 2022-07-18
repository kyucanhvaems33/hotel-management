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

namespace QLKS
{
    public partial class F_LogInOut : Form
    {
        public F_LogInOut()
        {
            InitializeComponent();
            getdataloginout();
        }

        private void getdataloginout()
        {
            string query = "select TK.username,NhanVien.HoTen,listlogintime.login, listlogintime.Logout from listlogintime,NhanVien,TK where NhanVien.MaNV = TK.MaNV and TK.username = listlogintime.username";
            DataTable tb = GetData.getdata(query, true,false);
            dataGridView1.DataSource = tb;
            dataGridView1.Columns[0].HeaderText = "Username";
            dataGridView1.Columns[1].HeaderText = "Họ tên nhân viên";
            dataGridView1.Columns[2].HeaderText = "Log In";
            dataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dataGridView1.Columns[3].HeaderText = "Log Out";
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void F_LogInOut_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {               
                string query = "select TK.username,NhanVien.HoTen,listlogintime.login, listlogintime.Logout from listlogintime,NhanVien,TK where NhanVien.MaNV = TK.MaNV and TK.username = listlogintime.username and listlogintime.login >= @para";
                GetData.com = new SqlCommand(query, GetData.con);
                GetData.com.Parameters.Add("@para", textBox1.Text);
                DataTable tb = GetData.getdata(query, true, true);
                dataGridView1.DataSource = tb;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                getdataloginout();
            }
        }
    }
}
