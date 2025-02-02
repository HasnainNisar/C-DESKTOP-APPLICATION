using Econtact.econtactClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Econtact
{
    public partial class Econtact : Form
    { 
        public Econtact()
        {
            InitializeComponent();
        }
        econtactClass c = new econtactClass();

        private string txtboxContactNO;
        private object txtboxContactNumber;
        private object txtBoxContactNumber;
        private object txtboxContactNo;

        private void Econtact_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContactID_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get the value from the inpt fields
            c.FirstName = txtboxLastname.Text;
            c.LastName = txtboxLastname.Text;
            c.ContactNo = txtbocContactNO.Text;
            c.Address = txtboxAddress.Text;
            c.Gender = cmbGender.SelectedValue.ToString();

            // Inserting Data into database using method we created in perivious episode
            bool success = c.Insert(c);
            if (success)
            {
                MessageBox.Show("New Contact Successfully Inserted.")
                     }
            else
            {
                MessageBox.Show("Failed to add contact. Please try again.");
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
