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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarManagementSystem
{
    public partial class UCitem : UserControl
    {
        BindingSource bindingSource = new BindingSource();
        DataTable table = new DataTable();
        public UCitem()
        {
            InitializeComponent();
        }

        private void UCitem_Load(object sender, EventArgs e)
        {
            InitializeDataTable();
            ReaderCategory();
            Reader();
        }

        private void InitializeDataTable()
        {
            // Initialize the DataTable
            //table.Columns.Add("ItemCode", typeof(int));
            table.Columns.Add("Brand Name", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("Price $", typeof(string));
            table.Columns.Add("In Stock", typeof(string));
            table.Columns.Add("Manufacurer", typeof(string));

            bindingSource = new BindingSource { DataSource = table };

            // Bind DataGridView and BindingNavigator
            dataGridView_item.DataSource = bindingSource;
            bindingNavigator1.BindingSource = bindingSource;
            // Set column widths
            setColumnsWidth();
        }

        private void Writer()
        {
            try
            {
                Directory.CreateDirectory("Data");
                using (StreamWriter writer = new StreamWriter("Data\\file_item.bin", append: true))
                {

                    writer.WriteLine($"{textBox_itemName.Text}/{comboBox_category.SelectedItem}/" +
                        $"{textBox_price.Text}/{textBox_stock.Text}/" +
                        $"{textBox_manufacurer.Text}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to file: {ex.Message}");
            }
        }

        private void Reader()
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
                            if (fields.Length == 5)
                            {
                                table.Rows.Add(fields[0], fields[1], fields[2], fields[3], fields[4]);
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
            dataGridView_item.Columns["Brand Name"].Width = 200;
            dataGridView_item.Columns["Category"].Width = 200;
            dataGridView_item.Columns["Price $"].Width = 150;
            dataGridView_item.Columns["In Stock"].Width = 150;
            dataGridView_item.Columns["Manufacurer"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            font();
        }

        private void font()
        {   
            dataGridView_item.EnableHeadersVisualStyles = false;

            dataGridView_item.ColumnHeadersDefaultCellStyle.BackColor = Color.Turquoise;
            dataGridView_item.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 9, FontStyle.Regular);

            //dataGridView_item.Columns["ItemCode"].DefaultCellStyle.Font = new Font("Lucida Bright", 9, FontStyle.Regular);
            dataGridView_item.Columns["Brand Name"].DefaultCellStyle.Font = new Font("Lucida Bright", 9, FontStyle.Regular);
            dataGridView_item.Columns["Category"].DefaultCellStyle.Font = new Font("Lucida Bright", 9, FontStyle.Regular);
            dataGridView_item.Columns["Price $"].DefaultCellStyle.Font = new Font("Lucida Bright", 9, FontStyle.Regular);
            dataGridView_item.Columns["In Stock"].DefaultCellStyle.Font = new Font("Lucida Bright", 9, FontStyle.Regular);
            dataGridView_item.Columns["Manufacurer"].DefaultCellStyle.Font = new Font("Lucida Bright", 9, FontStyle.Regular);
        }

        private string loop()
        {
            table.Columns["ItemCode"].AutoIncrement = true;
            table.Columns["ItemCode"].AutoIncrementSeed = 100;
            table.Columns["ItemCode"].AutoIncrementStep = 1;
            return table.ToString();
        }

        private void button_additem_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                Writer();
                Reader(); // Refresh data grid after writing
                textBox_itemName.Clear();
                comboBox_category.SelectedItem = null;
                textBox_price.Clear();
                textBox_stock.Clear();
                textBox_manufacurer.Clear();
            }

        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textBox_itemName.Text) ||
                string.IsNullOrWhiteSpace(textBox_stock.Text) ||
                string.IsNullOrWhiteSpace(textBox_price.Text) ||
                comboBox_category.SelectedItem == null)
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
                using (StreamWriter writer = new StreamWriter("Data\\file_item.bin", false)) // Overwrite the file
                {
                    foreach (DataRow row in table.Rows)
                    {
                        writer.WriteLine($"{row["Brand Name"]}/{row["Category"]}/{row["Price $"]}/{row["In Stock"]}/{row["Manufacurer"]}");
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
            if (dataGridView_item.CurrentRow != null)
            {
                var rowIndex = dataGridView_item.CurrentRow.Index;
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
            if (dataGridView_item.CurrentRow != null)
            {
                var rowIndex = dataGridView_item.CurrentRow.Index;

                if (ValidateInputs())
                {
                    // Update the DataTable
                    table.Rows[rowIndex]["Brand Name"] = textBox_itemName.Text;
                    table.Rows[rowIndex]["Category"] = comboBox_category.SelectedItem;
                    table.Rows[rowIndex]["Price $"] = textBox_price.Text;
                    table.Rows[rowIndex]["In Stock"] = textBox_stock.Text;
                    table.Rows[rowIndex]["Manufacurer"] = textBox_manufacurer.Text;

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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView_item.CurrentRow != null)
            {
                var rowIndex = dataGridView_item.CurrentRow.Index;
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

        private void ReaderCategory()
        {
            try
            {
                if (File.Exists("Data\\file_category.bin"))
                {
                    table.Clear(); // Clear existing rows

                    using (StreamReader reader = new StreamReader("Data\\file_category.bin"))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            var fields = line.Split('/');
                            if (fields.Length == 1)
                            {
                                comboBox_category.Items.Add(fields[0]);
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
