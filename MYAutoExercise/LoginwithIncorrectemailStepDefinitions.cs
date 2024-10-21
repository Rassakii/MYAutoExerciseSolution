using MYAutoExercise.Pages;
using MYAutoExercise.Setup;
using TechTalk.SpecFlow;

namespace MYAutoExercise
{
    [Binding]
    public class LoginwithIncorrectemailStepDefinitions
    {
        Basepage _basepage;
        Homepage _homepage;
        Signuppage _signuppage;
        RegisterInformationPage _registerInformationPage;


        public LoginwithIncorrectemailStepDefinitions(Homepage homepage,
              Basepage basepage, Signuppage signuppage, RegisterInformationPage registerInformationPage)
        {
            _basepage=basepage;
            _homepage = homepage;
            _signuppage = signuppage;
            _registerInformationPage = registerInformationPage;

        }
        [Given(@"taht Text automation page  has been opened")]
        public void GivenTahtTextAutomationPageHasBeenOpened()
        {
            _basepage.LoadApplicationUnderTest();
        }

        [When(@"When the user clicks on signup or login")]
        public void WhenWhenTheUserClicksOnSignupOrLogin()
        {
            _homepage.ClickConsent();
            _homepage.Clicksignup();
        }

        [When(@"the user fills email field as ""([^""]*)""")]
        public void WhenTheUserFillsEmailFieldAs(string p0)
        {
            _signuppage.InputLoginEmail(p0);
        }

        [When(@"the user fills in password As ""([^""]*)""")]
        public void WhenTheUserFillsInPasswordAs(string rasakii)
        {
            _signuppage.InsertLOginPassword(rasakii);
        }

        [When(@"the user click on login button")]
        public void WhenTheUserClickOnLoginButton()
        {
            _signuppage.clickLogin();
        }

        [Then(@"then ""([^""]*)"" is displayed")]
        public void ThenThenIsDisplayed(string p0)
        {
            _signuppage.CheckerrorMessage(p0);
        }
    }
}
