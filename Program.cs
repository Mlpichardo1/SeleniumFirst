using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst
{
    class Program
    {
    
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            // First create reference for our browser
            PropertiesCollection.driver = new ChromeDriver(@"C:\Users\User\");

            // ChromeOptions option = new ChromeOptions();
            // option.AddArgument("--headless");
            // PropertiesCollection.driver = new ChromeDriver(@"C:\Users\User\", option);

            // Navigate to Google Page
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            System.Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            ExcelLib.PopulateInCollection(@"C:\Users\User\Desktop\CliffisEvil.xlsx");

            //Login to Applciation
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login(ExcelLib.ReadData(1, "UserName"), ExcelLib.ReadData(1, "Password"));

            pageEA.FillUserForm(ExcelLib.ReadData(1, "Initial"), ExcelLib.ReadData(1, "MiddleName"), ExcelLib.ReadData(1, "FirstName"));

            // Login to Applciation
            // LoginPageObject pageLogin = new LoginPageObject();
            // EAPageObject pageEA = pageLogin.Login("execute", "automation");

            // pageEA.FillUserForm("MP", "Manny", "Automation");

            // Initialize the Page by calling its Reference
            // EAPageObject page = new EAPageObject();

            // page.txtInitial.SendKeys("executeautomation");

            // page.btnSave.Click();

        }

        [TearDown]
        public void CleanUp()
        {
            // Close Driver
            PropertiesCollection.driver.Close();
        }
    }
}
