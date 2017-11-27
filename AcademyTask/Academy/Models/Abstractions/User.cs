using System;

namespace Academy.Models.Abstractions
{
    public abstract class User
    {
        private readonly string username;

        public User(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("The provided first name is not valid!");
            }
            else if (username.Length < 3 || username.Length > 16)
            {
                throw new ArgumentException("User's username should be between 3 and 16 symbols long!");
            }
            this.username = username;
        }

        public string Username { get => this.username; }
    }
}

