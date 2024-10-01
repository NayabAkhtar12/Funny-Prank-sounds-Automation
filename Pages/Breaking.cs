using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class Breaking
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        Reusablemethods Reusablemethods;

        //Constructor
        public Breaking(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            Reusablemethods = new Reusablemethods(driver, test);

        }

        public void BreakingSoundTest1()
        {
            Reusablemethods.ScrollToElementByText("Breaking");

            ExtentTest test = Extent.CreateTest("Breaking Sound Test");
            try
            {
                // BreakingSoundMenu
                try
                {
                    BreakingSoundMenu.Click();
                    Reusablemethods.InterAdHandle();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Breaking Sound Menu", ex);
                }

                // Breaking Sound 1
                try
                {
                    BreakingSound1.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Breaking Sound 1", ex);
                }

                // Breaking Sound 2
                try
                {
                    BreakingSound2.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Breaking Sound 2", ex);
                }

                // Breaking Sound 3
                try
                {
                    BreakingSound3.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Breaking Sound 3", ex);
                }
            }
            catch (Exception ex)
            {
                Reusablemethods.HandleException("Breaking Sound Test", ex);
            }
        }
        public void BreakingSoundTest()
        {
            // Scroll to Breaking Sounds menu
            Reusablemethods.ScrollToElementByText("Breaking");

            // Click on the Breaking Sound menu and handle ads
            Reusablemethods.ClickwithAd(BreakingSoundMenu, "BreakingSoundMenu");

            // Breaking Sound 1
            Reusablemethods.ClickwithAd(BreakingSound1, "BreakingSound1");
            Reusablemethods.SoundPlayScreen("Breaking Sound 1");

            // Breaking Sound 2
            Reusablemethods.ClickwithAd(BreakingSound2, "BreakingSound2");
            Reusablemethods.SoundPlayScreen("Breaking Sound 2");

            // Breaking Sound 3
            Reusablemethods.ClickwithAd(BreakingSound3, "BreakingSound3");
            Reusablemethods.SoundPlayScreen("Breaking Sound 3 and back to main screen");

            // Navigate back to the main screen
            Reusablemethods.NavigateBack("Main screen Back");
        }

        IWebElement? BreakingSoundMenu => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Breaking\"]"), "BreakingSoundMenu");

        IWebElement? BreakingSound1 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Breaking 1\"]"), "BreakingSound1");

        IWebElement? BreakingSound2 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Breaking 2\"]"), "BreakingSound2");

        IWebElement? BreakingSound3 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Breaking 3\"]"), "BreakingSound3");

        IWebElement? BreakingSound4 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Breaking 4\"]"), "BreakingSound4");

        IWebElement? BreakingSound5 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Breaking 5\"]"), "BreakingSound5");

        IWebElement? BreakingSound6 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Breaking 6\"]"), "BreakingSound6");

        IWebElement? BackButton1 => Reusablemethods.FindElement(By.Id("Navigate up"), "BackButton1");

        IWebElement? VolumeUp => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus"), "VolumeUp");

        IWebElement? VolumeDown => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus"), "VolumeDown");

        IWebElement? Loop => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck"), "Loop");

        IWebElement? PlayButton => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]"), "PlayButton");

        IWebElement? AddtoBookmark => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite"), "AddtoBookmark");


    }
}
