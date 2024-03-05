using System.Drawing.Printing;

namespace DatingDB.Services
{
    public class UserService
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public static bool IsLoggedIn { get; set; }

        public string? UserName { get; set; }

    }
}
