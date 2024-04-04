using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseRegistrationSystem
{

    public class DatabaseControllerV2
    {
        // fields
        readonly OleDbConnection myConnection;
        readonly OleDbCommand myCommand;
        readonly OleDbDataAdapter myAdapter;
        DataSet dataSet;

        // constructor
        public DatabaseControllerV2()
        {
            // Initialize Database connection stuff
            string strConnection = "provider=Microsoft.ACE.OLEDB.12.0;" +
                        "Data Source=Resources/CRSDB.accdb;";
            myConnection = new OleDbConnection(strConnection);
            myCommand = new OleDbCommand(string.Empty, myConnection);
            myAdapter = new OleDbDataAdapter(myCommand);
        }

        public Dictionary<string, Course> GetCourseList()
        {
            // Gets all courses from Course table in database
            // Returns Dictionary of (code, Course)
            Dictionary<string, Course> courseList = new Dictionary<string, Course>();
            myCommand.CommandText = "SELECT * FROM Course";
            dataSet = new DataSet();
            try
            {
                myConnection.Open();
                myAdapter.Fill(dataSet, "Course");
            }
            catch (OleDbException ex) { Console.WriteLine(ex.Message); }
            finally
            {
                myConnection.Close();
            }

            DataTable tableCourses = dataSet.Tables["Course"];
            foreach (DataRow row in tableCourses.Rows)
            {
                List<string> courseData = new List<string>();
                foreach (object col in row.ItemArray)
                {
                    courseData.Add(col.ToString());
                }
                // Create course and add to list
                string code = courseData[0];
                courseList[code] = new Course(courseData);
            }
            return courseList;
        }
        public List<string> GetStudentCourseCodes(string studentID, string semester)
        {
            string tableName = "StudentCourses";
            myCommand.CommandText = "SELECT Code FROM Registration WHERE Student_ID = '" + studentID + "'";
            if (semester != null) { myCommand.CommandText += " AND Semester = '" + semester + "'"; }
            dataSet = new DataSet();
            try
            {
                myConnection.Open();
                myAdapter.Fill(dataSet, tableName);
            }
            catch (OleDbException ex) { Console.WriteLine(ex.Message); }
            finally { myConnection.Close(); }

            List<string> courseCodes = new List<string>();
            foreach (DataRow row in dataSet.Tables[tableName].Rows)
            {
                courseCodes.Add(row.ItemArray[0].ToString());
            }
            return courseCodes;
        }
        public void ModifyCourse(string[] newData)
        {
            string[] colHeaders = new string[] 
            { 
                "Code","Department","Title","Description",
                "Credits","Prereqs","Days","StartTime","EndTime",
                "MaxSeats","AvailableSeats","Professor","ImageUrl"
            };
            try
            {
                myConnection.Open();
                // Append changes to SQL string
                List<string> changes = new List<string>();
                for (int i = 0; i < newData.Length; i++)
                {
                    changes.Add(string.Format("{0} = '{1}'", colHeaders[i], newData[i]));
                }
                myCommand.CommandText = "UPDATE Course SET " + string.Join(", ", changes.ToArray()) +
                    "WHERE Code = '" + newData[0] + "'";
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex) { Console.WriteLine(ex.Message); }
            finally
            {
                myConnection.Close();
            }
        }

        public void AddCourse(string[] courseData)
        {
            try
            {
                myConnection.Open();
                // Append changes to SQL string
                List<string> changes = new List<string>();
                myCommand.CommandText = "INSERT INTO Course VALUES ('" + string.Join("','", courseData) + "')";
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex) { Console.WriteLine(ex.Message); }
            finally
            {
                myConnection.Close();
            }
        }

        public void DeleteCourse(string courseCode)
        {
            try
            {
                myConnection.Open();
                // Append changes to SQL string
                List<string> changes = new List<string>();
                myCommand.CommandText = "DELETE FROM Course WHERE Code = '" + courseCode + "'";
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex) { Console.WriteLine(ex.Message); }
            finally
            {
                myConnection.Close();
            }
        }

        public DataView GetAllStudents()
        {
            dataSet = new DataSet();
            try
            {
                myConnection.Open();
                myCommand.CommandText = "SELECT * FROM Student";
                myAdapter.Fill(dataSet, "Student");
            }
            catch (OleDbException ex) { Console.WriteLine(ex.Message); }
            finally { myConnection.Close(); }
            return new DataView(dataSet.Tables["Student"]);
        }
        public DataView GetCourseRoster(string code)
        {
            dataSet = new DataSet();
            try
            {
                myConnection.Open();
                myCommand.CommandText = "SELECT DISTINCT s.Student_ID, s.Student_Name FROM Student s INNER JOIN Registration r on s.Student_ID = r.Student_ID WHERE Code = '" + code + "'";
                myAdapter.Fill(dataSet, "Student");
            }
            catch (OleDbException ex) { Console.WriteLine(ex.Message); }
            finally { myConnection.Close(); }
            return new DataView(dataSet.Tables["Student"]);
        }

        public void AddRegistration(Registration registration)
        {
            try
            {
                myConnection.Open();
                myCommand.CommandText = "INSERT INTO Registration VALUES ('" + string.Join("','", registration.ToArray()) + "')";
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex) { Console.WriteLine(ex.Message); }
            finally { myConnection.Close(); }
        }
    }
}
