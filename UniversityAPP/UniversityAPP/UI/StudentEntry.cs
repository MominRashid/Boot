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

namespace UniversityAPP
{
    public partial class StudentEntry : Form
    {
        public StudentEntry()
        {
            InitializeComponent();
        }

        private  StudentBLL aStudentBll = new StudentBLL();
        private  Student aStudent = new Student();
        private void saveButton_Click(object sender, EventArgs e)
        {
            aStudent.Regno = studentregTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.Address = addressTextBox.Text;
            string add = aStudentBll.Save(aStudent);
            MessageBox.Show(add);
        }
    }
}
