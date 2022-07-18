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
    public partial class F_QLTK : Form
    {
        private int count = 0;
        // 1 la them - 2 la sua
        public F_QLTK()
        {
            InitializeComponent();
            getdataview();
            BindDataMaNV();
        }

        private void getdataview()
        {
            string query = "select * from TK";
            //GetData.con.Open();
            //GetData.com = new SqlCommand(query, GetData.con);
            //string user = F_LogIn.TK.user;
            //GetData.com.Parameters.Add("@user", user);
            F_QLTK_V.DataSource = GetData.getdata(query, true,false);
            F_QLTK_V.Columns[0].HeaderText = "Username";
            F_QLTK_V.Columns[1].HeaderText = "Password";
            F_QLTK_V.Columns[2].HeaderText = "Mã nhân viên";
            F_QLTK_V.Columns[3].HeaderText = "Quyền";
            F_QLTK_V.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            F_QLTK_V.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            //MessageBox.Show(GetData.getdata(query).Columns.Count+"");

        }

        private void BindDataMaNV()
        {
            string query = "select MaNV,HoTen from NhanVien";
            cb_manv.DataSource = GetData.getdata(query, false, false);
            cb_manv.DisplayMember = "HoTen";
            cb_manv.ValueMember = "MaNV";
            //MessageBox.Show(cb_manv.Items.Count + "");
        }

        private void cleardata()
        {
            tb_pass.Text = "";
            cb_manv.SelectedItem = null;
            cb_quyen.SelectedItem = null;
        }

        private void F_QLTK_Load(object sender, EventArgs e)
        {
            F_QLTK_V.CurrentCell = null;
            tb_user.Text = "";
            cleardata();
            //MessageBox.Show(F_QLKH_V.CurrentRow.Index + "");
            foreach (DataGridViewColumn item in F_QLTK_V.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            F_QLTK_Sua.Enabled = false;
            F_QLTK_Xoa.Enabled = false;
        }
        private void F_QLTK_V_SelectionChanged(object sender, EventArgs e)
        {
            tb_user.Text = F_QLTK_V.CurrentRow.Cells[0].Value + "";
            tb_pass.Text = F_QLTK_V.CurrentRow.Cells[1].Value + "";
            RefreshData();
            F_QLTK_Sua.Enabled = true;
            F_QLTK_Xoa.Enabled = true;
        }

        private void RefreshData()
        {
            switch (F_QLTK_V.CurrentRow.Cells[3].Value.ToString())
            {
                case "ADMIN":
                    {
                        cb_quyen.SelectedIndex = 0;
                        break;
                    }
                case "NHÂN VIÊN":
                    {
                        cb_quyen.SelectedIndex = 1;
                        break;
                    }
            }
            
            for (int i = 0; i < cb_manv.Items.Count; i++)
            {
                DataRowView item = cb_manv.Items[i] as DataRowView;
                int id;
                if (item != null)
                {
                    id = Convert.ToInt32(item.Row["MaNV"]);
                    if (id.ToString() == F_QLTK_V.CurrentRow.Cells[2].Value.ToString())
                    {
                        cb_manv.SelectedIndex = i;
                    }
                }
            }
        }

        private bool ContainsUnicodeCharacter(string input)
        {
            const int MaxAnsiCode = 127;

            return input.Any(c => c > MaxAnsiCode);
        }

        private void F_QLTK_Them_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                F_QLTK_Thoat.Text = "Huỷ";
                tb_user.Text = "";
                cleardata();
                tb_user.Enabled = true;
                F_QLTK_V.Enabled = false;
                tb_pass.Enabled = true;
                cb_manv.Enabled = true;
                cb_quyen.Enabled = true;
                F_QLTK_Sua.Enabled = false;
                F_QLTK_Xoa.Enabled = false;
                count = 1;
            }
            else if (count == 1)
            {
                string query = "SELECT CAST(COUNT(1) AS BIT) AS Expr1 FROM TK WHERE username = @user";
                GetData.con.Open();
                GetData.com = new SqlCommand(query, GetData.con);
                GetData.com.Parameters.Add("@user", tb_user.Text);
                bool ss = GetData.testdata(false);
                if (tb_user.Text == "" || tb_pass.Text == "" || cb_manv.SelectedItem == null || cb_quyen.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!!!");
                }
                else if (ContainsUnicodeCharacter(tb_user.Text))
                {
                    MessageBox.Show("Username không được có dấu!!!");
                }
                else if (tb_user.Text.Any(Char.IsWhiteSpace))
                {
                    MessageBox.Show("Username không được có khoảng trống!!!");
                }
                else if (tb_pass.Text.Any(Char.IsWhiteSpace))
                {
                    MessageBox.Show("Password không được có khoảng trống!!!");
                }
                else if (ss)
                {
                    MessageBox.Show("Đã tồn tại Username trong CSDL!!");
                }
                else
                {
                    if (askadd(Convert.ToInt32(cb_manv.SelectedValue)))
                    {
                        DialogResult a = MessageBox.Show(null, "Nhân viên " + cb_manv.Text + " đã có tài khoản trong cơ sở dữ liệu.\nBạn có muốn thêm tiếp không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (a == DialogResult.OK)
                        {
                            query = "insert into TK (username,pass,MaNV,Quyen) values (@user,@pass,@manv,@quyen)";
                            GetData.con.Open();
                            GetData.com = new SqlCommand(query, GetData.con);
                            GetData.com.Parameters.Add("@user", tb_user.Text);
                            GetData.com.Parameters.Add("@pass", tb_pass.Text);
                            GetData.com.Parameters.Add("@manv", Convert.ToInt32(cb_manv.SelectedValue));
                            GetData.com.Parameters.Add("@quyen", cb_quyen.Text);
                            GetData.putdata();
                            MessageBox.Show("Thêm tài khoản thành công!!", "Thông báo");
                            getdataview();
                            count = 0;
                            F_QLTK_Thoat.Text = "Thoát";
                            //F_QLTK_V.CurrentCell = F_QLTK_V.Rows[F_QLTK_V.RowCount - 1].Cells[0];
                            for (int i = 0; i < F_QLTK_V.RowCount; i++)
                            {
                                if (F_QLTK_V.Rows[i].Cells[0].ToString() == tb_user.Text)
                                {
                                    F_QLTK_V.CurrentCell = F_QLTK_V.Rows[i].Cells[0];
                                }
                            }
                            selectAfterDo();
                            F_QLTK_V.Enabled = true;

                        }

                    }
                    else
                    {
                        query = "insert into TK (username,pass,MaNV,Quyen) values (@user,@pass,@manv,@quyen)";
                        GetData.con.Open();
                        GetData.com = new SqlCommand(query, GetData.con);
                        GetData.com.Parameters.Add("@user", tb_user.Text);
                        GetData.com.Parameters.Add("@pass", tb_pass.Text);
                        GetData.com.Parameters.Add("@manv", Convert.ToInt32(cb_manv.SelectedValue));
                        GetData.com.Parameters.Add("@quyen", cb_quyen.Text);
                        GetData.putdata();
                        MessageBox.Show("Thêm tài khoản thành công!!", "Thông báo");
                        getdataview();
                        count = 0;
                        F_QLTK_Thoat.Text = "Thoát";
                        //F_QLTK_V.CurrentCell = F_QLTK_V.Rows[F_QLTK_V.RowCount - 1].Cells[0];
                        for (int i = 0; i < F_QLTK_V.RowCount; i++)
                        {
                            if (F_QLTK_V.Rows[i].Cells[0].ToString() == tb_user.Text)
                            {
                                F_QLTK_V.CurrentCell = F_QLTK_V.Rows[i].Cells[0];
                            }
                        }
                        selectAfterDo();
                        F_QLTK_V.Enabled = true;
                    }

                }
            }
        }

        private void selectAfterDo()
        {
            if (F_QLTK_V.CurrentCell == null)
            {
                cleardata();
            }
            else
            {
                tb_user.Text = F_QLTK_V.CurrentRow.Cells[0].Value.ToString();
                tb_pass.Text = F_QLTK_V.CurrentRow.Cells[1].Value.ToString();
                RefreshData();
                tb_user.Enabled = false;
                tb_pass.Enabled = false;
                cb_manv.Enabled = false;
                cb_quyen.Enabled = false;
            }
        }

        private bool askadd(int value)
        {
            string query = "SELECT CAST(COUNT(1) AS BIT) AS Expr1 FROM TK WHERE MaNV = @manv";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@manv", value);
            bool ss = GetData.testdata(false);
            return ss;

        }

        private void F_QLTK_Sua_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                F_QLTK_Thoat.Text = "Huỷ";
                tb_pass.Enabled = true;
                F_QLTK_V.Enabled = false;
                tb_user.Enabled = true;
                cb_manv.Enabled = true;
                cb_quyen.Enabled = true;
                F_QLTK_Xoa.Enabled = false;
                F_QLTK_Them.Enabled = false;
                count = 2;
            }
            else if (count == 2)
            {
                if (tb_user.Text == "" || tb_pass.Text == "" || cb_manv.SelectedItem == null || cb_quyen.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!!!");
                }
                else
                {

                    string query = "update TK set pass = @pass, MaNV = @ma, Quyen = @quyen Where username = @user1";
                    GetData.con.Open();
                    GetData.com = new SqlCommand(query, GetData.con);
                    GetData.com.Parameters.Add("@pass", tb_pass.Text);
                    GetData.com.Parameters.Add("@ma", Convert.ToInt32(cb_manv.SelectedValue));
                    GetData.com.Parameters.Add("@quyen", cb_quyen.SelectedItem);
                    GetData.com.Parameters.Add("@user1", F_QLTK_V.CurrentRow.Cells[0].Value.ToString());
                    //GetData.com.Parameters.Add("@user", tb_user.Text);
                    GetData.putdata();
                    int id = F_QLTK_V.CurrentRow.Index;
                    MessageBox.Show("Sửa tài khoản thành công!!", "Thông báo");
                    getdataview();
                    F_QLTK_V.CurrentCell = F_QLTK_V.Rows[id].Cells[0];
                    count = 0;
                    F_QLTK_Thoat.Text = "Thoát";
                    F_QLTK_Them.Enabled = true;
                    F_QLTK_V.Enabled = true;
                    selectAfterDo();

                }
            }
        }

        private void F_QLTK_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xoá tài khoản đã chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM TK WHERE username = @user";
                    GetData.con.Open();
                    GetData.com = new SqlCommand(query, GetData.con);
                    //GetData.com.Parameters.Add("@user", F_QLTK_V.CurrentRow.Cells[0].ToString());
                    GetData.com.Parameters.Add("@user", F_QLTK_V.CurrentRow.Cells[0].Value);
                    if (GetData.putdata() == 1)
                    {
                        MessageBox.Show("Xoá tài khoản thành công!!");
                        getdataview();
                        F_QLTK_V.CurrentCell = null;
                        tb_user.Text = "";
                        cleardata();
                        F_QLTK_Xoa.Enabled = false;
                        F_QLTK_Sua.Enabled = false;
                    }
                }catch(Exception)
                {
                    MessageBox.Show("Lỗi!!");
                    GetData.con.Close();
                }
     
            }
        }

        private void F_QLTK_Thoat_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                F_QLTK_V.CurrentCell = null;
                tb_pass.Enabled = false;
                tb_user.Enabled = false;
                cb_manv.Enabled = false;
                cb_quyen.Enabled = false;
                F_QLTK_Sua.Enabled = false;
                F_QLTK_Xoa.Enabled = false;
                F_QLTK_V.Enabled = true;
                //F_QLKH_V.CurrentCell = null;
                count = 0;
                F_QLTK_Thoat.Text = "Thoát";
                tb_user.Text = "";
                selectAfterDo();
            }
            else if (count == 2)
            {
                tb_user.Enabled = false;
                tb_pass.Enabled = false;
                cb_manv.Enabled = false;
                cb_quyen.Enabled = false;
                //F_QLP_Sua.Enabled = true;
                F_QLTK_V.Enabled = true;
                F_QLTK_Xoa.Enabled = true;
                F_QLTK_Them.Enabled = true;
                count = 0;
                F_QLTK_Thoat.Text = "Thoát";
                selectAfterDo();
            }
            else this.Dispose();
        }
    }
}
