﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class ExceptionsInfoManage
    {
        public static List<ExceptionsInfo> FindAll(string whereStr)
        {
            List<ExceptionsInfo> list = ExceptionsInfoService.FindAll(whereStr );
            return getOriginalInfo(list);
        }

        public static List<ExceptionsInfo> findTop(int num,int pageSize, string whereStr)
        {
            List<ExceptionsInfo> list = ExceptionsInfoService.findTop(num, pageSize, whereStr);
            return getOriginalInfo(list);
        }

        public static List<ExceptionsInfo> findFirstPage(int pageSize, string whereStr)
        {
            List<ExceptionsInfo> list =ExceptionsInfoService.findFirstPage( pageSize,  whereStr);
            return getOriginalInfo(list);
        }

        private static List<ExceptionsInfo> getOriginalInfo(List<ExceptionsInfo> list)
        {
            foreach (ExceptionsInfo e in list)
            {
                string userName = UserInfoManage.FindByID(e.UserID);
                string projectName = ProjectInfoManage.FindByID(e.ProjectID);
                string TypeName = ExceptionsTypeManage.FindByID(e.TypeID);
                e.UserID = userName;
                e.ProjectName = projectName;
                e.TypeID = TypeName;
            }
            return list;
        }

        public static int returnCount(string whereStr)
        {
            return ExceptionsInfoService.returnCount(whereStr);
        }
        
    }
}
