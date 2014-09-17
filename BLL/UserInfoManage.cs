using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class UserInfoManage
    {
        public static List<UserInfo> FindAll()
        {
            return UserInfoService.FindAll();
        }
        public static string FindByID(string id)
        {
            int newID = Convert.ToInt32(id);
            return UserInfoService.findByID(newID);
        }
        public static int FindByName(string name)
        {
            return UserInfoService.FindByName(name);
        }
        public static List<int> FindByNameArr(string name)
        {
            return UserInfoService.FindByNameArr(name);
        }
    }
}
