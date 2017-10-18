using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMUBox
{
    public partial class frmStudents : Form
    {
        public frmStudents()
        {
            InitializeComponent();
        }

        private void tblStudentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblStudentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dMUBoxDataSet);

        }

        private void Students_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dMUBoxDataSet.tblOrder' table. You can move, or remove it, as needed.
            this.tblOrderTableAdapter.Fill(this.dMUBoxDataSet.tblOrder);
            // TODO: This line of code loads data into the 'dMUBoxDataSet.tblHall' table. You can move, or remove it, as needed.
            this.tblHallTableAdapter.Fill(this.dMUBoxDataSet.tblHall);
            // TODO: This line of code loads data into the 'dMUBoxDataSet.tblStudents' table. You can move, or remove it, as needed.
            this.tblStudentsTableAdapter.Fill(this.dMUBoxDataSet.tblStudents);

        }
    }
}
