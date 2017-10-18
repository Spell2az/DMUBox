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
    public partial class frmStudentReport : Form
    {
        public frmStudentReport()
        {
            InitializeComponent();
        }

        private void frmStudentReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DMUBoxDataSet.tblStudents' table. You can move, or remove it, as needed.
            this.tblStudentsTableAdapter.Fill(this.DMUBoxDataSet.tblStudents);

            this.reportViewer1.RefreshReport();
        }
    }
}
