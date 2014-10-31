using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityAPP.DAL.DAO;
using UniversityAPP.DAL.GetWay;

namespace UniversityAPP.BLL
{
    class CourceBLL
    {
        private  CourcesGetWay acCourcesGetWay = new CourcesGetWay();
        public string Save(Coursce aCoursce)
        {
            return acCourcesGetWay.Save(aCoursce);
        }

        
        public List<Coursce> GetAllCources()
        {
            List<Coursce> aCourselist = acCourcesGetWay.GetAllCourse();
            return aCourselist;
        }
    }
}
