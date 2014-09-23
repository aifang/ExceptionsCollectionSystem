using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.OleDb;
namespace DAL
{
    public class ExceptionsInfoService
    {
        public static List<ExceptionsInfo> FindAll(string whereStr)
        {
            string sql = "select * from exceptionsInfo " + whereStr;
            List<ExceptionsInfo> list = GetValue(sql);
            return list;
        }

        private static List<ExceptionsInfo> GetValue(string sql)
        {
            List<ExceptionsInfo> list = new List<ExceptionsInfo>();
            OleDbDataReader odr = DBHelper.GetReader(sql);
            while (odr.Read())
            {
                ExceptionsInfo ei = new ExceptionsInfo();
                ei.ID = Convert.ToInt32(odr["ID"]);
                ei.UserID = odr["userid"].ToString();
                ei.ProjectID = odr["projectid"].ToString();
                ei.TypeID = odr["typeid"].ToString();
                ei.ExcepitionID = odr["exceptionid"].ToString();
                ei.ExcepitionName = odr["ExceptionName"].ToString();
                ei.ExcepitionDescri = odr["ExceptionDescription"].ToString();
                ei.Solution = odr["solution"].ToString();
                ei.Remarks = odr["remarks"].ToString();
                list.Add(ei);
            }
            odr.Close();
            return list;
        }


        public static List<ExceptionsInfo> FindAll()
        {
            string sql = "select * from exceptionsInfo ";
            List<ExceptionsInfo> list = GetValue(sql);
            return list;
        }

        public static List<ExceptionsInfo> findTop(int num,int pageSize ,string whereStr)
        {
            string sql = string.Format("select top {2} * from exceptionsinfo where {1} and id not in (select top {0} id from  exceptionsinfo where {1} order by id)  order by id", pageSize * (num - 1), whereStr,pageSize);
            List<ExceptionsInfo> list = GetValue(sql);
            return list;
        }

        public static List<ExceptionsInfo> findFirstPage(int pageSize, string whereStr)
        {
            string sql = string.Format("select top {0} * from  exceptionsinfo where {1} order by id", pageSize, whereStr);
            List<ExceptionsInfo> list = GetValue(sql);
            return list;
        }

        public static int returnCount(string whereStr)
        {
            int count=0;
            string sql = "select count (*) as counts from exceptionsinfo where " + whereStr;
            OleDbDataReader odr = DBHelper.GetReader(sql);
            while (odr.Read())
            {
                count =Convert.ToInt32( odr["counts"]);
            }
            odr.Close();
            return count;
        }
    }
}
