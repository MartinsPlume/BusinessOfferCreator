using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OfferCreation
{
    public partial class OfferCreator : Form
    {
        //DBConnect dbConnect;
        User currentUser;
        String currentCustomer = "No Customer Chosen";
        AddNew addNew;

        public OfferCreator(string userName, bool isAdmin)
        {
            currentUser = new User(userName, isAdmin);
            InitializeComponent();

            labelGreeting.Text = "Welcome, " + currentUser.userName.ToString().Trim() + "!";
            fillComboboxCustomers();
            fillComboboxOffers();
        }

        private void fillComboboxOffers()
        {
            try
            {
                DBConnect comboBoxOffersConnection = new DBConnect();
                DataTable dt = comboBoxOffersConnection.FillComboBoxOffers(currentCustomer);
                comboBoxOfferChoice.DataSource = dt;
                comboBoxOfferChoice.ValueMember = dt.Columns[0].ToString();
            }
            catch (Exception es)
            {
                Console.WriteLine("Error -->" + es);
            }
        }

        private void fillComboboxCustomers()
        {
            try
            {
                DBConnect comboBoxConnection = new DBConnect();
                DataTable dt = comboBoxConnection.FillComboBox();
                comboBoxCustomerChoice.DataSource = dt;
                comboBoxCustomerChoice.ValueMember = dt.Columns[0].ToString();
                try
                {
                    currentCustomer = dt.Rows[0]["CustomerName"].ToString();
                    Console.WriteLine(currentCustomer);
                }
                catch (Exception es)
                {
                    Console.WriteLine("Error -->" + es);
                }
            }
            catch (Exception es)
            {
                Console.WriteLine("Error -->" + es);
            }
            finally
            {
                if (currentCustomer.Equals(null))
                {
                    MessageBox.Show("Add new customers!");
                }
            }

        }

        private void dataGridView1_CellValue(object sender, DataGridViewCellEventArgs cell)
        {
            int columnIndex = cell.ColumnIndex;

            double count = 0 ;
            double labor = 0;
            double materials = 0;
            double equipment = 0;
            double totalUnit = 0;


            if (columnIndex > 1 & columnIndex < 6)
                {
                    try { 
                        if (!numberValidator(dataGridView1[cell.ColumnIndex, cell.RowIndex].Value.ToString()))
                    {
                        MessageBox.Show("Enter valid number!");
                        dataGridView1[cell.ColumnIndex, cell.RowIndex].Value = 0;
                        updateLabels(cell.ColumnIndex);
                    }
                    else
                    {
                        try { 
                        double.TryParse(dataGridView1[2, cell.RowIndex].Value.ToString(), out count);
                        double.TryParse(dataGridView1[3, cell.RowIndex].Value.ToString(), out labor);
                        double.TryParse(dataGridView1[4, cell.RowIndex].Value.ToString(), out materials);
                        double.TryParse(dataGridView1[5, cell.RowIndex].Value.ToString(), out equipment);
                        totalUnit = labor + materials + equipment;
                        } 
                        catch (Exception es)
                        {
                            Console.WriteLine(es);
                        }

                        Console.WriteLine(totalUnit);

                        
                        dataGridView1[6, cell.RowIndex].Value = totalUnit.ToString();

                        dataGridView1[7, cell.RowIndex].Value = (count * totalUnit).ToString();

                        updateLabels(cell.ColumnIndex);
                    }
                    }
                    catch (Exception es)
                    {
                        Console.WriteLine("Error occured " + es);
                    }
                }
        }
        void updateLabels(int column)
        {
            double sum = 0;
            double totalSum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[column].Value);
                totalSum += Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
                labelTotalCost.Text = totalSum.ToString();
                labelVatAmount.Text = (totalSum / 4).ToString();
                labelTotalWithVat.Text = (totalSum * 1.25).ToString();

            }
            switch (column)
            {
                case 3:
                    labelLaborCost.Text = sum.ToString() + " EUR";
                        break;
                case 4:
                    labelMaterialCost.Text = sum.ToString() + " EUR";
                        break;
                case 5:
                    labelEquipmentCost.Text = sum.ToString() + " EUR";
                        break;
                default:
                    Console.WriteLine("Error in updateLabels method");
                        break;
            }   
        }
        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            addNew = new AddNew(currentUser.isAdmin);
            addNew.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            fillComboboxCustomers();
        }

        private void comboBoxCustomerChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCustomer=comboBoxCustomerChoice.Text.ToString();
            Console.WriteLine(currentCustomer);
        }

        private bool numberValidator(string enteredValue)
        {
            double value;
            try
            {
                double.TryParse(enteredValue, out value);
                Console.WriteLine(value);
                if (value == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception es)
            {
                Console.WriteLine("Error -->" + es);
                return false;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string offerCheck;
            string offerTitle = textBoxOfferTitle.Text.ToString();
            string workSite = textBoxWorkSite.Text.ToString();
            if (offerTitle.Equals("") || workSite.Equals(""))
            {
                MessageBox.Show("Enter title and work site!");
            }
            else
            {
                DBConnect offerCheckConnection = new DBConnect();

                try
                {
                    offerCheck = offerCheckConnection.CheckOffer(offerTitle,currentCustomer);
                    Console.WriteLine(offerCheck);
                    switch (offerCheck)
                    {
                        case "new":
                            SaveOffer(false);
                            break;
                        case "existing":
                            SaveOffer(true);
                            break;
                        case "error":
                            break;
                    }
                }
                catch (Exception es)
                {
                    Console.WriteLine("Error -->" + es);
                }
            }
            fillComboboxOffers();
        }

        private void SaveOffer(bool existingOffer)
        {
            string offerTitle = textBoxOfferTitle.Text.ToString();
            string workSite = textBoxWorkSite.Text.ToString();
            string offerCommentary = textBoxCommentary.Text.ToString();
            bool success = false;

            DBConnect saveOffer = new DBConnect();
            if (existingOffer)
            {
                saveOffer.DeleteOldData(offerTitle,currentCustomer);
            }

            success = saveOffer.SaveData(offerTitle,
                                         comboBoxCustomerChoice.Text.ToString(),
                                         currentUser.userName,
                                         workSite,
                                         offerCommentary);
            if (success)
            {
                Console.WriteLine("Writing to Database");
                try { 
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    saveOffer.SavePosition(offerTitle,
                        currentCustomer,
                        dataGridView1.Rows[row.Index].Cells[0].Value.ToString(),
                        dataGridView1.Rows[row.Index].Cells[1].Value.ToString(),
                        dataGridView1.Rows[row.Index].Cells[2].Value.ToString(),
                        dataGridView1.Rows[row.Index].Cells[3].Value.ToString(),
                        dataGridView1.Rows[row.Index].Cells[4].Value.ToString(),
                        dataGridView1.Rows[row.Index].Cells[5].Value.ToString());
                }
                }
                catch (Exception es)
                {
                    Console.WriteLine("Error looping DatagridviewRow" + es);
                }
                
            }
            else
            {
                saveOffer.CloseConnection();
            }
            if (success)
            {
                saveOffer.CloseConnection();
                MessageBox.Show("saved!");
            }
        }

        private void comboBoxOfferChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string offerTitle = comboBoxOfferChoice.Text.ToString();
            DBConnect getOfferDetails = new DBConnect();
            Console.WriteLine(offerTitle);
            DataTable dt = new DataTable();
            dt = getOfferDetails.GetOfferDetails(offerTitle);
            try {
                textBoxOfferTitle.Text = dt.Rows[0][1].ToString();
                textBoxWorkSite.Text = dt.Rows[0][4].ToString();
                textBoxCommentary.Text = dt.Rows[0][5].ToString();
            }
            catch (Exception es)
                { 
                    Console.WriteLine("Nothing to load on textboxoffertitle -->" + es); 
                }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DBConnect OfferPositionList = new DBConnect();
            string offerTitle = comboBoxOfferChoice.Text.ToString();
            try
            {
                dt = OfferPositionList.GetOfferPositionList(currentCustomer, offerTitle);
            }
            catch (Exception es)
            {
                Console.WriteLine("Failed loading PositionList -->" + es);
            }

            try {
                clearDataGridview();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][3].ToString();
                dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][4].ToString();
                dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][5].ToString();
                dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i][6].ToString();
                dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i][7].ToString();
                dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i][8].ToString();
                }
            }
            catch (Exception es)
            {
                Console.WriteLine("Error loading " + es);
            }
        }

        private void clearDataGridview()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            textBoxOfferTitle.Text = null;
            textBoxWorkSite.Text = null;
            textBoxCommentary.Text = null;
        }

        private void buttonClearDataGridVIew_Click(object sender, EventArgs e)
        {
            clearDataGridview();
        }

        private void buttonDeleteOffer_Click(object sender, EventArgs e)
        {
            string offerTitle = comboBoxOfferChoice.Text.ToString();
            DBConnect deleteOffer = new DBConnect();
            deleteOffer.DeleteOldData(offerTitle,currentCustomer);
            textBoxOfferTitle.Text = null;
            textBoxWorkSite.Text = null;
            textBoxCommentary.Text = null;
            fillComboboxOffers();
        }
    }
}