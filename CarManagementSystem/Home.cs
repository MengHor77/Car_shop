using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class Home : Form
    {
        UCitem item = new UCitem();
        UCcategories categories = new UCcategories();
        UCcustomer customer = new UCcustomer();
        UCexchange exchange = new UCexchange();
        public Home()
        {
            InitializeComponent();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            panel8.Controls.Add(item);
        }

        private void button_item_Click(object sender, EventArgs e)
        {
            if (button_item.Enabled == true)
            {
                panel_item.BackColor = Color.DarkOrange;

                panel_categories.BackColor = Color.Transparent;
                panel_customer.BackColor = Color.Transparent;
                panel_exchange.BackColor = Color.Transparent;

                panel8.Controls.Clear();
                panel8.Controls.Add(item);
            }
            else
            {
                panel_item.BackColor = Color.Transparent;

                panel8.Controls.Clear();
            }
        }

        private void button_categories_Click(object sender, EventArgs e)
        {
            if (button_categories.Enabled == true)
            {
                panel_categories.BackColor = Color.DarkOrange;

                panel_item.BackColor = Color.Transparent;
                panel_customer.BackColor = Color.Transparent;
                panel_exchange.BackColor = Color.Transparent;

                panel8.Controls.Clear();
                panel8.Controls.Add(categories);
            }
            else
            {
                panel_categories.BackColor= Color.Transparent;

                panel8.Controls.Clear();
            }
        }

        private void button_customer_Click(object sender, EventArgs e)
        {
            if (button_customer.Enabled == true)
            {
                panel_customer.BackColor = Color.DarkOrange;

                panel_item.BackColor = Color.Transparent;
                panel_categories.BackColor = Color.Transparent;
                panel_exchange.BackColor = Color.Transparent;

                panel8.Controls.Clear();
                panel8.Controls.Add(customer);
            }
            else
            {
                panel_customer.BackColor = Color.Transparent;

                panel8.Controls.Clear();
            }
        }

        private void button_exchange_Click(object sender, EventArgs e)
        {
            if (button_exchange.Enabled == true)
            {
                panel_exchange.BackColor = Color.DarkOrange;

                panel_item.BackColor = Color.Transparent;
                panel_categories.BackColor = Color.Transparent;
                panel_customer.BackColor = Color.Transparent;

                panel8.Controls.Clear();
                panel8.Controls.Add(exchange);
            }
            else
            {
                panel_exchange.BackColor = Color.Transparent;

                panel8.Controls.Clear();
            }
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Program.frmHome.Hide();
            Program.frmLogin.Show();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
