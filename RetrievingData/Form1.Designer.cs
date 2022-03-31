
namespace RetrievingData
{
    partial class Form1
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
            this.adventureWorksDataSet = new RetrievingData.AdventureWorksDataSet();
            this.adventureWorksDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeAddressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeAddressTableAdapter = new RetrievingData.AdventureWorksDataSetTableAdapters.EmployeeAddressTableAdapter();
            this.employeeDepartmentHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDepartmentHistoryTableAdapter = new RetrievingData.AdventureWorksDataSetTableAdapters.EmployeeDepartmentHistoryTableAdapter();
            this.employeePayHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeePayHistoryTableAdapter = new RetrievingData.AdventureWorksDataSetTableAdapters.EmployeePayHistoryTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeAddressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDepartmentHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeePayHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // adventureWorksDataSet
            // 
            this.adventureWorksDataSet.DataSetName = "AdventureWorksDataSet";
            this.adventureWorksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adventureWorksDataSetBindingSource
            // 
            this.adventureWorksDataSetBindingSource.DataSource = this.adventureWorksDataSet;
            this.adventureWorksDataSetBindingSource.Position = 0;
            this.adventureWorksDataSetBindingSource.CurrentChanged += new System.EventHandler(this.adventureWorksDataSetBindingSource_CurrentChanged);
            // 
            // employeeAddressBindingSource
            // 
            this.employeeAddressBindingSource.DataMember = "EmployeeAddress";
            this.employeeAddressBindingSource.DataSource = this.adventureWorksDataSetBindingSource;
            // 
            // employeeAddressTableAdapter
            // 
            this.employeeAddressTableAdapter.ClearBeforeFill = true;
            // 
            // employeeDepartmentHistoryBindingSource
            // 
            this.employeeDepartmentHistoryBindingSource.DataMember = "EmployeeDepartmentHistory";
            this.employeeDepartmentHistoryBindingSource.DataSource = this.adventureWorksDataSetBindingSource;
            // 
            // employeeDepartmentHistoryTableAdapter
            // 
            this.employeeDepartmentHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // employeePayHistoryBindingSource
            // 
            this.employeePayHistoryBindingSource.DataMember = "EmployeePayHistory";
            this.employeePayHistoryBindingSource.DataSource = this.adventureWorksDataSetBindingSource;
            // 
            // employeePayHistoryTableAdapter
            // 
            this.employeePayHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.departmentIDDataGridViewTextBoxColumn,
            this.shiftIDDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.modifiedDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeDepartmentHistoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 267);
            this.dataGridView1.TabIndex = 0;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // departmentIDDataGridViewTextBoxColumn
            // 
            this.departmentIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.HeaderText = "DepartmentID";
            this.departmentIDDataGridViewTextBoxColumn.Name = "departmentIDDataGridViewTextBoxColumn";
            // 
            // shiftIDDataGridViewTextBoxColumn
            // 
            this.shiftIDDataGridViewTextBoxColumn.DataPropertyName = "ShiftID";
            this.shiftIDDataGridViewTextBoxColumn.HeaderText = "ShiftID";
            this.shiftIDDataGridViewTextBoxColumn.Name = "shiftIDDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // modifiedDateDataGridViewTextBoxColumn
            // 
            this.modifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.HeaderText = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.Name = "modifiedDateDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "EmployeeDetails";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeAddressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDepartmentHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeePayHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AdventureWorksDataSet adventureWorksDataSet;
        private System.Windows.Forms.BindingSource adventureWorksDataSetBindingSource;
        private System.Windows.Forms.BindingSource employeeAddressBindingSource;
        private AdventureWorksDataSetTableAdapters.EmployeeAddressTableAdapter employeeAddressTableAdapter;
        private System.Windows.Forms.BindingSource employeeDepartmentHistoryBindingSource;
        private AdventureWorksDataSetTableAdapters.EmployeeDepartmentHistoryTableAdapter employeeDepartmentHistoryTableAdapter;
        private System.Windows.Forms.BindingSource employeePayHistoryBindingSource;
        private AdventureWorksDataSetTableAdapters.EmployeePayHistoryTableAdapter employeePayHistoryTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
    }
}

