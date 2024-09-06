using AventStack.ExtentReports;
using HolyQuran.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class CarHorn
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        private AdHelperC adHelper;
        //Constructor
        public CarHorn(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            this.adHelper = new AdHelperC(driver); // Initialize AdHelper with the correct driver type

        }

        public void CarHornSoundTest()
        {
            ExtentTest test = Extent.CreateTest("Car Horn Sound Test");
            try
            {
                // CarHornMenu
                try
                {
                    CarHornMenu.Click();
                    HandleAd();
                }
                catch (Exception ex)
                {
                    HandleException("Car Horn Menu", ex);
                }

                // Car Horn 1
                try
                {
                    CarHorn1.Click();
                    HandleAd();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    HandleException("Car Horn 1", ex);
                }

                // Car Horn 2
                try
                {
                    CarHorn2.Click();
                    HandleAd();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    HandleException("Car Horn 2", ex);
                }

                // Car Horn 3
                try
                {
                    CarHorn3.Click();
                    HandleAd();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    HandleException("Car Horn 3", ex);
                }
            }
            catch (Exception ex)
            {
                HandleException("Car Horn Sound Test", ex);
            }
        }

        private void HandleException(string action, Exception ex)
        {
            Console.WriteLine($"Exception occurred during {action}: {ex.Message}");
            Test.Log(Status.Fail, $"Test failed during {action} due to: {ex.Message}");
        }

        private void HandleAd()
        {
            if (adHelper.IsAdPresent())
            {
                if (adHelper.IsCrossButtonPresent())
                {
                    adHelper.HandleAdCrossButton();
                }
                else if (adHelper.IsCloseButtonPresent())
                {
                    adHelper.HandleAdCloseButton();
                }
                else
                {
                    Console.WriteLine("No Ad found");
                }
            }
        }
        IWebElement CarHornMenu => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Car Horn\"]");
        IWebElement CarHorn1 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Car Horn 1\"]");
        IWebElement CarHorn2 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Car Horn 2\"]");
        IWebElement CarHorn3 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Car Horn 3\"]");
        IWebElement CarHorn4 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Car Horn 4\"]");
        IWebElement CarHorn5 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Car Horn 5\"]");
        IWebElement CarHornTestXpath => driver.FindElementByXPath("//android.widget.TextView[@text=\"Car Horn 5\"]\r\n");

        IWebElement BackButton1 => driver.FindElementByAccessibilityId("Navigate up");
        IWebElement VolumeUp => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus");
        IWebElement VolumeDown => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus");
        IWebElement Loop => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck");
        IWebElement PlayButton => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]");
        IWebElement AddtoBookmark => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite");

    }
}
