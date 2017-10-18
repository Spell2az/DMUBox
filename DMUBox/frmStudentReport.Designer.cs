namespace DMUBox
{
    partial class frmStudentReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DMUBoxDataSet = new DMUBox.DMUBoxDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblStudentsTableAdapter = new DMUBox.DMUBoxDataSetTableAdapters.tblStudentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DMUBoxDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tblStudentsBindingSource
            // 
            this.tblStudentsBindingSource.DataMember = "tblStudents";
            this.tblStudentsBindingSource.DataSource = this.DMUBoxDataSet;
            // 
            // DMUBoxDataSet
            // 
            this.DMUBoxDataSet.DataSetName = "DMUBoxDataSet";
            this.DMUBoxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "StudentDataSet";
            reportDataSource1.Value = this.tblStudentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DMUBox.rptStudents.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 49);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(949, 489);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblStudentsTableAdapter
            // 
            this.tblStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // frmStudentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 550);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmStudentReport";
            this.Text = "frmStudentReport";
            this.Load += new System.EventHandler(this.frmStudentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DMUBoxDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblStudentsBindingSource;
        private DMUBoxDataSet DMUBoxDataSet;
        private DMUBoxDataSetTableAdapters.tblStudentsTableAdapter tblStudentsTableAdapter;
    }
}