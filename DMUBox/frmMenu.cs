﻿using System;
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTestBox myBoxForm = new frmTestBox();

            myBoxForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmFindStudent myFindStudentForm = new frmFindStudent();

            myFindStudentForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            frmStudents myStudentsForm = new frmStudents();

            myStudentsForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmStudentReport myStudentReportForm = new frmStudentReport();

            myStudentReportForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmHallStudentReport myHallStudentReportForm = new frmHallStudentReport();

            myHallStudentReportForm.Show();
        }

       
    }
}
