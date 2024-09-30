using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FitnessCT
{
    class FoodIntake
    {
        private int intakeID;
        private DateTime intakeDate;
        private int mealTypeID;
        private decimal portionSize;
        private int userID;
        private int foodItemID;
        private int calories; 

        // Default constructor
        public FoodIntake()
        {
            this.intakeID = 0;
            this.intakeDate = DateTime.MinValue;
            this.mealTypeID = 0;
            this.portionSize = 0.0m;
            this.userID = 0;
            this.foodItemID = 0;
            this.calories = 0;
        }

        // Parameterized constructor
        public FoodIntake(int intakeID, DateTime intakeDate, int mealTypeID, decimal portionSize, int userID, int foodItemID, int calories)
        {
            this.intakeID = intakeID;
            this.intakeDate = intakeDate;
            this.mealTypeID = mealTypeID;
            this.portionSize = portionSize;
            this.userID = userID;
            this.foodItemID = foodItemID;
            this.calories = calories;
        }

        // Getters
        public int GetIntakeID() { return this.intakeID; }
        public DateTime GetIntakeDate() { return this.intakeDate; }
        public int GetMealTypeID() { return this.mealTypeID; }
        public decimal GetPortionSize() { return this.portionSize; }
        public int GetUserID() { return this.userID; }
        public int GetFoodItemID() { return this.foodItemID; }
        public int? GetCalories() { return this.calories; }

        // Setters
        public void SetIntakeID(int intakeID) { this.intakeID = intakeID; }
        public void SetIntakeDate(DateTime intakeDate) { this.intakeDate = intakeDate; }
        public void SetMealTypeID(int mealTypeID) { this.mealTypeID = mealTypeID; }
        public void SetPortionSize(decimal portionSize) { this.portionSize = portionSize; }
        public void SetUserID(int userID) { this.userID = userID; }
        public void SetFoodItemID(int foodItemID) { this.foodItemID = foodItemID; }
        public void SetCalories(int calories) { this.calories = calories; }


        public void AddFoodIntake()
        {
            // Open a database connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            // Build the SQL query to insert a new food intake record
            string sqlQuery = "INSERT INTO FoodIntake (IntakeID, IntakeDate, MealTypeID, PortionSize, UserID, FoodItemID, Calories) VALUES (" +
                              this.intakeID + "," +
                              "TO_DATE('" + this.intakeDate.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD'), " +
                              this.mealTypeID + ", " +
                              this.portionSize + ", " +
                              this.userID + ", " +
                              this.foodItemID + ", " +
                              this.calories + ")";

            // Test Sql Query
            Console.WriteLine(sqlQuery); // Useful for debugging

            // Create the OracleCommand object
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            // Open the connection to the database
            conn.Open();

            // Execute the SQL query
            cmd.ExecuteNonQuery();

            // Close the database connection
            conn.Close();
        }

        // Method to generate the next intake ID (similar to GetNextFoodItemID method in FoodItem class)
        public static int GetNextIntakeID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(IntakeID) FROM FoodIntake";

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

        public static int GetCalories(decimal portionSize, int caloriesPerPortion)
        {
            decimal totalCalories = portionSize * caloriesPerPortion;

            return Convert.ToInt32(totalCalories);
        }


        public static DataSet getDailyIntake(int userId, DateTime theDate)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            DataSet ds = new DataSet();
            //Define the SQL query to be executed
            String sqlQuery = " SELECT mt.MealTypeName AS \"Meal\" ,f.FoodName AS \"Food Item\", fi.PortionSize AS \"Portion\", fi.Calories AS \"Calories in Meal\"  " +
                "FROM FoodIntake fi JOIN FoodItems f ON fi.FoodItemID = f.FoodItemID " +
                "JOIN MealType mt ON fi.MealTypeID = mt.MealTypeID " +
                " WHERE fi.UserID = " + userId + " AND fi.IntakeDate = TO_DATE('" +
                 theDate.ToString("dd/MM/yyyy") + "', 'DD/MM/YYYY') ORDER BY fi.MealTypeID";
        
        
       
               
        
            Console.WriteLine(sqlQuery);
            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            // Execute the command and use OracleDataReader to read the data
            using (OracleDataReader dr = cmd.ExecuteReader())

            {
                // Create a new DataTable
                DataTable dt = new DataTable();
                dt.TableName = "FoodIntake";

                // Load data from the reader to the DataTable
                dt.Load(dr);

                // Add the DataTable to the DataSet
                Console.WriteLine("Rows loaded: " + dt.Rows.Count);
                ds.Tables.Add(dt);

            }

            // Return the populated DataSet
            return ds;
        }

        public static int GetTotalCaloriesForDay(int userId, DateTime theDate)
        {
            //The three values needed for analysis : average, lowest, highest.
            int result = 0;

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                try
                {
                    conn.Open();
                    string queryAverage = "SELECT SUM(Calories) FROM FoodIntake WHERE UserID = " + userId +
                        " AND IntakeDate = TO_DATE('" + theDate + "', 'DD/MM/YYYY HH24:MI:SS')";
                    OracleCommand cmdAverage = new OracleCommand(queryAverage, conn);

                    object resultAverage = cmdAverage.ExecuteScalar();
                    if (resultAverage != DBNull.Value)
                    {
                        result = Convert.ToInt32(resultAverage);
                        
                    }
                   

                   

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
                Console.WriteLine("Total Calories returned : " + result);
                return result;
            }

        }

        public static int GetFoodItemFromIntake(int intakeID) {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            int fooditemID = 0;

            try
            {
                conn.Open();
                string query = "SELECT fooditemID FROM FoodIntake WHERE intakeID = " + intakeID;
                OracleCommand cmd = new OracleCommand(query, conn);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    fooditemID = Convert.ToInt32(result);
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return fooditemID;
        }

        public static bool DeleteFoodIntake(int intakeID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            bool result = false;

            try
            {
                conn.Open();
                string query = "DELETE FROM FoodIntake WHERE IntakeID = :IntakeID";
                OracleCommand cmd = new OracleCommand(query, conn);

                cmd.Parameters.Add(new OracleParameter("IntakeID", intakeID));

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    result = true;
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public static bool updateIntakeDetails(int intakeID, decimal portionSize, int mealTypeID, int calories)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                try
                {
                    StringBuilder sqlStatement = new StringBuilder("UPDATE FoodIntake SET ");
                    bool addComma = false; // Adds comma to string if previous statement was added

                    if (portionSize > 0)
                    {
                        sqlStatement.Append("PortionSize = " + portionSize);
                        addComma = true;
                    }

                    if (mealTypeID > 0)
                    {
                        if (addComma)
                        {
                            sqlStatement.Append(", ");
                        }
                        sqlStatement.Append("MealTypeID = " + mealTypeID);
                        addComma = true;
                    }

                    if (calories > 0)
                    {
                        if (addComma)
                        {
                            sqlStatement.Append(", ");
                        }
                        sqlStatement.Append("Calories = " + calories);
                    }

                    sqlStatement.Append(" WHERE intakeID = " + intakeID);
                    string query = sqlStatement.ToString();
                    conn.Open();
                    Console.WriteLine(query);
                    OracleCommand cmd = new OracleCommand(query, conn);


                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine(rowsAffected + " rows affected.");
                    if (rowsAffected > 0)
                    {
                        return true;
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
            return false;
        }



    }
}