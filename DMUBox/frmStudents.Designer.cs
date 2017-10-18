namespace DMUBox
{
    partial class frmStudents
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
            System.Windows.Forms.Label studentNoLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label foreNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudents));
            System.Windows.Forms.Label familyNameLabel;
            System.Windows.Forms.Label apartmentNoLabel;
            System.Windows.Forms.Label hallNoLabel;
            this.dMUBoxDataSet = new DMUBox.DMUBoxDataSet();
            this.tblStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStudentsTableAdapter = new DMUBox.DMUBoxDataSetTableAdapters.tblStudentsTableAdapter();
            this.tableAdapterManager = new DMUBox.DMUBoxDataSetTableAdapters.TableAdapterManager();
            this.tblStudentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblStudentsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.studentNoTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.foreNameTextBox = new System.Windows.Forms.TextBox();
            this.familyNameTextBox = new System.Windows.Forms.TextBox();
            this.apartmentNoTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tblHallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHallTableAdapter = new DMUBox.DMUBoxDataSetTableAdapters.tblHallTableAdapter();
            this.tblOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblOrderTableAdapter = new DMUBox.DMUBoxDataSetTableAdapters.tblOrderTableAdapter();
            this.tblOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            studentNoLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            foreNameLabel = new System.Windows.Forms.Label();
            familyNameLabel = new System.Windows.Forms.Label();
            apartmentNoLabel = new System.Windows.Forms.Label();
            hallNoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dMUBoxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsBindingNavigator)).BeginInit();
            this.tblStudentsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblHallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentNoLabel
            // 
            studentNoLabel.AutoSize = true;
            studentNoLabel.Location = new System.Drawing.Point(31, 72);
            studentNoLabel.Name = "studentNoLabel";
            studentNoLabel.Size = new System.Drawing.Size(64, 13);
            studentNoLabel.TabIndex = 1;
            studentNoLabel.Text = "Student No:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(65, 108);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title:";
            // 
            // foreNameLabel
            // 
            foreNameLabel.AutoSize = true;
            foreNameLabel.Location = new System.Drawing.Point(33, 146);
            foreNameLabel.Name = "foreNameLabel";
            foreNameLabel.Size = new System.Drawing.Size(62, 13);
            foreNameLabel.TabIndex = 5;
            foreNameLabel.Text = "Fore Name:";
            // 
            // dMUBoxDataSet
            // 
            this.dMUBoxDataSet.DataSetName = "DMUBoxDataSet";
            this.dMUBoxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudentsBindingSource
            // 
            this.tblStudentsBindingSource.DataMember = "tblStudents";
            this.tblStudentsBindingSource.DataSource = this.dMUBoxDataSet;
            // 
            // tblStudentsTableAdapter
            // 
            this.tblStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblBoxTableAdapter = null;
            this.tableAdapterManager.tblHallTableAdapter = null;
            this.tableAdapterManager.tblOrderLineTableAdapter = null;
            this.tableAdapterManager.tblOrderTableAdapter = null;
            this.tableAdapterManager.tblStudentsTableAdapter = this.tblStudentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = DMUBox.DMUBoxDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblStudentsBindingNavigator
            // 
            this.tblStudentsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblStudentsBindingNavigator.BindingSource = this.tblStudentsBindingSource;
            this.tblStudentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblStudentsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblStudentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblStudentsBindingNavigatorSaveItem});
            this.tblStudentsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblStudentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblStudentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblStudentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblStudentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblStudentsBindingNavigator.Name = "tblStudentsBindingNavigator";
            this.tblStudentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblStudentsBindingNavigator.Size = new System.Drawing.Size(753, 25);
            this.tblStudentsBindingNavigator.TabIndex = 0;
            this.tblStudentsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblStudentsBindingNavigatorSaveItem
            // 
            this.tblStudentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblStudentsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblStudentsBindingNavigatorSaveItem.Image")));
            this.tblStudentsBindingNavigatorSaveItem.Name = "tblStudentsBindingNavigatorSaveItem";
            this.tblStudentsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblStudentsBindingNavigatorSaveItem.Text = "Save Data";
            this.tblStudentsBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblStudentsBindingNavigatorSaveItem_Click);
            // 
            // studentNoTextBox
            // 
            this.studentNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStudentsBindingSource, "StudentNo", true));
            this.studentNoTextBox.Location = new System.Drawing.Point(101, 69);
            this.studentNoTextBox.Name = "studentNoTextBox";
            this.studentNoTextBox.Size = new System.Drawing.Size(121, 20);
            this.studentNoTextBox.TabIndex = 2;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStudentsBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(101, 105);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(121, 20);
            this.titleTextBox.TabIndex = 4;
            // 
            // foreNameTextBox
            // 
            this.foreNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStudentsBindingSource, "ForeName", true));
            this.foreNameTextBox.Location = new System.Drawing.Point(101, 143);
            this.foreNameTextBox.Name = "foreNameTextBox";
            this.foreNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.foreNameTextBox.TabIndex = 6;
            // 
            // familyNameLabel
            // 
            familyNameLabel.AutoSize = true;
            familyNameLabel.Location = new System.Drawing.Point(25, 193);
            familyNameLabel.Name = "familyNameLabel";
            familyNameLabel.Size = new System.Drawing.Size(70, 13);
            familyNameLabel.TabIndex = 7;
            familyNameLabel.Text = "Family Name:";
            // 
            // familyNameTextBox
            // 
            this.familyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStudentsBindingSource, "FamilyName", true));
            this.familyNameTextBox.Location = new System.Drawing.Point(101, 190);
            this.familyNameTextBox.Name = "familyNameTextBox";
            this.familyNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.familyNameTextBox.TabIndex = 8;
            // 
            // apartmentNoLabel
            // 
            apartmentNoLabel.AutoSize = true;
            apartmentNoLabel.Location = new System.Drawing.Point(20, 275);
            apartmentNoLabel.Name = "apartmentNoLabel";
            apartmentNoLabel.Size = new System.Drawing.Size(75, 13);
            apartmentNoLabel.TabIndex = 9;
            apartmentNoLabel.Text = "Apartment No:";
            // 
            // apartmentNoTextBox
            // 
            this.apartmentNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStudentsBindingSource, "ApartmentNo", true));
            this.apartmentNoTextBox.Location = new System.Drawing.Point(101, 272);
            this.apartmentNoTextBox.Name = "apartmentNoTextBox";
            this.apartmentNoTextBox.Size = new System.Drawing.Size(121, 20);
            this.apartmentNoTextBox.TabIndex = 10;
            // 
            // hallNoLabel
            // 
            hallNoLabel.AutoSize = true;
            hallNoLabel.Location = new System.Drawing.Point(50, 233);
            hallNoLabel.Name = "hallNoLabel";
            hallNoLabel.Size = new System.Drawing.Size(45, 13);
            hallNoLabel.TabIndex = 11;
            hallNoLabel.Text = "Hall No:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblStudentsBindingSource, "HallNo", true));
            this.comboBox1.DataSource = this.tblHallBindingSource;
            this.comboBox1.DisplayMember = "HallName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 230);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "HallNo";
            // 
            // tblHallBindingSource
            // 
            this.tblHallBindingSource.DataMember = "tblHall";
            this.tblHallBindingSource.DataSource = this.dMUBoxDataSet;
            // 
            // tblHallTableAdapter
            // 
            this.tblHallTableAdapter.ClearBeforeFill = true;
            // 
            // tblOrderBindingSource
            // 
            this.tblOrderBindingSource.DataMember = "FK_tblOrder_tblStudent";
            this.tblOrderBindingSource.DataSource = this.tblStudentsBindingSource;
            // 
            // tblOrderTableAdapter
            // 
            this.tblOrderTableAdapter.ClearBeforeFill = true;
            // 
            // tblOrderDataGridView
            // 
            this.tblOrderDataGridView.AutoGenerateColumns = false;
            this.tblOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tblOrderDataGridView.DataSource = this.tblOrderBindingSource;
            this.tblOrderDataGridView.Location = new System.Drawing.Point(288, 72);
            this.tblOrderDataGridView.Name = "tblOrderDataGridView";
            this.tblOrderDataGridView.Size = new System.Drawing.Size(342, 220);
            this.tblOrderDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "OrderNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DeliveryDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "DeliveryDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // frmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 421);
            this.Controls.Add(this.tblOrderDataGridView);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(hallNoLabel);
            this.Controls.Add(apartmentNoLabel);
            this.Controls.Add(this.apartmentNoTextBox);
            this.Controls.Add(familyNameLabel);
            this.Controls.Add(this.familyNameTextBox);
            this.Controls.Add(foreNameLabel);
            this.Controls.Add(this.foreNameTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(studentNoLabel);
            this.Controls.Add(this.studentNoTextBox);
            this.Controls.Add(this.tblStudentsBindingNavigator);
            this.Name = "frmStudents";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dMUBoxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsBindingNavigator)).EndInit();
            this.tblStudentsBindingNavigator.ResumeLayout(false);
            this.tblStudentsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblHallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DMUBoxDataSet dMUBoxDataSet;
        private System.Windows.Forms.BindingSource tblStudentsBindingSource;
        private DMUBoxDataSetTableAdapters.tblStudentsTableAdapter tblStudentsTableAdapter;
        private DMUBoxDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblStudentsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblStudentsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox studentNoTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox foreNameTextBox;
        private System.Windows.Forms.TextBox familyNameTextBox;
        private System.Windows.Forms.TextBox apartmentNoTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tblHallBindingSource;
        private DMUBoxDataSetTableAdapters.tblHallTableAdapter tblHallTableAdapter;
        private System.Windows.Forms.BindingSource tblOrderBindingSource;
        private DMUBoxDataSetTableAdapters.tblOrderTableAdapter tblOrderTableAdapter;
        private System.Windows.Forms.DataGridView tblOrderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}