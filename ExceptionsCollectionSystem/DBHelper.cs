using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Configuration;

namespace DAL
{
    public static class DBHelper
    {
        private static OleDbConnection connection;
        private static readonly string connstr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ExceptionsCollection.mdb;Persist Security Info=False;";
        /// <summary>
        /// 获取连接
        /// </summary>
        public static OleDbConnection  Connection
        {
            get 
            {
                if (connection == null)
                {
                    connection = new OleDbConnection(connstr);
                    connection.Open();
                }
                else if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                else if (connection.State == ConnectionState.Broken)
                {
                    connection.Close();
                    connection.Open();
                }
                return connection;
            }
        }
        public static int ExcuteCommand(string safeSql)
        {
            OleDbCommand cmd = new OleDbCommand(safeSql, Connection);
            int result = cmd.ExecuteNonQuery();
            return result;
        }
        public static int ExcuteCommand(string sql, params OleDbParameter[] values)
        {
            OleDbCommand cmd = new OleDbCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            int result = cmd.ExecuteNonQuery();
            return result;
        }
        public static OleDbDataReader GetReader(string safeSql)
        {
            OleDbCommand cmd = new OleDbCommand(safeSql, Connection);
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public static OleDbDataReader GetReader(string safeSql, params OleDbParameter[] values)
        {
            OleDbCommand cmd = new OleDbCommand(safeSql, Connection);
            cmd.Parameters.AddRange(values);
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public static DataTable GetDataSet(string safeSql)
        {
            DataSet ds = new DataSet();
            OleDbCommand cmd = new OleDbCommand(safeSql, Connection);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds);
            return ds.Tables[0];
        }
        public static DataTable GetDataSet(string sql, params OleDbParameter[] values)
        {
            DataSet ds = new DataSet();
            OleDbCommand cmd = new OleDbCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
