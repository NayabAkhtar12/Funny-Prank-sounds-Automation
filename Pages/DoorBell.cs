using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class DoorBell
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        Reusablemethods Reusablemethods;

        //Constructor
        public DoorBell(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            Reusablemethods = new Reusablemethods(driver, test);

        }

        public void DoorBellSoundTest1()
        {
            Reusablemethods.ScrollToElementByText("Door Bell");

            ExtentTest test = Extent.CreateTest("Door Bell Sound Test");
            try
            {
                // DoorBellMenu
                try
                {
                    DoorBellMenu.Click();
                    Reusablemethods.InterAdHandle();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Door Bell Menu", ex);
                }

                // Door Bell 1
                try
                {
                    DoorBell1.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Door Bell 1", ex);
                }

                // Door Bell 2
                try
                {
                    DoorBell2.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Door Bell 2", ex);
                }

                // Door Bell 3
                try
                {
                    DoorBell3.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Door Bell 3", ex);
                }
            }
            catch (Exception ex)
            {
                Reusablemethods.HandleException("Door Bell Sound Test", ex);
            }
        }

        public void DoorBellSoundTest()
        {
            // Scroll to Door Bell menu
            Reusablemethods.ScrollToElementByText("Door Bell");

            // Click on the Door Bell menu and handle ads
            Reusablemethods.ClickwithAd(DoorBellMenu, "DoorBellMenu");

            // Door Bell 1
            Reusablemethods.ClickwithAd(DoorBell1, "DoorBell1");
            Reusablemethods.SoundPlayScreen("Door Bell 1");

            // Door Bell 2
            Reusablemethods.ClickwithAd(DoorBell2, "DoorBell2");
            Reusablemethods.SoundPlayScreen("Door Bell 2");

            // Door Bell 3
            Reusablemethods.ClickwithAd(DoorBell3, "DoorBell3");
            Reusablemethods.SoundPlayScreen("Door Bell 3 and back to main screen");

            // Navigate back to the main screen
            Reusablemethods.NavigateBack("Main screen Back");
        }


        IWebElement? DoorBellMenu => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Door Bell\"]"), "DoorBellMenu");

        IWebElement? DoorBell1 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Door Bell 1\"]"), "DoorBell1");

        IWebElement? DoorBell2 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Door Bell 2\"]"), "DoorBell2");

        IWebElement? DoorBell3 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Door Bell 3\"]"), "DoorBell3");

        IWebElement? DoorBell4 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Door Bell 4\"]"), "DoorBell4");

        IWebElement? DoorBell5 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Door Bell 5\"]"), "DoorBell5");

        IWebElement? DoorBell6 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Door Bell 6\"]"), "DoorBell6");

        IWebElement? DoorBell7 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Door Bell 7\"]"), "DoorBell7");

        IWebElement? DoorBell8 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Door Bell 8\"]"), "DoorBell8");

        IWebElement? DoorBell9 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Door Bell 9\"]"), "DoorBell9");

        // Note: No XPath was provided for DoorBell10, so it's left empty.
        IWebElement? DoorBell10 => Reusablemethods.FindElement(By.XPath(""), "DoorBell10");

        IWebElement? VolumeUp => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus"), "VolumeUp");

        IWebElement? VolumeDown => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus"), "VolumeDown");

        IWebElement? Loop => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck"), "Loop");

        IWebElement? PlayButton => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]"), "PlayButton");

        IWebElement? AddtoBookmark => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite"), "AddtoBookmark");

    }
}
