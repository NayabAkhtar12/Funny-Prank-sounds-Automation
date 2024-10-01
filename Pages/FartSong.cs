using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class FartSong
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        Reusablemethods Reusablemethods;

        //Constructor
        public FartSong(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            Reusablemethods = new Reusablemethods(driver, test);

        }

        public void FartSongSoundTest1()
        {
            Reusablemethods.ScrollToElementByText("Fart Song");
            ExtentTest test = Extent.CreateTest("Fart Song Sound Test");
            try
            {
                // Fart Song Menu
                try
                {
                    FartSongMenu.Click();
                    Reusablemethods.InterAdHandle();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Fart Song Menu", ex);
                }

                // Fart Song 1
                try
                {
                    FartSong1.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Fart Song 1", ex);
                }

                // Fart Song 2
                try
                {
                    FartSong2.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Fart Song 2", ex);
                }

                // Fart Song 3
                try
                {
                    FartSong3.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Fart Song 3", ex);
                }
            }
            catch (Exception ex)
            {
                Reusablemethods.HandleException("Fart Song Sound Test", ex);
            }
        }
        public void FartSongSoundTest()
        {
            // Scroll to Fart Song menu
            Reusablemethods.ScrollToElementByText("Fart Song");

            // Click on the Fart Song menu and handle ads
            Reusablemethods.ClickwithAd(FartSongMenu, "FartSongMenu");

            // Fart Song 1
            Reusablemethods.ClickwithAd(FartSong1, "FartSong1");
            Reusablemethods.SoundPlayScreen("Fart Song 1");

            // Fart Song 2
            Reusablemethods.ClickwithAd(FartSong2, "FartSong2");
            Reusablemethods.SoundPlayScreen("Fart Song 2");

            // Fart Song 3
            Reusablemethods.ClickwithAd(FartSong3, "FartSong3");
            Reusablemethods.SoundPlayScreen("Fart Song 3 and back to main screen");

            // Navigate back to the main screen
            Reusablemethods.NavigateBack("Main screen Back");
        }

        IWebElement? FartSongMenu => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Song\"]"), "FartSongMenu");

        IWebElement? FartSong1 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Song 1\"]"), "FartSong1");

        IWebElement? FartSong2 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Song 2\"]"), "FartSong2");

        IWebElement? FartSong3 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Song 3\"]"), "FartSong3");

        IWebElement? FartSong4 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Song 4\"]"), "FartSong4");

        IWebElement? FartSong5 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Song 5\"]"), "FartSong5");

        IWebElement? FartSong6 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Song 6\"]"), "FartSong6");

        IWebElement? FartSong7 => Reusablemethods.FindElement(By.XPath("(//android.view.ViewGroup[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/maiCv\"])[7]"), "FartSong7");

        IWebElement? FartSong8 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Song 8\"]"), "FartSong8");

        IWebElement? FartSong9 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Song 9\"]"), "FartSong9");

        IWebElement? FartSong10 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Song 10\"]"), "FartSong10");

        IWebElement? FartSong11 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Song 11\"]"), "FartSong11");

        IWebElement? FartSong12 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Song 12\"]"), "FartSong12");

        IWebElement? VolumeUp => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus"), "VolumeUp");

        IWebElement? VolumeDown => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus"), "VolumeDown");

        IWebElement? Loop => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck"), "Loop");

        IWebElement? PlayButton => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]"), "PlayButton");

        IWebElement? AddtoBookmark => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite"), "AddtoBookmark");


    }
}
