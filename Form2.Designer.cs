﻿
namespace databaseprojlast
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label aIRPORTNAMELabel;
            System.Windows.Forms.Label cAPACITYLabel;
            System.Windows.Forms.Label lOCATIONLabel;
            this.masterDataSet = new databaseprojlast.masterDataSet();
            this.aIRCRAFTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aIRCRAFTTableAdapter = new databaseprojlast.masterDataSetTableAdapters.AIRCRAFTTableAdapter();
            this.tableAdapterManager = new databaseprojlast.masterDataSetTableAdapters.TableAdapterManager();
            this.aIRPORTTableAdapter = new databaseprojlast.masterDataSetTableAdapters.AIRPORTTableAdapter();
            this.fLIGHTTableAdapter = new databaseprojlast.masterDataSetTableAdapters.FLIGHTTableAdapter();
            this.aIRPORTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fLIGHTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aIRPORTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.aIRPORTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.masterDataSet2 = new databaseprojlast.masterDataSet2();
            this.aIRPORTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aIRPORTTableAdapter1 = new databaseprojlast.masterDataSet2TableAdapters.AIRPORTTableAdapter();
            this.tableAdapterManager1 = new databaseprojlast.masterDataSet2TableAdapters.TableAdapterManager();
            this.aIRPORTNAMETextBox = new System.Windows.Forms.TextBox();
            this.cAPACITYTextBox = new System.Windows.Forms.TextBox();
            this.lOCATIONTextBox = new System.Windows.Forms.TextBox();
            this.aIRCRAFTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aIRCRAFTTableAdapter1 = new databaseprojlast.masterDataSet2TableAdapters.AIRCRAFTTableAdapter();
            this.aIRCRAFTDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            aIRPORTNAMELabel = new System.Windows.Forms.Label();
            cAPACITYLabel = new System.Windows.Forms.Label();
            lOCATIONLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRCRAFTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPORTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPORTBindingNavigator)).BeginInit();
            this.aIRPORTBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPORTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRCRAFTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRCRAFTDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aIRCRAFTBindingSource
            // 
            this.aIRCRAFTBindingSource.DataMember = "AIRCRAFT";
            this.aIRCRAFTBindingSource.DataSource = this.masterDataSet;
            // 
            // aIRCRAFTTableAdapter
            // 
            this.aIRCRAFTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADMINTableAdapter = null;
            this.tableAdapterManager.AIRCRAFTTableAdapter = this.aIRCRAFTTableAdapter;
            this.tableAdapterManager.AIRPORTTableAdapter = this.aIRPORTTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKED_FLIGHTTableAdapter = null;
            this.tableAdapterManager.FLIGHTTableAdapter = this.fLIGHTTableAdapter;
            this.tableAdapterManager.LUGGAGETableAdapter = null;
            this.tableAdapterManager.TICKETTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = databaseprojlast.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USER_PHONENUMBERTableAdapter = null;
            this.tableAdapterManager.USERTableAdapter = null;
            // 
            // aIRPORTTableAdapter
            // 
            this.aIRPORTTableAdapter.ClearBeforeFill = true;
            // 
            // fLIGHTTableAdapter
            // 
            this.fLIGHTTableAdapter.ClearBeforeFill = true;
            // 
            // aIRPORTBindingSource
            // 
            this.aIRPORTBindingSource.DataMember = "AIRPORT";
            this.aIRPORTBindingSource.DataSource = this.masterDataSet;
            // 
            // fLIGHTBindingSource
            // 
            this.fLIGHTBindingSource.DataMember = "FK_FLIGHT_FLIES_TO_AIRPORT";
            this.fLIGHTBindingSource.DataSource = this.aIRPORTBindingSource;
            // 
            // aIRPORTBindingNavigator
            // 
            this.aIRPORTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aIRPORTBindingNavigator.BindingSource = this.aIRPORTBindingSource;
            this.aIRPORTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aIRPORTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aIRPORTBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.aIRPORTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.aIRPORTBindingNavigatorSaveItem});
            this.aIRPORTBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aIRPORTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aIRPORTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aIRPORTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aIRPORTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aIRPORTBindingNavigator.Name = "aIRPORTBindingNavigator";
            this.aIRPORTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aIRPORTBindingNavigator.Size = new System.Drawing.Size(1156, 27);
            this.aIRPORTBindingNavigator.TabIndex = 12;
            this.aIRPORTBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // aIRPORTBindingNavigatorSaveItem
            // 
            this.aIRPORTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aIRPORTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aIRPORTBindingNavigatorSaveItem.Image")));
            this.aIRPORTBindingNavigatorSaveItem.Name = "aIRPORTBindingNavigatorSaveItem";
            this.aIRPORTBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.aIRPORTBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // masterDataSet2
            // 
            this.masterDataSet2.DataSetName = "masterDataSet2";
            this.masterDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aIRPORTBindingSource1
            // 
            this.aIRPORTBindingSource1.DataMember = "AIRPORT";
            this.aIRPORTBindingSource1.DataSource = this.masterDataSet2;
            // 
            // aIRPORTTableAdapter1
            // 
            this.aIRPORTTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.ADMINTableAdapter = null;
            this.tableAdapterManager1.AIRCRAFTTableAdapter = this.aIRCRAFTTableAdapter1;
            this.tableAdapterManager1.AIRPORTTableAdapter = this.aIRPORTTableAdapter1;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BOOKED_FLIGHTTableAdapter = null;
            this.tableAdapterManager1.FLIGHTTableAdapter = null;
            this.tableAdapterManager1.LUGGAGETableAdapter = null;
            this.tableAdapterManager1.TICKETTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = databaseprojlast.masterDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.USER_PHONENUMBERTableAdapter = null;
            this.tableAdapterManager1.USERTableAdapter = null;
            // 
            // aIRPORTNAMELabel
            // 
            aIRPORTNAMELabel.AutoSize = true;
            aIRPORTNAMELabel.Location = new System.Drawing.Point(586, 119);
            aIRPORTNAMELabel.Name = "aIRPORTNAMELabel";
            aIRPORTNAMELabel.Size = new System.Drawing.Size(104, 17);
            aIRPORTNAMELabel.TabIndex = 12;
            aIRPORTNAMELabel.Text = "AIRPORTNAME:";
            // 
            // aIRPORTNAMETextBox
            // 
            this.aIRPORTNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aIRPORTBindingSource1, "AIRPORTNAME", true));
            this.aIRPORTNAMETextBox.Location = new System.Drawing.Point(696, 116);
            this.aIRPORTNAMETextBox.Name = "aIRPORTNAMETextBox";
            this.aIRPORTNAMETextBox.Size = new System.Drawing.Size(100, 24);
            this.aIRPORTNAMETextBox.TabIndex = 13;
            // 
            // cAPACITYLabel
            // 
            cAPACITYLabel.AutoSize = true;
            cAPACITYLabel.Location = new System.Drawing.Point(586, 149);
            cAPACITYLabel.Name = "cAPACITYLabel";
            cAPACITYLabel.Size = new System.Drawing.Size(75, 17);
            cAPACITYLabel.TabIndex = 14;
            cAPACITYLabel.Text = "CAPACITY:";
            // 
            // cAPACITYTextBox
            // 
            this.cAPACITYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aIRPORTBindingSource1, "CAPACITY", true));
            this.cAPACITYTextBox.Location = new System.Drawing.Point(696, 146);
            this.cAPACITYTextBox.Name = "cAPACITYTextBox";
            this.cAPACITYTextBox.Size = new System.Drawing.Size(100, 24);
            this.cAPACITYTextBox.TabIndex = 15;
            // 
            // lOCATIONLabel
            // 
            lOCATIONLabel.AutoSize = true;
            lOCATIONLabel.Location = new System.Drawing.Point(586, 179);
            lOCATIONLabel.Name = "lOCATIONLabel";
            lOCATIONLabel.Size = new System.Drawing.Size(78, 17);
            lOCATIONLabel.TabIndex = 16;
            lOCATIONLabel.Text = "LOCATION:";
            // 
            // lOCATIONTextBox
            // 
            this.lOCATIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aIRPORTBindingSource1, "LOCATION", true));
            this.lOCATIONTextBox.Location = new System.Drawing.Point(696, 176);
            this.lOCATIONTextBox.Name = "lOCATIONTextBox";
            this.lOCATIONTextBox.Size = new System.Drawing.Size(100, 24);
            this.lOCATIONTextBox.TabIndex = 17;
            // 
            // aIRCRAFTBindingSource1
            // 
            this.aIRCRAFTBindingSource1.DataMember = "FK_AIRCRAFT_CONTAINS_AIRPORT";
            this.aIRCRAFTBindingSource1.DataSource = this.aIRPORTBindingSource1;
            // 
            // aIRCRAFTTableAdapter1
            // 
            this.aIRCRAFTTableAdapter1.ClearBeforeFill = true;
            // 
            // aIRCRAFTDataGridView
            // 
            this.aIRCRAFTDataGridView.AutoGenerateColumns = false;
            this.aIRCRAFTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aIRCRAFTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.aIRCRAFTDataGridView.DataSource = this.aIRCRAFTBindingSource1;
            this.aIRCRAFTDataGridView.Location = new System.Drawing.Point(51, 283);
            this.aIRCRAFTDataGridView.Name = "aIRCRAFTDataGridView";
            this.aIRCRAFTDataGridView.RowHeadersWidth = 51;
            this.aIRCRAFTDataGridView.RowTemplate.Height = 26;
            this.aIRCRAFTDataGridView.Size = new System.Drawing.Size(1105, 220);
            this.aIRCRAFTDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MODEL";
            this.dataGridViewTextBoxColumn1.HeaderText = "MODEL";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MANUDACTURE";
            this.dataGridViewTextBoxColumn2.HeaderText = "MANUDACTURE";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "YEAROFMANUFACTURE";
            this.dataGridViewTextBoxColumn3.HeaderText = "YEAROFMANUFACTURE";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LASTMAINTENACEDATE";
            this.dataGridViewTextBoxColumn4.HeaderText = "LASTMAINTENACEDATE";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CAPACITY";
            this.dataGridViewTextBoxColumn5.HeaderText = "CAPACITY";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AIRCRAFTID";
            this.dataGridViewTextBoxColumn6.HeaderText = "AIRCRAFTID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FLIGHT_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "FLIGHT_ID";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ADMIN_SSN";
            this.dataGridViewTextBoxColumn8.HeaderText = "ADMIN_SSN";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "STATUS";
            this.dataGridViewTextBoxColumn9.HeaderText = "STATUS";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "AIRCRAFTNAME";
            this.dataGridViewTextBoxColumn10.HeaderText = "AIRCRAFTNAME";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "AIRPORTNAME";
            this.dataGridViewTextBoxColumn11.HeaderText = "AIRPORTNAME";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 515);
            this.Controls.Add(this.aIRCRAFTDataGridView);
            this.Controls.Add(aIRPORTNAMELabel);
            this.Controls.Add(this.aIRPORTNAMETextBox);
            this.Controls.Add(cAPACITYLabel);
            this.Controls.Add(this.cAPACITYTextBox);
            this.Controls.Add(lOCATIONLabel);
            this.Controls.Add(this.lOCATIONTextBox);
            this.Controls.Add(this.aIRPORTBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRCRAFTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPORTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPORTBindingNavigator)).EndInit();
            this.aIRPORTBindingNavigator.ResumeLayout(false);
            this.aIRPORTBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPORTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRCRAFTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRCRAFTDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource aIRCRAFTBindingSource;
        private masterDataSetTableAdapters.AIRCRAFTTableAdapter aIRCRAFTTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private masterDataSetTableAdapters.AIRPORTTableAdapter aIRPORTTableAdapter;
        private System.Windows.Forms.BindingSource aIRPORTBindingSource;
        private masterDataSetTableAdapters.FLIGHTTableAdapter fLIGHTTableAdapter;
        private System.Windows.Forms.BindingSource fLIGHTBindingSource;
        private System.Windows.Forms.BindingNavigator aIRPORTBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton aIRPORTBindingNavigatorSaveItem;
        private masterDataSet2 masterDataSet2;
        private System.Windows.Forms.BindingSource aIRPORTBindingSource1;
        private masterDataSet2TableAdapters.AIRPORTTableAdapter aIRPORTTableAdapter1;
        private masterDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
        private masterDataSet2TableAdapters.AIRCRAFTTableAdapter aIRCRAFTTableAdapter1;
        private System.Windows.Forms.TextBox aIRPORTNAMETextBox;
        private System.Windows.Forms.TextBox cAPACITYTextBox;
        private System.Windows.Forms.TextBox lOCATIONTextBox;
        private System.Windows.Forms.BindingSource aIRCRAFTBindingSource1;
        private System.Windows.Forms.DataGridView aIRCRAFTDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}