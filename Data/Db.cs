using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Data
{
    public class Db

    {
        private static MySqlConnection connection;
       
       
        public void InitializeDb()
        {
            string ConnectionString = "SERVER=localhost;DATABASE=calculatordb;UID=root;PASSWORD=";
            connection = new MySqlConnection(ConnectionString);
        }
        public DataTable GetAllCalculations()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM calculations", connection);
            this.OpenConnection();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            this.CloseConnection();
            
            return dt;
        }
        public bool Insert(int ID, string RecentCalculations )
        {
           
            string query = "INSERT INTO `calculations` (`ID`, `RecentCalculations`) VALUES (@ID, @RecentCalculations)"; ;
           
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@RecentCalculations", RecentCalculations);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                    return true;
                }
                catch (MySqlException ex)
                {
                    //return false;
                    //MessageBox.Show(ex.Message);

                }
            }
            return false;
        }
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
               
                return false;
            }
        }

    }
}
