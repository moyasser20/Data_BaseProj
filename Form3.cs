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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void aIRPORTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aIRPORTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet2);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet2.AIRCRAFT' table. You can move, or remove it, as needed.
            this.aIRCRAFTTableAdapter.Fill(this.masterDataSet2.AIRCRAFT);
            // TODO: This line of code loads data into the 'masterDataSet2.AIRPORT' table. You can move, or remove it, as needed.
            this.aIRPORTTableAdapter.Fill(this.masterDataSet2.AIRPORT);

        }
    }
}
