using Boa.Constrictor.WebDriver;
using OpenQA.Selenium;
using static Boa.Constrictor.WebDriver.WebLocator;

namespace BigHealthTakeHomeTest.Pages
{
    public static class CreateAccountPage
    {
        // Ideally email/passwords should be managed in a config page
        public static string Email = "mm.ndsc.test@gmail.com";
        public static string Password = "This_Is_A_Strong_Password123!@#";

        public static IWebLocator FirstNameInput => L("First Name Input", By.CssSelector("input[name='first_name']"));
        public static IWebLocator LastNameInput => L("Last Name Input", By.CssSelector("input[name='last_name']"));
        public static IWebLocator EmailInput => L("Email Input", By.CssSelector("input[name='email']"));
        public static IWebLocator PasswordInput => L("Password Input", By.CssSelector("input[name='password']"));
        public static IWebLocator PrivacyCheckboxes => L("Privacy Checkboxes", By.ClassName("sl-input-checkbox"));
        public static IWebLocator SignUpButton => L("Sign Up Button", By.CssSelector("button[type='submit']"));
    }
}
