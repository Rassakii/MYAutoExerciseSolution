using MYAutoExercise.Pages;
using MYAutoExercise.Setup;
using TechTalk.SpecFlow;

namespace MYAutoExercise
{
    [Binding]
    public class VerifyProductPageStepDefinitions
    {
        Basepage _basepage;
        Homepage _homepage;
        Signuppage _signuppage;
        RegisterInformationPage _registerInformationPage;
        ContactPage _contactPage;
        ProductPage _productPage;


        public VerifyProductPageStepDefinitions(Homepage homepage,
              Basepage basepage, Signuppage signuppage, RegisterInformationPage registerInformationPage, ContactPage contactPage,
              ProductPage productPage)
        {
            _basepage= basepage;
            _homepage = homepage;
            _signuppage = signuppage;
            _registerInformationPage = registerInformationPage;
            _contactPage = contactPage;
            _productPage = productPage;
        }


        [Given(@"Test automation page  has been opened successfully")]
        public void GivenTestAutomationPageHasBeenOpenedSuccessfully()
        {
            _basepage.LoadApplicationUnderTest();
            _homepage.ClickConsent();
        }

        [When(@"A user clicks on product page")]
        public void WhenAUserClicksOnProductPage()
        {
            _homepage.ClickProduct();
        }

        [When(@"All product is displayed successfully")]
        public void WhenAllProductIsDisplayedSuccessfully()
        {
            _productPage.GetproductHeader();
        }

        [When(@"user clicks on view product")]
        public void WhenUserClicksOnViewProduct()
        {
            _productPage.ClickSelectedProduct();
        }

        [Then(@"Productname,category, price, availability, condition, brand is displayed successfully")]
        public void ThenProductnameCategoryPriceAvailabilityConditionBrandIsDisplayedSuccessfully()
        {
            _productPage.ProductDetails();
        }
    }
}
