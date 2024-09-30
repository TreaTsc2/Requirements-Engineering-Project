using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCT
{
    public class UserSession
    {
        private static UserSession instance;
        private int userID;
        private int dailyCalorieGoal;
        private bool loggedIn;

 
        private UserSession()
        {
        
        }
        public static UserSession Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserSession();

                }
                return instance;
            }
        }

        // getters
        public int GetUserID() { return this.userID; }
        public int GetDailyCalorieGoal() { return this.dailyCalorieGoal; }
        public bool GetLoggedIn() { return this.loggedIn; }

        // Setters
        public void SetUserID(int userID) { this.userID = userID; }
        public void SetDailyCalorieGoal(int dailyCalorieGoal) { this.dailyCalorieGoal = dailyCalorieGoal; }
        public void SetLoggedIn(bool loggedIn) { this.loggedIn = loggedIn; }

        

       

        public void Login(int userID, int dailyCalorieGoal)
        {
            this.userID = userID;
            this.dailyCalorieGoal = dailyCalorieGoal;
            this.loggedIn = true;
        }


         public void Logout()
        {
            SetUserID(0);
            SetDailyCalorieGoal(0);
            SetLoggedIn(false);
        }

    }
}
