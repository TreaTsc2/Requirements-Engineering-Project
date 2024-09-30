using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnesCT
{
    class Customer
    {
        private int uerID;
        private String surename;
        private String forename;
        private String password;
        private DateTime DOB;
        private Decimal height;
        private Decimal weight;
        private String gender;
        private String activityLevelID;
        private int dailyCalorieGoal;


        public Customeer()
        {
            this.userID = 0;
            this.surename = "";
            this.forename = "";
            this.password = "";
            this.DOB = null;
            this.height = 0;
            this.weight = 0;
            this.gender = "";
            this.activityLevelID = "";
            this.dailyCalorieGoal = 0;
        }

        public Customer(int userID, string surname, string forename, string password, DateTime DOB, decimal height, decimal weight, string gender, string activityLevelID, decimal dailyCalorieGoal)
        {
            this.userID = userID;
            this.surname = surname;
            this.forename = forename;
            this.password = password;
            this.DOB = DOB;
            this.height = height;
            this.weight = weight;
            this.gender = gender;
            this.activityLevelID = activityLevelID;
            this.dailyCalorieGoal = dailyCalorieGoal;
        }

        // Getters
        public int GetUserID() { return this.userID; }
        public string GetSurname() { return this.surname; }
        public string GetForename() { return this.forename; }
        public string GetPassword() { return this.password; }
        public DateTime GetDOB() { return this.DOB; }
        public decimal GetHeight() { return this.height; }
        public decimal GetWeight() { return this.weight; }
        public string GetGender() { return this.gender; }
        public string GetActivityLevelID() { return this.activityLevelID; }
        public int GetDailyCalorieGoal() { return this.dailyCalorieGoal; }

        // Setters
        public void SetUserID(int userID) { this.userID = userID; }
        public void SetSurname(string surname) { this.surname = surname; }
        public void SetForename(string forename) { this.forename = forename; }
        public void SetPassword(string password) { this.password = password; }
        public void SetDOB(DateTime DOB) { this.DOB = DOB; }
        public void SetHeight(decimal height) { this.height = height; }
        public void SetWeight(decimal weight) { this.weight = weight; }
        public void SetGender(string gender) { this.gender = gender; }
        public void SetActivityLevelID(string activityLevelID) { this.activityLevelID = activityLevelID; }
        public void SetDailyCalorieGoal(int dailyCalorieGoal) { this.dailyCalorieGoal = dailyCalorieGoal; }
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

}

    



}
