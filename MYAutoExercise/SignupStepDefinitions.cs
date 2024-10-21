using MYAutoExercise.Model;
using MYAutoExercise.Pages;
using MYAutoExercise.Setup;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MYAutoExercise
{
    [Binding]
    public class SignupStepDefinitions
    {
        Basepage _basepage;
        Homepage _homepage;
        Signuppage _signuppage;
        RegisterInformationPage _registerInformationPage;


        public SignupStepDefinitions(Homepage homepage,
              Basepage basepage, Signuppage signuppage, RegisterInformationPage registerInformationPage)
        {
            _basepage = basepage;
            _homepage = homepage;
            _signuppage = signuppage;
            _registerInformationPage = registerInformationPage;

        }
        [Given(@"Text automation page is opened")]
        public void GivenTextAutomationPageIsOpened()
        {
            _basepage.LoadApplicationUnderTest();
        }

        [When(@"When the user click on signUp")]
        public void WhenWhenTheUserClickOnSignUp()
        {
            _homepage.ClickConsent();
            _homepage.Clicksignup();
        }

        [When(@"the user fill in name field as ""([^""]*)""")]
        public void WhenTheUserFillInNameFieldAs(string p0)
        {
            _signuppage.InputName(p0);
        }

        [When(@"the user fill in Email As ""([^""]*)""")]
        public void WhenTheUserFillInEmailAs(string p0)
        {
            _signuppage.InputEmail(p0);
        }

        [When(@"the user clicks on Sign up button")]
        public void WhenTheUserClicksOnSignUpButton()
        {
            _signuppage.ClickSignUpButton();
        }

        [When(@"the user selects Mrs radiobutton")]
        public void WhenTheUserSelectsMrsRadiobutton()
        {
            _registerInformationPage.clickradio();
        }

        [When(@"the user inputs password as ""([^""]*)""")]
        public void WhenTheUserInputsPasswordAs(string rasakii)
        {
            _registerInformationPage.Enterpassword(rasakii);
        }


        [When(@"the user selects ""([^""]*)"" ""([^""]*)"" ""([^""]*)"" as the date of birth")]
        public void WhenTheUserSelectsAsTheDateOfBirth(string p0, string p1, string p2)
        {
            _registerInformationPage.Select_year(p2);
            _registerInformationPage.Select_month(p1);
            _registerInformationPage.selectday(p0);
        }



        [When(@"user checks the checkbox buttons")]
        public void WhenUserChecksTheCheckboxButtons()
        {
            _registerInformationPage.clickCheckboxes();
        }

        [When(@"user fill the following information")]
        public void WhenUserFillTheFollowingInformation(Table table)
        {
            var SignupDetailsInfo = table.CreateInstance<SignUpModel>();
            _registerInformationPage.Enterinfo(SignupDetailsInfo.Firstname, SignupDetailsInfo.Lastname, SignupDetailsInfo.Company,
                SignupDetailsInfo.Address, SignupDetailsInfo.State, SignupDetailsInfo.City, SignupDetailsInfo.Zipcode,
                SignupDetailsInfo.MobileNumber);
        }


        [When(@"the user select ""([^""]*)"" as country")]
        public void WhenTheUserSelectAsCountry(string Canada)
        {
            _registerInformationPage.selectCountry(Canada);
        }

        [When(@"th user clicks create account")]
        public void WhenThUserClicksCreateAccount()
        {
            _registerInformationPage.ClickSubmit();

        }
        [When(@"the user clicks on continue")]
        public void WhenTheUserClicksOnContinue()
        {


            _homepage.ClickContinue();

        }


        [Then(@"The account is created successsfully")]
        public void ThenTheAccountIsCreatedSuccesssfully()
        {


        }
    }
}
