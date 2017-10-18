namespace DMUBox
{
    partial class frmHallStudentReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DMUBoxDataSet = new DMUBox.DMUBoxDataSet();
            this.sproc_HallStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sproc_HallStudentsTableAdapter = new DMUBox.DMUBoxDataSetTableAdapters.sproc_HallStudentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DMUBoxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sproc_HallStudentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "HallStudentDataSet";
            reportDataSource1.Value = this.sproc_HallStudentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DMUBox.rptHallStudents.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(72, 50);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(671, 326);
            this.reportViewer1.TabIndex = 0;
            // 
            // DMUBoxDataSet
            // 
            this.DMUBoxDataSet.DataSetName = "DMUBoxDataSet";
            this.DMUBoxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sproc_HallStudentsBindingSource
            // 
            this.sproc_HallStudentsBindingSource.DataMember = "sproc_HallStudents";
            this.sproc_HallStudentsBindingSource.DataSource = this.DMUBoxDataSet;
            // 
            // sproc_HallStudentsTableAdapter
            // 
            this.sproc_HallStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // frmHallStudentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 434);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmHallStudentReport";
            this.Text = "frmHallStudentReport";
            this.Load += new System.EventHandler(this.frmHallStudentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DMUBoxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sproc_HallStudentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sproc_HallStudentsBindingSource;
        private DMUBoxDataSet DMUBoxDataSet;
        private DMUBoxDataSetTableAdapters.sproc_HallStudentsTableAdapter sproc_HallStudentsTableAdapter;
    }
}