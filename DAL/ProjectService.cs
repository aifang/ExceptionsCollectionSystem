using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.OleDb;

namespace DAL
{
    public class ProjectService
    {
        public static List<ProjectInfo> fingAll()
        {
            string sql = "select * from Projectinfo";
            List<ProjectInfo> list = getValue(sql);
            return list;
        }

        public static List<ProjectInfo> getValue(string sql)
        {
            List<ProjectInfo> list = new List<ProjectInfo>();
            OleDbDataReader odr = DBHelper.GetReader(sql);
            while (odr.Read())
            {
                ProjectInfo pi = new ProjectInfo();
                pi.ProjectID = Convert.ToInt32(odr["ProjectID"]);
                pi.ProjectName = odr["ProjectName"].ToString();
                pi.Province = odr["Province"].ToString();
                pi.Remarks = odr["remarks"].ToString();
                list.Add(pi);
            }
            odr.Close();
            return list;
        }
        public static string findByID(int id)
        {
            string name = "";
            string sql = "select * from projectinfo where projectid=@ID";
            OleDbParameter[] para = new OleDbParameter[]
            {
                new OleDbParameter("@ID",id)
            };
            OleDbDataReader odr = DBHelper.GetReader(sql, para);
            if (odr.Read())
            {
                name = odr["projectName"].ToString();
                odr.Close();
            }
            return name;
        }

        public static List<int> FindByNameArr(string name)
        {
            List<int> listid = new List<int>();
            string sql = string.Format("select * from projectinfo where projectName like '%{0}%'", name);
            OleDbDataReader odr = DBHelper.GetReader(sql);
            while (odr.Read())
            {
                listid.Add(Convert.ToInt32(odr["projectid"]));
            }
            odr.Close();
            return listid;
        }
    }
}
