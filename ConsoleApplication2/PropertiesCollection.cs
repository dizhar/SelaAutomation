using CSCore.CoreAudioAPI;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{

    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        CssSelector,
        Xpath,
        ClassName
    }
    
    
    class PropertiesCollection
    {
     
        //Auto Implement Property
        public static IWebDriver driver { get; set; }
         
    
    }

    class  PropertyAction
    {
        public static Actions shiftClick = new Actions(PropertiesCollection.driver);
    }

    class PropertyAudio
    {
        public static MMDevice audioDevice = AudioPlayChecker.GetDefaultRenderDevice();
    }

}
