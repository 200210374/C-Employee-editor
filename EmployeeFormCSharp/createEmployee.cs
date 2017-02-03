using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;




namespace EmployeeFormCSharp
{
    public partial class createEmployee : Form
    {
        public createEmployee()
        {
            InitializeComponent();
        }

        private void createEmployee_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            menu mainMenu = new menu();
            mainMenu.Show();


        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            string path = "employeeData.txt";



            if (!File.Exists(path))
            {
                // Create a file to write to.
                string createText = Environment.NewLine + "Name:" + nameTextBox.Text + Environment.NewLine +
                    "Position:" + positionTextBox.Text + Environment.NewLine + "Annual Pay:" + salarytextBox.Text + Environment.NewLine;




                File.WriteAllText(path, createText);
            }
            else
            {

                string appendText = Environment.NewLine + "Name:" + nameTextBox.Text + Environment.NewLine +
                        "Position:" + positionTextBox.Text + Environment.NewLine + "Annual Pay:" + salarytextBox.Text + Environment.NewLine;

                File.AppendAllText(path, appendText);

                MessageBox.Show("Employee record created");
            }

              
            }

      
    }


    }


