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
            driver.Navigate().GoToUrl("http://www.google.com");
            System.Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            // Find the element
            IWebElement element = driver.FindElement(By.Name("q"));

            // Perform Ops
            element.SendKeys("executeautomation");
        }

        [TearDown]
        public void CleanUp()
        {
            // Close Driver
            driver.Close();
        }

    }
}
