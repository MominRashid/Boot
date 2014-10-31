using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityAPP.BLL;
using UniversityAPP.DAL.DAO;
using UniversityAPP.DAL.GetWay;

namespace UniversityAPP
{
    public partial class Enrollment : Form
    {
        public Enrollment()
        {
            InitializeComponent();
            GetAllCorces();
            GetALLRrgNo();
        }

        private CourceBLL acCourceBll = new CourceBLL();
        private  StudentBLL aStudentBll = new StudentBLL();
        private Coursce aCoursce = new Coursce();
        private  Student aStudent = new Student();
        private void GetALLRrgNo()
        {
            List<Student> students = aStudentBll.GetAllRegNo();
            foreach (Student aStudent in students)
            {
                studentregnoComboBox.Items.Add(aStudent);
            }
            studentregnoComboBox.DisplayMember = "Regno";
        }

       
        private void GetAllCorces()
        {
            List<Coursce> coursces = acCourceBll.GetAllCources();

            foreach (Coursce aCoursce in coursces)
            {
                courcenameComboBox.Items.Add(aCoursce);
            }
            courcenameComboBox.DisplayMember = "Name";
        }

        private void enrollButton_Click(object sender, EventArgs e)
        {

        }
    }
}
