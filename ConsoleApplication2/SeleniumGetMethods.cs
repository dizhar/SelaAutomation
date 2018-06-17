using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class SeleniumGetMethods
    {

        // Is Element present
        public static bool IsElementPresent(string value, PropertyType elementtype)
        {
            try
            {
                if (elementtype == PropertyType.Id)
                    return PropertiesCollection.driver.FindElement(By.Id(value)).Displayed;
                if (elementtype == PropertyType.Name)
                    return PropertiesCollection.driver.FindElement(By.Name(value)).Displayed;
                if (elementtype == PropertyType.CssSelector)
                    return PropertiesCollection.driver.FindElement(By.CssSelector(value)).Displayed;
                if (elementtype == PropertyType.Xpath)
                    return PropertiesCollection.driver.FindElement(By.XPath(value)).Displayed;
                if (elementtype == PropertyType.ClassName)
                    return PropertiesCollection.driver.FindElement(By.ClassName(value)).Displayed;
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public static string getText(string value, PropertyType elementtype)
        {
            try
            {
                if (elementtype == PropertyType.Id)
                    return PropertiesCollection.driver.FindElement(By.Id(value)).Text;
                if (elementtype == PropertyType.Name)
                    return PropertiesCollection.driver.FindElement(By.Name(value)).Text;
                if (elementtype == PropertyType.CssSelector)
                    return PropertiesCollection.driver.FindElement(By.CssSelector(value)).Text;
                if (elementtype == PropertyType.Xpath)
                    return PropertiesCollection.driver.FindElement(By.XPath(value)).Text;
                if (elementtype == PropertyType.ClassName)
                    return PropertiesCollection.driver.FindElement(By.ClassName(value)).Text;
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
