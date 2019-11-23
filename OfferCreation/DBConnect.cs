using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OfferCreation
{
    class DBConnect
    {
        String dataBaseStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OfferDatabase;Integrated Security=True";
        SqlConnection dbConnection;
        public string currentUser;
        public bool isAdmin;

        public DBConnect() {    
        try
            {
                dbConnection = new SqlConnection(dataBaseStr);
                dbConnection.Open();
                Console.WriteLine("DB Connected");
            }
            catch (Exception es)
            {
                Console.WriteLine("DB Failed --> " + es);
            }
        }

        public Boolean checkUser()
        {
            try
            {
                string query = "Select * from Employees";
                SqlDataAdapter sda = new SqlDataAdapter(query, dbConnection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count <1)
                {
                    query = "Insert into Employees(EmployeeName, EmployeePassword, Adminstrator) values('admin', 'pass', 1)";
                    using (SqlCommand command = new SqlCommand(query, dbConnection))
                    {
                        command.ExecuteNonQuery();
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception es)
            {
                Console.WriteLine("Error -->" + es);
                return false;
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public DataTable ListFromDB(bool admin)
        {
            string query;
            try {
                if (admin)
                {
                    query = "SELECT EmployeeName,Adminstrator from Employees";
                }
                else
                {
                    query = "SELECT CustomerName,ContactPerson,Address from Customers";
                }
            
            SqlDataAdapter sda = new SqlDataAdapter(query, dbConnection);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
                return dtbl;
            }
            catch (Exception es)
            {
                Console.WriteLine("Error -->" + es);
            }
            finally
            {
                dbConnection.Close();
            }
            return null;
        }

        public bool SignIn(String Login, String Password)
        {
            bool success = false;
            try
            {
                string query = "Select * from Employees Where EmployeeName = '" + Login +
                    "'and EmployeePassword = '" + Password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, dbConnection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    DataRow[] rows = dtbl.Select();
                    currentUser = dtbl.Rows[0]["EmployeeName"].ToString();
                    if (dtbl.Rows[0]["Adminstrator"].ToString() == "True")
                    {
                        isAdmin = true;
                    }
                    else
                    {
                        isAdmin = false;
                    }
                    success = true;
                }
            }
            catch (Exception es)
            {
                Console.WriteLine("Error -->" + es);
            }
            finally
            {
                dbConnection.Close();
            }
            return success;
        }

        public string CheckOffer(string offerTitle,string customer)
        {
            string query = "Select * from Offers where (Title = '" + offerTitle + "' AND Customer = '" + customer + "')";
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, dbConnection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 0)
                {
                    return "new";
                }
                else if (dtbl.Rows.Count == 1)
                {
                    return "existing";
                }
                else
                { return "error"; }
            } catch (Exception es)
            {
                Console.WriteLine("Error --> " + es);
                return "error";
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public bool InsertNewCustomerUser(string company, string contact, string address)
        {
            bool success = false;
            try { 
            string query = "Insert into Customers (CustomerName, ContactPerson, Address) VALUES (@CustomerName,@ContactPerson,@Address)";
            SqlCommand command = new SqlCommand(query, dbConnection);
                command.Parameters.AddWithValue("@CustomerName", company);
                command.Parameters.AddWithValue("@ContactPerson", contact);
                command.Parameters.AddWithValue("@Address", address);
                command.ExecuteNonQuery();
                success = true;
            }
            catch
            (Exception es)
            {
                Console.WriteLine("Error -->" + es);
            }
            finally
            {
                dbConnection.Close();
            }
            return success;
        }

        public bool InsertNewCustomerUser(string employee, string password, bool admin)
        {
            bool success = false;
            try
            {
                string query = "Insert into Employees (EmployeeName, EmployeePassword, Adminstrator) VALUES (@EmployeeName,@EmployeePassword,@Adminstrator)";
                SqlCommand command = new SqlCommand(query, dbConnection);
                command.Parameters.AddWithValue("@EmployeeName", employee);
                command.Parameters.AddWithValue("@EmployeePassword", password);
                command.Parameters.AddWithValue("@Adminstrator", admin);
                command.ExecuteNonQuery();
                success = true;
            }
            catch
            (Exception es)
            {
                Console.WriteLine("Error -->" + es);
            }
            finally
            {
                dbConnection.Close();
            }
            return success;
        }

        public DataTable FillComboBox()
        {
            try { 
                string query = "Select CustomerName from Customers";
                SqlDataAdapter sda = new SqlDataAdapter(query, dbConnection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                return dtbl;
            }
            catch
           (Exception es)
            {
                Console.WriteLine("Error -->" + es);
                return null;
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public DataTable FillComboBoxOffers(string currentCustomer)
        {
            try
            {
                string query = "Select Title from Offers where Customer ='"+currentCustomer+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, dbConnection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                return dtbl;
            }
            catch
           (Exception es)
            {
                Console.WriteLine("Error -->" + es);
                return null;
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public void DeleteOldData(string offerTitle, string customerName)
        {
            try
            {
                string query = "DELETE FROM Offers where (Title = '" + offerTitle + "' AND Customer = '" + customerName + "')";
                using (SqlCommand command = new SqlCommand(query, dbConnection))
                {
                    command.ExecuteNonQuery();
                }
                query = "DELETE FROM PositionList WHERE (OfferTitle = '" + offerTitle + "' AND CustomerName = '" + customerName + "')";
                using (SqlCommand command = new SqlCommand(query, dbConnection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch(Exception es)
            {
                Console.WriteLine("Error Deleting Offer -->" + es);
            }

        }

        public bool SaveData(string offerTitle, string customerName, string userName, string workSite, string offerCommentary)
        {
            try
            {
                string query = "Insert into Offers (Title, Customer, Employee, Worksite, Commentary) VALUES (@Title, @Customer, @Employee, @Worksite, @Commentary)";
                SqlCommand offerCommand = new SqlCommand(query, dbConnection);
                offerCommand.Parameters.AddWithValue("@Title", offerTitle);
                offerCommand.Parameters.AddWithValue("@Customer", customerName);
                offerCommand.Parameters.AddWithValue("@Employee", userName);
                offerCommand.Parameters.AddWithValue("@Worksite", workSite);
                offerCommand.Parameters.AddWithValue("@Commentary", offerCommentary);
                offerCommand.ExecuteNonQuery();
                Console.WriteLine("Saving Data success");
                return true;
                
            }

            catch (Exception es)
            {
                Console.WriteLine("Error Saving Offer -->" + es);
                Console.WriteLine("Saving Data failed");
                return false;
            }
        }

        public void SavePosition(string offerTitle, string customer, string description, string unit, string count, string labor, string materials, string equipment)
        {
            try {
                Console.WriteLine("Writing in Positionlist");
            string query = "Insert into PositionList (OfferTitle, CustomerName, Description, Unit, Count, Labor, Materials, Equipment) VALUES (@OfferTitle,@CustomerName,@Description,@Unit,@Count,@Labor,@Materials,@Equipment)";
            SqlCommand positionCommand = new SqlCommand(query, dbConnection);
            positionCommand.Parameters.AddWithValue("@OfferTitle", offerTitle);
            positionCommand.Parameters.AddWithValue("@CustomerName", customer);
            positionCommand.Parameters.AddWithValue("@Description", description);
            positionCommand.Parameters.AddWithValue("@Unit", unit);
            positionCommand.Parameters.AddWithValue("@Count", count);
            positionCommand.Parameters.AddWithValue("@Labor", labor);
            positionCommand.Parameters.AddWithValue("@Materials", materials);
            positionCommand.Parameters.AddWithValue("@Equipment", equipment);
            positionCommand.ExecuteNonQuery();
            }
            catch (Exception es)
            {
                Console.WriteLine("Error Saving Offer -->" + es);
            }
        }

        internal DataTable GetOfferPositionList(string currentCustomer, string offerTitle)
        {
            try
            {
                string query = "Select * FROM PositionList WHERE (OfferTitle = '" + offerTitle + "' AND CustomerName = '" + currentCustomer + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, dbConnection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                return dtbl;
            }
            catch
           (Exception es)
            {
                Console.WriteLine("Error -->" + es);
                return null;
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public DataTable GetOfferDetails(string title)
        {
            try
            {
                string query = "Select * from Offers where Title ='" + title + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, dbConnection);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                return dtbl;
            }
            catch
           (Exception es)
            {
                Console.WriteLine("Error -->" + es);
                return null;
            }
            finally
            {
                dbConnection.Close();
            }
        }

        public void CloseConnection()
        {
            dbConnection.Close();
        }
    }
}
