using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class UCcustomer : UserControl
    {
        BindingSource bindingSource = new BindingSource();
        DataTable table = new DataTable();
        public UCcustomer()
        {
            InitializeComponent();
        }

        private void UCcustomer_Load(object sender, EventArgs e)
        {
            InitializeDataTable();
            ReaderItem();
            Reader();
        }

        private void InitializeDataTable()
        {
            // Initialize the DataTable
            table = new DataTable();
            //table.Columns.Add("ItemCode", typeof(int));
            table.Columns.Add("Customer Name", typeof(string));
            table.Columns.Add("Gender", typeof(string));
            table.Columns.Add("Phone Number", typeof(string));
            table.Columns.Add("Item", typeof(string));

            bindingSource = new BindingSource { DataSource = table };

            // Bind DataGridView and BindingNavigator
            dataGridView_customer.DataSource = bindingSource;
            bindingNavigator1.BindingSource = bindingSource;
            // Set column widths
            setColumnsWidth();
        }

        private void Writer()
        {
            try
            {
                Directory.CreateDirectory("Data");
                using (StreamWriter writer = new StreamWriter("Data\\file_customer.bin", append: true))
                {

                    writer.WriteLine($"{textBox_customerName.Text}/{gender()}/" +
                        $"{textBox_phone.Text}/{comboBox_item.SelectedItem}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to file: {ex.Message}");
            }
        }

        private string gender()
        {
            return radioButton_male.Checked ? "Male" : "Female";
        }

        private void Reader()
        {
            try
            {
                if (File.Exists("Data\\file_customer.bin"))
                {
                    table.Clear(); // Clear existing rows

                    using (StreamReader reader = new StreamReader("Data\\file_customer.bin"))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            var fields = line.Split('/');
                            if (fields.Length == 4)
                            {
                                table.Rows.Add(fields[0], fields[1], fields[2], fields[3]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}");
            }
        }

        private void setColumnsWidth()
        {
            //dataGridView_item.Columns["ItemCode"].Width = 100;
            dataGridView_customer.Columns["Customer Name"].Width = 250;
            dataGridView_customer.Columns["Gender"].Width = 200;
            dataGridView_customer.Columns["Phone Number"].Width = 200;
            dataGridView_customer.Columns["Item"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            font();
        }

        private void font()
        {
            dataGridView_customer.EnableHeadersVisualStyles = false;

            dataGridView_customer.ColumnHeadersDefaultCellStyle.BackColor = Color.Turquoise;
            dataGridView_customer.ColumnHeadersDefaultCellStyle.Font = new Font("Kh Muol", 9, FontStyle.Regular);

            //dataGridView_item.Columns["ItemCode"].DefaultCellStyle.Font = new Font("Lucida Bright", 9, FontStyle.Regular);
            dataGridView_customer.Columns["Customer Name"].DefaultCellStyle.Font = new Font("Lucida Bright", 9, FontStyle.Regular);
            dataGridView_customer.Columns["Gender"].DefaultCellStyle.Font = new Font("Lucida Bright", 9, FontStyle.Regular);
            dataGridView_customer.Columns["Phone Number"].DefaultCellStyle.Font = new Font("Lucida Bright", 9, FontStyle.Regular);
            dataGridView_customer.Columns["Item"].DefaultCellStyle.Font = new Font("Lucida Bright", 9, FontStyle.Regular);
        }

        private string loop()
        {
            table.Columns["ItemCode"].AutoIncrement = true;
            table.Columns["ItemCode"].AutoIncrementSeed = 100;
            table.Columns["ItemCode"].AutoIncrementStep = 1;
            return table.ToString();
        }

        private void button_addCustomer_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                Writer();
                Reader(); // Refresh data grid after writing
                textBox_customerName.Clear();
                textBox_phone.Clear();
                comboBox_item.SelectedItem = null;
            }

        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textBox_customerName.Text) ||
                string.IsNullOrWhiteSpace(textBox_phone.Text) ||
                comboBox_item.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields before adding.");
                return false;
            }

            return true;
        }

        // save data to file after deleted
        private void SaveDataToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("Data\\file_customer.bin", false)) // Overwrite the file
                {
                    foreach (DataRow row in table.Rows)
                    {
                        writer.WriteLine($"{row["Customer Name"]}/{row["Gender"]}/{row["Phone Number"]}/{row["Item"]}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}");
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_customer.CurrentRow != null)
            {
                var rowIndex = dataGridView_customer.CurrentRow.Index;
                //MessageBox.Show(rowIndex.ToString());
                // Confirm deletion
                var confirmResult = MessageBox.Show("Are you sure to delete this item?",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {

                    // Remove the row from the DataTable
                    table.Rows[rowIndex].Delete();

                    // Save changes to file
                    SaveDataToFile();

                    MessageBox.Show("Row deleted successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView_customer.CurrentRow != null)
            {
                var rowIndex = dataGridView_customer.CurrentRow.Index;

                if (ValidateInputs())
                {
                    // Update the DataTable
                    table.Rows[rowIndex]["Customer Name"] = textBox_customerName.Text;
                    table.Rows[rowIndex]["Gender"] = gender();
                    table.Rows[rowIndex]["Phone Number"] = textBox_phone.Text;
                    table.Rows[rowIndex]["Item"] = comboBox_item.SelectedItem;

                    // Save changes to file
                    SaveDataToFile();

                    MessageBox.Show("Row updated successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                Writer();
                Reader(); // Refresh data grid after writing
            }
        }

        private void toolStripButton_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_customer.CurrentRow != null)
            {
                var rowIndex = dataGridView_customer.CurrentRow.Index;
                //MessageBox.Show(rowIndex.ToString());
                // Confirm deletion
                var confirmResult = MessageBox.Show("Are you sure to delete this item?",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {

                    // Remove the row from the DataTable
                    table.Rows[rowIndex].Delete();

                    // Save changes to file
                    SaveDataToFile();

                    MessageBox.Show("Row deleted successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void ReaderItem()
        {
            try
            {
                if (File.Exists("Data\\file_item.bin"))
                {
                    table.Clear(); // Clear existing rows

                    using (StreamReader reader = new StreamReader("Data\\file_item.bin"))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            var fields = line.Split('/');
                            if (fields.Length == 1)
                            {
                                comboBox_item.Items.Add(fields[0]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}");
            }
        }
    }
}
