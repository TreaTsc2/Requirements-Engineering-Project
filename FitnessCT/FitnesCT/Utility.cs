using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FitnessCT
{
    internal class Utility
    {

        public static DataSet LoadActivityLevels()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            DataSet ds = new DataSet();

            try
            {
                conn.Open();
                String sqlQuery = "SELECT * FROM ActivityLevel ORDER BY ActivityLevelID";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                using (OracleDataReader dr = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.TableName = "ActivityLevels";

                    dt.Load(dr);
                   
                    ds.Tables.Add(dt);
                }

                return ds;
            }
            catch (OracleException ex)
            {
                Console.WriteLine(ex.Message);
                return ds;
            }
            finally
            {
                conn.Close();
            }

        }
        public static DataSet LoadUserFoodItems(int userID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            DataSet ds = new DataSet();

            try
            {
                String sqlQuery = "SELECT * FROM FoodItems WHERE UserID = :userID AND ItemStatusID = 1 ORDER BY FoodName ASC";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                cmd.Parameters.Add(new OracleParameter("userID", userID));

                conn.Open();

                using (OracleDataReader dr = cmd.ExecuteReader())

                {
                    DataTable dt = new DataTable();
                    dt.TableName = "FoodItems";

                    dt.Load(dr);

                    Console.WriteLine("Rows loaded: " + dt.Rows.Count);
                    ds.Tables.Add(dt);
                }

                return ds;
            }
            catch (OracleException ex)
            {
                Console.WriteLine(ex.Message);
                return ds;
            }
            finally
            {
                conn.Close();
            }
        }


        public static DataSet LoadMealTypes()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            DataSet ds = new DataSet();

            try
            {
                String sqlQuery = "SELECT * FROM MealType ORDER BY MealTypeID ASC";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                conn.Open();

                using (OracleDataReader dr = cmd.ExecuteReader())

                {
                    DataTable dt = new DataTable();
                    dt.TableName = "MealType";

                    dt.Load(dr);

                    Console.WriteLine("Rows loaded: " + dt.Rows.Count);
                    ds.Tables.Add(dt);
                }

                return ds;
            }
            catch (OracleException ex)
            {
                Console.WriteLine(ex.Message);
                return ds;
            }
            finally
            {
                conn.Close();
            }
        }


        public static DataSet LoadAllFoodItems(int userID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            DataSet ds = new DataSet();

            try
            {
                String sqlQuery = "SELECT * FROM FoodItems WHERE (UserID = :userID OR UserID IS NULL) AND (ItemStatusID = 1 OR ItemStatusID = 3) ORDER BY FoodName ASC";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                cmd.Parameters.Add(new OracleParameter("userID", userID));

                conn.Open();

                using (OracleDataReader dr = cmd.ExecuteReader())

                {
                    DataTable dt = new DataTable();
                    dt.TableName = "FoodItems";

                    dt.Load(dr);

                    ds.Tables.Add(dt);
                }
                return ds;
            }
            catch (OracleException ex)
            {
                Console.WriteLine(ex.Message);
                return ds;
            }
            finally
            {
                conn.Close();
            }

        }


        public static DataSet LoadSelectedFoodIntake(int userID, DateTime date)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            DataSet ds = new DataSet();

            try
            {

                String sqlQuery = "SELECT FI.*, F.FoodName,F.FoodItemID, F.CaloriesPerUnit FROM FoodIntake FI JOIN FoodItems F ON FI.FoodItemID = F.FoodItemID WHERE FI.UserID = :userID " +
                    " AND FI.IntakeDate = :intakeDate ORDER BY FI.MealTypeID ASC"; 

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                cmd.Parameters.Add(new OracleParameter("userID", userID));
                cmd.Parameters.Add(new OracleParameter("intakeDate", date.Date));

                conn.Open();

                using (OracleDataReader dr = cmd.ExecuteReader())

                {
                    DataTable dt = new DataTable();
                    dt.TableName = "FoodIntake";

                    dt.Load(dr);

                    Console.WriteLine("Rows loaded: " + dt.Rows.Count);
                    ds.Tables.Add(dt);
                }

                return ds;
            }
            catch (OracleException ex)
            {
                Console.WriteLine(ex.Message);
                return ds;
            }
            finally
            {
                conn.Close();
            }

        }



        public static int GetFoodItemCaloriesPerUnit(int foodItemID)
        {
            int caloriesPerUnit = 0;
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String query = "SELECT CaloriesPerUnit FROM FoodItems WHERE FoodItemId =: fooditemID";

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("fooditemID", foodItemID));
                Console.WriteLine("FoodItemID being searched is : " + foodItemID);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    caloriesPerUnit = Convert.ToInt32(result);
                }
                else
                {
                    caloriesPerUnit = 0;
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

            return caloriesPerUnit;

        }

        public static String ValidateIfFoodItemAlreadyExists(int userID, string foodName)
        { 

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            string foodItemsFound = "-1";

            try
            {
                conn.Open();
                string query = "SELECT FoodName FROM FoodItems WHERE UserID = :userID AND FoodName = :foodName";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("userID", userID));
                cmd.Parameters.Add(new OracleParameter("foodName", foodName));

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    foodItemsFound = (string)result;
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

            return foodItemsFound;
        }

        

        
        public static int GetActivityLevelIdByName(string activityLevelName) //Get activityLevelId from activityLevelName
        {
            int activityLevelId = -1; // Default value indicating not found

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                string query = "SELECT ActivityLevelID FROM ActivityLevel WHERE LevelName = :levelName";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("levelName", activityLevelName));

                try
                {
                    conn.Open();
                    OracleDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        activityLevelId = reader.GetInt32(0);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            return activityLevelId;
        }

        

        public static string FindEmail(string email)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            string foundEmail = "-1";

            try
            {
                conn.Open();
                string query = "SELECT Email FROM Accounts WHERE Email = :email";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("email", email));

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    foundEmail = (string)result;
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

            return foundEmail;
        }

        //Get UserID from user email
        public static int GetIdFromEmail(String email)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            int idFound = -1;

            try
            {
                conn.Open();
                string query = "SELECT UserID FROM Accounts WHERE Email = :email";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("email", email));

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    idFound = Convert.ToInt32(result);
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
            Console.WriteLine("id being returned : " + idFound);
            return idFound;
        }

        public static Boolean VerifyLoginInformation(string email, string password)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);


            try
            {
                conn.Open();
                string query = "SELECT Password FROM Accounts WHERE Email = :email";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("email", email));

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string foundPassword = (string)result;
                    if (foundPassword == password)
                    {
                        return true;
                    }
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

            return false;
        }

        public static int GetDailyCalorieGoalFromUserID(int userID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            int DailyCalorieGoalFound = -1;

            try
            {
                conn.Open();
                string query = "SELECT DailyCalorieGoal FROM Accounts WHERE UserID = :userID";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("userID", userID));

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    DailyCalorieGoalFound = (int)result;
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

            return DailyCalorieGoalFound;
        }

    

        

        public static int getCaloriesPerUnitFromIntake(int intakeID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            int caloriesPerUnit = 0;
            try
            {
                conn.Open();
                string query = "SELECT fi.CaloriesPerUnit FROM FoodIntake f INNER JOIN FoodItems fi ON f.FoodItemID = fi.FoodItemID WHERE f.IntakeID = :IntakeID";
                OracleCommand cmd = new OracleCommand(query, conn);

                cmd.Parameters.Add(new OracleParameter("IntakeID", intakeID));

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    caloriesPerUnit = Convert.ToInt32(result);
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

            return caloriesPerUnit;

        }

        

        public static int[] GetAllTimeCalorieAnalysis(int userId)
        {
            //The three values needed for analysis : average, lowest, highest.
            int[] results = new int[3] { 0, 0, 0 };

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {
                try
                {
                    conn.Open();
                    string queryAverage = "SELECT AVG(Calories) FROM FoodIntake WHERE UserID = " + userId ;
                    OracleCommand cmdAverage = new OracleCommand(queryAverage, conn);

                    object resultAverage = cmdAverage.ExecuteScalar();
                    if (resultAverage != DBNull.Value)
                    {
                        results[0] = Convert.ToInt32(resultAverage);
                    }

                    string queryLowest = "SELECT MIN(Calories) FROM FoodIntake WHERE UserID = " + userId + "GROUP BY IntakeDate "; 
                    OracleCommand cmdLowest = new OracleCommand(queryLowest, conn);

                    object resultLowest = cmdLowest.ExecuteScalar();
                    if (resultLowest != DBNull.Value)
                    {
                        results[1] = Convert.ToInt32(resultLowest);
                    }

                    string queryHighest = "SELECT MAX(SumCalories)  FROM (SELECT SUM(Calories) AS SumCalories FROM FoodIntake WHERE UserID = " + userId +
                    "GROUP BY IntakeDate)";
                    OracleCommand cmdHighest = new OracleCommand(queryHighest, conn);

                    object resultHighest = cmdHighest.ExecuteScalar();
                    if (resultHighest != DBNull.Value)
                    {
                        results[2] = Convert.ToInt32(resultHighest);
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

                return results;
            }

        }
        public static int[] GetCalorieAnalysis(int userId, int numberOfWeeksToAnalyse)
        {
            //The three values needed for analysis : average, lowest, highest.
            int[] results = new int[3] { 0, 0, 0 };

            // Calculates the date range for the analysis
            DateTime toDate = DateTime.Today.AddDays(1);
            DateTime fromDate = toDate.AddDays(-7 * numberOfWeeksToAnalyse);
            Console.WriteLine(fromDate);
            Console.WriteLine(toDate);

            using (OracleConnection conn = new OracleConnection(DBConnect.oradb))
            {

                try
                {
                    conn.Open();
                    string query = "SELECT AVG(Calories) FROM FoodIntake WHERE UserID  = " + userId +
                         " AND IntakeDate BETWEEN TO_DATE('" + fromDate + "', 'DD/MM/YYYY HH24:MI:SS') AND TO_DATE('" + toDate + "', 'DD/MM/YYYY HH24:MI:SS')";
                    OracleCommand cmdAverage = new OracleCommand(query, conn);


                    object resultAverage = cmdAverage.ExecuteScalar();
                    if (resultAverage != DBNull.Value)
                    {
                        results[0] = Convert.ToInt32(resultAverage);
                    }

                    string queryLowest = "SELECT MIN(Calories) FROM FoodIntake WHERE UserID = " + userId +
                         " AND IntakeDate BETWEEN TO_DATE('" + fromDate + "', 'DD/MM/YYYY HH24:MI:SS') AND TO_DATE('" + toDate + "', 'DD/MM/YYYY HH24:MI:SS')";
                    OracleCommand cmdLowest = new OracleCommand(queryLowest, conn);


                    object resultLowest = cmdLowest.ExecuteScalar();
                    if (resultLowest != DBNull.Value)
                    {
                        results[1] = Convert.ToInt32(resultLowest);
                    }

                    string queryHighest = " SELECT MAX(SumOfCalories) FROM (SELECT SUM(Calories) AS SumOfCalories FROM FoodIntake WHERE UserID = " + userId +
                          " AND IntakeDate BETWEEN TO_DATE('" + fromDate + "', 'DD/MM/YYYY HH24:MI:SS') AND TO_DATE('" + toDate +
                          "', 'DD/MM/YYYY HH24:MI:SS') GROUP BY IntakeDate)";
                    Console.WriteLine(queryHighest);
                    OracleCommand cmdHighest = new OracleCommand(queryHighest, conn);


                    object resultsHighest = cmdHighest.ExecuteScalar();
                    if (resultsHighest != DBNull.Value)
                    {
                        results[2] = Convert.ToInt32(resultsHighest);
                    }

                    // Display the results in the console
                    Console.WriteLine($"Average: {results[0]}, Lowest: {results[1]}, Highest: {results[2]}");

                    return results;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                return results;
            }
        }
    }
}

