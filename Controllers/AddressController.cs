using DatabaseProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseProjectApp.Controllers
{
    public class AddressController : Controller
    {


        public ActionResult Newstudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Newstudent(StudentModel students) {
            SqlConnection con = new SqlConnection("Data Source=ALAMIN785;Initial Catalog=StudentDatabase;Integrated Security = true;");
            con.Open();
            string query = "insert into StudentsTable(Name,RegNo,Email,Address,Department)values('" + students.Name + "','" + students.RegNo + "','" + students.Email + "','" + students.Address + "','" + students.Department + "')";
            SqlCommand cmd = new SqlCommand(query, con);

            int rowcount = cmd.ExecuteNonQuery();

            if (rowcount > 0)
            {
                mgs = "save data successfully";
            }
            else { mgs = " data failure";
            }
            return View();
        }
    
        public ActionResult Index()
        {
          
            StudentModel studentnew = new StudentModel();
            studentnew.Name = "kamal";
            studentnew.RegNo = "abcde";
            studentnew.Email = "shakil785kw@gmail.com";
            studentnew.Address = "Tangail";
            studentnew.Department = "Computer science";
            ViewBag.StudentModel = studentnew;
            return View();
        }

        public ActionResult GetAll()
        {
            ViewBag.Department = GetDepartments();
            return View();
        }

        public List<string> GetDepartments()
        {
            return List<string>(){ "cse","eee","eng"};


       

        public List<StudentModel> GetStudentModel()
        {
            return new List<StudentModel>
            {

      new StudentModel(Name="jamal",RegNo="cbec",Email="shakil@gmail",Address="Dhalapara",Department="Science");
        };
    }
   

}
    
