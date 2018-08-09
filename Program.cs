using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst
{
    class Program
    {
    
        // static void Main(string[] args)
        // {
        // }

        [SetUp]
        public void Initialize()
        {
            // First create reference for our browser
            PropertiesCollection.driver = new ChromeDriver(@"C:\Users\User\");

            // Navigate to Google Page
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            System.Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            // Login to Applciation
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login("execute", "automation");

            pageEA.FillUserForm("MP", "Manny", "Automation");

            // Initialize the Page by calling its Reference
            EAPageObject page = new EAPageObject();

            page.txtInitial.SendKeys("executeautomation");

            page.btnSave.Click();



            // // Title 
            // SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            // // Initial
            // SeleniumSetMethods.EnterText("Initial", "executeautomation", PropertyType.Name);

            // System.Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetText("TitleId", PropertyType.Id));

            // System.Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText("TitleId", PropertyType.Name));

            // //Click 
            // SeleniumSetMethods.Click("Save", PropertyType.Name);
        }

        [TearDown]
        public void CleanUp()
        {
            // Close Driver
            PropertiesCollection.driver.Close();
        }

    }
}
