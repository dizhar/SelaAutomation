using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace ConsoleApplication2
{
    class YouTubePageObject
    {
        public YouTubePageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
       

        [FindsBy(How = How.Name, Using="search_query")]
        public IWebElement seacrhSongTesxtBox { get; set; }


        [FindsBy(How = How.Id, Using = "search-icon-legacy")]
        public IWebElement search_button { get; set; }


        [FindsBy(How = How.CssSelector, Using = "ytd-video-renderer.style-scope:nth-child(3) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > h3:nth-child(1) > a:nth-child(2)")]
        public IWebElement third_video_down_search_results { get; set; }


        [FindsBy(How = How.CssSelector, Using = "ytd-guide-section-renderer.style-scope:nth-child(2) > div:nth-child(3) > ytd-guide-entry-renderer:nth-child(3) > a:nth-child(1)")]
        public IWebElement Play_List_button { get; set; }


        [FindsBy(How = How.CssSelector, Using = "ytd-playlist-video-renderer.style-scope:nth-child(1) > div:nth-child(2) > a:nth-child(1) > div:nth-child(2) > h3:nth-child(1) > span:nth-child(2)")]
        public IWebElement first_video_on_the_playlist { get; set; }

        [FindsBy(How = How.CssSelector, Using = "ytd-playlist-panel-video-renderer.style-scope:nth-child(5) > a:nth-child(1) > div:nth-child(1) > div:nth-child(3) > h4:nth-child(2) > span:nth-child(2)")]
        public IWebElement Fourth_video_on_the_playlist { get; set; }

        [FindsBy(How = How.CssSelector, Using = "ytd-grid-video-renderer.ytd-grid-renderer:nth-child(1) > div:nth-child(1) > ytd-thumbnail:nth-child(1) > a:nth-child(1) > yt-img-shadow:nth-child(1) > img:nth-child(1)")]
        public IWebElement first_recommeded_video { get; set; }

        [FindsBy(How = How.CssSelector, Using = "h1.title > yt-formatted-string:nth-child(1)")]
        public IWebElement video_title { get; set; }

        [FindsBy(How = How.CssSelector, Using = "yt-icon-button.ytd-masthead:nth-child(3) > button:nth-child(1)")]
        public IWebElement menu_bar { get; set; }
                                                 
        [FindsBy(How = How.CssSelector, Using = "ytd-guide-section-renderer.style-scope:nth-child(2) > div:nth-child(3) > ytd-guide-entry-renderer:nth-child(1) > a:nth-child(1) > span:nth-child(3)")]
        public IWebElement history_tab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "ytd-video-renderer.style-scope:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > h3:nth-child(1) > a:nth-child(2)")]
        public IWebElement first_video_in_history_list { get; set; }


        [FindsBy(How = How.XPath, Using = "//button[@class='ytp-large-play-button ytp-button")]
        public IWebElement skip_button { get; set; }
          
        [FindsBy(How = How.CssSelector, Using = "ytd-video-renderer.style-scope:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > ytd-menu-renderer:nth-child(1) > div:nth-child(1) > ytd-button-renderer:nth-child(1) > a:nth-child(1) > yt-icon-button:nth-child(1) > button:nth-child(1)")]
        public IWebElement remove_item_the_first_item { get; set; }

     
        
        
        public void searchSong(string title)
        {
            try
            {
                var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(seacrhSongTesxtBox));
                seacrhSongTesxtBox.SendKeys(title);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public void ClickOnUsersPersonalPlaylist()
        {
            try
            {
                var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(Play_List_button));
                Play_List_button.Click();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public void ClickOnTheFirstVideoOnThePlayList()
        {
            try
            {
                var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(first_video_on_the_playlist));
                first_video_on_the_playlist.Click();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void ClickOnTheFourthVideo()
        {
            try
            {
                var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(Fourth_video_on_the_playlist));
                Fourth_video_on_the_playlist.Click();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void clickOnTheFirstRecommendedVideo()
        {
            try
            {
                //wait 3 seconds
                Thread.Sleep(5000);
                var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(first_recommeded_video));
                first_recommeded_video.Click();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public void clickOnTheMenuBar()
        {
            try
            {
                //wait 3 seconds
                Thread.Sleep(5000);
                var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(menu_bar));
                menu_bar.Click();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void clickOnHistoryTab()
        {
            try
            {
                Thread.Sleep(5000);
                var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(history_tab));
                history_tab.Click();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void removeVideo()
        {
            try
            {
                Thread.Sleep(5000);
                var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(remove_item_the_first_item));
                remove_item_the_first_item.Click();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public string getFirstVideoTitleInHistoryList()
        {
            try
            {
                //wait 3 seconds
                //Thread.Sleep(5000);
                var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(remove_item_the_first_item));
                return first_video_in_history_list.Text;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void refreshPage()
        {
            try
            {
                PropertiesCollection.driver.Navigate().Refresh();
                //wait
                Thread.Sleep(10000);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public string getVideoTitle()
        {
            try
            {
                var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(video_title));
                return video_title.Text;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public string getTheFirstVideoInTheHistoryList(){
            try
            {
                Thread.Sleep(5000);
                var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(first_video_in_history_list));
                return first_video_in_history_list.Text;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public void CloseWindow()
        {
            try
            {
                PropertiesCollection.driver.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void clickSearch()
        {
            try
            {
                var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(search_button));
                search_button.Click();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public IWebElement thirdVideoOnTheSearchResults()
        {
            try
            {
                return third_video_down_search_results;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public void showResultsInNewWindow(IWebElement element)
        {
            try
            {
                SeleniumSetMethods.openInNewWindow(PropertyAction.shiftClick, element, PropertyType.CssSelector);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public void focusOnNewWindow()
        {
            try
            {
                PropertiesCollection.driver.SwitchTo().Window(PropertiesCollection.driver.WindowHandles.Last());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Boolean isAudioWorking()
        {
            try
            {
                Thread.Sleep(5000);
                return AudioPlayChecker.IsAudioPlaying(PropertyAudio.audioDevice);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Boolean isVideoPlaying()
        {
            try
            {
                return PropertiesCollection.driver.FindElement(By.XPath("//button[@aria-label='Pause']")).Displayed;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void clickPersonalPlaylist(){
            try
            {
                var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(Play_List_button));
                Play_List_button.Click();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public void clickOnTheFirstVideoThatAppearsOnThePlaylist(){
            try
            {
                var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(first_video_on_the_playlist));
                first_video_on_the_playlist.Click();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public void clickOnTheFourthVideo()
        {
            try
            {
                var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(Fourth_video_on_the_playlist));
                Fourth_video_on_the_playlist.Click();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Boolean isTextVisible(string videoTitle)
        {
            try
            {
                var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.TagName("body")));
                Thread.Sleep(5000);
                return PropertiesCollection.driver.PageSource.Contains(videoTitle);
            }
            catch (Exception e)
            {
                throw e;
            }
        }




     }

       
    }


