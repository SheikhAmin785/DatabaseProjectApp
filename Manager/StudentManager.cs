using DatabaseProjectApp.Gateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseProjectApp.Manager
{
    public class StudentManager
    {
        StudentGateway studentgateway = new StudentGateway();
        public List<StdentModel> Getstudents()
        {
            return studentgateway.GetStudents();
        }
    }
}