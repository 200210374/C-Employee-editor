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
    public partial class Paystub : Form
    {
        public Paystub()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
     

         

            

            
  

        private void employeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           



           
        }





        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            menu mainMenu = new menu();
            mainMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {


           

                   using (StreamReader reader = File.OpenText("employeeData.txt"))
            {
                for (var i = 0; i < 500; i++)
                    employeeDataRichTextBox.Text += reader.ReadLine() + "\r\n";
                    reader.Close();
            }

            



        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            employeeDataRichTextBox.Clear();
            
        }

       


    }
    }


