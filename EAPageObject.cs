using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumFirst
{
    public class EAPageObject
    {
        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        

        [FindsBy(How = How.Id, Using = "TitleId")]
        public IWebElement ddlTitleId { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }


        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstname { get; set; }


        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }
        

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        public void FillUserForm(string initial, string middleName, string firstName)
        {
            SeleniumSetMethods.EnterText(txtInitial, initial);
            SeleniumSetMethods.EnterText(txtFirstname, firstName);
            SeleniumSetMethods.EnterText(txtMiddleName, middleName);
            SeleniumSetMethods.Click(btnSave);
             
            
            // txtInitial.SendKeys(initial);
            // txtFirstname.SendKeys(firstName);
            // txtMiddleName.SendKeys(middleName);
            // btnSave.Click();

        }

    }
}