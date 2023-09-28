using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) ; instance = new DataProvider(); return instance; }

            private set => instance = value;
        }
        public DataProvider() { }

        private string connectionString = @"Data Source=DESKTOP-77LQJ4S;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";

        #region Cach 1
/*        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(data);
                sqlConnection.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                data = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query)
        {
            object data = 0;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                data = sqlCommand.ExecuteScalar();
                sqlConnection.Close();
            }
            return data;
        }*/
        #endregion


        #region Cach 2

        /*        public DataTable ExecuteQuery(string query, object[] parameter = null)
                {
                    DataTable data = new DataTable();
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand sqlCommand = new SqlCommand(query, connection);

                        if (parameter != null)
                        {
                            string[] listPara = query.Split(',');
                            int i = 0;
                            foreach (string item in listPara)
                            {
                                if (item.Contains('@'))
                                {
                                    sqlCommand.Parameters.AddWithValue(item, parameter[i]);
                                    i++;
                                }
                            }
                        }
                        SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                        adapter.Fill(data);
                        connection.Close();
                    }
                    return data;
                }

                public int ExecuteNonQuery(string query, object[] parameter = null)
                {
                    int data = 0;
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand sqlCommand = new SqlCommand(query, connection);

                        if (parameter != null)
                        {
                            string[] listPara = query.Split(',');
                            int i = 0;
                            foreach (string item in listPara)
                            {
                                if (item.Contains('@'))
                                {
                                    sqlCommand.Parameters.AddWithValue(item, parameter[i]);
                                    i++;
                                }
                            }
                        }
                        data = sqlCommand.ExecuteNonQuery();
                        connection.Close();
                    }
                    return data;
                }
                public object ExecuteScalar(string query, object[] parameter = null)
                {
                    object data = 0;
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand sqlCommand = new SqlCommand(query, connection);

                        if (parameter != null)
                        {
                            string[] listPara = query.Split(',');
                            int i = 0;
                            foreach (string item in listPara)
                            {
                                if (item.Contains('@'))
                                {
                                    sqlCommand.Parameters.AddWithValue(item, parameter[i]);
                                    i++;
                                }
                            }
                        }
                        data = sqlCommand.ExecuteScalar();
                        connection.Close();
                    }
                    return data;
                }*/

        #endregion

        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using(SqlConnection sqlConnection =  new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                sqlConnection.Close();
            }
            return data;
        }

    }
}
