using System;
using System.Data;
using System.IO;
using System.Management;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SRS_IMproject
{
    public partial class Student : Form
    {
        private MySqlConnection connection;
        private const string connectionString = "server=localhost;database=student_record;user=root;password=";

        public Student()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
            displayData();
        }

        private void displayData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to fetch data from a table (Replace TableName with your table name)
                    string query = "SELECT * FROM student_tbl";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the data to the DataGridView
                    dataGridView_std.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button_stdmenu_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void button_stdadd_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO student_tbl (`Stud_FirstName`, `Stud_LastName`, MI,`Stud_Gender`, `Stud_ContactNum`, `Stud_Address`) " +
                               "VALUES (@FirstName ,@LastName, @MI, @Gender,  @ContactNo, @Address)";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@FirstName", textBox_stdfname.Text);
                cmd.Parameters.AddWithValue("@LastName", textBox_stdlname.Text);
                cmd.Parameters.AddWithValue("@MI", textBox_stdmi.Text);
                cmd.Parameters.AddWithValue("@Gender", textBox_stdgender.Text);
                cmd.Parameters.AddWithValue("@ContactNo", textBox_contactno.Text);
                cmd.Parameters.AddWithValue("@Address", textBox_add.Text);

                textBox_stdfname.Text = null;
                textBox_stdlname.Text = null;
                textBox_stdgender.Text = null;
                textBox_contactno.Text = null;
                textBox_stdmi.Text = null;
                textBox_add.Text = null;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Student added successfully!");
                dataGridView_std.DataSource = null;
                displayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding student: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button_stdupdate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM student_tbl", connection);
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);

                    DataTable changes = ((DataTable)dataGridView_std.DataSource).GetChanges();

                    if (changes != null)
                    {
                        adapter.Update(changes);
                        ((DataTable)dataGridView_std.DataSource).AcceptChanges();
                        MessageBox.Show("Changes saved to the database.");
                        dataGridView_std.DataSource = null;
                        displayData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button_stsdelete_Click(object sender, EventArgs e)
        {
            if (dataGridView_std.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_std.SelectedRows[0];
                int rowIndex = selectedRow.Index;

                // Get the ID or primary key value of the row to be deleted
                int rowID = Convert.ToInt32(selectedRow.Cells["studentID"].Value); // Replace "ID_Column" with your column name

                // Remove the row from the DataGridView
                dataGridView_std.Rows.RemoveAt(rowIndex);

                // Update the database to reflect the deletion
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string deleteQuery = "DELETE FROM student_tbl WHERE studentID = @ID"; // Replace YourTableName and ID_Column
                        MySqlCommand command = new MySqlCommand(deleteQuery, connection);
                        command.Parameters.AddWithValue("@ID", rowID);
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if the deletion was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Row deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Deletion failed or no matching record found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void button_stdrefresh_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void button_stdprint_Click(object sender, EventArgs e)
        {
            ExportToCSV();
        }

        private void textBox_stdsearch_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void dataGridView_std_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExportToCSV()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM student_tbl"; // Replace YourTableName with your table name

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Create a SaveFileDialog
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "CSV File (*.csv)|*.csv";
                        saveFileDialog.Title = "Save CSV File";
                        saveFileDialog.FileName = "data.csv"; // Default file name

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Get the chosen file path
                            string filePath = saveFileDialog.FileName;

                            using (StreamWriter streamWriter = new StreamWriter(filePath))
                            {
                                // Write the column headers
                                foreach (DataColumn column in dataTable.Columns)
                                {
                                    streamWriter.Write(column.ColumnName + ",");
                                }
                                streamWriter.WriteLine();

                                // Write the data rows
                                foreach (DataRow row in dataTable.Rows)
                                {
                                    for (int i = 0; i < dataTable.Columns.Count; i++)
                                    {
                                        streamWriter.Write(row[i].ToString() + ",");
                                    }
                                    streamWriter.WriteLine();
                                }
                            }

                            MessageBox.Show("Data exported to CSV successfully.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void SearchData(string searchText)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand();
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    string query = "SELECT * FROM student_tbl WHERE Stud_FirstName LIKE @searchText OR  Stud_LastName LIKE @searchText"; // Replace YourTableName and columnName

                    cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                    cmd.CommandText = query;
                    cmd.Connection = connection;

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                        dataGridView_std.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button_stdsearch_Click(object sender, EventArgs e)
        {
            string search = textBox_stdsearch.Text;
            SearchData(search);
        }
    }
}
