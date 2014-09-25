using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using DAL;
using Model;
using BLL;
using myDLL;

using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geometry;

namespace ExceptionsCollectionSystem
{
    public partial class mapShow : Form
    {
        public mapShow()
        {
            InitializeComponent();
            turnPaper1.OnPageIndexChange += new Component.turnPaper.OnPageIndexChangeDelegate(turnPage);
        }

        string tableName = null;
        string column = null;
        string columnID = null;
        int count = 0;
        int _pageSize = 10;
        int _pageIndex = 0;

        IElement pEleTemp = null;
        Button btnTemp = null;
        
        List<Button> listbtn = new List<Button>();


        #region  控件事件

        //窗体创建
        private void mapShow_Load(object sender, EventArgs e)
        {

            IWorkspace pWorkspace = myDLL.WorkspaceHelper.GetFGDBWorkspace(@"California.gdb");
            if (pWorkspace != null)
            {
                IList<IFeatureLayer> pLayers = (myDLL.LayerHelper.getFeatureLayersFromWorkspace(pWorkspace));
                if (pLayers.Count != 0)
                {
                    foreach (IFeatureLayer item in pLayers)
                        axMapControl1.AddLayer(item);
                }
                axMapControl1.Extent = axMapControl1.FullExtent;
            }
        }

        //左侧结果栏显示隐藏按钮
        private void picShowresult_Click(object sender, EventArgs e)
        {
            Bitmap imageShow = new Bitmap(Application.StartupPath + @"\Resources\show.jpg");
            Bitmap imageun = new Bitmap(Application.StartupPath + @"\Resources\unshow.jpg");
            if (pnlResult.Dock == DockStyle.None)
            {
                pnlResult.Dock = DockStyle.Left;
                picShowresult.Image = imageun;
            }
            else
            {
                pnlResult.Dock = DockStyle.None;
                picShowresult.Image = imageShow;
            }
        }

        //查询文本框Enter事件
        private void txtKeywork_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _pageIndex = 0;
                DoQuery();
                turnPaper1.setCount(count); 
                
            }
        }

        //查询按钮
        private void btnQuery_Click(object sender, EventArgs e)
        {
            _pageIndex = 0;
            DoQuery();
            turnPaper1.setCount(count);
        }

        //查询类别改变事件
        private void cmbo_TextChanged(object sender, EventArgs e)
        {
            txtKeywork.AutoCompleteMode = AutoCompleteMode.Suggest;
            switch (cmbo.Text)
            {
                case "ID":
                    tableName = "exceptionsinfo";
                    column = "id";
                    break;
                case "用户名":
                    tableName = "userinfo";
                    column = "username";
                    columnID = "userID";
                    break;
                case "项目名称":
                    tableName = "projectinfo";
                    column = "projectname";
                    columnID = "projectID";
                    break;
                case "异常类型":
                    tableName = "exceptionstype";
                    column = "typename";
                    columnID = "typeId";
                    break;
                case "异常ID":
                    tableName = "exceptionsinfo";
                    column = "exceptionid";
                    txtKeywork.Text = "TLW-";
                    txtKeywork.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    break;
                case "异常名称":
                    tableName = "exceptionsinfo";
                    column = "exceptionName";
                    break;
                default:
                    break;
            }
            txtKeywork.AutoCompleteCustomSource = getSuggestSource(tableName, column);
        }


        //地图鼠标点击事件
        private void axMapControl1_OnMouseDown(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseDownEvent e)
        {

        }

        //地图鼠标移动事件
        private void axMapControl1_OnMouseMove(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseMoveEvent e)
        {
            lblCoordinate.Text = " 坐标: " + string.Format("{0}, {1}  {2}", e.mapX.ToString("#######.##"), e.mapY.ToString("#######.##"), axMapControl1.MapUnits.ToString().Substring(4));
            IPoint pPoint = axMapControl1.ActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(e.x, e.y);
            IEnumElement pEunmEle = queryElementOnMap(pPoint, 0.005);
            IElement pEle;
            //IElement pEleTemp=null;
            //Button btnTemp=null;
            IElementProperties pEleProperties;
            Color black=Color.FromArgb(255, 219, 222, 226);
            Color withe = Color.FromArgb(255, 244, 247, 252);
            //if (pEleTemp == null)
            //{
            if (pEunmEle != null && pEleTemp == null)
            {
                while ((pEle = pEunmEle.Next()) != null)
                {
                    pEleProperties = (IElementProperties)pEle;
                    string projectID = pEleProperties.Name;
                    Button btn = queryResultButton(projectID);
                    if (btn.BackColor !=black )
                    {
                        btn.BackColor = black;
                        btnTemp = btn;
                        pEleTemp = pEle;
                    }

                    //IGraphicsContainer pGContainer = axMapControl1.Map as IGraphicsContainer;
                    //IElement pEle = queryElement(projectIDstr);
                    //pEle = setElementStyle(size, pColor, pEle, direction);
                    //pGContainer.UpdateElement(pEle);
                    //axMapControl1.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);
                }
            }
            //else if (pEunmEle != null && pEleTemp != null)
            //{
            //    while ((pEle = pEunmEle.Next()) != null)
            //    {
            //        pEleProperties = (IElementProperties)pEle;
            //        string projectID = pEleProperties.Name;
            //        Button btn = queryResultButton(projectID);
            //        if (pEleTemp != pEle)
            //        {
            //            if (btn.BackColor != black)
            //            {
            //                btn.BackColor = black;
            //            }

            //            if (btnTemp.BackColor != withe)
            //            {
            //                btnTemp.BackColor = withe;
            //                btnTemp = btn;
            //                pEleTemp = pEle;
            //            }
            //        }
            //    }
            //}
            else if (pEunmEle == null && pEleTemp != null)
            {
                if (btnTemp.BackColor != withe)
                {
                    btnTemp.BackColor = withe;
                    btnTemp = null;
                    pEleTemp = null;
                }
            }

                
            //}
            //else
            //{
            //    if (pEunmEle == null)
            //    {
            //        if (btnTemp.BackColor != Color.FromArgb(255, 244, 247, 252))
            //        {
            //            btnTemp.BackColor = Color.FromArgb(255, 244, 247, 252);
            //            btnTemp = null;
            //            pEleTemp = null;
            //            //btn.BackColor = Color.FromArgb(255, 244, 247, 252);
            //        }
            //    }
            //}

        }



        
       
        #endregion


        #region 私有方法
        private AutoCompleteStringCollection getSuggestSource(string tableName, string column)
        {
            DataDisposes dataDisposes = new DataDisposes();
            AutoCompleteStringCollection strings = new AutoCompleteStringCollection();
            DataTable userTable = (DataTable)dataDisposes.Select(tableName, "*", "");
            foreach (DataRow dr in userTable.Rows)
            {
                strings.Add(dr[column].ToString());
            }
            return strings;
        }

        private void btnResultArr_Click(object sender, EventArgs e)
        {
            int index=btnResultArr.Text.IndexOf('：');
            int index2=btnResultArr.Text.IndexOf('，');

            string id=btnResultArr.Text.Substring(index+1,index2-index-1);
            ExInfoFrm exInfo = new ExInfoFrm();
            if (id != "")
            {
                exInfo.ID = Convert.ToInt32(id);
                exInfo.Text = "修改异常信息";
                exInfo.Show();
            }
        }


        /// <summary>
        /// 根据用户选择的查询方式查询
        /// </summary>
        private void DoQuery()
        {
            
            count = 0;
            listbtn.Clear();
            if (cmbo.Text != "" && txtKeywork.Text.Trim() != "")
            {
                string whereStr = null;
                List<ExceptionsInfo> list = null;
                switch (cmbo.Text)
                {
                    case "ID":
                        whereStr = "ID like '%" + txtKeywork.Text.Trim() + "%'";
                        break;
                    case "用户名":
                        List<int> listUserID = UserInfoManage.FindByNameArr(txtKeywork.Text.Trim());
                        queryByName(listUserID);
                        return; //完全跳出
                    case "项目名称":
                        List<int> listProID = ProjectInfoManage.FindByNameArr(txtKeywork.Text.Trim());
                        queryByName(listProID);
                        return;//完全跳出
                    case "异常类型":
                        List<int> listTypeID = ExceptionsTypeManage.FindByNameArr(txtKeywork.Text.Trim());
                        queryByName(listTypeID);
                        return;//完全跳出
                    case "异常ID":
                        whereStr = "exceptionID like '%" + txtKeywork.Text.Trim() + "%'";
                        break;
                    case "异常名称":
                        whereStr = "exceptionName like '%" + txtKeywork.Text.Trim() + "%'";
                        break;
                    default:
                        break;
                }

                if (whereStr != null)
                {
                    if (_pageIndex > 1)
                    {
                        list = ExceptionsInfoManage.findTop(_pageIndex, _pageSize, whereStr);
                    }
                    else
                    {
                        list = ExceptionsInfoManage.findFirstPage(_pageSize, whereStr);
                    }
                    flowLayoutPanel1.Controls.Clear();
                    AddResult(list);
                    count = ExceptionsInfoManage.returnCount(whereStr);
                }
            }
        }


        /// <summary>
        /// 根据当前页数改变显示的结果
        /// </summary>
        /// <param name="pageIndex"></param>
        private void turnPage(int pageIndex)
        {
            _pageIndex = pageIndex;
            DoQuery();
            
        }

        /// <summary>
        /// 通过ID查询异常信息
        /// </summary>
        /// <param name="listID"></param>
        private void queryByName(List<int> listID)
        {
            int _count=0;
            flowLayoutPanel1.Controls.Clear();
            foreach (int ex in listID)
            {
                string whereStr= columnID+"="+ex;
                List<ExceptionsInfo> list;
                if (_pageIndex > 1)
                {
                    list = ExceptionsInfoManage.findTop(_pageIndex, _pageSize, whereStr);
                }
                else
                {
                    list = ExceptionsInfoManage.findFirstPage(_pageSize, whereStr);
                }
                AddResult(list);
                _count = ExceptionsInfoManage.returnCount(whereStr);
                count += _count;
            }
            
            pnlResultDorkSetting();
        }


        /// <summary>
        /// 添加结果到列表框里面
        /// </summary>
        /// <param name="list">完整的异常信息list</param>
        private void AddResult(List<ExceptionsInfo> list)
        {
            IGraphicsContainer pGContainer = axMapControl1.Map as IGraphicsContainer;
            pGContainer.DeleteAllElements();

            if (list.Count != 0)
            {
                foreach(ExceptionsInfo n in list)
                {
                    Button btn = createNewButton(n);
                    flowLayoutPanel1.Controls.Add(btn);
                    drawElement(n);
                }
            }
            
            pnlResultDorkSetting();
            axMapControl1.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);
        }


        /// <summary>
        /// 设置查询结果列表框的显示和隐藏
        /// </summary>
        private void pnlResultDorkSetting()
        {
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                pnlResult.Dock = DockStyle.Left;
            }
            else pnlResult.Dock = DockStyle.None;
        }

        /// <summary>
        /// 新建结果按钮
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private Button createNewButton(ExceptionsInfo n)
        {
            Button btn = new Button();
            btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            btn.Size = new System.Drawing.Size(205, 62);
            btn.Text = "ID：" + n.ID + "，" + n.ExcepitionName + "\r\n标签：" + n.ProjectID + "，" + n.UserID + "\r\n异常信息：" + n.ExcepitionID + "，" + n.TypeID + "\r\n问题描述：" + n.ExcepitionDescri;
            //btn.Text = "ID：" + n.ID + "，" + n.ExcepitionName + "\r\n标签：" + n.ProjectName + "，" + n.UserID + "\r\n异常信息：" + n.ExcepitionID + "，" + n.TypeID + "\r\n问题描述：" + n.ExcepitionDescri;
            btn.Tag = n.ProjectID;
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.UseVisualStyleBackColor = true;
            btn.Click += new System.EventHandler(this.btnResultArr_Click);
            btn.MouseEnter += new System.EventHandler(changeElementStyle);
            btn.MouseLeave += new System.EventHandler(rollBackElementStyle);
            return btn;
        }


        /// <summary>
        /// 设置颜色值
        /// </summary>
        /// <param name="r">red</param>
        /// <param name="g">green</param>
        /// <param name="b">blue</param>
        /// <param name="t">透明度 0为透明</param>
        /// <returns></returns>
        private IRgbColor setRGBColor(int r, int g, int b, int t)
        {

            IRgbColor pColor = new RgbColor();
            pColor.Red = r;
            pColor.Blue = b;
            pColor.Green = g;
            pColor.Transparency = (byte)t;
            return pColor;
        }

        /// <summary>
        /// 设置点元素的样式
        /// </summary>
        /// <param name="rgbColor">颜色</param>
        /// <param name="OutLineColor">轮廓颜色</param>
        private IElement createElement(IRgbColor rgbColor, IRgbColor OutLineColor)
        {
            ISimpleMarkerSymbol pSimpleMarkerSymbol = new SimpleMarkerSymbol();
            pSimpleMarkerSymbol.Color = rgbColor;
            pSimpleMarkerSymbol.Outline = true;
            pSimpleMarkerSymbol.OutlineColor = OutLineColor;
            pSimpleMarkerSymbol.Size = 15;
            pSimpleMarkerSymbol.Style = esriSimpleMarkerStyle.esriSMSDiamond;
            IMarkerElement pMElement = new MarkerElement() as IMarkerElement;
            pMElement.Symbol = pSimpleMarkerSymbol;
            IElement ele = (IElement)pMElement;
            return ele; 

        }


        /// <summary>
        /// 在屏幕中添加标记元素
        /// </summary>
        /// <param name="n"></param>
        private void drawElement(ExceptionsInfo n)
        {
            IFeature pFeature;
            IQueryFilter pQFilter = new QueryFilter();
            pQFilter.WhereClause = "\"projectName\"='" + n.ProjectID+"'";
            IFeatureLayer pFlayer = LayerHelper.getFeatureLayerFromMap(axMapControl1.Map, "Cities");    //获取特定图层
            IFeatureCursor pFtCursor =pFlayer.Search(pQFilter, true);                                   //查找对应结果

            IRgbColor pColor1 = setRGBColor(255, 0, 0, 255);
            IRgbColor pColor2 = setRGBColor(0, 255, 0, 255);
            IElement ele = createElement(pColor1, pColor2);
            IElementProperties pEleProperties = (IElementProperties)ele;
            pEleProperties.Name = n.ProjectID;                                                //设置element的Name属性方便查找
            IGraphicsContainer pGContainer = axMapControl1.Map as IGraphicsContainer;
            IActiveView pView = pGContainer as IActiveView;

            while ((pFeature = pFtCursor.NextFeature()) != null)
            {
                
                IPoint pPoint = pFeature.Shape as IPoint;
                ele.Geometry = pPoint;
                pGContainer.AddElement(ele, 0);
            }
        }


        /// <summary>
        /// 查询地图上已添加的元素并选择
        /// </summary>
        /// <param name="elementName"></param>
        private IElement queryElement(string elementName)
        {
            IElement ele =null;
            IElementProperties pEleProperties;
            IGraphicsContainer pGContainer = axMapControl1.Map as IGraphicsContainer;
            pGContainer.Reset();
            while ((pEleProperties = pGContainer.Next() as IElementProperties) != null)
            {
                if (pEleProperties.Name == elementName)
                {
                    ele = (IElement)pEleProperties;
                    break;
                }
            }
            return ele;
        }

        /// <summary>
        /// 作为MouseEnter事件的响应方法,改变标记现有的样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeElementStyle(object sender, System.EventArgs e)
        {
            bool direction = true;
            double size = 1.5;
            IRgbColor pColor = setRGBColor(0, 0, 200, 255);
            string projectIDstr = ((Button)sender).Tag.ToString();
            IGraphicsContainer pGContainer = axMapControl1.Map as IGraphicsContainer;            
            IElement pEle = queryElement(projectIDstr);
            pEle = setElementStyle(size, pColor, pEle, direction);
            pGContainer.UpdateElement(pEle);
            axMapControl1.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);
        }


        /// <summary>
        /// 作为MouseLeave事件的响应方法，回滚标注样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rollBackElementStyle(object sender, System.EventArgs e)
        {
            string projectIDstr = ((Button)sender).Tag.ToString();
            bool direction = false;
            double size = 1.5;
            IRgbColor pColor = setRGBColor(255, 0, 0, 255);            
            IGraphicsContainer pGContainer = axMapControl1.Map as IGraphicsContainer;
            IElement pEle = queryElement(projectIDstr);
            pEle = setElementStyle(size, pColor, pEle, direction);
            pGContainer.UpdateElement(pEle);
            axMapControl1.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, null, null);
        }

        /// <summary>
        /// 设置标注的样式外观
        /// </summary>
        /// <param name="size">缩放比例 1.5</param>
        /// <param name="pColor">颜色</param>
        /// <param name="pEle">要改变的颜色</param>
        /// <param name="direction">true为改变，false为还原</param>
        /// <returns></returns>
        private static IElement setElementStyle(double size, IRgbColor pColor, IElement pEle,bool direction)
        {
            IMarkerElement pMarEle = pEle as IMarkerElement;
            ISimpleMarkerSymbol pMarSymbol = pMarEle.Symbol as ISimpleMarkerSymbol;
            //axMapControl1.FlashShape(pEle.Geometry, 1, 300, pMarEle.Symbol);          //element闪烁，symbol没有则闪烁Geometry
            if (direction)
            {
                pMarSymbol.Size *= size;
            }
            else
            {
                pMarSymbol.Size /= size;
            }
            pMarSymbol.Color = pColor;
            pMarEle.Symbol = pMarSymbol;
            pEle = pMarEle as IElement;
            return pEle;
        }

        /// <summary>
        /// 查询地图上的标注Element
        /// </summary>
        /// <param name="point">地图上的点</param>
        /// <param name="tolerance">缓冲距离</param>
        /// <returns></returns>
        private IEnumElement queryElementOnMap(IPoint point, double tolerance)
        {
            IGraphicsContainer pGContainer = axMapControl1.Map as IGraphicsContainer;
            IEnumElement pEunmEle = pGContainer.LocateElements(point, tolerance);
            return pEunmEle;
        }

        /// <summary>
        /// 查找结果栏中的button
        /// </summary>
        /// <param name="projectID">element的name</param>
        /// <returns></returns>
        private Button queryResultButton(string projectID)
        {
            Button btn = null;
            Control.ControlCollection btnCollection = flowLayoutPanel1.Controls;
            for (int i = 0; i < btnCollection.Count; i++)
            {
                btn = (Button)btnCollection[i];
                if (btn.Tag.ToString() == projectID)
                {
                    return btn;
                }
            }
            return null;
        }

        #endregion 

       

        

        
        

    }
}
