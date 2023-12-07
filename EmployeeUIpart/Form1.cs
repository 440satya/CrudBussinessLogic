﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudBussinessLogic;
using CrudDataLogic;

namespace EmployeeUIpart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValid = EmployeeBussinessLogic.AddEmployee(textBox1.Text, textBox2.Text, decimal.Parse(textBox3.Text));

                if (isValid)
                {
                    EmployeeDataLogic.AddEmployee(textBox1.Text, textBox2.Text, decimal.Parse(textBox3.Text));

                    Message_Box.Text = "Employee added successfully!";
                    ClearTextBoxes();
                }
                else
                {
                    Message_Box.Text = "Validation failed. Please check the input.";
                }
            }
            catch (Exception ex)
            {
                Message_Box.Text = "Error: " + ex.Message;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            Message_Box.Text = string.Empty;

        }

        private void ClearTextBoxes()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }
    }
}
