using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Application.Helpers
{
    public static class PasswordHasher
    {
        public static void CreatePasswordHash(string password, out string hash, out string salt)
        {
            salt = Convert.ToBase64String(RandomNumberGenerator.GetBytes(16));

            using var sha256 = SHA256.Create();
            var combined = Encoding.UTF8.GetBytes(password + salt);
            hash = Convert.ToBase64String(sha256.ComputeHash(combined));
        }
        public static bool VerifyPassword(string password, string storedHash, string storedSalt)
        {
            using var sha256 = SHA256.Create();
            var combined = Encoding.UTF8.GetBytes(password + storedSalt);
            var computed = Convert.ToBase64String(sha256.ComputeHash(combined));
            return computed == storedHash;
        }
    }
}
