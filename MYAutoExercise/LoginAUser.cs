using MYAutoExercise.Pages;
using MYAutoExercise.Setup;
using TechTalk.SpecFlow;

namespace MYAutoExercise
{
    [Binding]
    public class LoginAUser
    {
        Basepage _basepage;
        Homepage _homepage;
        Signuppage _signuppage;
        RegisterInformationPage _registerInformationPage;


        public LoginAUser(Homepage homepage,
              Basepage basepage, Signuppage signuppage, RegisterInformationPage registerInformationPage)
        {
            _basepage=basepage;
            _homepage = homepage;
            _signuppage = signuppage;
            _registerInformationPage = registerInformationPage;

        }
        [Given(@"Text automation page  has been opened")]
        public void GivenTextAutomationPageHasBeenOpened()
        {
            _basepage.LoadApplicationUnderTest();
        }

        [When(@"When the user click on signup or login")]
        public void WhenWhenTheUserClickOnSignupOrLogin()
        {
            _homepage.ClickConsent();
            _homepage.Clicksignup();
        }

        [When(@"the user fill email field as ""([^""]*)""")]
        public void WhenTheUserFillEmailFieldAs(string p0)
        {
            _signuppage.InputLoginEmail(p0);
        }

        [When(@"the user fill in password As ""([^""]*)""")]
        public void WhenTheUserFillInPasswordAs(string rasakii)
        {
            _signuppage.InsertLOginPassword(rasakii);
        }

        [When(@"the user clicks on login button")]
        public void WhenTheUserClicksOnLoginButton()
        {
            _signuppage.clickLogin();
        }

        [Then(@"the user is logged in succesfully")]
        public void ThenTheUserIsLoggedInSuccesfully()
        {
            _homepage.VerifyLoginUsername();
        }
    }
}
