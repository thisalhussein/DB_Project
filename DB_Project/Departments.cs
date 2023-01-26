﻿using DB_Project;
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
    public partial class Departments : Form
    {
        Function Con;
        public Departments()
        {
            InitializeComponent();
            Con = new Function();
            showDepartments();
        }

        private void showDepartments()
        {
            string Query = "Select * from DepartmentTb1";
            DeptList.DataSource = Con.SetData(Query);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    String Dep = DepNameTb.Text;
                    string Query = "insert into DepartmentTb1 values ('{0}')";
                    Query = string.Format(Query, DepNameTb.Text);
                    Con.SetData(Query);
                    showDepartments();
                    MessageBox.Show("Department Added!!!");
                    DepNameTb.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Departments_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
