using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class ExceptionsTypeManage
    {
        public static List<ExceptionsType> fingAll()
        {
            return ExceptionsTypeService.FindAll();
        }
        public static string FindByID(string id)
        {
            int newID = Convert.ToInt32(id);
            return ExceptionsTypeService.findByID(newID);
        }
        public static List<int> FindByNameArr(string name)
        {
            return ExceptionsTypeService.FindByNameArr(name);
        }

        /// <summary>
        /// 通过类型名称获取类型Id
        /// </summary>
        /// <param name="typeName">类型名称</param>
        /// <returns>ID</returns>
        public static string getIDbyName(string typeName)
        {
            return ExceptionsTypeService.getIDbyName(typeName);
        }
    }
}
