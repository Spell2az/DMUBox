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
    public partial class frmFindStudent : Form
    {
        public frmFindStudent()
        {
            InitializeComponent();
        }

        private void tblStudentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblStudentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dMUBoxDataSet);

        }

        private void frmFindStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dMUBoxDataSet.tblStudents' table. You can move, or remove it, as needed.
            tblStudentsTableAdapter.Fill(dMUBoxDataSet.tblStudents);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sporc_tblStudent_FilterByStudentNoTableAdapter.Fill(this.dMUBoxDataSet.sporc_tblStudent_FilterByStudentNo, studentNoToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
