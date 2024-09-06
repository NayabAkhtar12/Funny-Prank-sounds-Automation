using AventStack.ExtentReports;
using HolyQuran.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class FunnyPolice
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        private AdHelperC adHelper;
        //Constructor
        public FunnyPolice(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            this.adHelper = new AdHelperC(driver); // Initialize AdHelper with the correct driver type

        }

        public void FunnyPoliceTest()
        {
            ExtentTest test = Extent.CreateTest("Funny Police Sound Test");
            try
            {
                // FunnyPoliceMenu
                try
                {
                    FunnyPoliceMenu.Click();
                    HandleAd();
                }
                catch (Exception ex)
                {
                    HandleException("Funny Police Menu", ex);
                }

                // Funny Police 1
                try
                {
                    FunnyPolice1.Click();
                    HandleAd();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    HandleException("Funny Police 1", ex);
                }

                // Funny Police 2
                try
                {
                    FunnyPolice2.Click();
                    HandleAd();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    HandleException("Funny Police 2", ex);
                }

                // Funny Police 3
                try
                {
                    FunnyPolice3.Click();
                    HandleAd();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    HandleException("Funny Police 3", ex);
                }
            }
            catch (Exception ex)
            {
                HandleException("Funny Police Sound Test", ex);
            }
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

        private void HandleException(string action, Exception ex)
        {
            Console.WriteLine($"Exception occurred during {action}: {ex.Message}");
            Test.Log(Status.Fail, $"Test failed during {action} due to: {ex.Message}");
        }

        IWebElement FunnyPoliceMenu => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Funny Police\"]");
        IWebElement FunnyPolice1 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Funny Police 1\"]");
        IWebElement FunnyPolice2 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Funny Police 2\"]");
        IWebElement FunnyPolice3 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Funny Police 3\"]");
        IWebElement FunnyPolice4 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Funny Police 4\"]");
        IWebElement FunnyPolice5 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Funny Police 5\"]");
        IWebElement FunnyPolice6 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Funny Police 6\"]");

        IWebElement BackButton1 => driver.FindElementByAccessibilityId("Navigate up");
        IWebElement VolumeUp => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus");
        IWebElement VolumeDown => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus");
        IWebElement Loop => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck");
        IWebElement PlayButton => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]");
        IWebElement AddtoBookmark => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite");

    }
}
