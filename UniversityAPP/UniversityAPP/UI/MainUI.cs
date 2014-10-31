using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityAPP
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void courseentryButton_Click(object sender, EventArgs e)
        {
            CourceEntry acCourceEntry = new CourceEntry();
            acCourceEntry.Show();
        }

        private void studententryButton_Click(object sender, EventArgs e)
        {
            StudentEntry aStudentEntry = new StudentEntry();
            aStudentEntry.Show();
        }

        private void enrollmentButton_Click(object sender, EventArgs e)
        {
            Enrollment aEnrollment = new Enrollment();
            aEnrollment.Show();
        }
    }
}
