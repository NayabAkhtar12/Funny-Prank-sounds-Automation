using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class SleighBell
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        Reusablemethods Reusablemethods;

        //Constructor
        public SleighBell(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            Reusablemethods = new Reusablemethods(driver, test);

        }
        public void SleighBellSoundTest1()
        {
            Reusablemethods.ScrollToElementByText("Sleigh Bell");

            ExtentTest test = Extent.CreateTest("Sleigh Bell Sound Test");
            try
            {
                // Sleigh Bell Menu
                try
                {
                    SleighBellMenu.Click();
                    Reusablemethods.InterAdHandle();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Sleigh Bell Menu", ex);
                }

                // Sleigh Bell 1
                try
                {
                    SleighBell1.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Sleigh Bell 1", ex);
                }

                // Sleigh Bell 2
                try
                {
                    SleighBell2.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Sleigh Bell 2", ex);
                }

                // Sleigh Bell 3
                try
                {
                    SleighBell3.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Sleigh Bell 3", ex);
                }
            }
            catch (Exception ex)
            {
                Reusablemethods.HandleException("Sleigh Bell Sound Test", ex);
            }
        }
        public void SleighBellSoundTest()
        {
            // Scroll to Sleigh Bell menu
            Reusablemethods.ScrollToElementByText("Sleigh Bell");

            // Click on the Sleigh Bell menu and handle ads
            Reusablemethods.ClickwithAd(SleighBellMenu, "SleighBellMenu");

            // Sleigh Bell 1
            Reusablemethods.ClickwithAd(SleighBell1, "SleighBell1");
            Reusablemethods.SoundPlayScreen("Sleigh Bell 1");

            // Sleigh Bell 2
            Reusablemethods.ClickwithAd(SleighBell2, "SleighBell2");
            Reusablemethods.SoundPlayScreen("Sleigh Bell 2");

            // Sleigh Bell 3
            Reusablemethods.ClickwithAd(SleighBell3, "SleighBell3");
            Reusablemethods.SoundPlayScreen("Sleigh Bell 3 and back to main screen");

            // Navigate back to the main screen
            Reusablemethods.NavigateBack("Main screen Back");
        }

        IWebElement? SleighBellMenu => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Sleigh Bell\"]"), "SleighBellMenu");

        IWebElement? SleighBell1 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Sleigh Bell 1\"]"), "SleighBell1");

        IWebElement? SleighBell2 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Sleigh Bell 2\"]"), "SleighBell2");

        IWebElement? SleighBell3 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Sleigh Bell 3\"]"), "SleighBell3");

        IWebElement? SleighBell4 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Sleigh Bell 4\"]"), "SleighBell4");

        IWebElement? SleighBell5 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Sleigh Bell 5\"]"), "SleighBell5");

        IWebElement? SleighBell6 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Sleigh Bell 6\"]"), "SleighBell6");

        IWebElement? SleighBell7 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Sleigh Bell 7\"]"), "SleighBell7");

        IWebElement? VolumeUp => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus"), "VolumeUp");

        IWebElement? VolumeDown => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus"), "VolumeDown");

        IWebElement? Loop => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck"), "Loop");

        IWebElement? PlayButton => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]"), "PlayButton");

        IWebElement? AddtoBookmark => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite"), "AddtoBookmark");


    }
}
