using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EmployeeFormCSharp
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            createEmployee create = new createEmployee();
            create.Show();
            this.Hide();




        }

        private void button4_Click(object sender, EventArgs e)
        {

            Paystub paystub = new Paystub();
            paystub.Show();
            this.Hide();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            editEmployee editEmp= new editEmployee();
            editEmp.Show();
            this.Hide();

        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Employee Data";
            saveFileDialog1.ShowDialog();





        }
    }
}
