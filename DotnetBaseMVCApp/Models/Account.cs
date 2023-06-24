namespace DotnetBaseMVCApp.Models
{
    public class Account
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }

        public Account(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

    }
}