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

        public delegate void OnPageIndexChangeDelegate(int pageIndex);
        public event OnPageIndexChangeDelegate OnPageIndexChange;

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
            ButtonState();
        }




        /// <summary>
        /// 按钮状态
        /// </summary>
        private void ButtonState()
        {
            if (_rowCount == 0 || _pageCount == 1)
            {
                this.btnBackPage.Enabled = false;
                this.btnEndPage.Enabled = false;
                this.btnFirstPage.Enabled = false;
                this.btnFwdPage.Enabled = false;
                this.btnGo.Enabled = false;
            }
            else
            {
                this.btnBackPage.Enabled = true;
                this.btnEndPage.Enabled = true;
                this.btnFirstPage.Enabled = true;
                this.btnFwdPage.Enabled = true;
                this.btnGo.Enabled = true;
            }
        }

        private void checkforGobtn()
        {
            try
            {
                if (Convert.ToInt32(txtCurPage.Text) > _pageCount)
                {
                    _pageIndex = _pageCount;
                    txtCurPage.Text = _pageIndex.ToString();
                }
                else
                {
                    _pageIndex = Convert.ToInt32(txtCurPage.Text);

                }
            }
            catch
            {
                txtCurPage.Text = _pageIndex.ToString();
            }
            finally
            {
                OnPageIndexChange(_pageIndex);
            }
        }

        #endregion 

        

        #region  控件方法

        //跳首页
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            _pageIndex = 1;
            txtCurPage.Text = _pageIndex.ToString();
            OnPageIndexChange(_pageIndex);
        }
        //上一页
        private void btnBackPage_Click(object sender, EventArgs e)
        {
            if (--_pageIndex == 0)
            {
                _pageIndex = 1;
            }            
            txtCurPage.Text = _pageIndex.ToString();
            OnPageIndexChange(_pageIndex);
        }
        //下一页
        private void btnFwdPage_Click(object sender, EventArgs e)
        {
            //_pageIndex += 1;
            if (++_pageIndex > _pageCount)
            {
                _pageIndex = _pageCount;
            }
            txtCurPage.Text = _pageIndex.ToString();
            OnPageIndexChange(_pageIndex);
        }
        //最后页
        private void btnEndPage_Click(object sender, EventArgs e)
        {
            _pageIndex = _pageCount;
            txtCurPage.Text = _pageIndex.ToString();
            OnPageIndexChange(_pageIndex);
        }
        //GO
        private void btnGo_Click(object sender, EventArgs e)
        {
            checkforGobtn();
        }

        
        //GO
        private void txtCurPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkforGobtn();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        #endregion       
    }
}


