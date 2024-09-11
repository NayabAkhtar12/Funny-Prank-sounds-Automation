using AventStack.ExtentReports;
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
        TouchAction touchAction;
        Reusablemethods Reusablemethods;

        //Constructor
        public ManCough(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            touchAction = new TouchAction(driver);
            Reusablemethods = new Reusablemethods(driver, test);

        }

        public void MannCoughSoundTest()
        {
            Reusablemethods.ScrollToElementByText("Men Cough");

            ExtentTest test = Extent.CreateTest("NearBy Places Report 1");

            try
            {
                // Men Cough Menu
                ManCoughMenu.Click();

                try
                {
                    Reusablemethods.InterAdHandle();

                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Men Cough Menu", ex);
                }

                // Men Cough 1
                try
                {
                    ManCough1.Click();

                    Reusablemethods.InterAdHandle();


                    PlayButton.Click();
                    Thread.Sleep(3000);
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Men Cough 1", ex);
                }

                // Men Cough 2
                try
                {
                    ManCough2.Click();

                    Reusablemethods.InterAdHandle();

                    PlayButton.Click();
                    Thread.Sleep(3000);
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Men Cough 2", ex);
                }

                // Men Cough 3
                try
                {
                    ManCough3.Click();

                    Reusablemethods.InterAdHandle();


                    PlayButton.Click();
                    Thread.Sleep(3000);
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Men Cough 3", ex);
                }

                // Men Cough 4
                try
                {
                    ManCough4.Click();

                    Reusablemethods.InterAdHandle();


                    PlayButton.Click();
                    Thread.Sleep(3000);
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Men Cough 4", ex);
                }

            }
            catch (Exception ex)
            {
                Reusablemethods.HandleException("Men Cough Menu", ex);
            }
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
