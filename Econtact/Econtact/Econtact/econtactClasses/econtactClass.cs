using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econtact.econtactClasses
{
    internal class econtactClass
    {
        //  Getter Setter Properties
        // Acts as a Data Carrier in Our Application
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Selecting Data From Database

        public DataTable Select()
        {
            // Step 1: Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //  Step 2: Writing Sql query
                string sql = "Select * from tbl_contact";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating sqlAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {


            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //Inserting Data Into Database
        public bool Insert(econtactClass c)
        {
            // Creating a default return type and setting its value to false
            bool isSuccess = false;

            // step 1 : Connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                // step 2 : create sql query to insert data
                string sql = "INSERT INTO tbl_contact (FirstName, LastName, ContactNo, Address, Gender) Values(@FirstName, @LastName, @ContactNo, @Address, @Gender)";
                //Creating sql Coomand usingg sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                // Create Parameters to add data 
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);

                // Connection Open Here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query run successfully then value of rows greater than zero else value will
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {

                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {


            }
            finally
            {

                conn.Close();
            }
            return isSuccess;

        }
        // Method to update data in database From  our application
        public bool Update(econtactClass c)
        {
            // create default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQL to update our data in database
                string sql = "Update tbl_contact SET FirstName=@FirstName, LastName=@LastName,ContactNo=@ContactNo,Address=@Address,Gender=@Gender WHERE ContactID= @ContactID";

                //Creating sql Coomand 
                SqlCommand cmd = new SqlCommand(sql, conn);
                // Create Parameters to add data 
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("ContactID", c.ContactID);
                //Open database connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {

                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {


            }

            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        // method to delete data form our datbase
        public bool Delete(econtactClass c)
        {
            // create default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //SQL to delete table
                string sql = "DELETE FROM  tbl_contact WHERE ContactID= @ContactID";

                //Creating sql Coomand 
                SqlCommand cmd = new SqlCommand(sql, conn);
                // Create Parameters to add data 
    
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);
                //Open database connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {

                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {


            }

            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}