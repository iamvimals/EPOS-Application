using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EPOSApplication
{
    public partial class SearchOrderForm : Form
    {
        //Constants declared
        private const string ORDER_DETAILS_FILE = "OrderDetails.txt";

        public List<string> orderDetails = new List<string>();
        public SearchOrderForm(List<string> orderDetailsData)
        {
            InitializeComponent();
            orderDetails = orderDetailsData;
        }

        //Event Handler called on click of Search button after inputting the order ID or the date
        private void searchButton_Click1(object sender, EventArgs e)
        {
            bool dataFlag = false;
            string previousID = "";
            if (searchTextBox.Text.Trim() != "")
            {
                searchResultsListBox.Items.Clear();

                for (int i = 0; i < orderDetails.Count; i++)
                {
                    if (orderDetails[i].Contains(searchTextBox.Text.Trim()))
                    {
                        if (orderDetails[i].Substring(0, 8) != previousID)
                        {
                            previousID = orderDetails[i].Substring(0, 8);
                            searchResultsListBox.Items.Add("=============================================================================");
                            searchResultsListBox.Items.Add("Order ID: " + orderDetails[i].Substring(0, 8) + "\n");
                            searchResultsListBox.Items.Add("=============================================================================");
                        }
                        searchResultsListBox.Items.Add("Date: " + this.parseOrderDataForFields(orderDetails[i], 1));
                        searchResultsListBox.Items.Add("Suit Brand: " + this.parseOrderDataForFields(orderDetails[i], 2));
                        searchResultsListBox.Items.Add("Size: " + this.parseOrderDataForFields(orderDetails[i], 3));
                        searchResultsListBox.Items.Add("Units: " + this.parseOrderDataForFields(orderDetails[i], 4));
                        searchResultsListBox.Items.Add("Total Cost: " + this.parseOrderDataForFields(orderDetails[i], 5));
                        searchResultsListBox.Items.Add("Customer Name: " + this.parseOrderDataForFields(orderDetails[i], 6));
                        searchResultsListBox.Items.Add("Phone: " + this.parseOrderDataForFields(orderDetails[i], 7));
                        searchResultsListBox.Items.Add("Email: " + this.parseOrderDataForFields(orderDetails[i], 8));
                        searchResultsListBox.Items.Add("Payment Method: " + this.parseOrderDataForFields(orderDetails[i], 9));
                        searchResultsListBox.Items.Add("");

                        searchResultsLabel.Text = "Search Results:";
                        searchResultsLabel.Visible = true;
                        searchResultsListBox.Visible = true;
                        dataFlag = true;
                    }
                }
                //Display No Results Found when there are no matching results
                if (!dataFlag)
                {
                    searchResultsLabel.Text = "No Results Found.";
                    searchResultsListBox.Visible = false;
                }
                searchResultsLabel.Visible = true;
                searchTextBox.Text = "";
            }
            else
            {
                this.showErrorDialogBox("Please enter a valid input to search", "Data Entry Error");
                searchTextBox.Focus();
            }
        }

        //Method to retrieve specific data fields from the file based on their position in the line 
        private string parseOrderDataForFields(string orderLineData, int iter)
        {
            int firstIndex = 0, nextIndex = 0;
            string newStr = "";
            for (int i = 0; i < iter; i++)
            {
                firstIndex = orderLineData.IndexOf(",");
                newStr = orderLineData.Substring(firstIndex + 1);
                orderLineData = newStr;
            }
            nextIndex = newStr.IndexOf(",");
            if (nextIndex == -1)
            {
                return newStr.Substring(0);
            }
            return newStr.Substring(0, nextIndex);
        }

        //Method to show the error dialog when an invalid input data is entered
        private void showErrorDialogBox(string message, string headerTitle)
        {
            MessageBox.Show(message, headerTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
