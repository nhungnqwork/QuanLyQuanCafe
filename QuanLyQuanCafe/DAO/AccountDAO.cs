﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class AccountDAO
    {
        public AccountDAO() { }
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get { if (instance == null) ; instance = new AccountDAO(); return instance; }
            private set => instance = value; 
        }

        #region Login
        public bool Login(string userName, string passWord)
        {
            string query = "select * from dbo.Account where UserName = N'" + userName + "' and PassWord = N'"+ passWord + "'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        #endregion
    }
}
