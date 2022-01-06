using System;
using System.IO;
using System.Windows.Forms;

namespace EPOSApplication
{
    public partial class StocksAvailability : Form
    {
        //Constants declared
        private const string STOCK_AVAILABILITY_FILE = "StocksAvailability.txt";
        public StocksAvailability()
        {
            InitializeComponent();
        }

        private void StocksAvailability_Load(object sender, EventArgs e)
        {   //Load items stock data from the file on load of the form
            try
            {
                StreamReader InputFile = File.OpenText(STOCK_AVAILABILITY_FILE);
                while (!InputFile.EndOfStream)
                {
                    stocksAvailabilityListBox.Items.Add(InputFile.ReadLine()); //Add the items counts to a listBox
                }
                InputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to fetch the stock details file\nContact Manager\n\n" + ex);
            }
        }
    }
}
