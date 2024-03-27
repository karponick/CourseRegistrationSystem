using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CourseRegistrationSystem
{
    internal class DatabaseController
    {
        // fields
        OleDbConnection myConnection;
        OleDbCommand myCommand;
        OleDbDataAdapter myAdapter;
        DataSet dataSet;

        // constructor
        public DatabaseController()
        {
            // Initialize Database connection stuff
            string strConnection = "provider=Microsoft.ACE.OLEDB.12.0;" +
                        "Data Source=Resources/CRSDB.accdb;";
            myConnection = new OleDbConnection(strConnection);
            myCommand = new OleDbCommand(string.Empty, myConnection);
            myAdapter = new OleDbDataAdapter(myCommand);
        }

        public DataTable GetTable(string tableName)
        {
            // Returns table given by "tableName"
            myCommand.CommandText = "SELECT * FROM " + tableName;
            dataSet = new DataSet(tableName);
            try
            {
                myConnection.Open();
                myAdapter.Fill(dataSet, tableName);
            }
            catch (OleDbException ex) { Console.WriteLine(ex.Message); }
            finally
            {
                myConnection.Close();
            }
            return dataSet.Tables[tableName];
        }

        public void UpdateTable(Dictionary<string, Course> courseList)
        {
            try
            {
                myConnection.Open();
                foreach (string code in courseList.Keys)
                {
                    Course course = courseList[code];
                    DataTable table = dataSet.Tables["Courses"]; // Get table
                    string[] pKeys = new string[table.Rows.Count]; // Get list of primary keys
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        pKeys[i] = table.Rows[i][0].ToString();
                    }
                    string[] colHeaders = new string[table.Columns.Count]; // Get column headers
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        colHeaders[i] = table.Columns[i].ColumnName;
                    }

                    bool newEntry = true;
                    // Loop over primary keys to see if table contains course
                    for (int i = 0; i < pKeys.Length; i++)
                    {
                        string key = pKeys[i].ToString();
                        // If course is already in course, update the row
                        if (key == code)
                        {
                            UpdateRow(table.Rows[i], courseList[code].ToArray());
                            newEntry = false;
                            break;
                        }
                    }

                    if (newEntry) // If course is not in table, create a new row
                    {
                        InsertRow(table, colHeaders, courseList[code].ToArray());
                    }
                    
                }
                OleDbCommandBuilder builder = new OleDbCommandBuilder(myAdapter);
                myAdapter.Update(dataSet, "Courses");
            }
            catch (OleDbException ex) { Console.WriteLine(ex.Message); }
            finally
            {
                myConnection.Close();
            }
        }

        public void InsertRow(DataTable table, string[] colHeaders, string[] newRow)
        {
            // Creates a new row and inserts data for each column header
            DataRow row = table.NewRow();
            for (int i = 0; i < colHeaders.Length; i++)
            {
                row[colHeaders[i]] = newRow[i];
            }
            table.Rows.Add(row);
        }
        public void UpdateRow(DataRow row, string[] updatedRow)
        {
            // Updates an existing row with any new data
            for (int i = 0; i < updatedRow.Length - 1; i++)
            {
                if (updatedRow[i] != row.ItemArray[i].ToString())
                {
                    row[i] = updatedRow[i];
                }
            }
        }
        public void DeleteRow()
        {

        }
    }
}
