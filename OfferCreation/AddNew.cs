using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfferCreation
{
    public partial class AddNew : Form
    {
        private bool isAdmin;
        public AddNew(bool admin)
        {
            InitializeComponent();
            isAdmin = admin;
            if (admin)
            {
                DBConnect employeeConnection = new DBConnect();
                dataGridViewEmployees.DataSource= employeeConnection.ListFromDB(isAdmin);
                radioButtonNewEmployee.Visible = true;
                dataGridViewEmployees.Visible = true;

            }
            DBConnect userConnection = new DBConnect();
            dataGridViewCustomers.DataSource = userConnection.ListFromDB(false);
        }

        private void radioButtonNewEmployee_CheckedChanged(object sender, EventArgs e)
        {
            Switcher(true);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButtonNewCustomer_CheckedChanged(object sender, EventArgs e)
        {
            Switcher(false);
        }

        private void Switcher(bool employee)
        {
            if (employee)
            {
                labelContactPerson.Text = "Password";
                checkBoxAdminstrator.Visible = true;
                labelAddress.Visible = false;
                textBoxAddress.Visible = false;
            }
            else
            {
                labelContactPerson.Text = "Contact";
                checkBoxAdminstrator.Visible = false;
                labelAddress.Visible = true;
                textBoxAddress.Visible = true;
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            bool success = false;
            bool createCustomer = radioButtonNewCustomer.Checked;
            DBConnect creationConnection = new DBConnect();

            if (createCustomer)
            {
                string companyName = textBoxName.Text.ToString().Trim();
                string contactName = textBoxContactorPassword.Text.ToString().Trim();
                string address = textBoxAddress.Text.ToString().Trim();
                if (companyName.Equals("") | contactName.Equals("") | address.Equals(""))
                {
                    MessageBox.Show("Fill all the fields!");
                }
                else { 
                    success = creationConnection.InsertNewCustomerUser(companyName, contactName, address);
                    if (success)
                        {
                            MessageBox.Show("New Customer added!");
                            DBConnect userConnection = new DBConnect();
                            dataGridViewCustomers.DataSource = userConnection.ListFromDB(false);
                        }
                    else
                        {
                            MessageBox.Show("Error!");
                        }
                    }
            }
            else if (!createCustomer)
            {
                string employeeName = textBoxName.Text.ToString().Trim();
                string password = textBoxContactorPassword.Text.ToString().Trim();
                if (employeeName.Equals("") | password.Equals(""))
                {
                    MessageBox.Show("Fill all the fields!");
                }
                else
                {
                    success = creationConnection.InsertNewCustomerUser(employeeName, password, checkBoxAdminstrator.Checked);
                    if (success)
                    {
                        MessageBox.Show("New Employee added!");
                        DBConnect userConnection = new DBConnect();
                        dataGridViewEmployees.DataSource = userConnection.ListFromDB(true);
                    }
                    else
                    {
                        MessageBox.Show("Error!");
                    }
                }
            }
        }
    }
}
