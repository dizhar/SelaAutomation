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
            var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(seacrhSongTesxtBox));
            seacrhSongTesxtBox.SendKeys(title);
        }


        public void ClickOnUsersPersonalPlaylist()
        {
            var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(Play_List_button));
            Play_List_button.Click();
        }


        public void ClickOnTheFirstVideoOnThePlayList()
        {
            var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(first_video_on_the_playlist));
            first_video_on_the_playlist.Click();
        }

        public void ClickOnTheFourthVideo()
        {
            var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(Fourth_video_on_the_playlist));
            Fourth_video_on_the_playlist.Click();
        }

        public void clickOnTheFirstRecommendedVideo()
        {
            //wait 3 seconds
            Thread.Sleep(5000);
            var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(first_recommeded_video));
            first_recommeded_video.Click();
        }


        public void clickOnTheMenuBar()
        {
            //wait 3 seconds
            Thread.Sleep(5000);
            var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(menu_bar));
            menu_bar.Click();
        }

        public void clickOnHistoryTab()
        {
            Thread.Sleep(5000);
            var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(history_tab));
            history_tab.Click();
        }

        public void removeVideo()
        {
            Thread.Sleep(5000);
            var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(remove_item_the_first_item));
            remove_item_the_first_item.Click();
        }


        public string getFirstVideoTitleInHistoryList()
        {
            //wait 3 seconds
            //Thread.Sleep(5000);
            var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(remove_item_the_first_item));
            return first_video_in_history_list.Text;
        }

        public void refreshPage()
        {

            PropertiesCollection.driver.Navigate().Refresh();
            //wait
            Thread.Sleep(10000);
        }


        public string getVideoTitle()
        {
            var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(video_title));
            return video_title.Text; 
        }


        public string getTheFirstVideoInTheHistoryList(){
            Thread.Sleep(5000);
            var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(first_video_in_history_list));
            return first_video_in_history_list.Text;
        }


        public void CloseWindow()
        {
            PropertiesCollection.driver.Close();
        }

        public void clickSearch()
        {
            var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(search_button));
            search_button.Click();
        }


        public IWebElement thirdVideoOnTheSearchResults()
        {
            return third_video_down_search_results;
        }


        public void showResultsInNewWindow(IWebElement element)
        {
            SeleniumSetMethods.openInNewWindow(PropertyAction.shiftClick, element, PropertyType.CssSelector);
        }


        public void focusOnNewWindow()
        {
            PropertiesCollection.driver.SwitchTo().Window(PropertiesCollection.driver.WindowHandles.Last());
        }

        public Boolean isAudioWorking()
        {
            Thread.Sleep(5000);
            return AudioPlayChecker.IsAudioPlaying(PropertyAudio.audioDevice);
        }

        public Boolean isVideoPlaying()
        {
            return PropertiesCollection.driver.FindElement(By.XPath("//button[@aria-label='Pause']")).Displayed;
        }

        public void clickPersonalPlaylist(){
            var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(Play_List_button));
            Play_List_button.Click();
        }


        public void clickOnTheFirstVideoThatAppearsOnThePlaylist(){
            var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(first_video_on_the_playlist));
            first_video_on_the_playlist.Click();
        }


        public void clickOnTheFourthVideo()
        {
            var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(Fourth_video_on_the_playlist));
            Fourth_video_on_the_playlist.Click();
        }

        public Boolean isTextVisible(string videoTitle)
        {
            var wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(By.TagName("body")));
            Thread.Sleep(5000);
            return PropertiesCollection.driver.PageSource.Contains(videoTitle);
        }




     }

       
    }


