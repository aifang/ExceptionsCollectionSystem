using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Model;

namespace DAL
{
    public class UserInfoService
    {
        public static List<UserInfo> FindAll()
        {
            string sql = "select * from UserInfo";
            List<UserInfo> list = getValue(sql);
            return list;
        }

        public static List<UserInfo> getValue(string sql)
        {
            List<UserInfo> list = new List<UserInfo>();
            OleDbDataReader odr = DBHelper.GetReader(sql);
            while (odr.Read())
            {
                UserInfo ui = new UserInfo();
                ui.UserID = Convert.ToInt32(odr["userid"]);
                ui.UserName = odr["username"].ToString();
                ui.Province = odr["Province"].ToString();
                ui.Phone = odr["phone"].ToString();
                ui.Remarks = odr["remarks"].ToString();
                list.Add(ui);
            }
            odr.Close();
            return list;
        }

        public static string findByID(int id)
        {
            string name = "";
            string sql = "select * from userinfo where userID=@ID";
            OleDbParameter[] para = new OleDbParameter[]
            {
                new OleDbParameter("@ID",id)
            };
            OleDbDataReader odr = DBHelper.GetReader(sql, para);
            if (odr.Read())
            {
                name = odr["UserName"].ToString();
                odr.Close();
            }
            return name;
        }
        public static int FindByName(string name)
        {
            //string sql = "select * from userinfo where userName='" + name1 + "'";
            int userid = -1;
            string sql = "select * from userinfo where userName=@userName";
            OleDbParameter[] para = new OleDbParameter[]
            {
                new OleDbParameter("@userName",name)
            };
            OleDbDataReader odr = DBHelper.GetReader(sql, para);
            if (odr.Read())
            {
                userid = Convert.ToInt32(odr["userid"]);
                odr.Close();
            }
            return userid;
        }
        /// <summary>
        /// 返回用户ID数组（模糊查询）
        /// </summary>
        /// <param name="name">用户名</param>
        /// <returns></returns>
        public static List<int> FindByNameArr(string name)
        {
            List<int> userid=new List<int> ();
            string sql = string.Format("select * from userinfo where userName like '%{0}%'", name);
            OleDbDataReader odr = DBHelper.GetReader(sql);
            while(odr.Read())
            {
                userid.Add(Convert.ToInt32(odr["userid"]));
            }
            odr.Close();
            return userid;
        }
    }
}
