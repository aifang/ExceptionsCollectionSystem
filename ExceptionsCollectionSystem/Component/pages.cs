using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace ExceptionsCollectionSystem.Component
{
    /// <summary>
    /// 自定义分页控件
    /// 作者：hch126163
    /// 时间：2009-9-25
    /// </summary>
    public partial class WinformPager : UserControl
    {

        private int _pageIndex = 1; //当前的页索引
        private int _pageCount = 0; // 总页数
        private int _pageSize = 20; // 每页多少行 
        private int _rowCount = 0;  //  总记录数
        public delegate void PageIndexChangeEventHandler(object sender, PageIndexChangeEventArgs e);

        /// <summary>
        /// 当前页索引改变时,触发
        /// </summary>
        [Description("页索引发生改变后触发")]　//显示在属性设计视图中的描述
        public event PageIndexChangeEventHandler PageIndexChange;

        /// <summary>
        /// 触发当前页索引改变事件
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnPageIndexChange(PageIndexChangeEventArgs e)
        {
            ButtonState();
            if (PageIndexChange != null)        // 如果有此事件
            {
                PageIndexChange(this, e);
            }
        }

        /// <summary>
        /// 当前的页索引（最小值1 最大值pageCount,要设置pageIndex值，请先设置PageSize 和 RowCount）
        /// </summary>
        [Description("获取或设置当前的页索引 从1开始 默认是1第一页 要改变此值，请先设置每页多少行PageSize和总记录数RowCount")]　//显示在属性设计视图中的描述
        [DefaultValue(typeof(int), "1")]//给予初始值
        public int PageIndex
        {
            get { return _pageIndex; }
            set
            {
                if (value < 1)
                {
                    _pageIndex = 1;
                    return;
                }
                if (_pageCount > 0 && value > _pageCount)
                {
                    _pageIndex = _pageCount;
                    return;
                }
                _pageIndex = value;

            }
        }
        /// <summary>
        /// 总页数（只读 最小值0）
        /// </summary>
        [Description("获取总页数")]　//显示在属性设计视图中的描述
        [DefaultValue(typeof(int), "0")]//给予初始值
        public int PageCount
        {
            get { return _pageCount; }

        }

        /// <summary>
        /// 每页多少行 (最小值1 默认值20)
        /// </summary>
        [Description("获取或设置每页显示多少行数据")]　//显示在属性设计视图中的描述
        [DefaultValue(typeof(int), "20")]//给予初始值
        public int PageSize
        {
            get { return _pageSize; }
            set
            {
                if (value < 1)
                {
                    _pageSize = 1;
                    return;
                }
                _pageSize = value;
                SetPageCount();
            }
        }

        /// <summary>
        /// 总记录数（最小值0）
        /// </summary>
        [Description("获取或设置总记录数")]　//显示在属性设计视图中的描述
        [DefaultValue(typeof(int), "0")]//给予初始值
        public int RowCount
        {
            get { return _rowCount; }
            set
            {
                if (value < 0)
                {
                    _rowCount = 0;
                    return;
                }
                _rowCount = value;
                SetPageCount();
            }
        }



        public WinformPager()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 计算共多少页
        /// </summary>
        private void SetPageCount()
        {
            _pageCount = (int)(Math.Ceiling(_rowCount / (double)_pageSize));

            ButtonState();
        }
        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirst_Click(object sender, EventArgs e)
        {

            _pageIndex = 1;

            OnPageIndexChange(new PageIndexChangeEventArgs(_pageIndex));


        }
        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_pageIndex > 1)
            {
                _pageIndex--;

                OnPageIndexChange(new PageIndexChangeEventArgs(_pageIndex));
            }
        }
        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_pageIndex < _pageCount)
            {
                _pageIndex++;

                OnPageIndexChange(new PageIndexChangeEventArgs(_pageIndex));
            }
        }
        /// <summary>
        /// 尾页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLast_Click(object sender, EventArgs e)
        {
            _pageIndex = _pageCount;
            OnPageIndexChange(new PageIndexChangeEventArgs(_pageIndex));

        }
        /// <summary>
        /// 跳转页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmpJumpPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_pageIndex == cmpJumpPage.SelectedIndex + 1 || cmpJumpPage.Text == "")
            {
                return;
            }
            _pageIndex = cmpJumpPage.SelectedIndex + 1;
            OnPageIndexChange(new PageIndexChangeEventArgs(_pageIndex));

        }

        /// <summary>
        /// 按钮状态
        /// </summary>
        private void ButtonState()
        {
            if (_rowCount == 0)
            {
                this.btnFirst.Enabled = false;
                this.btnPrevious.Enabled = false;

                this.btnNext.Enabled = false;
                this.btnLast.Enabled = false;
                this.cmpJumpPage.Enabled = false;
                this.cmpJumpPage.Items.Clear();
                this.cmpJumpPage.Text = "";
                this.lblMessage.Text = "没有搜到相关数据！";

                return;
            }



            this.btnFirst.Enabled = true;
            this.btnPrevious.Enabled = true;
            this.btnNext.Enabled = true;
            this.btnLast.Enabled = true;
            this.cmpJumpPage.Enabled = true;
            if (_pageIndex == 1)
            {
                this.btnFirst.Enabled = false;
                this.btnPrevious.Enabled = false;
            }
            if (_pageIndex == _pageCount)
            {
                this.btnNext.Enabled = false;
                this.btnLast.Enabled = false;
            }
            cmpJumpPage.Items.Clear();
            for (int i = 1; i <= _pageCount; i++)
            {
                cmpJumpPage.Items.Add(i);

            }
            if (_pageCount > 0)
                cmpJumpPage.SelectedIndex = _pageIndex - 1;

            this.lblMessage.Text = "共搜到" + _rowCount + "条数据  共" + _pageCount + "页  第" + this._pageIndex + "页";
        }




    }

    /// <summary>
    /// PageIndexChange事件参数类
    /// </summary>
    public class PageIndexChangeEventArgs : System.EventArgs
    {

        public PageIndexChangeEventArgs(int newPageIndex)
        {
            _newPageIndex = newPageIndex;

        }

        private int _newPageIndex;

        public int NewPageIndex
        {
            get { return _newPageIndex; }

        }

    }
}
