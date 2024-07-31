using System.Windows.Forms;
using CsvHelper;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace dataGridForm
{
    public partial class dataGridForm : Form
    {
        public dataGridForm()
        {
            InitializeComponent();
            List<DataSet> dataValues;
            using (var reader = new StreamReader(@"C:\Users\Compl\Documents\programUnitsTest.csv")) 
                using(var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                dataValues = csv.GetRecords<DataSet>().ToList();
            }
            dataGridOutput.DataSource = dataValues;
        }

        private void dataGridOutput_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataCellView cellData = new dataCellView();
            cellData.dataTxBx.Text = this.dataGridOutput.CurrentCell.Value.ToString();
            cellData.Show();
        }
    }
}
