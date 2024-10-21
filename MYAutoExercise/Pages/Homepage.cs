using MYAutoExercise.Setup;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace MYAutoExercise.Pages
{
    public class Homepage
    {

        private IWebDriver _driver;

        public Homepage(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement Consent()
        {
            return _driver.FindElement(By.XPath("/html/body/div/div[2]/div[1]/div[2]/div[2]/button[1]/p"));
        }
        public void ClickConsent()
        {
            Consent().Click();
        }
        private IWebElement clicksignup()
        {
            return _driver.FindElement(By.CssSelector("a[href='/login']"));

        }
        public void Clicksignup()
        {
            clicksignup().Click();
        }
        private IWebElement ContinueButton()
        {
            return _driver.FindElement(By.XPath("//a[normalize-space()='Continue']"));
        }
        public void ClickContinue()
        {
            ContinueButton().Click();
        }
        private IWebElement Username()
        {
            return  _driver.FindElement(By.XPath("//b[normalize-space()='Yussuph Tomilayo Iqmat']"));
        }
        public void verifyUSER()
        {
            string UsernameCheck = Username().Text;
            StringAssert.Contains("Yussuph Tomilayo", UsernameCheck);
        }
        public void sleep()
        {
            Thread.Sleep(10000);
        }

        public void ClickAlert()
        {
            _driver.SwitchTo().Alert().Dismiss();
        }
        public void WaitAlert()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(60));
            IWebElement element = (IWebElement)wait.Until(ExpectedConditions.AlertIsPresent());

        }
        private IWebElement LoginUseranme()
        {
            return _driver.FindElement(By.XPath("//b[normalize-space()='Yussuph Tomilayo']"));
        }

        public void VerifyLoginUsername()
        {
            string UsernameCheck = LoginUseranme().Text;
            StringAssert.Contains("Yussuph Tomilayo", UsernameCheck);
        }
        private IWebElement ContactButton()
        {
            return _driver.FindElement(By.CssSelector("a[href='/contact_us']"));
        }
        public void clickcontact()
        {
            ContactButton().Click();
        }
        private IWebElement GetINtouchLine()
        {
            return _driver.FindElement(By.CssSelector("div[class='contact-form'] h2[class='title text-center']"));
        }
        public void ContecHeader()
        {
            string HeaderText = GetINtouchLine().Text;
            StringAssert.Contains("Get In Touch", HeaderText);

        }
        private IWebElement ProductButton()
        {
            return  _driver.FindElement(By.CssSelector("a[href='/products']"));
        }
        public void ClickProduct()
        {
            ProductButton().Click();
        }
    }
}
