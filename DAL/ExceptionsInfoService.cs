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

        /// <summary>
        /// 返回记录总数
        /// </summary>
        /// <param name="whereStr">查询条件</param>
        /// <returns></returns>
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

        /// <summary>
        /// 更新记录
        /// </summary>
        /// <returns></returns>
        public static bool updateExinfo(int ID,string UserID,string ProjectID,string TypeID,string ExcepitionID,string ExcepitionName,string ExceptionDescri,string Solution,string Remarks)
        {
            string sql = string.Format("update exceptionsinfo set userid='{0}',projectid='{1}',typeid='{2}',exceptionid='{3}',exceptionName='{4}',ExceptionDescription='{5}',Solution='{6}',Remarks='{7}' where id={8}",
                                      UserID, ProjectID, TypeID, ExcepitionID, ExcepitionName, ExceptionDescri, Solution, Remarks, ID);
            try
            {
                DBHelper.ExcuteCommand(sql);
            }
            catch
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 获取某个异常类型的最大编号
        /// </summary>
        /// <param name="exid"></param>
        /// <returns></returns>
        public static string getMaxExInfoID(string exid)
        {
            string sql = "select max(exceptionid) as idmax from exceptionsinfo where exceptionid in(select exceptionid from exceptionsinfo where exceptionid like '" + exid + "%')";
            try
            {
                OleDbDataReader odr = DBHelper.GetReader(sql);
                while (odr.Read())
                {
                    string strID = odr["idmax"].ToString();
                    if (strID != "")
                    {
                         int num = Convert.ToInt32(strID.Substring(strID.LastIndexOf('-') + 1)) + 1;
                         exid += num.ToString();
                    }
                    else
                    {
                        exid += '1';
                    }
                }
                odr.Close();
            }
            catch
            {
                return exid;
            }
            return exid;
        }
    }
}
