using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

using System.Threading;


namespace ConsoleApplication2
{
    class SeleniumSetMethods
    {

    

        //Enter Text
        public static void EnterText(string element, string value, PropertyType elementtype)
        {
            try
            {
                if (elementtype == PropertyType.Id)
                    PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
                if (elementtype == PropertyType.Name)
                    PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
                if (elementtype == PropertyType.CssName)
                    PropertiesCollection.driver.FindElement(By.CssSelector(element)).SendKeys(value);
                if (elementtype == PropertyType.Xpath)
                    PropertiesCollection.driver.FindElement(By.XPath(element)).SendKeys(value);
                if (elementtype == PropertyType.ClassName)
                    PropertiesCollection.driver.FindElement(By.ClassName(element)).SendKeys(value);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //Click into a button, CheckBox, option etx
        public static void Click(string element, PropertyType elementtype)
        {
            try
            {
                if (elementtype == PropertyType.Id)
                    PropertiesCollection.driver.FindElement(By.Id(element)).Click();
                if (elementtype == PropertyType.Name)
                    PropertiesCollection.driver.FindElement(By.Name(element)).Click();
                if (elementtype == PropertyType.CssSelector)
                    PropertiesCollection.driver.FindElement(By.CssSelector(element)).Click();
                if (elementtype == PropertyType.Xpath)
                    PropertiesCollection.driver.FindElement(By.XPath(element)).Click();
                if (elementtype == PropertyType.ClassName)
                    PropertiesCollection.driver.FindElement(By.ClassName(element)).Click();
            }catch (Exception e)
            {
                throw e;
            }
        }

        //Select a drop down control
        public static void SelectDropDown(string element, string value, PropertyType elementtype)
        {
            try
            {
                if (elementtype == PropertyType.Id)
                    new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).DeselectByText(value);
                if (elementtype == PropertyType.Name)
                    new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).DeselectByText(value);
                if (elementtype == PropertyType.Xpath)
                    new SelectElement(PropertiesCollection.driver.FindElement(By.XPath(element))).DeselectByText(value);
                if (elementtype == PropertyType.CssSelector)
                    new SelectElement(PropertiesCollection.driver.FindElement(By.CssSelector(element))).DeselectByText(value);
                if (elementtype == PropertyType.ClassName)
                    new SelectElement(PropertiesCollection.driver.FindElement(By.ClassName(element))).DeselectByText(value);
            }
            catch (Exception e)
            {
                throw e;
            }

        }






        internal static void openInNewWindow(Actions shiftClick, IWebElement element, PropertyType elementtype)
        {
            try{
                shiftClick.KeyDown(Keys.Shift).Click(element).KeyUp(Keys.Shift).Perform();
            }
            catch (Exception e)
            {
                 throw e;
            }
        }


        public static IWebElement getWebElement(string value, PropertyType elementtype)
        {
            try
            {
                if (elementtype == PropertyType.Id)
                    return PropertiesCollection.driver.FindElement(By.Id(value));
                if (elementtype == PropertyType.Name)
                    return PropertiesCollection.driver.FindElement(By.Name(value));
                if (elementtype ==  PropertyType.CssSelector)
                    return PropertiesCollection.driver.FindElement(By.CssSelector(value));
                if (elementtype == PropertyType.Xpath)
                    return PropertiesCollection.driver.FindElement(By.XPath(value));
                if (elementtype == PropertyType.ClassName)
                    return PropertiesCollection.driver.FindElement(By.ClassName(value));
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }


     





    }
}
