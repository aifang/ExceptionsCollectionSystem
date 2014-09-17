using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Model;

namespace DAL
{
    public class ExceptionsTypeService
    {
        public static List<ExceptionsType> FindAll()
        {
            string sql = "select * from ExceptionsType";
            List<ExceptionsType> list = getValue(sql);
            return list;
        }

        public static List<ExceptionsType> getValue(string sql)
        {
            List<ExceptionsType> list = new List<ExceptionsType>();
            OleDbDataReader odr = DBHelper.GetReader(sql);
            while (odr.Read())
            {
                ExceptionsType et = new ExceptionsType();
                et.TypeID = Convert.ToInt32(odr["TypeID"]);
                et.TypeName = odr["TypeName"].ToString();
                et.Category = odr["Category"].ToString();
                et.Remarks = odr["remarks"].ToString();
                list.Add(et);
            }
            odr.Close();
            return list;
        }

        public static string findByID(int id)
        {
            string name = "";
            string sql = "select * from ExceptionsType where TypeID=@ID";
            OleDbParameter[] para = new OleDbParameter[]
            {
                new OleDbParameter("@ID",id)
            };
            OleDbDataReader odr = DBHelper.GetReader(sql, para);
            if (odr.Read())
            {
                name = odr["typeName"].ToString();
                odr.Close();
            }
            return name;
        }

        public static List<int> FindByNameArr(string name)
        {
            List<int> userid = new List<int>();
            string sql = string.Format("select * from exceptionstype where typename like '%{0}%'", name);
            OleDbDataReader odr = DBHelper.GetReader(sql);
            while (odr.Read())
            {
                userid.Add(Convert.ToInt32(odr["typeid"]));
            }
            odr.Close();
            return userid;
        }
    }
}
