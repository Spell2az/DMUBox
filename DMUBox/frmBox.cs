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
    public partial class frmBox : Form
    {
        public frmBox()
        {
            InitializeComponent();
        }

        private void Box_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dMUBoxDataSet.tblBox' table. You can move, or remove it, as needed.
            this.tblBoxTableAdapter.Fill(this.dMUBoxDataSet.tblBox);

        }

        private void tblBoxBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblBoxBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dMUBoxDataSet);

        }

        private void boxNoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tblBoxBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void boxNoTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void boxNoLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
