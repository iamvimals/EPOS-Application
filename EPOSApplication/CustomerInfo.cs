using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EPOSApplication
{
    public partial class CustomerInfo : Form
    {
        //Constants declared
        private const string CREDIT_DEBIT_PAYMENT = "Credit/Debit Card";
        private const string PAYPAL_PAYMENT = "PayPal";
        private const string CASH_PAYMENT = "Cash";

        private List<string> customerInfo = new List<string>();
        public CustomerInfo()
        {
            InitializeComponent();
        }

        //Method to show the error dialog when an invalid input data is entered
        private void showErrorDialogBox(string message, string headerTitle)
        {
            MessageBox.Show(message, headerTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Method to check if a valid email has been entered
        private bool checkEmailValidity(string emailAddress)
        {
            if (emailValueTextBox.Text.Contains("@"))
            {
                int indexOfAt = emailValueTextBox.Text.IndexOf('@');
                string extract = emailValueTextBox.Text.Substring(indexOfAt);
                return extract.Contains(".");
            }
            return false; //Return false when the email entered is invalid
        }

        //Send the customerInfo data back to parent form
        public List<string> sendCustomerInfoData()
        {
            return customerInfo;
        }

        //Method to get the payment method selected by the customer
        private string getPaymentInfo()
        {
            if (cardButton.Checked)
            {
                return CREDIT_DEBIT_PAYMENT;
            }
            else if (paypalRadioButton.Checked)
            {
                return PAYPAL_PAYMENT;
            }
            return CASH_PAYMENT;
        }

        //Event Handler called on click of Confirm button after inputting the customer info and the payment method
        private void confirmButton_Click(object sender, EventArgs e)
        {
            //Checking the validity of customer's name
            if (nameValueTextBox.Text.Length > 0 && !nameValueTextBox.Text.Any(char.IsDigit))
            {
                //Checking the validity of customer's phone number
                if (phoneValueTextBox.Text.Length > 0 && phoneValueTextBox.Text.All(char.IsDigit))
                {
                    //Checking the validity of customer's email
                    if (emailValueTextBox.Text.Length > 0 && this.checkEmailValidity(emailValueTextBox.Text))
                    {
                        customerInfo.Add(nameValueTextBox.Text);
                        customerInfo.Add(phoneValueTextBox.Text);
                        customerInfo.Add(emailValueTextBox.Text);
                        customerInfo.Add(this.getPaymentInfo());
                        this.Close();
                    }
                    else
                    {
                        this.showErrorDialogBox("Please enter a valid email address", "Data Entry Error");
                    }
                }
                else
                {
                    this.showErrorDialogBox("Please enter a valid phone number", "Data Entry Error");
                }
            }
            else
            {
                this.showErrorDialogBox("Please enter the name of the client", "Data Entry Error");
            }
        }
        //Event Handler called on click of Cancel button
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
