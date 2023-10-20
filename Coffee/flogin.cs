using System.Data;
using System.Windows.Forms;

namespace Coffee
{
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();
        
        private void button1_Click(object sender, System.EventArgs e)
        {
            string usernameC = textusername.Text;
            string passwordC = textpassword.Text;
            if (usernameC.Trim() == "") { MessageBox.Show("Vui lòng nhập tài khoản!"); }
            else if (passwordC.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu!"); }
            else
            {
                DataTable data = DataProvider.Instance.ExecuteQuery("sp_login @tk , @mk ",new object[] { usernameC , passwordC });
                if (data.Rows.Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    fHome h = new fHome(data.Rows[0]["name"].ToString(), (int)data.Rows[0]["admin"], (int)data.Rows[0]["idpos"], (int)data.Rows[0]["id"]);
                    h.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void loginform_Load(object sender, System.EventArgs e)
        {

        }


        private void loginform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
