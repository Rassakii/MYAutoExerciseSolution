using MYAutoExercise.Setup;
using OpenQA.Selenium;

namespace MYAutoExercise.Pages
{
    public class ContactPage
    {
        private IWebDriver _driver;

        public ContactPage(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement GetINtouchLine()
        {
            return _driver.FindElement(By.CssSelector("div[class='contact-form'] h2[class='title text-center']"));
        }
        public void ContactHeader()
        {
            string HeaderText = GetINtouchLine().Text;
            StringAssert.Contains("GET IN TOUCH", HeaderText);

        }
        private IWebElement Namefield()
        {
            return _driver.FindElement(By.CssSelector("input[placeholder='Name']"));
        }
        private IWebElement Emailfield()
        {
            return _driver.FindElement(By.CssSelector("input[placeholder='Email']"));
        }
        private IWebElement SubjectField()
        {
            return _driver.FindElement(By.CssSelector("input[placeholder='Subject']"));
        }
        private IWebElement BodyField()
        {
            return _driver.FindElement(By.XPath("(//textarea[@id='message'])[1]"));
        }
        public void EnterTableInfo(string Name, string Email, string Subject, string Body)
        {
            Namefield().SendKeys(Name);
            Emailfield().SendKeys(Email);
            SubjectField().SendKeys(Subject);
            BodyField().SendKeys(Body);

        }
        private IWebElement Submitbutton()
        {
            return _driver.FindElement(By.CssSelector("input[value='Submit']"));
        }
        public void ClickSubmit()
        {
            Submitbutton().Click();
        }
        public void AcceptPopUp()
        {
            _driver.SwitchTo().Alert().Accept();
        }
        public IWebElement submissonMessage()
        {
            return _driver.FindElement(By.XPath("//div[@class='status alert alert-success']"));
        }
        public void DisplayedMessage(string message)
        {
            string DisplayText = submissonMessage().Text;
            StringAssert.Contains(message, DisplayText);
        }
        private IWebElement HomeButton()
        {
            return  _driver.FindElement(By.CssSelector(".btn.btn-success"));
        }
        public void ClickHome()
        {
            HomeButton().Click();
        }

    }
}
