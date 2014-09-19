using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExceptionsCollectionSystem.Component
{
    public partial class turnPaper : UserControl
    {
        public turnPaper()
        {
            InitializeComponent();
            
        }


        private int _rowCount = 0;        //  总记录数
        private int _pageCount = 0;       // 总页数
        private int _pageIndex = 0;         //当前的页索引
        private double _pageSize = 10.0;  // 每页多少行 

        //public delegate void PageIndexChangeEventHandler(

        #region  私有方法


        /// <summary>
        /// 设置页数和记录总数
        /// </summary>
        /// <param name="n"></param>
        public void setCount(int n)
        {
            //设置记录总数
            _rowCount = n;
            _pageCount = _rowCount / 10;
            lblCount.Text = "共 " + _rowCount + " 条记录";

            //设置页数
            double page = _rowCount / _pageSize;
            _pageCount = (int)Math.Ceiling(page);
            lblTotalPage.Text = "共 " + _pageCount + " 页";

            //设置当前页
            if (_pageCount > 0)
            {
                _pageIndex = 1;
                txtCurPage.Text = _pageIndex.ToString();
            }
        }

        #endregion 

        

        #region  控件方法

        private void btnFirstPage_Click(object sender, EventArgs e)
        {

        }

        private void btnBackPage_Click(object sender, EventArgs e)
        {

        }

        private void btnFwdPage_Click(object sender, EventArgs e)
        {

        }

        private void btnEndPage_Click(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}


