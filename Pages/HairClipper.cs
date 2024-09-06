﻿using AventStack.ExtentReports;
using HolyQuran.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class HairClipper
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        private AdHelperC adHelper;

        //Constructor
        public HairClipper(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            this.adHelper = new AdHelperC(driver); // Initialize AdHelper with the correct driver type

        }
        public void HairClipperSoundTest()
        {
            ExtentTest test = Extent.CreateTest("Hair Clipper Sound Test");
            try
            {
                // HairClipperMenu
                try
                {
                    HairClipperMenu.Click();
                    HandleAd();
                }
                catch (Exception ex)
                {
                    HandleException("Hair Clipper Menu", ex);
                }

                // Hair Clipper 1
                try
                {
                    HairClipper1.Click();
                    HandleAd();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    HandleException("Hair Clipper 1", ex);
                }

                // Hair Clipper 2
                try
                {
                    HairClipper2.Click();
                    HandleAd();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    HandleException("Hair Clipper 2", ex);
                }

                // Hair Clipper 3
                try
                {
                    HairClipper3.Click();
                    HandleAd();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    HandleException("Hair Clipper 3", ex);
                }
            }
            catch (Exception ex)
            {
                HandleException("Hair Clipper Sound Test", ex);
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
        IWebElement HairClipperMenu => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Clipper\"]");
        IWebElement HairClipper1 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Clipper 1\"]");
        IWebElement HairClipper2 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Clipper 2\"]");
        IWebElement HairClipper3 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Clipper 3\"]");
        IWebElement HairClipper4 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Clipper 4\"]");
        IWebElement HairClipper5 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Clipper 5\"]");
        IWebElement HairClipper6 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Clipper 6\"]");
        IWebElement HairClipper7 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Clipper 7\"]");
        IWebElement HairClipper8 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Clipper 8\"]");
        IWebElement HairClipper9 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Clipper 9\"]");


        IWebElement BackButton1 => driver.FindElementByAccessibilityId("Navigate up");
        IWebElement VolumeUp => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus");
        IWebElement VolumeDown => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus");
        IWebElement Loop => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck");
        IWebElement PlayButton => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]");
        IWebElement AddtoBookmark => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite");

    }
}
