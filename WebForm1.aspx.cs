using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;


namespace ProjectCourse
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection connect;
        SqlCommand command;
        SqlDataReader reader;
        String connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=CourseDB;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(connectionString);

            try
            {
                connect.Open();
                Response.Write("Connection Successfull!!!");            //Veritabanı bağlantısını sayfa yüklenirken kontrol
                connect.Close();                                        //etmek için yazdığım kod bloğudur.
            }
            catch (Exception)
            {

                Response.Write("Check Your Connection!!!");
            }
        }

        protected void ButtonCourse_Click(object sender, EventArgs e)
        {
            connect = new SqlConnection(connectionString);
            command = new SqlCommand("Select ID as 'Course ID', Name as 'Course Name' From Courses", connect);

            connect.Open();
            reader = command.ExecuteReader();
            CourseTable.Columns.Clear();
            CourseTable.DataSourceID = null;
            CourseTable.DataKeyNames = null;
            CourseTable.AutoGenerateColumns = true;
            CourseTable.DataSource = reader;
            CourseTable.DataBind();
            reader.Close();
            connect.Close();
        }

        protected void ButtonStudent_Click(object sender, EventArgs e)
        {
            connect = new SqlConnection(connectionString);
            command = new SqlCommand("Select ID as 'Student ID', Name as 'First Name', Surname From Students", connect);

            connect.Open();
            reader = command.ExecuteReader();
            CourseTable.Columns.Clear();
            CourseTable.DataSourceID = null;
            CourseTable.DataKeyNames = null;
            CourseTable.AutoGenerateColumns = true;
            CourseTable.DataSource = reader;
            CourseTable.DataBind();
            reader.Close();
            connect.Close();
        }

        protected void ButtonClass_Click(object sender, EventArgs e)
        {
            connect = new SqlConnection(connectionString);
            command = new SqlCommand("Select Class.Name as 'Class Name', Courses.Name as 'Given Course Name', COUNT(Courses.ID) as 'Number Of Students' From TakenCourses INNER JOIN Courses ON TakenCourses.CourseID = Courses.ID INNER JOIN Class ON Courses.ID = Class.CourseID Group By Class.Name, Courses.Name; ", connect);

            connect.Open();
            reader = command.ExecuteReader();
            CourseTable.Columns.Clear();
            CourseTable.DataSourceID = null;
            CourseTable.DataKeyNames = null;
            CourseTable.AutoGenerateColumns = true;
            CourseTable.DataSource = reader;
            CourseTable.DataBind();
            reader.Close();
            connect.Close();
        }

        protected void ButtonTakenCourse_Click(object sender, EventArgs e)
        {
            connect = new SqlConnection(connectionString);
            command = new SqlCommand("Select Students.Name, Courses.Name From TakenCourses INNER JOIN Students ON TakenCourses.StudentID = Students.ID INNER JOIN Courses ON TakenCourses.CourseID = Courses.ID", connect);

            connect.Open();
            reader = command.ExecuteReader();
            CourseTable.Columns.Clear();
            CourseTable.DataSourceID = null;
            CourseTable.DataKeyNames = null;
            CourseTable.AutoGenerateColumns = true;
            CourseTable.DataSource = reader;
            CourseTable.DataBind();
            reader.Close();
            connect.Close();
        }
    }
}