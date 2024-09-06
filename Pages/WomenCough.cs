using AventStack.ExtentReports;
using HolyQuran.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class WomenCough
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        private AdHelperC adHelper;

        //Constructor
        public WomenCough(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            this.adHelper = new AdHelperC(driver); // Initialize AdHelper with the correct driver type
        }

        public void WomenCoughSoundTest()
        {
            ExtentTest test = Extent.CreateTest("NearBy Places Report 1");
            try
            {
                // Women Cough Menu
                WoMenCoughMenu.Click();

                try
                {
                    if (adHelper.IsAdPresent() && adHelper.IsCrossButtonPresent())
                    {
                        adHelper.HandleAdCrossButton();
                    }
                    else if (adHelper.IsAdPresent() && adHelper.IsCloseButtonPresent())
                    {
                        adHelper.HandleAdCloseButton();
                    }
                    else
                    {
                        Console.WriteLine("No Ad found");
                    }
                }
                catch (Exception ex)
                {
                    HandleException("Women Cough Menu", ex);
                }

                //Code to close Collapsible Banner by clicking on Collapse Icon
                adHelper.HandleCollapsibleBanner();


                // Women Cough 1
                try
                {
                    WoMenCough1.Click();

                    if (adHelper.IsAdPresent() && adHelper.IsCrossButtonPresent())
                    {
                        adHelper.HandleAdCrossButton();
                    }
                    else if (adHelper.IsAdPresent() && adHelper.IsCloseButtonPresent())
                    {
                        adHelper.HandleAdCloseButton();
                    }
                    else
                    {
                        Console.WriteLine("No Ad found");
                    }

                    PlayButton.Click();
                    Thread.Sleep(3000);
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    HandleException("Women Cough 1", ex);
                }

                // Women Cough 2
                try
                {
                    WoMenCough2.Click();

                    if (adHelper.IsAdPresent() && adHelper.IsCrossButtonPresent())
                    {
                        adHelper.HandleAdCrossButton();
                    }
                    else if (adHelper.IsAdPresent() && adHelper.IsCloseButtonPresent())
                    {
                        adHelper.HandleAdCloseButton();
                    }
                    else
                    {
                        Console.WriteLine("No Ad found");
                    }

                    PlayButton.Click();
                    Thread.Sleep(3000);
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    HandleException("Women Cough 2", ex);
                }

                // Women Cough 3
                try
                {
                    WoMenCough3.Click();

                    if (adHelper.IsAdPresent() && adHelper.IsCrossButtonPresent())
                    {
                        adHelper.HandleAdCrossButton();
                    }
                    else if (adHelper.IsAdPresent() && adHelper.IsCloseButtonPresent())
                    {
                        adHelper.HandleAdCloseButton();
                    }
                    else
                    {
                        Console.WriteLine("No Ad found");
                    }

                    PlayButton.Click();
                    Thread.Sleep(3000);
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    HandleException("Women Cough 3", ex);
                }
            }
            catch (Exception ex)
            {
                HandleException("Women Cough Menu", ex);
            }

        }
        private void HandleException(string action, Exception ex)
        {
            Console.WriteLine($"Exception occurred during {action}: {ex.Message}");
            Test.Log(Status.Fail, $"Test failed during {action} due to: {ex.Message}");
        }
        IWebElement WoMenCoughMenu => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Women Cough\"]");
        IWebElement WoMenCough1 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Woman Cough 1\"]");
        IWebElement WoMenCough2 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Woman Cough 2\"]");
        IWebElement WoMenCough3 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Woman Cough 3\"]");
        IWebElement AddtoBookmark => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite");

        IWebElement BackButton1 => driver.FindElementByAccessibilityId("Navigate up");
        IWebElement VolumeUp => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus");
        IWebElement VolumeDown => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus");
        IWebElement Loop => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck");
        IWebElement PlayButton => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]");

    }
}
