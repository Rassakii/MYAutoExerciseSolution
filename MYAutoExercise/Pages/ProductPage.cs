using MYAutoExercise.Setup;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace MYAutoExercise.Pages
{
    public class ProductPage
    {
        private IWebDriver _driver;

        public ProductPage(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement ProductHeader()
        {
            return  _driver.FindElement(By.CssSelector(".title.text-center"));
        }
        public void GetproductHeader()
        {
            string productText = ProductHeader().Text;
            StringAssert.Contains("ALL PRODUCTS", productText);
        }
        private IWebElement ViewProduct()
        {
            return _driver.FindElement(By.LinkText("View Product"));
        }
        public void ClickSelectedProduct()
        {
            ViewProduct().Click();
        }
        private IWebElement Price()
        {
            return _driver.FindElement(By.CssSelector("div[class='product-information'] span span"));
        }
        private IWebElement Category()
        {
            return _driver.FindElement(By.XPath("//p[normalize-space()='Category: Women > Tops']"));
        }
        private IWebElement Brand()
        {
            return _driver.FindElement(By.XPath("/html/body/section/div/div/div[2]/div[2]/div[2]/div/p[4]"));
        }
        private IWebElement ProductName()
        {
            return _driver.FindElement(By.XPath("//h2[normalize-space()='Blue Top']"));
        }
        public void ProductDetails()
        {
            string priceText = Price().Text;
            StringAssert.Contains("Rs. 500", priceText);
            string categoryText = Category().Text;
            StringAssert.Contains("Women", categoryText);
            string BrandText = Brand().Text;
            StringAssert.Contains("Polo", BrandText);
            string productnameText = ProductName().Text;
            StringAssert.Contains("Blue Top", productnameText);


        }
        String Bluetop = "Blue Top";
        String Dress = "Stylish Dress";
        String Tshirt = "Men Tshirt";
        private IList<IWebElement> products()
        {
            return _driver.FindElements(By.XPath("//div[@class='features_items']"));
        }
        public void MovetoCart()
        {
            var action = new Actions(_driver);
            action.MoveToElement(_driver.FindElement(By.XPath("(//div[@class='product-image-wrapper'])[1]"))).Perform();
            _driver.FindElement(By.XPath("(//a[@data-product-id='1'])[2]")).Click();
            _driver.FindElement(By.XPath("//button[@data-dismiss]")).Click();
            action.MoveToElement(_driver.FindElement(By.XPath("(//div[@class='productinfo text-center'])[2]"))).Perform();
            _driver.FindElement(By.XPath("(//a[@data-product-id='2'])[2]")).Click();
            _driver.FindElement(By.XPath("//button[@data-dismiss]")).Click();
            action.MoveToElement(_driver.FindElement(By.XPath("(//img[@alt='ecommerce website products'])[1]"))).Perform();
            _driver.FindElement(By.XPath("(//a[@data-product-id='3'])[2]")).Click();
            _driver.FindElement(By.XPath("(//u[normalize-space()='View Cart'])[1]")).Click();


        }
        //public void AddProducttoCart() 
        //{

        //    foreach (IWebElement product in products())
        //    {

        //        string productTextLower = product.Text.Trim().ToLower();
        //        if (productTextLower == Bluetop.ToLower())
        //        {
        //            var action = new Actions(context._driver);
        //            action.MoveToElement(context._driver.FindElement(By.XPath("(//div[@class='product-image-wrapper'])[1]"))).Perform();
        //            product.FindElement(By.XPath("(//a[@data-product-id='1'])[2]")).Click();
        //            product.FindElement(By.XPath("//button[@data-dismiss]")).Click();
        //        }

        //        //if (productTextLower == Dress.ToLower())
        //        //{
        //        //    product.FindElement(By.LinkText("Add to cart")).Click();
        //        //    product.FindElement(By.CssSelector(".btn.btn-success.close-modal.btn-block")).Click();
        //        //}
        //        //if (productTextLower == Tshirt.ToLower())
        //        //{
        //        //    product.FindElement(By.LinkText("Add to cart")).Click();
        //        //    product.FindElement(By.TagName("u")).Click();
        //        //}






        //    }

        //}

    }
}
