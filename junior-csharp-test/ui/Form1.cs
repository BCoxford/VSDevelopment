using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace ui
{
    public partial class Form1 : Form
    {
        private Database db;
        private IEnumerable<dynamic> orderNumberList;

        public Form1()
        {
            InitializeComponent();
            this.db = new Database();
            //Set up the list of order numbers
            this.orderNumberList = this.db.FetchAllOrderNumbers();
            if (this.orderNumberList.Count() != 0)
            {
                //Iterate all orders
                foreach (var o in orderNumberList)
                {
                    orderList.Items.Add(o.order_number);
                }
            }
        }

        public int validateOrderNumber(String orderNumber)
        {
            //Is numeric test
            int orderInteger;
            bool isNumeric = int.TryParse(orderNumber, out orderInteger);
            if (isNumeric)
            {
                return orderInteger;
            }
            else
            {
                return -1;
            }
        }

        private void orderList_Click(object sender, EventArgs e)
        {
            if (orderList.SelectedItem != null)
            {
                int orderNum = this.validateOrderNumber(orderList.GetItemText(orderList.SelectedItem));
                if (orderNum == -1)
                {
                    //Invalid order number entered
                    errorLabel.Visible = true;
                    errorLabel.Text = "An invalid order number was selected";
                }
                else
                {
                    var order = this.db.FetchOrderDetails(orderNum);
                    if (order.Count() == 1)
                    {
                        foreach (var o in order)
                        {
                            //Order was found and displayed
                            errorLabel.Visible = false;
                            orderNumberLabel.Text = o.order_number.ToString();
                            orderDateLabel.Text = o.order_date.ToShortDateString();
                            salePriceLabel.Text = "£" + o.sale_price.ToString();
                            depositLabel.Text = "£" + o.deposit.ToString();
                            customerNumberLabel.Text = o.customer_number.ToString();
                            customerNameLabel.Text = o.forename.ToString() + " " + o.surname.ToString();
                            customerTelephoneLabel.Text = o.telephone_number.ToString();
                            branchNameLabel.Text = o.branch_name.ToString();
                            postcodeLabel.Text = o.postcode.ToString();
                        }
                    }
                    else
                    {
                        //No order was found
                        errorLabel.Visible = true;
                        errorLabel.Text = "Could not load the orders' details";
                    }


                }
            }
            else
            {
                //No order selected
                errorLabel.Visible = true;
                errorLabel.Text = "Please select an order";
            }
        }

        private void userInput_TextChanged(object sender, EventArgs e)
        {
            int orderNum = this.validateOrderNumber(userInput.Text);
            if (orderNum == -1)
            {
                //Invalid order number entered
                errorLabel.Visible = true;
                errorLabel.Text = "An invalid order number was selected";
            }
            else
            {
                var order = this.db.FetchOrderDetails(orderNum);
                if (order.Count() == 1)
                {
                    //Order found and displayed
                    foreach (var o in order)
                    {
                        errorLabel.Visible = false;
                        orderNumberLabel.Text = o.order_number.ToString();
                        orderDateLabel.Text = o.order_date.ToShortDateString();
                        salePriceLabel.Text = "£" + o.sale_price.ToString();
                        depositLabel.Text = "£" + o.deposit.ToString();
                        customerNumberLabel.Text = o.customer_number.ToString();
                        customerNameLabel.Text = o.forename.ToString() + " " + o.surname.ToString();
                        customerTelephoneLabel.Text = o.telephone_number.ToString();
                        branchNameLabel.Text = o.branch_name.ToString();
                        postcodeLabel.Text = o.postcode.ToString();
                    }
                }
                else
                {
                    //No order details were found
                    errorLabel.Visible = true;
                    errorLabel.Text = "Could not load the orders' details";
                }
            }
        }

        private void searchByDate_Click(object sender, EventArgs e)
        {
            DateTime startDate = startDateInput.Value;
            DateTime endDate = endDateInput.Value;

            var orderNumbers = this.db.FetchOrderNumbersByDate(startDate, endDate);
            if (orderNumbers.Count() > 0)
            {
                //Update the order number list with the orders between the start and end date
                errorLabel.Visible = false;
                orderList.Items.Clear();
                foreach (var o in orderNumbers)
                {
                    orderList.Items.Add(o.order_number);
                }
            }
            else
            {
                //No orders were found
                errorLabel.Visible = true;
                errorLabel.Text = "No orders were found between those dates.";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Search all orders and reset the order number list.
            if (this.orderNumberList.Count() != 0)
            {
                orderList.Items.Clear();
                foreach (var o in orderNumberList)
                {
                    orderList.Items.Add(o.order_number);
                }
            }
        }
    }
}
