using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        #region Login function
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = textBox2.Text;
            string password = textBox1.Text;
            if (Login(userName, password))
            {
                this.Hide();
                fTableManager f = new fTableManager();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu!");
            }
            
        }
        bool Login(string userName, string passWord) => AccountDAO.Instance.Login(userName,passWord);
 

        #endregion
         
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
