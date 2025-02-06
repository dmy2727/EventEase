using System;

namespace Shared.Services
{
    public class UserSessionService
    {
        public bool IsLoggedIn { get; private set; }
        public string? UserName { get; private set; }

        public event Action? OnChange;

        public void Login(string userName)
        {
            UserName = userName;
            IsLoggedIn = true;
            NotifyStateChanged();
        }

        public void Logout()
        {
            UserName = null;
            IsLoggedIn = false;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}