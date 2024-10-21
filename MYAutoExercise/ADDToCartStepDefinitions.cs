using MYAutoExercise.Pages;
using MYAutoExercise.Setup;
using TechTalk.SpecFlow;

namespace MYAutoExercise
{
    [Binding]
    public class ADDToCartStepDefinitions
    {
        Basepage _basepage;
        Homepage _homepage;
        Signuppage _signuppage;
        RegisterInformationPage _registerInformationPage;
        ContactPage _contactPage;
        ProductPage _productPage;


        public ADDToCartStepDefinitions(Homepage homepage,
              Basepage basepage, Signuppage signuppage, RegisterInformationPage registerInformationPage, ContactPage contactPage,
              ProductPage productPage)
        {
            _basepage=basepage;
            _homepage = homepage;
            _signuppage = signuppage;
            _registerInformationPage = registerInformationPage;
            _contactPage = contactPage;
            _productPage = productPage;
        }
        [Given(@"Test automation page is loaded succesfully")]
        public void GivenTestAutomationPageIsLoadedSuccesfully()
        {
            _basepage.LoadApplicationUnderTest();
        }

        [When(@"user clicks on product page")]
        public void WhenUserClicksOnProductPage()
        {
            _homepage.ClickConsent();
            _homepage.ClickProduct();
        }

        [When(@"All products are displayed successfully")]
        public void WhenAllProductsAreDisplayedSuccessfully()
        {
            _productPage.GetproductHeader();
        }

        [When(@"user clicks on   add to cart for blue Top")]
        public void WhenUserClicksOnAddToCartForBlueTop()
        {
            _productPage.MovetoCart();
        }

        [When(@"user clicks on continue shopping")]
        public void WhenUserClicksOnContinueShopping()
        {
            throw new PendingStepException();
        }

        [When(@"user clicks on add to cart for men Tshirt")]
        public void WhenUserClicksOnAddToCartForMenTshirt()
        {
            throw new PendingStepException();
        }

        [When(@"user clicks on add to cart for sleeveless dress")]
        public void WhenUserClicksOnAddToCartForSleevelessDress()
        {
            throw new PendingStepException();
        }

        [When(@"user clicks on view cart")]
        public void WhenUserClicksOnViewCart()
        {
            throw new PendingStepException();
        }

        [When(@"user clicks on Proceed to check out")]
        public void WhenUserClicksOnProceedToCheckOut()
        {
            throw new PendingStepException();
        }

        [Then(@"Product are shown in checkoutPage")]
        public void ThenProductAreShownInCheckoutPage()
        {
            throw new PendingStepException();
        }
    }
}
