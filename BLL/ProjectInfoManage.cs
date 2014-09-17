using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
namespace BLL
{
    public class ProjectInfoManage
    {
        public static List<ProjectInfo> fingAll()
        {
            return ProjectService.fingAll();
        }
        public static string FindByID(string id)
        {
            int newID = Convert.ToInt32(id);
            return ProjectService.findByID(newID);
        }
        public static List<int> FindByNameArr(string name)
        {
            return ProjectService.FindByNameArr(name);
        }
    }
}
