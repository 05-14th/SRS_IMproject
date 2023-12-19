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
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;

namespace SRS_IMproject
{
    public partial class Subject : Form
    {
        private string connectionString = "server=localhost;database=student_record;user=root;password=";
        public Subject()
        {
            InitializeComponent();
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
                    string query = "SELECT * FROM subject_tbl";

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

        private void button_save_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string subjectID = textBox_stdfname.Text;
            string subjectName = textBoxstdlname.Text;
            string teacherId = textBox_contactno.Text;
            string subName = textBox_add.Text;
            string marks = textBox_stdid.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Assuming you have text boxes named txtFirstName and txtLastName for user input
                    string query = "INSERT INTO subject_tbl VALUES (@SubjectID, @SubjectName, @TeacherID, @SubName, @Marks)";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@SubjectID", subjectID);
                    command.Parameters.AddWithValue("@SubjectName", subjectName);
                    command.Parameters.AddWithValue("@TeacherID", teacherId);
                    command.Parameters.AddWithValue("@SubName", subName);
                    command.Parameters.AddWithValue("@Marks", marks);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Data inserted successfully!");
                    dataGridView_std.DataSource = null;
                    displayData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                   
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_std.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_std.SelectedRows[0];
                int rowIndex = selectedRow.Index;

                // Get the ID or primary key value of the row to be deleted
                int rowID = Convert.ToInt32(selectedRow.Cells["SubjectID"].Value); // Replace "ID_Column" with your column name

                // Remove the row from the DataGridView
                dataGridView_std.Rows.RemoveAt(rowIndex);

                // Update the database to reflect the deletion
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string deleteQuery = "DELETE FROM subject_tbl WHERE SubjectID = @ID"; // Replace YourTableName and ID_Column
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

        private void button_update_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM subject_tbl", connection);
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

        private void ExportToCSV()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM subject_tbl"; // Replace YourTableName with your table name

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

        private void button1_Click(object sender, EventArgs e)
        {
            ExportToCSV();
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
                    string query = "SELECT * FROM subject_tbl WHERE SubjectName LIKE @searchText"; // Replace YourTableName and columnName

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

        private void button2_Click(object sender, EventArgs e)
        {
            string searchObject = textBox1.Text;
            SearchData(searchObject);
        }
    }



}
