using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseprojlast
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        internal void show()
        {
            throw new NotImplementedException();
        }

        private void aIRCRAFTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aIRCRAFTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet2.AIRCRAFT' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'masterDataSet2.AIRPORT' table. You can move, or remove it, as needed.
            this.aIRPORTTableAdapter1.Fill(this.masterDataSet2.AIRPORT);
            this.aIRCRAFTTableAdapter1.Fill(this.masterDataSet2.AIRCRAFT);
            // TODO: This line of code loads data into the 'masterDataSet.FLIGHT' table. You can move, or remove it, as needed.
            // this.fLIGHTTableAdapter.Fill(this.masterDataSet.FLIGHT);
            // TODO: This line of code loads data into the 'masterDataSet.AIRPORT' table. You can move, or remove it, as needed.
            // this.aIRPORTTableAdapter.Fill(this.masterDataSet.AIRPORT);
            // TODO: This line of code loads data into the 'masterDataSet.AIRCRAFT' table. You can move, or remove it, as needed.
            // this.aIRCRAFTTableAdapter.Fill(this.masterDataSet.AIRCRAFT);

        }
    }
}
