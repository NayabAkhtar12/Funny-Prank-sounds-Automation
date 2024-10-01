using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class HairDryer
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        Reusablemethods Reusablemethods;

        //Constructor
        public HairDryer(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            Reusablemethods = new Reusablemethods(driver, test);

        }

        public void HairDryerSoundTest1()
        {
            Reusablemethods.ScrollToElementByText("Hair Dryer");
            ExtentTest test = Extent.CreateTest("Hair Dryer Sound Test");
            try
            {
                // Hair Dryer Menu
                try
                {
                    HairDryerMenu.Click();
                    Reusablemethods.InterAdHandle();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Hair Dryer Menu", ex);
                }

                // Hair Dryer 1
                try
                {
                    HairDryer1.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Hair Dryer 1", ex);
                }

                // Hair Dryer 2
                try
                {
                    HairDryer2.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Hair Dryer 2", ex);
                }

                // Hair Dryer 3
                try
                {
                    HairDryer3.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Hair Dryer 3", ex);
                }
            }
            catch (Exception ex)
            {
                Reusablemethods.HandleException("Hair Dryer Sound Test", ex);
            }
        }
        public void HairDryerSoundTest()
        {
            // Scroll to Hair Dryer menu
            Reusablemethods.ScrollToElementByText("Hair Dryer");

            // Click on the Hair Dryer menu and handle ads
            Reusablemethods.ClickwithAd(HairDryerMenu, "HairDryerMenu");

            // Hair Dryer 1
            Reusablemethods.ClickwithAd(HairDryer1, "HairDryer1");
            Reusablemethods.SoundPlayScreen("Hair Dryer 1");

            // Hair Dryer 2
            Reusablemethods.ClickwithAd(HairDryer2, "HairDryer2");
            Reusablemethods.SoundPlayScreen("Hair Dryer 2");

            // Hair Dryer 3
            Reusablemethods.ClickwithAd(HairDryer3, "HairDryer3");
            Reusablemethods.SoundPlayScreen("Hair Dryer 3 and back to main screen");

            // Navigate back to the main screen
            Reusablemethods.NavigateBack("Main screen Back");
        }


        IWebElement? HairDryerMenu => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Dryer\"]"), "HairDryerMenu");

        IWebElement? HairDryer1 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Dryer 1\"]"), "HairDryer1");

        IWebElement? HairDryer2 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Dryer 2\"]"), "HairDryer2");

        IWebElement? HairDryer3 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Dryer 3\"]"), "HairDryer3");

        IWebElement? HairDryer4 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Dryer 4\"]"), "HairDryer4");

        IWebElement? HairDryer5 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Dryer 5\"]"), "HairDryer5");

        IWebElement? HairDryer6 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Dryer 6\"]"), "HairDryer6");

        IWebElement? HairDryer7 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Dryer 7\"]"), "HairDryer7");

        IWebElement? HairDryer8 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Dryer 8\"]"), "HairDryer8");


        IWebElement? VolumeUp => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus"), "VolumeUp");

        IWebElement? VolumeDown => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus"), "VolumeDown");

        IWebElement? Loop => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck"), "Loop");

        IWebElement? PlayButton => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]"), "PlayButton");

        IWebElement? AddtoBookmark => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite"), "AddtoBookmark");


    }
}
