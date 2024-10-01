using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class GunSounds
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        Reusablemethods Reusablemethods;

        //Constructor
        public GunSounds(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            Reusablemethods = new Reusablemethods(driver, test);

        }

        public void GunSoundTest1()
        {
            Reusablemethods.ScrollToElementByText("Gun Sound");

            ExtentTest test = Extent.CreateTest("Gun Sound Test");
            try
            {
                // GunSoundMenu
                try
                {
                    GunSoundMenu.Click();
                    Reusablemethods.InterAdHandle();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Gun Sound Menu", ex);
                }

                // Gun Sound 1
                try
                {
                    GunSound1.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Gun Sound 1", ex);
                }

                // Gun Sound 2
                try
                {
                    GunSound2.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Gun Sound 2", ex);
                }

                // Gun Sound 3
                try
                {
                    GunSound3.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Gun Sound 3", ex);
                }
            }
            catch (Exception ex)
            {
                Reusablemethods.HandleException("Gun Sound Test", ex);
            }
        }
        public void GunSoundTest()
        {
            // Scroll to Gun Sound menu
            Reusablemethods.ScrollToElementByText("Gun Sound");

            // Click on the Gun Sound menu and handle ads
            Reusablemethods.ClickwithAd(GunSoundMenu, "GunSoundMenu");

            // Gun Sound 1
            Reusablemethods.ClickwithAd(GunSound1, "GunSound1");
            Reusablemethods.SoundPlayScreen("Gun Sound 1");

            // Gun Sound 2
            Reusablemethods.ClickwithAd(GunSound2, "GunSound2");
            Reusablemethods.SoundPlayScreen("Gun Sound 2");

            // Gun Sound 3
            Reusablemethods.ClickwithAd(GunSound3, "GunSound3");
            Reusablemethods.SoundPlayScreen("Gun Sound 3 and back to main screen");

            // Navigate back to the main screen
            Reusablemethods.NavigateBack("Main screen Back");
        }

        IWebElement? GunSoundMenu => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Gun Sound\"]"), "GunSoundMenu");

        IWebElement? GunSound1 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Gun Sound 1\"]"), "GunSound1");

        IWebElement? GunSound2 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Gun Sound 2\"]"), "GunSound2");

        IWebElement? GunSound3 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Gun Sound 3\"]"), "GunSound3");

        IWebElement? GunSound4 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Gun 4\"]"), "GunSound4");

        IWebElement? GunSound5 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Gun 5\"]"), "GunSound5");

        IWebElement? GunSound6 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Gun 6\"]"), "GunSound6");

        IWebElement? GunSound7 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Gun 7\"]"), "GunSound7");

        IWebElement? GunSound8 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Gun 8\"]"), "GunSound8");

        IWebElement? GunSound9 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Gun 9\"]"), "GunSound9");

        IWebElement? GunSound10 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Gun 10\"]"), "GunSound10");

        IWebElement? GunSound11 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Gun 11\"]"), "GunSound11");

        IWebElement? VolumeUp => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus"), "VolumeUp");

        IWebElement? VolumeDown => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus"), "VolumeDown");

        IWebElement? Loop => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck"), "Loop");

        IWebElement? PlayButton => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]"), "PlayButton");

        IWebElement? AddtoBookmark => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite"), "AddtoBookmark");


    }
}
