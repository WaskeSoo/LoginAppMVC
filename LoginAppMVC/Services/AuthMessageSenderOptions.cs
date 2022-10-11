namespace LoginAppMVC.Services
{
    public class AuthMessageSenderOptions
    {
        public string? SendGridKey { get; set; }
        public string? ConfirmationSenderEmail { get; set; }   
    }
}
