namespace DotnetBaseMVCApp.ViewModels
{
    public class RegisterViewModel
    {
        public string? name { get; set; }
        public required string email { get; set; }
        public required string password { get; set; }
    }
}