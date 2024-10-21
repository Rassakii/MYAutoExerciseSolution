using MYAutoExercise.Setup;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MYAutoExercise.Pages
{
    public class RegisterInformationPage
    {
        private IWebDriver _driver;

        public RegisterInformationPage(IWebDriver driver)
        {
            _driver = driver;
        }
        private IList<IWebElement> RadioButton()
        {
            return _driver.FindElements(By.XPath("//div[@class='radio-inline']"));
        }

        public void clickradio()
        {
            RadioButton()[1].Click();
        }
        private IWebElement Password()
        {
            return _driver.FindElement(By.XPath("//input[@id='password']"));
        }

        public void Enterpassword(string password)
        {
            Password().SendKeys(password);
        }
        private IWebElement day_dropdown()
        {
            return _driver.FindElement(By.Id("days"));
        }
        public void selectday(string day)
        {
            SelectElement sd = new SelectElement(day_dropdown());
            sd.SelectByValue("29");
        }
        private IWebElement month_dropdown()
        {
            return _driver.FindElement(By.Id("months"));
        }
        public void Select_month(string month)
        {

            SelectElement sd = new SelectElement(month_dropdown());
            sd.SelectByValue(month);
        }
        private IWebElement year_dropdown()
        {
            return _driver.FindElement(By.Id("years"));
        }
        public void Select_year(string year)
        {
            SelectElement sd = new SelectElement(year_dropdown());
            sd.SelectByValue(year);
        }
        private IWebElement checkbox()
        {
            return _driver.FindElement(By.Name("newsletter"));
        }
        public void clickCheckboxes()
        {

            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", checkbox());
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", checkbox());
            Receive_offers();
        }

        private IWebElement Receive_offers()
        {
            return _driver.FindElement(By.CssSelector("label[for='optin']"));

        }
        private IWebElement Firstname_()
        {
            return _driver.FindElement(By.Id("first_name"));

        }
        private IWebElement Lasttname()
        {
            return _driver.FindElement(By.Id("last_name"));

        }
        private IWebElement Company_()
        {
            return _driver.FindElement(By.Id("company"));

        }
        private IWebElement Address_()
        {
            return _driver.FindElement(By.Id("address1"));

        }

        private IWebElement country_dropdown()
        {
            return _driver.FindElement(By.Name("country"));
        }
        private IWebElement State_()
        {
            return _driver.FindElement(By.Id("state"));

        }
        private IWebElement City_()
        {
            return _driver.FindElement(By.Id("city"));

        }
        private IWebElement Zipcode_()
        {
            return _driver.FindElement(By.Id("zipcode"));

        }
        private IWebElement Phonenumber_()
        {
            return _driver.FindElement(By.Id("mobile_number"));

        }
        private IWebElement Submit()
        {
            return _driver.FindElement(By.CssSelector("button[data-qa='create-account']"));

        }
        public void selectCountry(string country)
        {
            SelectElement cd = new SelectElement(country_dropdown());
            cd.SelectByValue(country);
        }
        public void Enterinfo(string Firstname, string Lastname, string Company, string Address, string State, string City, string Zipcode,
            string Phonenumber)
        {

            Firstname_().SendKeys(Firstname);
            Lasttname().SendKeys(Lastname);
            Company_().SendKeys(Company);
            Address_().SendKeys(Address);
            State_().SendKeys(State);
            City_().SendKeys(City);
            Zipcode_().SendKeys(Zipcode);
            Phonenumber_().SendKeys(Phonenumber);






        }
        public void ClickSubmit()
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", Submit());
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].click();", Submit());

        }
    }
}
