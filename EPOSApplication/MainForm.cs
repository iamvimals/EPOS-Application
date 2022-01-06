/* Student Name: Vimal Shetty 
 * Student ID: 21236713
 * Date: 03/12/2021
 * Assignment: 4
 * Assignment: To develop an EPOS system for a retail business by providing features for carrying out 
 * transactions, searching previous orders, inventory stock management, and daily sales report generation.
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EPOSApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //Constants declared
        private const string ORDER_DETAILS_FILE = "OrderDetails.txt";
        private const string STOCK_INVENTORY_FILE = "StockInventory.txt";
        private const string STOCK_AVAILABILITY_FILE = "StocksAvailability.txt";
        private const string DAILY_SALES_REPORT = "SalesReport.txt";
        //Global variables
        private int totalUnits = 0;
        private decimal subTotal = 0m;
        private int orderID = 0;
        private bool checkoutSuccessful = false;
        private int lineQuantity = 0;
        private List<string> customerInfo = new List<string>();

        static List<string> suitBrands = new List<string>()
            {"Georgio Armani", "Burberry Suits", "Dolce & Gabbana", "Brioni Suits", "Givenchy Suits", "Saint Laurent", "Prada Suits", "Hugo Boss", "Berlutti Suits", "Valentino Suits", "Kingsman Suits", "Gucci Suits", "Boglioli Suits", "Jil Sander", "Canali Suits"};
        static List<string> suitSize = new List<string>()
            {"XS(36)", "S(38)", "M(40)", "L(42)", "XL(44)", "XXL(46)"};
        static int[] stockInventoryData = new int[suitBrands.Count * suitSize.Count];
        static int[,] stockInventoryDataArray = new int[suitBrands.Count, suitSize.Count];
        static int[,] backupStockInventoryDataArray = new int[suitBrands.Count, suitSize.Count];
        static int[,] originalStockInventoryDataArray = new int[suitBrands.Count, suitSize.Count];
        static List<string> orderDetailsData = new List<string>();
        static decimal[,] itemSalePrices = { { 1150, 6318, 1150, 7320, 2380, 1268 },
                                            { 1058, 7320, 1268, 2380, 8249, 123 },
                                            { 2110, 558, 8249, 1268, 6318, 2380 },
                                            { 8249, 8249, 1268, 280, 282, 6318 },
                                            { 9332, 860, 1150, 1268, 2380, 8249 },
                                            { 2380, 6318, 275, 278, 8249, 100 },
                                            { 1030, 493, 1268, 1150, 100, 2380 },
                                            { 5225, 6318, 8249, 2380, 255, 189 },
                                            { 4329, 1268, 144, 747, 7320, 187 },
                                            { 7320, 638, 265, 1268, 2380, 109 },
                                            { 6423, 563, 358, 361, 1150, 6318 },
                                            { 7325, 1268, 7320, 273, 2380, 178 },
                                            { 6318, 641, 1150, 1268, 2380, 198 },
                                            { 6438, 613, 143, 266, 1268, 145 },
                                            { 1268, 1268, 263, 7320, 128, 2380 } };

        private void MainForm_Load(object sender, EventArgs e)
        {
            priceLabel.Text = 0.ToString("c");
            unitsInputNumericUpDown.Maximum = 1000;
            //Load Suit brands to the listBox
            foreach (string brand in suitBrands)
            {
                suitBrandListBox.Items.Add(brand);
            }

            //Load Suit sizes to the listBox
            foreach (string size in suitSize)
            {
                suitSizeListBox.Items.Add(size);
            }
            //Read stock inventory from file and store in 2D array
            if (File.Exists(STOCK_INVENTORY_FILE))
            {
                try
                {
                    StreamReader Outputfile = File.OpenText(STOCK_INVENTORY_FILE);
                    for (int index = 0; index < (suitBrands.Count * suitSize.Count); index++)
                    {
                        stockInventoryData[index] = int.Parse(Outputfile.ReadLine());
                    }
                    int arrIncrement = 0;
                    for (int i = 0; i < suitBrands.Count; i++)
                    {
                        for (int j = 0; j < suitSize.Count; j++)
                        {
                            stockInventoryDataArray[i, j] = stockInventoryData[arrIncrement];
                            originalStockInventoryDataArray[i, j] = stockInventoryData[arrIncrement];
                            arrIncrement++;
                        }
                    }
                    Outputfile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to access inventory data.", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Missing file: StockInventory.txt", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Event Handler called on click of Exit button
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.updateInventoryCounts(); //Write the updated inventory stock counts back to file
            this.generateDailyReport(); //Generate the report for sales made the same day
            this.Close();
        }

        //Event Handler called on click of Add to cart button
        private void addToCartButton_Click(object sender, EventArgs e)
        {
            if (suitBrandListBox.SelectedIndex != -1)
            {
                if (suitSizeListBox.SelectedIndex != -1)
                {
                    if (unitsInputNumericUpDown.Value > 0)
                    {
                        lineQuantity = (int)unitsInputNumericUpDown.Value;
                        priceLabel.Text = (lineQuantity * itemSalePrices[suitBrandListBox.SelectedIndex, suitSizeListBox.SelectedIndex]).ToString("c");
                        totalPriceGroupBox.Enabled = true;
                        this.showCartView(); //Shows the cart with the selected items
                    }
                    else
                    {
                        this.showErrorDialogBox("Please select 1 or more unit(s) to proceed", "Invalid Input");
                        unitsInputNumericUpDown.Focus();
                    }
                }
                else
                {
                    this.showErrorDialogBox("Please select a Suit Size to proceed", "Invalid Input");
                    suitSizeListBox.Focus();
                }
            }
            else
            {
                this.showErrorDialogBox("Please select a Suit Brand to proceed", "Invalid Input");
                suitBrandListBox.Focus();
            }
        }

        //Method to show cart section after selecting the items and clicking the Add to cart button
        private void showCartView()
        {
            for (int i = 0; i < suitBrands.Count; i++)
            {
                for (int j = 0; j < suitSize.Count; j++)
                {
                    //Store the copy of initial stock array in another array
                    backupStockInventoryDataArray[i, j] = stockInventoryDataArray[i, j];
                }
            }
            if (lineQuantity <= stockInventoryDataArray[suitBrandListBox.SelectedIndex, suitSizeListBox.SelectedIndex])
            {
                if (orderID == 0)
                {
                    orderID = this.generateUniqueOrderID();
                }
                if (orderIDValueLabel.Text == "")
                {
                    orderIDValueLabel.Text = orderID.ToString();
                }
                totalUnits += lineQuantity;
                subTotal += decimal.Parse(priceLabel.Text, NumberStyles.Currency);
                subTotalValueLabel.Text = subTotal.ToString("c");
                cartCountLabel.Text = "(" + totalUnits + ")";
                //Reduce the count of selected items in the stock array
                stockInventoryDataArray[suitBrandListBox.SelectedIndex, suitSizeListBox.SelectedIndex] -= lineQuantity;
                cartItemsDataGridView.Rows.Add(suitBrands[suitBrandListBox.SelectedIndex],
                                               suitSize[suitSizeListBox.SelectedIndex],
                                               lineQuantity.ToString(),
                                               priceLabel.Text);
                cartViewPanel.Visible = true;
            }
            else
            {
                string inventoryCountErrorMessage = "Sorry, we do not have enough units available for this item!\n\n";
                inventoryCountErrorMessage += "Suit Brand:\t" + suitBrands[suitSizeListBox.SelectedIndex] + "\n" +
                                              "Size:\t\t" + suitSize[suitSizeListBox.SelectedIndex] + "\n" +
                                              "Inventory Count:\t" + stockInventoryDataArray[suitBrandListBox.SelectedIndex, suitSizeListBox.SelectedIndex];

                this.showErrorDialogBox(inventoryCountErrorMessage, "Inventory Error");
            }
        }

        //Method to generate a random 8-digit number
        private int generateRandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next(10000000, 99999999);
        }

        //Method to parse the file contents to check the uniqueness of the Transaction ID/Number
        private int generateUniqueOrderID()
        {
            int generatedOrderNumber = this.generateRandomNumber();
            try
            {
                if (File.ReadLines(ORDER_DETAILS_FILE).Count() >= 1)
                {
                    StreamReader inputFile = File.OpenText(ORDER_DETAILS_FILE);
                    string orderLineData = "";
                    while (!inputFile.EndOfStream)
                    {
                        orderLineData = inputFile.ReadLine();
                        if (orderLineData.Substring(0, 8).Equals(generatedOrderNumber.ToString()))
                        {
                            generatedOrderNumber = this.generateRandomNumber();
                            return generatedOrderNumber;
                        }
                    }
                    inputFile.Close();
                }
            }
            catch (Exception ex)
            {
                this.showErrorDialogBox("Unable to check for the uniqueness of order ID", "Application Error");
            }
            return generatedOrderNumber;
        }


        //Method to show the error dialog when an invalid input data is entered
        private void showErrorDialogBox(string message, string headerTitle)
        {
            MessageBox.Show(message, headerTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Reset the form fields and variables to inital values
        private void resetForm()
        {
            totalPriceGroupBox.Enabled = false;
            cartViewPanel.Visible = false;
            orderID = 0;
            subTotal = 0m;
            suitBrandListBox.ClearSelected();
            suitSizeListBox.ClearSelected();
            subTotalValueLabel.Text = "";
            orderIDValueLabel.Text = "";
            priceLabel.Text = 0.ToString("c");
            lineQuantity = 0;
            totalUnits = 0;
            unitsInputNumericUpDown.Value = 0;
            //Reset the stock array data to its initial state in the event of an unsuccessful transaction
            if (cartItemsDataGridView.Rows.Count > 0 && !checkoutSuccessful)
            {
                for (int i = 0; i < suitBrands.Count; i++)
                {
                    for (int j = 0; j < suitSize.Count; j++)
                    {
                        stockInventoryDataArray[i, j] = backupStockInventoryDataArray[i, j];
                    }
                }
            }
            cartItemsDataGridView.Rows.Clear();
            checkoutSuccessful = false;
        }

        //Event Handler called on click of Clear button
        private void clearSelectionButton_Click(object sender, EventArgs e)
        {
            this.resetForm();
        }

        //Event Handler called on click of Search button
        private void searchOrdersButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile;
                string orderLineData = "";
                inputFile = File.OpenText(ORDER_DETAILS_FILE);
                if (File.ReadLines(ORDER_DETAILS_FILE).Count() > 0)
                {
                    while (!inputFile.EndOfStream)
                    {
                        orderLineData = inputFile.ReadLine();
                        orderDetailsData.Add(orderLineData);
                    }
                }
                else
                {
                    this.showErrorDialogBox("There are no records in the file", "File Error");
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                this.showErrorDialogBox("Unable to read details from the file", "File Error");
            }
            //Open the search dialog window
            SearchOrderForm searchOrderForm = new SearchOrderForm(orderDetailsData);
            searchOrderForm.ShowDialog();
            orderDetailsData.Clear();
        }

        //Event Handler called on click of View Inventory button to view the current stocks inventory 
        private void viewInventoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter OutputFile = File.CreateText(STOCK_AVAILABILITY_FILE);
                OutputFile.WriteLine("================================================================");
                OutputFile.WriteLine("|\t\t\tManagement Stock Inventory\t\t\t|");
                OutputFile.WriteLine("================================================================");
                OutputFile.Write("\t\t");
                for (int i = 0; i < suitSize.Count; i++)
                {
                    OutputFile.Write(suitSize[i] + "\t");
                }
                for (int i = 0; i < suitBrands.Count; i++)
                {
                    OutputFile.WriteLine();
                    OutputFile.Write(suitBrands[i] + "\t");
                    for (int j = 0; j < suitSize.Count; j++)
                    {
                        if (cartItemsDataGridView.Rows.Count > 0)
                        {
                            OutputFile.Write(backupStockInventoryDataArray[i, j].ToString() + "\t");
                            Console.WriteLine("B" + backupStockInventoryDataArray[0, 0]);
                        }
                        else
                        {
                            Console.WriteLine("S" + stockInventoryDataArray[0, 0]);
                            OutputFile.Write(stockInventoryDataArray[i, j].ToString() + "\t");
                        }
                    }
                }
                OutputFile.WriteLine("\n================================================================");
                OutputFile.Close();
                StocksAvailability stocksInventory = new StocksAvailability();
                stocksInventory.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Generate Existing Stock details file\nContact your Manager\n" + ex);
            }
        }

        //Event Handler called on click of Remove button to remove the items from the cart
        private void removeItemButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in cartItemsDataGridView.SelectedRows)
            {
                List<string> rowToBeRemoved = new List<string>();
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    rowToBeRemoved.Add(row.Cells[i].Value.ToString());
                }
                //Increment the stock count of the removed item(s) in the stock array
                stockInventoryDataArray[suitBrands.IndexOf(rowToBeRemoved[0]), suitSize.IndexOf(rowToBeRemoved[1])] += int.Parse(rowToBeRemoved[2]);
                subTotal -= decimal.Parse(rowToBeRemoved[3], NumberStyles.Currency);
                subTotalValueLabel.Text = subTotal.ToString("c");
                totalUnits -= int.Parse(rowToBeRemoved[2]);
                cartCountLabel.Text = "(" + totalUnits + ")";
                cartItemsDataGridView.Rows.Remove(row);
                if (cartItemsDataGridView.Rows.Count == 0)
                {
                    this.resetForm();
                }
            }

        }

        //Event Handler called on click of Checkout button to proceed to capture customer information
        private void checkoutButton_Click(object sender, EventArgs e)
        {
            CustomerInfo customerInfoDialog = new CustomerInfo();
            customerInfoDialog.ShowDialog();
            customerInfo = customerInfoDialog.sendCustomerInfoData(); //customerInfo passed from the child form to the parent form
            if (customerInfo.Count > 0)
            {
                int rowCount = cartItemsDataGridView.Rows.Count;
                string orderDetails = "Order ID:\t\t" + orderID + "\n\n";
                for (int i = 0; i < rowCount; i++)
                {
                    if ((rowCount > 1) && (i != 0))
                    {
                        orderDetails += "--------------------------------------------------\n";
                    }
                    orderDetails += "Suit Brand: \t" + cartItemsDataGridView.Rows[i].Cells[0].Value.ToString() + "\n";
                    orderDetails += "Suit Size: \t" + cartItemsDataGridView.Rows[i].Cells[1].Value.ToString() + "\n";
                    orderDetails += "Units: \t\t" + cartItemsDataGridView.Rows[i].Cells[2].Value.ToString() + "\n";
                    orderDetails += "Price: \t\t" + cartItemsDataGridView.Rows[i].Cells[3].Value.ToString() + "\n";
                }
                orderDetails += "=========================\n";
                orderDetails += "Total: \t\t" + (subTotal).ToString("c") + "\n";
                orderDetails += "=========================\n";
                DialogResult dialogResult = MessageBox.Show(orderDetails, "Order Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    checkoutSuccessful = true;
                    this.saveOrderDetailsToFile();
                    this.updateInventoryCounts();
                    MessageBox.Show("You have done it!\n\nYour order has been successfully placed. Please note the order number for your reference\n\nOrder Number: " + orderID, "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.resetForm();
                }
            }
        }


        //Method to fetch the current date in (dd-mm-yyyy) format
        private string getCurrentDate()
        {
            return DateTime.Today.ToString("dd-MM-yyyy");
        }

        //Method called to store the order details as comma seperated in a file
        private void saveOrderDetailsToFile()
        {
            try
            {
                string orderLineData = "";
                StreamWriter outputFile = outputFile = File.AppendText(ORDER_DETAILS_FILE); //Opens the file in Append mode
                for (int i = 0; i < cartItemsDataGridView.Rows.Count; i++)
                {
                    orderLineData = orderID + "," + this.getCurrentDate() + "," +
                                    cartItemsDataGridView.Rows[i].Cells[0].Value.ToString() + "," +
                                    cartItemsDataGridView.Rows[i].Cells[1].Value.ToString() + "," +
                                    cartItemsDataGridView.Rows[i].Cells[2].Value.ToString() + "," +
                                    decimal.Parse(cartItemsDataGridView.Rows[i].Cells[3].Value.ToString(), NumberStyles.Currency) + "," +
                                    customerInfo[0] + "," + customerInfo[1] + "," + customerInfo[2] + "," + customerInfo[3];
                    outputFile.WriteLine(orderLineData); //Writes data to file
                }
                outputFile.Close();
            }
            catch (Exception ex)
            {
                this.showErrorDialogBox("Unable to save order details to file.", "File Error");
            }
        }

        //Method called to update the new stock levels in the inventory stored in a file
        private void updateInventoryCounts()
        {
            try
            {
                StreamWriter inventoryFile = File.CreateText(STOCK_INVENTORY_FILE);
                int arrayIncrement = 0;
                for (int i = 0; i < suitBrands.Count; i++)
                {
                    for (int j = 0; j < suitSize.Count; j++)
                    {
                        stockInventoryData[arrayIncrement] = stockInventoryDataArray[i, j];
                        arrayIncrement++;
                    }
                }
                for (int i = 0; i < (suitBrands.Count * suitSize.Count); i++)
                {
                    inventoryFile.WriteLine(stockInventoryData[i]);
                }
                inventoryFile.Close();
            }
            catch (Exception ex)
            {
                this.showErrorDialogBox("Unable to update inventory counts.", "File Error");
            }
        }

        //Event Handler called on click of Report button
        private void generateReportButton_Click(object sender, EventArgs e)
        {
            this.generateDailyReport();
        }

        //Method called to generate the daily report for the management
        private void generateDailyReport()
        {
            try
            {
                int count = 0;
                int[,] itemsSoldData = new int[suitBrands.Count, suitSize.Count];
                StreamWriter OutputFile = File.CreateText(this.getCurrentDate() + "_" + DAILY_SALES_REPORT);
                OutputFile.WriteLine("=======================================================================================================");
                OutputFile.WriteLine("|(" + this.getCurrentDate() + ")\t\t\t\t  DAILY SALES REPORT\t\t\t\t\t      |");
                OutputFile.WriteLine("=======================================================================================================");
                OutputFile.Write("\t\t");
                for (int i = 0; i < suitSize.Count; i++)
                {
                    OutputFile.Write(suitSize[i] + "\t\t");
                }
                OutputFile.Write("\n=======================================================================================================");
                for (int i = 0; i < suitBrands.Count; i++)
                {
                    OutputFile.WriteLine();
                    OutputFile.Write(suitBrands[i]);
                    for (int j = 0; j < suitSize.Count; j++)
                    {
                        itemsSoldData[i, j] = originalStockInventoryDataArray[i, j] - stockInventoryDataArray[i, j];
                        OutputFile.Write("\t" + itemsSoldData[i, j].ToString() + "\t");
                        count += itemsSoldData[i, j];
                    }
                }
                OutputFile.WriteLine("\n=======================================================================================================");
                OutputFile.Write("Total Items Sold: " + count);
                OutputFile.WriteLine("\n=======================================================================================================");
                MessageBox.Show("Daily orders report has been generated", "Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start("notepad.exe", this.getCurrentDate() + "_" + DAILY_SALES_REPORT);
                OutputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Generate Existing Stock details file\nContact your Manager\n" + ex);
            }
        }

    }
}
