using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UniversitySystem
{
    public static class Logger
    {
        private static List<String> currentSessionActivities = new List<String>();
        public static void LogActivity(String activity) 
        {
            String activityLine = DateTime.Now+";"+/*LoginValidation.currentUsername*/LoginValidation.CurrentUserRole + ";" + activity;
            currentSessionActivities.Add(activityLine);
            File.AppendAllText(@"C:\Users\Elly\IdeaProjects\TU_C_Sharp\UniversitySystem\UniversitySystem\test.txt", activityLine + Environment.NewLine);
            }
        public static String GetCurrentSessionActivities(String filter) 
        {
            List<String> filteredActivities = (from activity in currentSessionActivities where activity.Contains(filter) select activity).ToList();
            StringBuilder loggerBuilder = new StringBuilder();
            foreach (var currentLog in filteredActivities) 
            {
                loggerBuilder.Append(currentLog);
                loggerBuilder.Append(Environment.NewLine);
            
            }

            return loggerBuilder.ToString();
        }
    }
}
