using QuanLyQuanCafe.DAO;
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

namespace QuanLyQuanCafe
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadAccountList();
            LoadFoodList();     
        }

        #region Function
        void LoadFoodList()
        {
            string query = "select * from dbo.Food";
            DataProvider provider = new DataProvider();
            dtgvFood.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void LoadAccountList()
        {
            string query = "select * from dbo.Account";
            DataProvider provider = new DataProvider();
           // dataGridView4.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] {"nhi", "quynh"});
        }

        #endregion

        private void fAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
