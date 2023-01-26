﻿using System;
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
            Showdepartment();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void department_Load(object sender, EventArgs e)
        {

        }
        private void Showdepartment()
        {
            string Query = "Select * from DepartmentTbl";
            DepL.DataSource = Con.GetData(Query);
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data !");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "Insert into DepartmentTbl values('{0}')";
                    Query = string.Format(Query, DepNameTb.Text);
                    Con.SetData(Query);
                    Showdepartment();
                    MessageBox.Show("Department Added");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data !");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "Insert into DepartmentTbl values('{0}')";
                    Query = string.Format(Query, DepNameTb.Text);
                    Con.SetData(Query);
                    Showdepartment();
                    MessageBox.Show("Department Added");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int Key = 0;
        private void DepL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DepNameTb.Text = DepL.SelectedRows[0].Cells[0].Value.ToString();
            if(DepNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DepL.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data !");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "Update DepartmentTbl set DepName = '{0}' where DepId = {1}";
                    Query = string.Format(Query, DepNameTb.Text, Key);
                    Con.SetData(Query);
                    Showdepartment();
                    MessageBox.Show("Department Updated");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data !");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "Dlete from DepartmentTbl where DepId = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    Showdepartment();
                    MessageBox.Show("Department Deleted");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data !");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "Insert into DepartmentTbl values('{0}')";
                    Query = string.Format(Query, DepNameTb.Text);
                    Con.SetData(Query);
                    Showdepartment();
                    MessageBox.Show("Department Added");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        
    }
}
