using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst
{
    class Program
    {
        // First create reference for our browser
        IWebDriver driver = new ChromeDriver(@"C:\Users\User\");
        // static void Main(string[] args)
        // {
        // }

        [SetUp]
        public void Initialize()
        {
            // Navigate to Google Page
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            System.Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            // Title 
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");

            // Initial
            SeleniumSetMethods.EnterText(driver, "Initial", "executeautomation", "Name");

            System.Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetText(driver, "TitleId", "Id"));

            System.Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText(driver, "TitleId", "Name"));

            //Click 
            SeleniumSetMethods.Click(driver, "Save", "Name");
        }

        [TearDown]
        public void CleanUp()
        {
            // Close Driver
            driver.Close();
        }

    }
}
