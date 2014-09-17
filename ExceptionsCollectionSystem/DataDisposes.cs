using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class DataDisposes
    {
        DataBaseLayer dbl = new DataBaseLayer(@"Provider=Microsoft.Jet.OLEDB.4.0;data source=ExceptionsCollection.mdb", "Access");
        
        /// <summary>
        /// 查询方法
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="columnStr">列名,结构图:column1,column2,column3或*</param>
        /// <param name="whereStr">条件的列名和值.结构如:where key1=value1 and key2=value2</param>
        /// <returns></returns>
        public object Select(string tableName, string columnStr, string whereStr)
        {
            string sql = string.Format("select {0} from {1} {2}", columnStr, tableName, whereStr);
            return dbl.ExecuteQuery(sql);
        }
        /// <summary>
        /// 查询方法
        /// </summary>
        /// <param name="sql">手动完整输入select语句</param>
        /// <returns></returns>
        public object SelectStr(string sql)
        {
            //string sql = string.Format("select {0} from {1} {2}", columnStr, tableName, whereStr);
            return dbl.ExecuteQuery(sql);
        }

        /// <summary>
        /// 添加方法
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="columnValue">列的值</param>
        /// <returns></returns>
        public int Insertsquen(string tableName, string columnValue)
        {
            string sql = string.Format("insert into {0} values ({0}_ID.NEXTVAL,{1})", tableName, columnValue);
            return dbl.ExecuteSql(sql);
        }
        public int Insertfull(string tableName,string columnName, string columnValue)
        {
            string sql = string.Format("insert into {0}({2}) values ({1})", tableName, columnValue,columnName);
            return dbl.ExecuteSql(sql);
        }
        public int Insert(string tableName, string columnValue)
        {
            string sql = string.Format("insert into {0} values ({1})", tableName, columnValue);
            return dbl.ExecuteSql(sql);
        }

        /// <summary>
        /// 更新方法
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="columnStr">列名和列值.结构如:key1=value1,key2=value2</param>
        /// <param name="whereStr">条件的列名和值.结构如:where key1=value1 and key2=value2</param>
        /// <returns></returns>
        public int Update(string tableName, string columnStr, string whereStr)
        {
            string sql = string.Format("update {0} set {1} {2}", tableName, columnStr, whereStr);
            return dbl.ExecuteSql(sql);
        }

        /// <summary>
        /// 删除方法
        /// </summary>
        /// <param name="tableName">表名</param> 
        /// <param name="whereStr">条件的列名和值.结构如:where key1=value1 and key2=value2</param>
        /// <returns></returns>
        public int Delete(string tableName, string whereStr)
        {
            string sql = string.Format("delete  from {0}  {1}", tableName, whereStr);
            return dbl.ExecuteSql(sql);
        }
    }
}
