using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Integrator
{
    public class Class_Data
    {
        private SqlConnection conn_MsSQL = null;
        private SqlCommand comd_MsSQL = null;
        public SqlDataReader read_MsSQL = null;
        private SqlDataAdapter adap_MsSQL = null;
        public DataSet ds_zrodlo_MsSQL = new DataSet();
        public DataSet ds_cel_MsSQL = new DataSet();
        public string error_db = null;

        public void Connect_MsSQL(string server, string dbname, string login, string pass)
        {
            error_db = null;

            try
            {
                if (login == "" && pass == "") {
                    conn_MsSQL = new SqlConnection("Data Source=" + server + "; Initial Catalog=" + dbname + "; Integrated Security=SSPI");
                } else
                {
                    conn_MsSQL = new SqlConnection("Data Source=" + server + "; Database=" + dbname + "; User ID=" + login + "; Password=" + pass);
                }

                conn_MsSQL.Open();
            }
            catch (SqlException ex)
            {
                error_db = ex.Message;
            }
        }

        public bool isOpen_MsSQL()
        {
            bool test = false;
            error_db = null;

            try
            {
                if (conn_MsSQL != null)
                {
                    if (conn_MsSQL.State == ConnectionState.Open)
                    {
                        test = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                error_db = ex.Message;
            }

            return test;
        }

        public void Close_MsSQL()
        {
            error_db = null;

            try
            {
                if (conn_MsSQL != null)
                {
                    if (conn_MsSQL.State == ConnectionState.Open)
                    {
                        conn_MsSQL.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                error_db = ex.Message;
            }
        }

        public void DS_zrodlo_MsSQL(string query, string tabname)
        {
            error_db = null;

            try
            {
                if (ds_zrodlo_MsSQL.Tables.IndexOf(tabname) != -1)
                {
                    ds_zrodlo_MsSQL.Tables.Remove(tabname);
                }

                comd_MsSQL = new SqlCommand(query, conn_MsSQL);
                adap_MsSQL = new SqlDataAdapter(comd_MsSQL.CommandText, conn_MsSQL);
                adap_MsSQL.Fill(ds_zrodlo_MsSQL, tabname);
                adap_MsSQL.Dispose();
            }
            catch (SqlException ex)
            {
                error_db = ex.Message;
            }
        }

        public void DS_cel_MsSQL(string query, string tabname)
        {
            error_db = null;

            try
            {
                if (ds_cel_MsSQL.Tables.IndexOf(tabname) != -1)
                {
                    ds_cel_MsSQL.Tables.Remove(tabname);
                }

                comd_MsSQL = new SqlCommand(query, conn_MsSQL);
                adap_MsSQL = new SqlDataAdapter(comd_MsSQL.CommandText, conn_MsSQL);
                adap_MsSQL.Fill(ds_cel_MsSQL, tabname);
                adap_MsSQL.Dispose();
            }
            catch (SqlException ex)
            {
                error_db = ex.Message;
            }
        }

        static void PrintDataSet(DataSet ds)
        {
            foreach (DataTable dt in ds.Tables)
            {
                for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
                {
                    System.Diagnostics.Debug.Write(dt.Columns[curCol].ColumnName.Trim() + "\t");
                }
                for (int curRow = 0; curRow < dt.Rows.Count; curRow++)
                {
                    for (int curCol = 0; curCol < dt.Columns.Count; curCol++)
                    {
                        System.Diagnostics.Debug.Write(dt.Rows[curRow][curCol].ToString().Trim() + "\t");
                    }
                    System.Diagnostics.Debug.WriteLine("");
                }
            }

        }

        public void Read_MsSQL(string query)
        {
            error_db = null;

            try
            {
                comd_MsSQL = new SqlCommand(query, conn_MsSQL);
                read_MsSQL = comd_MsSQL.ExecuteReader();
            }
            catch (SqlException ex)
            {
                error_db = ex.Message;

                if (!read_MsSQL.IsClosed)
                {
                    read_MsSQL.Close();
                }
            }
        }

        public int Noread_MsSQL(string query)
        {
            error_db = null;
            int id = 0;

            try
            {
                comd_MsSQL = new SqlCommand(query, conn_MsSQL);
                id = comd_MsSQL.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                error_db = ex.Message;

                if (!read_MsSQL.IsClosed)
                {
                    read_MsSQL.Close();
                }
            }

            return id;
        }

        public int Scalarread_MsSQL(string query)
        {
            error_db = null;
            int id = 0;

            try
            {
                comd_MsSQL = new SqlCommand(query, conn_MsSQL);
                id = Convert.ToInt32(comd_MsSQL.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                error_db = ex.Message;

                if (!read_MsSQL.IsClosed)
                {
                    read_MsSQL.Close();
                }
            }

            return id;
        }

        public void execute_sql_transaction(string query)
        {
            SqlCommand command = conn_MsSQL.CreateCommand();
            SqlTransaction transaction;
            transaction = conn_MsSQL.BeginTransaction("Transaction");

            command.Connection = conn_MsSQL;
            command.Transaction = transaction;

            try
            {
                command.CommandText = query;
                command.ExecuteNonQuery();
                
                transaction.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                Console.WriteLine("  Message: {0}", ex.Message);
                
                try
                {
                    transaction.Rollback();
                }
                catch (Exception ex2)
                {
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
            }

        }

    }
}
