using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class FartSound
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        Reusablemethods Reusablemethods;

        //Constructor
        public FartSound(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            Reusablemethods = new Reusablemethods(driver, test);

        }

        public void FartSoundTest()
        {
            Reusablemethods.Prank2ndSession();
            Reusablemethods.ScrollToElementByText("Fart Sound");

            ExtentTest test = Extent.CreateTest("Fart Sound Test");
            try
            {
                // FartSoundMenu
                try
                {
                    FartSoundMenu.Click();
                    Reusablemethods.InterAdHandle();

                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Fart Sound Menu", ex);
                }

                // Fart Sound 1
                try
                {
                    FartSound1.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Fart Sound 1", ex);
                }

                // Fart Sound 2
                try
                {
                    FartSound2.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    // WaitForElement(AddtoBookmark); // Use explicit wait instead of Thread.Sleep
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Fart Sound 2", ex);
                }

                // Fart Sound 3
                try
                {
                    FartSound3.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    Reusablemethods.WaitForElement(AddtoBookmark); // Use explicit wait instead of Thread.Sleep
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Fart Sound 3", ex);
                }

                // Fart Sound 4
                try
                {
                    FartSound4.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    Reusablemethods.WaitForElement(AddtoBookmark); // Use explicit wait instead of Thread.Sleep
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Fart Sound 4", ex);
                }
            }
            catch (Exception ex)
            {
                Reusablemethods.HandleException("Fart Sound Test", ex);
            }
        }




        IWebElement FartSoundMenu => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound\"]");
        IWebElement FartSound1 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 1\"]");
        IWebElement FartSound2 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 2\"]");
        IWebElement FartSound3 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 3\"]");
        IWebElement FartSound4 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 4\"]");
        IWebElement FartSound5 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 5\"]");
        IWebElement FartSound6 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 6\"]");
        IWebElement FartSound7 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 7\"]");
        IWebElement FartSound8 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 8\"]");
        IWebElement FartSound9 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 9\"]");
        IWebElement FartSound10 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 10\"]");
        IWebElement FartSound11 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 11\"]");
        IWebElement FartSound12 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 12\"]");
        IWebElement FartSound13 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 13\"]");
        IWebElement FartSound14 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 14\"]");
        IWebElement FartSound15 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 15\"]");
        IWebElement FartSound16 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 16\"]");
        IWebElement FartSound17 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 17\"]");

        IWebElement AddtoBookmark => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite");


        IWebElement BackButton1 => driver.FindElementByAccessibilityId("Navigate up");
        IWebElement VolumeUp => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus");
        IWebElement VolumeDown => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus");
        IWebElement Loop => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck");
        IWebElement PlayButton => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]");

    }
}
