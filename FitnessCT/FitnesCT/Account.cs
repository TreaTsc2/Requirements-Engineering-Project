using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace FitnessCT
{
    class Account
    {
        private int userID;
        private String surname;
        private String forename;
        private String email;
        private String password;
        private DateTime DOB;
        private Decimal height;
        private Decimal weight;
        private String gender;
        private int activityLevelID;
        private int dailyCalorieGoal;


        public Account()
        {
            this.userID = 0;
            this.surname = "";
            this.forename = "";
            this.email = "";
            this.password = "";
            this.DOB = new System.DateTime();
            this.height = 0;
            this.weight = 0;
            this.gender = "";
            this.activityLevelID = 0;
            this.dailyCalorieGoal = 0;
        }

        public Account(int userID, string surname, string forename, string email, string password, DateTime DOB, decimal height, decimal weight, string gender, int activityLevelID, decimal dailyCalorieGoal)
        {
            this.userID = userID;
            this.surname = surname;
            this.forename = forename;
            this.email = email;
            this.password = password;
            this.DOB = DOB;
            this.height = height;
            this.weight = weight;
            this.gender = gender;
            this.activityLevelID = activityLevelID;
            this.dailyCalorieGoal = (int)dailyCalorieGoal;
        }

        // Getters
        public int GetUserID() { return this.userID; }
        public string GetSurname() { return this.surname; }
        public string GetForename() { return this.forename; }
        public string GetEmail() { return this.email; }
        public string GetPassword() { return this.password; }
        public DateTime GetDOB() { return this.DOB; }
        public decimal GetHeight() { return this.height; }
        public decimal GetWeight() { return this.weight; }
        public string GetGender() { return this.gender; }
        public int GetActivityLevelID() { return this.activityLevelID; }
        public int GetDailyCalorieGoal() { return this.dailyCalorieGoal; }

        // Setters
        public void SetUserID(int userID) { this.userID = userID; }
        public void SetSurname(string surname) { this.surname = surname; }
        public void SetForename(string forename) { this.forename = forename; }
        public void SetEmail(string email) { this.email = email; }
        public void SetPassword(string password) { this.password = password; }
        public void SetDOB(DateTime DOB) { this.DOB = DOB; }
        public void SetHeight(decimal height) { this.height = height; }
        public void SetWeight(decimal weight) { this.weight = weight; }
        public void SetGender(string gender) { this.gender = gender; }
        public void SetActivityLevelID(int activityLevelID) { this.activityLevelID = activityLevelID; }
        public void SetDailyCalorieGoal(int dailyCalorieGoal) { this.dailyCalorieGoal = dailyCalorieGoal; }

        public static decimal GetActivityMultiplier(int activityLevelId)
        {
            decimal multiplier = 1m; //Default if non found
            

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                string query = "SELECT LevelCoefficient FROM ActivityLevel WHERE ActivityLevelID = :activityLevelId";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("activityLevelId", activityLevelId));

                try
                {
                    conn.Open();
                    OracleDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        multiplier = reader.GetDecimal(0); // Get the first column
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    
                    Console.WriteLine(ex.Message);
                }
            }

            return multiplier;
        }


        public void CalculateDailyCalorieGoal()
        {
            
            int age = DateTime.Now.Year - this.DOB.Year;
            if (this.DOB > DateTime.Now.AddYears(-age)) age--;

           
            decimal BMR = 0;
            if (this.gender == "Male") 
            {
                BMR = 88.4m + (13.4m * this.weight) + (4.8m * this.height) - (5.7m * age);
            }
            else if (this.gender == "Female")
            {
                BMR = 447.6m + (9.2m * this.weight) + (3.1m * this.height) - (4.3m * age);
            }
            int userActivityLevelId = GetActivityLevelID();

            Console.WriteLine("Gender: " + this.gender);

            decimal activityMultiplier = GetActivityMultiplier(userActivityLevelId);
            Console.WriteLine("Activity Multiplier: " + activityMultiplier); //Test multiplier
            Console.WriteLine("BMR: " + BMR); //Test BMR
           
            this.dailyCalorieGoal = (int)(BMR * activityMultiplier);

        }

        public static int getNextUserID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(UserID) FROM Accounts";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //Does dr contain a value or NULL?
            int nextId;
            dr.Read();

            if (dr.IsDBNull(0))
                nextId = 1;
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }

            //Close db connection
            conn.Close();

            return nextId;
        }

        public void RegisterUser()
        {
            // Open a database connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            string sqlQuery = "INSERT INTO Accounts Values(" +
                this.userID + ", '" +   
                this.surname + "', '" +  
                this.forename + "', '" + 
                this.email + "', '" +    
                this.password + "', " +  
                "TO_DATE('" + this.DOB.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD'), " + 
                this.height + ", " +     
                this.weight + ", '" +    
                this.gender + "', " +    
                this.activityLevelID + ", " + 
                this.dailyCalorieGoal + ")";

            //Test Sql Query
            Console.WriteLine(sqlQuery); //Test BMR

            // Create the OracleCommand object
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            // Open the connection to the database
            conn.Open();

            // Execute the SQL query
            cmd.ExecuteNonQuery();

            // Close the database connection
            conn.Close();
        }

        public static int GetCalorieGoal(int userID) {
            int calorieGoal = 0;
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
                try
                {
                    conn.Open();
                    string query = "SELECT DailyCalorieGoal FROM Accounts WHERE UserID = :userID";
                    OracleCommand cmd = new OracleCommand(query, conn);

                    cmd.Parameters.Add(new OracleParameter("userID", userID));

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        calorieGoal = Convert.ToInt32(result);
                    }
                }


                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                 return calorieGoal;
                    
                }

        public static Boolean UpdateWeightDetails(int userID, double weight, int activityLevelID)
        {
            bool valid = false;
            int dailyCalorieGoal;
            DateTime DOB = DateTime.Today; //Placeholder value
            string gender = "";
            int height = 0;
            int age = 0;
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT height FROM Accounts WHERE UserID = :userID";
                    OracleCommand cmd = new OracleCommand(query, conn);

                    cmd.Parameters.Add(new OracleParameter("userID", userID));

                    object resultHeight = cmd.ExecuteScalar();
                    if (resultHeight != null)
                    {
                        height = Convert.ToInt32(resultHeight);
                    }

                    string queryTwo = "SELECT DOB FROM Accounts WHERE UserID = :userID";
                    OracleCommand cmdTwo = new OracleCommand(queryTwo, conn);

                    cmdTwo.Parameters.Add(new OracleParameter("userID", userID));

                    object resultDOB = cmdTwo.ExecuteScalar();
                    if (resultDOB != null)
                    {
                        DOB = Convert.ToDateTime(resultDOB);
                    }


                    string queryThree = "SELECT Gender FROM Accounts WHERE UserID = :userID";
                    OracleCommand cmdThree = new OracleCommand(queryThree, conn);

                    cmdThree.Parameters.Add(new OracleParameter("userID", userID));

                    object resultGender = cmdThree.ExecuteScalar();
                    if (resultDOB != null)
                    {
                        gender = (String)resultGender;
                    }


                    if (activityLevelID == 0)
                    {
                        string queryFour = "SELECT ActivityLevelID FROM Accounts WHERE UserID = :userID";
                        OracleCommand cmdFour = new OracleCommand(queryFour, conn);

                        cmdFour.Parameters.Add(new OracleParameter("userID", userID));

                        object resultActivityLevelID = cmdFour.ExecuteScalar();
                        if (resultDOB != null)
                        {
                            activityLevelID = Convert.ToInt32(resultActivityLevelID);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

            }

            age = DateTime.Now.Year - DOB.Year;



            decimal BMR = 0;
            if (gender == "Male")
            {
                BMR = 88.4m + (13.4m * Convert.ToDecimal(weight)) + (4.8m * height) - (5.7m * age);
            }
            else if (gender == "Female")
            {
                BMR = 447.6m + (9.2m * Convert.ToDecimal(weight)) + (3.1m * height) - (4.3m * age);
            }

            decimal activityMultiplier = Account.GetActivityMultiplier(activityLevelID);

            dailyCalorieGoal = (int)(BMR * activityMultiplier);
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {

                try
                {
                    string queryUpdate = "UPDATE Accounts SET weight = " + weight + ", DailyCalorieGoal = " + dailyCalorieGoal + ", ActivityLevelID = " + activityLevelID + " WHERE UserID = " + userID;

                    OracleCommand cmdUpdate = new OracleCommand(queryUpdate, conn);
                    conn.Open();

                    Console.WriteLine(queryUpdate);

                    int rowsAffected = cmdUpdate.ExecuteNonQuery();
                    Console.WriteLine(rowsAffected + " rows affected.");
                    if (rowsAffected > 0)
                    {
                        valid = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

            }

            return valid;
        }



    }
}



    



