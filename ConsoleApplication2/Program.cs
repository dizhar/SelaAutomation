using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CSCore.CoreAudioAPI;
using OpenQA.Selenium.Remote;
using System.Collections.Specialized;
using System.Configuration;
using OpenQA.Selenium.Support.UI;



namespace ConsoleApplication2
{
        
    class Program
    {

        

        string songTitle = "stand by me song";

       
        string email = ConfigurationManager.AppSettings["username"];
        string password = ConfigurationManager.AppSettings["password"];

        YouTubePageObject youTubePage;


        static void Main(string[] args)
        {
            
        }

        [SetUp]
        public void Initialize()
        {
          String browser = ConfigurationManager.AppSettings["browser"];

            //Create  the refrence for our browser
            switch (browser)
            {
                case "CHROME":
                    PropertiesCollection.driver = new ChromeDriver();
                    break;
                case "IE":
                   PropertiesCollection.driver = new InternetExplorerDriver();
                    break;
                case "FF":
                    PropertiesCollection.driver = new FirefoxDriver();
                    break;
            }
            
            
            
            
            //open browser window is set to to full screen
            PropertiesCollection.driver.Manage().Window.Maximize();
            //wait 10 second between Clicks
            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait =  TimeSpan.FromSeconds(10);
            //Navigate to  google page
            PropertiesCollection.driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["url"]);
            Console.WriteLine("Opned URL");
            //Initialize the youtube page by callying its reference
            youTubePage = new YouTubePageObject();

        }

        [Test]
        public void TestVideoAudio()
        {
   
            try
            {

                youTubePage.searchSong(songTitle);
                youTubePage.clickSearch();
                youTubePage.showResultsInNewWindow(youTubePage.thirdVideoOnTheSearchResults());
                youTubePage.focusOnNewWindow();  
                Assert.IsTrue(youTubePage.isAudioWorking());
               youTubePage.CloseWindow();
             
            }catch(Exception err){
               Assert.Fail("Error in AudioTest method", err);
               Console.Write(err);
            }


        }




        [Test]
        public void testUsersPlaylist()
        {

   
            try
            {
  
                SeleniumLoginMethod.loginToYoutube(this.email, this.password);
                youTubePage.clickPersonalPlaylist();
                youTubePage.clickOnTheFirstVideoThatAppearsOnThePlaylist();
                youTubePage.clickOnTheFourthVideo();
                Assert.IsTrue(youTubePage.isVideoPlaying());
                youTubePage.CloseWindow();
            }
            catch(Exception err)
            {
                Assert.Fail("Error in testUsersPlaylist method", err);
                Console.Write(err);
            } 
        }



        //Verify that user can delete history items.
        [Test]
        public void testHistoryOfVideoIsDeleted()
        {
            
            try
            {
                //Login with user
                SeleniumLoginMethod.loginToYoutube(this.email, this.password);
                youTubePage.clickOnTheFirstRecommendedVideo();
                youTubePage.clickOnTheMenuBar();
                youTubePage.clickOnHistoryTab();
                string videoTitle = youTubePage.getFirstVideoTitleInHistoryList();
                youTubePage.removeVideo();  
                youTubePage.refreshPage(); 
                //Verify that the title ofthe video you just deleted is not displayed on the list
                Assert.IsFalse(youTubePage.isTextVisible(videoTitle));
                
            
            }
            catch (Exception err)
            {
                Assert.Fail("Error in test history of viewed video", err);
                Console.Write(err);
            }


        }


        //Verify that recently viewed video is in the history list
        [Test]
        public void testHistoryOfViewedVideo()
        {
            
            try
            {
                SeleniumLoginMethod.loginToYoutube(this.email, this.password);
                youTubePage.clickOnTheFirstRecommendedVideo();
                string text = youTubePage.getVideoTitle();
                Console.WriteLine(text);
                youTubePage.clickOnTheMenuBar();
                youTubePage.clickOnHistoryTab();
                youTubePage.refreshPage();
                String history_title = youTubePage.getTheFirstVideoInTheHistoryList();
                Console.WriteLine(history_title);
                Assert.IsTrue(text.Equals(history_title));
                youTubePage.CloseWindow();
            }
            catch (Exception err)
            {
                Assert.Fail("Error in test history of viewed video", err);
                Console.Write(err);
            } 


        }





        




        [TearDown]
        public void CleanUp()
        {
            //Close browser
            PropertiesCollection.driver.Quit();
            Console.WriteLine("Closed the browser");
        }

    }
}
