//Online Ticket Purchase form

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurchaseTicketUI
{
    public partial class PurchaseTicketUI : Form
    {
        private int numberofTickets = 0;
        private double unitPrice = 100;
        private String customerName = " ";
        private double totalPrice = 0;


        public PurchaseTicketUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void details_Click(object sender, EventArgs e)
        {

        }

        private void PurchaseTicketUI_Load(object sender, EventArgs e)
        {

        }

        private void totalaprice_Click(object sender, EventArgs e)
        {
            numberofTickets = Convert.ToInt32(numberofticketscombo.Text);
            customerName = Customernametext.Text;
            totalPrice = unitPrice * numberofTickets;
            paymenttext.Text = totalPrice.ToString();
            unitpricetext.Text = unitPrice.ToString();
            MessageBox.Show(customerName + " Please pay " + totalPrice + " Take to purchase " + numberofTickets + " ticket(s).");
          
        }

        private void TotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void numberofTickets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Name: " +customerName + "\n Unit Price: " + unitPrice + "\n Total Price: " + totalPrice );
        }

        private void Customernametext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
