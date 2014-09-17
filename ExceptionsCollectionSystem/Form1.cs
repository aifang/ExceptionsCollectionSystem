using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;

namespace ExceptionsCollectionSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataDisposes dataDisposes = new DataDisposes();

        private void btnTypeCre_Click(object sender, EventArgs e)
        {
            DataTable pDataTable = (DataTable)dataDisposes.Select("userinfo","*","");
        }

    }
}
