using MYAutoExercise.Model;
using MYAutoExercise.Pages;
using MYAutoExercise.Setup;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MYAutoExercise
{
    [Binding]
    public class VerifyContactStepDefinitions
    {
        Basepage _basepage;
        Homepage _homepage;
        Signuppage _signuppage;
        RegisterInformationPage _registerInformationPage;
        ContactPage _contactPage;


        public VerifyContactStepDefinitions(Homepage homepage,
              Basepage basepage, Signuppage signuppage, RegisterInformationPage registerInformationPage, ContactPage contactPage)
        {
            _basepage = basepage;
            _homepage = homepage;
            _signuppage = signuppage;
            _registerInformationPage = registerInformationPage;
            _contactPage = contactPage;

        }
        [Given(@"Test automation page  has been opened")]
        public void GivenTestAutomationPageHasBeenOpened()
        {
            _basepage.LoadApplicationUnderTest();
            _homepage.ClickConsent();
        }

        [When(@"A user clicks on contact us page")]
        public void WhenAUserClicksOnContactUsPage()
        {
            _homepage.clickcontact();
        }

        [When(@"Get in touch is visible")]
        public void WhenGetInTouchIsVisible()
        {
            _contactPage.ContactHeader();
        }
        [When(@"user fill the following informations")]
        public void WhenUserFillTheFollowingInformations(Table table)
        {
            var contactDetailsInfo = table.CreateInstance<ContactModel>();
            _contactPage.EnterTableInfo(contactDetailsInfo.Name, contactDetailsInfo.Email, contactDetailsInfo.Subject, contactDetailsInfo.Body);
        }


        [When(@"the user clicks uploads a file")]
        public void WhenTheUserClicksUploadsAFile()
        {
            Thread.Sleep(100);
        }

        [When(@"the user clicks submit")]
        public void WhenTheUserClicksSubmit()
        {
            _contactPage.ClickSubmit();
        }

        [When(@"the user clicks OK button")]
        public void WhenTheUserClicksOKButton()
        {
            _contactPage.AcceptPopUp();
        }

        [Then(@"""([^""]*)"" is displayed")]
        public void ThenIsDisplayed(string p0)
        {
            _contactPage.DisplayedMessage(p0);
        }

        [Then(@"the user clicks on Home Button")]
        public void ThenTheUserClicksOnHomeButton()
        {
            _contactPage.ClickHome();
        }

        [Then(@"the user is returned to the home page")]
        public void ThenTheUserIsReturnedToTheHomePage()
        {
            throw new PendingStepException();
        }
    }
}
