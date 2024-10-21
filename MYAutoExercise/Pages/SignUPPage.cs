using MYAutoExercise.Setup;
using OpenQA.Selenium;

namespace MYAutoExercise.Pages
{
    public class Signuppage
    {
        private IWebDriver _driver;

        public Signuppage(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement Username()
        {
            return _driver.FindElement(By.CssSelector("input[placeholder='Name']"));
        }
        public void InputName(string name)
        {
            Username().SendKeys(name);
        }
        private IWebElement Email()
        {
            return _driver.FindElement(By.CssSelector("input[data-qa='signup-email"));
        }
        public void InputEmail(string email)
        {
            Email().SendKeys(email);
        }
        public IWebElement SignUpButton()
        {
            return _driver.FindElement(By.CssSelector("button[data-qa='signup-button']"));
        }
        public void ClickSignUpButton()
        {
            SignUpButton().Click();
        }
        private IWebElement LoginEmail()
        {
            return _driver.FindElement(By.CssSelector("input[data-qa='login-email']"));
        }
        public void InputLoginEmail(string login)
        {
            LoginEmail().SendKeys(login);
        }
        private IWebElement LoginPassword()
        {
            return _driver.FindElement(By.CssSelector("input[data-qa='login-password']"));
        }
        public void InsertLOginPassword(string password)
        {
            LoginPassword().SendKeys(password);
        }
        private IWebElement login()
        {
            return _driver.FindElement(By.CssSelector("button[data-qa='login-button']"));
        }
        public void clickLogin()
        {
            login().Click();
        }
        private IWebElement LoginError()
        {
            return  _driver.FindElement(By.XPath("//p[normalize-space()='Your email or password is incorrect!']"));
        }
        public void CheckerrorMessage(string errormessage)
        {
            string Dispayederror = LoginError().Text;
            StringAssert.Contains(errormessage, Dispayederror);
        }

    }
}
