using MYAutoExercise.configuration;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAutoExercise.Pages
{
    public class Basepage
    {
        public IWebDriver Driver;
        public Basepage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void LoadApplicationUnderTest()
        {
            Driver.Navigate().GoToUrl(ConfigurationManager.Url);
            Driver.Manage().Window.Maximize();
        }
    }
}
