using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginFormAssesment
{
    internal class DBConnection
    {
        private SqlConnection conn;

        public DBConnection()
        {
            try
            {
                conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\yonat\\source\\repos\\LoginFormAssesment\\DB.mdf;Integrated Security=True;Connect Timeout=30");
                MessageBox.Show("Connected to the database");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }
        public int InsertData(string tableName, string firstName, string lastName, int age, string type)
        {
            try
            {
                conn.Open();
                string queryInfo = "INSERT INTO " + tableName + " (FirstName, LastName, Age, Type) VALUES ('" + firstName + "','" + lastName + "','" + age + "','" + type + "')";

                string username = lastName + "_" + firstName + "@" + $"{age}";

                string queryAccount = $"INSERT INTO AccountTbl (UserName, Password, infoID) VALUES ('{username}', '123', '{firstName}')";

                //save user data to info table
                SqlCommand cmd = new SqlCommand(queryInfo, conn);
                cmd.ExecuteNonQuery();

                //account creation for the registerd user
                cmd = new SqlCommand(queryAccount, conn);



                MessageBox.Show("info inserted successfully");
                try
                {
                    int row = cmd.ExecuteNonQuery();

                    MessageBox.Show("Account inserted successfully");
                    return row;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return 0;
            }
            finally
            {
                conn.Close();
            }
        }
        public (Boolean, Dictionary<string, object>) login(string username, string password)
        {
            Dictionary<string, object> fileData = new Dictionary<string, object>();
            SqlDataReader reader = null;

            try
            {
                conn.Open();
                // First query to check if user exists in AccountTbl
                string query = $"SELECT * FROM AccountTbl WHERE UserName = '{username}' AND Password = '{password}'";
                SqlCommand cmd = new SqlCommand(query, conn);

                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string firstName = reader["infoID"].ToString();

                    // Close the first reader before executing the second query
                    reader.Close();

                    // Second query to fetch data from InfoTbl based on infoID (firstName in this case)
                    query = $"SELECT * FROM InfoTbl WHERE FirstName = '{firstName}'";
                    cmd = new SqlCommand(query, conn);

                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        fileData["Type"] = reader["Type"].ToString();
                        fileData["FirstName"] = reader["FirstName"].ToString();
                        fileData["LastName"] = reader["LastName"].ToString();
                        fileData["Age"] = reader["Age"].ToString();
                        return (true, fileData);
                    }
                    else
                    {
                        MessageBox.Show("User information not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return (false, null);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                conn.Close();
            }

            return (false, null);
        }
    }
    }
