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
    public partial class UCcategories : UserControl
    {
        UCitem ucitem = new UCitem();
        BindingSource bindingSource = new BindingSource();
        DataTable table = new DataTable();
        public UCcategories()
        {
            InitializeComponent();
        }

        private void UCcategories_Load(object sender, EventArgs e)
        {
            InitializeDataTable();
            Reader();
        }

        private void InitializeDataTable()
        {
            // Initialize the DataTable
            table = new DataTable();
            //table.Columns.Add("ItemCode", typeof(int));
            table.Columns.Add("Category", typeof(string));

            bindingSource = new BindingSource { DataSource = table };

            // Bind DataGridView and BindingNavigator
            dataGridView_category.DataSource = bindingSource;
            bindingNavigator1.BindingSource = bindingSource;
            // Set column widths
            setColumnsWidth();
        }

        private void Writer()
        {
            try
            {
                Directory.CreateDirectory("Data");
                using (StreamWriter writer = new StreamWriter("Data\\file_category.bin", append: true))
                {

                    writer.WriteLine($"{textBox_category.Text}");
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
                                table.Rows.Add(fields[0]);
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
            dataGridView_category.Columns["Category"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            font();
        }

        private void font()
        {
            dataGridView_category.EnableHeadersVisualStyles = false;

            dataGridView_category.ColumnHeadersDefaultCellStyle.BackColor = Color.Turquoise;
            dataGridView_category.ColumnHeadersDefaultCellStyle.Font = new Font("Kh Muol", 9, FontStyle.Regular);

            //dataGridView_item.Columns["ItemCode"].DefaultCellStyle.Font = new Font("Lucida Bright", 9, FontStyle.Regular);
            dataGridView_category.Columns["Category"].DefaultCellStyle.Font = new Font("Lucida Bright", 9, FontStyle.Regular);
        }

        private string loop()
        {
            table.Columns["ItemCode"].AutoIncrement = true;
            table.Columns["ItemCode"].AutoIncrementSeed = 100;
            table.Columns["ItemCode"].AutoIncrementStep = 1;
            return table.ToString();
        }

        private void button_addCategory_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                Writer();
                Reader(); // Refresh data grid after writing
                textBox_category.Clear();
            }

        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(textBox_category.Text))
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
                using (StreamWriter writer = new StreamWriter("Data\\file_category.bin", false)) // Overwrite the file
                {
                    foreach (DataRow row in table.Rows)
                    {
                        writer.WriteLine($"{row["Category"]}");
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
            if (dataGridView_category.CurrentRow != null)
            {
                var rowIndex = dataGridView_category.CurrentRow.Index;
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
            if (dataGridView_category.CurrentRow != null)
            {
                var rowIndex = dataGridView_category.CurrentRow.Index;

                if (ValidateInputs())
                {
                    // Update the DataTable
                    table.Rows[rowIndex]["Category"] = textBox_category.Text;

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

        private void toolStripButton_dalete_Click(object sender, EventArgs e)
        {
            if (dataGridView_category.CurrentRow != null)
            {
                var rowIndex = dataGridView_category.CurrentRow.Index;
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
    }
}
