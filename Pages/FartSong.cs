using AventStack.ExtentReports;
using HolyQuran.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class FartSong
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        private AdHelperC adHelper;

        //Constructor
        public FartSong(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            this.adHelper = new AdHelperC(driver); // Initialize AdHelper with the correct driver type

        }

        public void FartSongSoundTest()
        {
            ExtentTest test = Extent.CreateTest("NearBy Places Report 1");
            try
            {
                FartSongMenu.Click();
                FartSong1.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred : " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                FartSong2.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred : " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                FartSong3.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred : " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                FartSong4.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred : " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                FartSong5.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred : " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                FartSong6.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred : " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");

            }

            try
            {
                FartSong7.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred : " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");

            }

            try
            {
                FartSong8.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occured: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");

            }

            try
            {
                FartSong9.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred : " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");

            }

            try
            {
                IWebElement ScrollelementtoLast = driver.FindElement(MobileBy.AndroidUIAutomator(
                "new UiScrollable(new UiSelector().scrollable(true))" +
                ".scrollIntoView(new UiSelector().text(\"Fart Song 12\")) "));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);

            }

            try
            {
                FartSong10.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred : " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");

            }

            try
            {
                FartSong11.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred : " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");

            }
            try
            {
                FartSong12.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred : " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");

            }
        }

        IWebElement FartSongMenu => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Song\"]");
        IWebElement FartSong1 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Song 1\"]");
        IWebElement FartSong2 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Song 2\"]");
        IWebElement FartSong3 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Song 3\"]");
        IWebElement FartSong4 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Song 4\"]");
        IWebElement FartSong5 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Song 5\"]");
        IWebElement FartSong6 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Song 6\"]");
        IWebElement FartSong7 => driver.FindElementByXPath("(//android.view.ViewGroup[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/maiCv\"])[7]");
        IWebElement FartSong8 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Song 8\"]");
        IWebElement FartSong9 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Song 9\"]");
        IWebElement FartSong10 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Song 10\"]");
        IWebElement FartSong11 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Song 11\"]");
        IWebElement FartSong12 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Song 12\"]");

        IWebElement BackButton1 => driver.FindElementByAccessibilityId("Navigate up");
        IWebElement VolumeUp => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus");
        IWebElement VolumeDown => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus");
        IWebElement Loop => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck");
        IWebElement PlayButton => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]");
        IWebElement AddtoBookmark => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite");

    }
}
