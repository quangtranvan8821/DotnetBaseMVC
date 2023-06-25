namespace DotnetBaseMVCApp.ViewModels
{
    public class LoginViewModel
    {
        public string email { get; set; }
        public string password { get; set; }

        public LoginViewModel(string email, string password)
        {
            this.email = email;
            this.password = password;
        }
    }
}