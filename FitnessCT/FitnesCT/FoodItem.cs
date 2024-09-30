using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCT
{
    class FoodItem
    {
        private int foodItemID;
        private string foodName;
        private string portion;
        private int caloriesPerUnit;
        private int userID;
        private int ItemStatusID;

        public FoodItem()
        {
            this.foodItemID = 0;
            this.foodName = "";
            this.portion = "";
            this.caloriesPerUnit = 0;
            this.userID = 0;
            this.ItemStatusID = 0;
        }

        public FoodItem(int foodItemID, string foodName, string portion, int caloriesPerUnit, int userID,  int ItemStatusID)
        {
            this.foodItemID = foodItemID;
            this.foodName = foodName;
            this.portion = portion;
            this.caloriesPerUnit = caloriesPerUnit;
            this.userID = userID;
            this.ItemStatusID = ItemStatusID;
        }

        // Getters
        public int GetFoodItemID() { return this.foodItemID; }
        public string GetFoodName() { return this.foodName; }
        public string GetPortion() { return this.portion; }
        public decimal GetCaloriesPerUnit() { return this.caloriesPerUnit; }
        public int GetUserID() { return this.userID; }
        public int GetItemStatusID() { return this.ItemStatusID; }


        // Setters
        public void SetFoodItemID(int foodItemID) { this.foodItemID = foodItemID; }
        public void SetFoodName(string foodName) { this.foodName = foodName; }
        public void SetPortion(string portion) { this.portion = portion; }
        public void SetCaloriesPerUnit(int caloriesPerUnit) { this.caloriesPerUnit = caloriesPerUnit; }
        public void SetUserID(int userID) { this.userID = userID; }
        public void SetItemStatusID(int ItemStatusID) { this.ItemStatusID = ItemStatusID; }


        public void AddFoodItem()
        {
            // Open a database connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            // Build the SQL query to insert a new food item
            string sqlQuery = "INSERT INTO FoodItems Values(" +
                this.foodItemID + ", '" +
                this.foodName + "', '" +
                this.portion + "', " +
                this.caloriesPerUnit + ", " +
                this.userID + ", " +
                this.ItemStatusID + ")";

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


        public static int GetNextFoodItemID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(FoodItemID) FROM FoodItems";

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

        public static String GetPortionNameFromFoodItem(int fooditemID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String portionName = "";

            try
            {
                conn.Open();
                string query = "SELECT Portion FROM FoodItems WHERE FoodItemID = " + fooditemID;
                OracleCommand cmd = new OracleCommand(query, conn);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    portionName = Convert.ToString(result);
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

            return portionName;
        }

        public static Boolean DeleteFoodItem(int foodItemID)
        {
            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                string query = "UPDATE FoodItems SET ItemStatusID = 2 WHERE FoodItemID = " + foodItemID;
                OracleCommand cmd = new OracleCommand(query, conn);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            return false;
        }

        public static Boolean UpdateItemDetails(int foodItemID, string foodNameUpdate, int caloriesPerUnitUpdate, string portionUpdate)
        {

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {

                StringBuilder sqlStatement = new StringBuilder("UPDATE FoodItems SET ");

                bool addComma = false; // Adds comma to string if previous statement was added

                if (foodNameUpdate.Length > 0)
                {
                    sqlStatement.Append("FoodName = :foodNameUpdate");
                    addComma = true;
                }

                if (caloriesPerUnitUpdate > 0)
                {
                    if (addComma)
                    {
                        sqlStatement.Append(", ");
                    }
                    sqlStatement.Append("CaloriesPerUnit = :caloriesPerUnitUpdate");
                    addComma = true;
                }

                if (!string.IsNullOrEmpty(portionUpdate))
                {
                    if (addComma)
                    {
                        sqlStatement.Append(", ");
                    }
                    sqlStatement.Append("Portion = :portionUpdate");
                }

                sqlStatement.Append(" WHERE FoodItemID = " + foodItemID);

                string query = sqlStatement.ToString();
                OracleCommand cmd = new OracleCommand(query, conn);
                Console.WriteLine("FoodItemID being searched is : " + foodItemID);

                if (foodNameUpdate.Length > 0)
                {
                    cmd.Parameters.Add(new OracleParameter("foodNameUpdate", foodNameUpdate));
                }
                if (caloriesPerUnitUpdate > 0)
                {
                    cmd.Parameters.Add(new OracleParameter("caloriesPerUnitUpdate", caloriesPerUnitUpdate));
                }
                if (portionUpdate.Length > 0)
                {
                    cmd.Parameters.Add(new OracleParameter("portionUpdate", portionUpdate));
                }

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            return false;

        }



    }
}
