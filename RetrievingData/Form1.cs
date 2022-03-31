using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetrievingData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adventureWorksDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorksDataSet.EmployeePayHistory' table. You can move, or remove it, as needed.
            this.employeePayHistoryTableAdapter.Fill(this.adventureWorksDataSet.EmployeePayHistory);
            // TODO: This line of code loads data into the 'adventureWorksDataSet.EmployeeDepartmentHistory' table. You can move, or remove it, as needed.
            this.employeeDepartmentHistoryTableAdapter.Fill(this.adventureWorksDataSet.EmployeeDepartmentHistory);
            // TODO: This line of code loads data into the 'adventureWorksDataSet.EmployeeAddress' table. You can move, or remove it, as needed.
            this.employeeAddressTableAdapter.Fill(this.adventureWorksDataSet.EmployeeAddress);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
