using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Application.Helpers
{
    public static class SessionManager
    {
        public const int SessionDuration = 60; // 1 hour
        public const int InactivityTimeout = 3600; // 1 hour 
        //public const int SessionDurationMinutes = 60; //  1 min for test
        //public const int InactivityTimeout = 60; // 1 min for test,

        private static readonly string SessionPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "session.json");
        public static void SaveSession(int userId, string fullName)
        {
            var session = new SessionData
            {
                UserId = userId,
                UserName = fullName,
                LoginTime = DateTime.Now
            };

            File.WriteAllText(SessionPath, JsonConvert.SerializeObject(session));
        }
        public static SessionData? LoadSession()
        {
            if (!File.Exists(SessionPath))
                return null;

            var json = File.ReadAllText(SessionPath);
            return JsonConvert.DeserializeObject<SessionData>(json);
        }
        public static void ClearSession()
        {
            if (File.Exists(SessionPath))
                File.Delete(SessionPath);
        }
    }

}
