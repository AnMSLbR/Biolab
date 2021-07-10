using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biolab
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }

        #region Properties

        private string _title;
        private string _pointID;
        private DateTime _recordDate;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lbl_PointTitle.Text = value; }
        }

        [Category("Custom Props")]
        public string PointID
        {
            get { return _pointID; }
            set { _pointID = value; lbl_PointID.Text = value; }
        }

        public DateTime RecordDate
        {
            get { return _recordDate; }
            set { _recordDate = value; lbl_RecordDateValue.Text = Convert.ToString(value); }
        }

        #endregion

        private void ListItem_MouseEnter(object sender, EventArgs e)
        {
           this.BackColor = Color.Silver;
        }

        private void ListItem_MouseLeave(object sender, EventArgs e)
        {
           this.BackColor = Color.White;
        }

        private void ListItem_MouseClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.DarkGray;
            this.Select();
        }
    }
}
