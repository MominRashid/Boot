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
    public partial class CourceEntry : Form
    {
        public CourceEntry()
        {
            InitializeComponent();
        }

        private  CourceBLL aCourceBll = new CourceBLL();
        private Coursce aCoursce;
        private void saveButton_Click(object sender, EventArgs e)
        {
            aCoursce = new Coursce();
            aCoursce.Code = codeTextBox.Text;
            aCoursce.Name = nameTextBox.Text;
            aCoursce.Cradit = Convert.ToDouble(craditTextBox.Text);
            string mess = aCourceBll.Save(aCoursce);
            MessageBox.Show(mess);

        }
    }
}
