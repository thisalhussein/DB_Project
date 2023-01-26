using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class department : Form
    {
        Function Con;
        public department()
        {
            InitializeComponent();
            Con = new Function();
            ListerDepartments();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void department_Load(object sender, EventArgs e)
        {

        }
        private void ListerDepartments()
        {
            string Query = "Select = form DepartmentTbl";
            DepList = DataSource = Con.GetData(Query);
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(DepNameTb.Text == "")
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }   
        }
    }
}
