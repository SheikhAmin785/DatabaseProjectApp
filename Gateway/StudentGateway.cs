using DatabaseProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DatabaseProjectApp.Gateway
{
    public class StudentGateway 
    {
        public List<StudentModel> GetStudents()
        {
            SqlConnection con = new SqlConnection("Data Source=ALAMIN785;Initial Catalog=StudentDatabase;Integrated Security = true;");
            string query = "select * from StudentsTable";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<StudentModel> students = new List<StudentModel>;

            while (reader.Read())
            {

                StudentModel student = new StudentModel();
                student.Name = reader.["Name"].ToString();
                student.RegNo = reader.["RegNo"].ToString();
                student.Email = reader.["Email"].ToString();
                student.Address = reader.["Address"].ToString();
                student.Department = reader.["Department"].ToString();
                student.Add(StudentModel);
            }

            con.Close();

            return students;
        }
        
    }
}
