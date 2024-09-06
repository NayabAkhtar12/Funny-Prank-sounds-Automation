using AventStack.ExtentReports;
using HolyQuran.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;

namespace Prank_Sound_App.Pages
{
    class ManCough
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        private AdHelperC adHelper;
        TouchAction touchAction;
        //Constructor
        public ManCough(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            this.adHelper = new AdHelperC(driver); // Initialize AdHelper with the correct driver type
            touchAction = new TouchAction(driver);
        }
        public void CBanner()
        {
            //**************Code to close c banner ***********
            try
            {

                var x = 667;
                var y = 850;

                touchAction.Tap(x, y).Perform();

                // new TouchAction(driver)
                //.Tap(PointOption.Point(x, y))
                //.Perform();
                Console.WriteLine("Tap performed successfully at coordinates: (" + x + ", " + y + ")");
            }
            catch (Exception ex)
            {
                HandleException("C Banner nt closeable", ex);
            }
        }
        public void MannCoughSoundTest()
        {
            ExtentTest test = Extent.CreateTest("NearBy Places Report 1");

            try
            {
                // Men Cough Menu
                ManCoughMenu.Click();

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
                    HandleException("Men Cough Menu", ex);
                }

                // Men Cough 1
                try
                {
                    ManCough1.Click();

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
                    HandleException("Men Cough 1", ex);
                }

                // Men Cough 2
                try
                {
                    ManCough2.Click();

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
                    HandleException("Men Cough 2", ex);
                }

                // Men Cough 3
                try
                {
                    ManCough3.Click();

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
                    HandleException("Men Cough 3", ex);
                }

                // Men Cough 4
                try
                {
                    ManCough4.Click();

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
                    HandleException("Men Cough 4", ex);
                }

            }
            catch (Exception ex)
            {
                HandleException("Men Cough Menu", ex);
            }
        }
        private void HandleException(string action, Exception ex)
        {
            Console.WriteLine($"Exception occurred during {action}: {ex.Message}");
            Test.Log(Status.Fail, $"Test failed during {action} due to: {ex.Message}");
        }
        IWebElement ManCoughMenu => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Men Cough\"]");
        IWebElement ManCough1 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Man Cough 1\"]");
        IWebElement ManCough2 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Man Cough 2\"]");
        IWebElement ManCough3 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Man Cough 3\"]");
        IWebElement ManCough4 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Man Cough 4\"]");
        IWebElement ManCough5 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Man Cough 5\"]");
        IWebElement AddtoBookmark => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite");

        IWebElement BackButton1 => driver.FindElementByAccessibilityId("Navigate up");
        IWebElement VolumeUp => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus");
        IWebElement VolumeDown => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus");
        IWebElement Loop => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck");
        IWebElement PlayButton => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]");

    }
}
