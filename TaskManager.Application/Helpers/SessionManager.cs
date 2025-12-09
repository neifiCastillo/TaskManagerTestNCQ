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
        //public const int SessionDuration = 3600; // 1 hour
        public const int SessionDurationSeconds = 300; //  30 second
        public const int InactivityTimeoutSeconds = 120; // 2 min,

        private static readonly string SessionPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "session.json");

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
