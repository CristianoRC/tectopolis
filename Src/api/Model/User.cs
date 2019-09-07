using System;
using System.Security.Cryptography;
using System.Text;

namespace Model
{
    public class User
    {
        public User()
        {
        }

        public User(string name, string imageUrl, string password,string email)
        {
            Name = name;
            ImageUrl = imageUrl;
            Password = GetHash(password);
            Email = email;
        }
        
        public User(Guid id, string name, string imageUrl, string password,string email)
        {
            Id = id;
            Name = name;
            ImageUrl = imageUrl;
            Password = GetHash(password);
            Email = email;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        private static string GetHash(string text)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}