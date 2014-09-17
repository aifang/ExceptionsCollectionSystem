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
    }
}
