using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using DAL;

namespace ExceptionsCollectionSystem.common
{
    class common
    {
        //private DataDisposes dataDisposes = new DataDisposes();//全局数据库链接 
        //private TreeNode RefreshTree(int type)
        //{
        //    //TreeNode node1;
        //    DataTable provinceTable;
        //    DataTable nameTable;
        //    switch (type)
        //    {
        //        case 0:
        //            provinceTable = (DataTable)dataDisposes.Select("userinfo", "province", "");
        //            nameTable = (DataTable)dataDisposes.Select("userinfo", "username ,userid", "where province='" + node1.Text + "'");
        //            break;
        //        case 1:
        //            break;

        //    }

        //    ArrayList arrProvince = new ArrayList();
        //    for (int i = 0; i < provinceTable.Rows.Count; i++)
        //    {
        //        if (arrProvince.Contains(provinceTable.Rows[i][0].ToString()) == false)
        //        {
        //            arrProvince.Add(provinceTable.Rows[i][0].ToString());
        //        }
        //    }
        //    TreeNode node0 = new TreeNode();
        //    node0.Text = "用户列表";

        //    for (int i = 0; i < arrProvince.Count; i++)
        //    {
        //        TreeNode node1 = new TreeNode();
        //        node1.Text = arrProvince[i].ToString();
        //        for (int j = 0; j < nameTable.Rows.Count; j++)
        //        {
        //            TreeNode node2 = new TreeNode();
        //            node2.Text = nameTable.Rows[j][0].ToString();
        //            node2.Tag = nameTable.Rows[j]["userid"];
        //            node1.Nodes.Add(node2);
        //        }
        //        node0.Nodes.Add(node1);
        //    }
        //    return node0;
        //}
    }
}
