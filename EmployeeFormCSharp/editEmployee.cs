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
    public partial class editEmployee : Form
    {
        public editEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            menu mainMenu = new menu();
            mainMenu.Show();
        }

        private void submit_Click(object sender, EventArgs e)
        {
           
            //If file exists employeeData txt file will open in notepad
            if (File.Exists(@"employeeData.txt"))
            {
                System.Diagnostics.Process.Start("notepad.exe", "employeeData.txt");
            }
        }

       

       
    }
    }

