using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace ConsoleApplication2
{
    class LoginPageObject
    {

        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }


        [FindsBy(How = How.Id, Using = "text")]
        public IWebElement Sign_In_text_link { get; set; }


        [FindsBy(How = How.Id, Using = "identifierId")]
        public IWebElement Email_Input_Field { get; set; }

        [FindsBy(How = How.Id, Using = "identifierNext")]
        public IWebElement Next_Email_Button { get; set; }


        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement password_Input_field { get; set; }

        [FindsBy(How = How.Id, Using = "passwordNext")]
        public IWebElement Next_Password_Button { get; set; }

       
        
        public void ClickOnTheSignInLink()
        {
            var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(Sign_In_text_link));
            Sign_In_text_link.Click();
        } 

        public void TypeEmail(string email){
            var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(Email_Input_Field));
            Email_Input_Field.SendKeys(email);
        }


        public void ClickOnTheNextEmailButton()
        {
            var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(Next_Email_Button));
            Next_Email_Button.Click();
        }

        public void typeInPassword(string password){
            var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(password_Input_field));
            password_Input_field.SendKeys(password);
        }

        public void clickOnTheNextPasswordButton()
        {
            Thread.Sleep(1000);
            var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(Next_Password_Button));
            Next_Password_Button.Click();
        }


    }
}
