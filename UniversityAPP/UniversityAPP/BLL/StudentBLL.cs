using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityAPP.DAL.DAO;
using UniversityAPP.DAL.GetWay;

namespace UniversityAPP.BLL
{
    class StudentBLL
    {
        private  StudentGetWay aStudentGetWay= new StudentGetWay();
        public string Save(Student aStudent)
        {
            return aStudentGetWay.Save(aStudent);
        }

        public List<Student> GetAllRegNo()
        {
            List<Student> aCourselist = aStudentGetWay.GetAllCourse();
            return aCourselist;
        }
    }
}
