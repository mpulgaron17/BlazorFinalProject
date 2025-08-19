using System;

namespace BlazorFinalProject.State
{
    public class UserSessionState
    {
        public bool IsLoggedIn { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public DateTime? LoginTime { get; set; }

        public void StartSession(string userName, string email)
        {
            IsLoggedIn = true;
            UserName = userName;
            Email = email;
            LoginTime = DateTime.Now;
        }

        public void EndSession()
        {
            IsLoggedIn = false;
            UserName = null;
            Email = null;
            LoginTime = null;
        }
    }
}
