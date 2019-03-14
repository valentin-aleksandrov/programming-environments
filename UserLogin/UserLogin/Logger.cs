using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UserLogin
{
    public static class Logger
    {
        private static List<String> currentSessionActivities = new List<string>();
        public static void LogActivity(String activity)
        {
            String activityLine = DateTime.Now /*LoginValidation.currentUserName*/
                + ";" + LoginValidation.CurrentUserRole + ";"
                + activity;
            currentSessionActivities.Add(activityLine);      
            File.AppendAllText(@"C:\Users\Lenny\Documents\Lenny\projects\Програмни среди\programming-environments\UserLogin\UserLogin\test.txt", activityLine + Environment.NewLine);
        }
        public static String getCurrentSessionActivities(String filter)
        {
            List<String> filteredActivities = (from activity in currentSessionActivities where activity.Contains(filter) select activity).ToList();
            StringBuilder loggerBuilder = new StringBuilder();
            foreach(var currentLog in filteredActivities)
            {
                loggerBuilder.Append(currentLog);
                loggerBuilder.Append(Environment.NewLine);
            }
            return loggerBuilder.ToString();
        }
    }
}
