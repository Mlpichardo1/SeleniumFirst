using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumExtras.PageObjects;

namespace SeleniumFirst
{
    public class LoginPageObject
    {


        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        
        // private readonly RemoteWebDriver _driver;

        // public LoginPageObject(RemoteWebDriver driver) => _driver = driver;

        // IWebElement txtUserName => _driver.FindElementByName("UserName");
        // IWebElement txtPassword => _driver.FindElementByName("Password");

        // IWebElement btnLogin => _driver.FindElementByName("Login");



        public EAPageObject Login(string userName, string password)
        {
            //Username
            txtUserName.SendKeys(userName);
            //Password
            txtPassword.SendKeys(password);
            //Click Button
            btnLogin.Submit();

            //Return the page object
            return new EAPageObject();
        }
    }
}