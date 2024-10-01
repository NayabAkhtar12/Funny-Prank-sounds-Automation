using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class SantaClaus
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        Reusablemethods Reusablemethods;

        //Constructor
        public SantaClaus(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            Reusablemethods = new Reusablemethods(driver, test);

        }
        public void SantaClausSoundTest1()
        {
            Reusablemethods.ScrollToElementByText("Santa Claus");

            ExtentTest test = Extent.CreateTest("Santa Claus Sound Test");
            try
            {
                // Santa Claus Menu
                try
                {
                    SantaClausMenu.Click();
                    Reusablemethods.InterAdHandle();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Santa Claus Menu", ex);
                }

                // Santa Claus 1
                try
                {
                    SantaClaus1.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Santa Claus 1", ex);
                }

                // Santa Claus 2
                try
                {
                    SantaClaus2.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Santa Claus 2", ex);
                }

                // Santa Claus 3
                try
                {
                    SantaClaus3.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Santa Claus 3", ex);
                }
            }
            catch (Exception ex)
            {
                Reusablemethods.HandleException("Santa Claus Sound Test", ex);
            }
        }

        public void SantaClausSoundTest()
        {
            // Scroll to Santa Claus menu
            Reusablemethods.ScrollToElementByText("Santa Claus");

            // Click on the Santa Claus menu and handle ads
            Reusablemethods.ClickwithAd(SantaClausMenu, "SantaClausMenu");

            // Santa Claus 1
            Reusablemethods.ClickwithAd(SantaClaus1, "SantaClaus1");
            Reusablemethods.SoundPlayScreen("Santa Claus 1");

            // Santa Claus 2
            Reusablemethods.ClickwithAd(SantaClaus2, "SantaClaus2");
            Reusablemethods.SoundPlayScreen("Santa Claus 2");

            // Santa Claus 3
            Reusablemethods.ClickwithAd(SantaClaus3, "SantaClaus3");
            Reusablemethods.SoundPlayScreen("Santa Claus 3 and back to main screen");

            // Navigate back to the main screen
            Reusablemethods.NavigateBack("Main screen Back");
        }


        IWebElement? SantaClausMenu => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Santa Claus\"]"), "SantaClausMenu");

        IWebElement? SantaClaus1 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Santa Claus 1\"]"), "SantaClaus1");

        IWebElement? SantaClaus2 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Santa Claus 2\"]"), "SantaClaus2");

        IWebElement? SantaClaus3 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Santa Claus 3\"]"), "SantaClaus3");

        IWebElement? SantaClaus4 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Santa Claus 4\"]"), "SantaClaus4");

        IWebElement? SantaClaus5 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Santa Claus 5\"]"), "SantaClaus5");

        IWebElement? SantaClaus6 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Santa Claus 6\"]"), "SantaClaus6");

        IWebElement? VolumeUp => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus"), "VolumeUp");

        IWebElement? VolumeDown => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus"), "VolumeDown");

        IWebElement? Loop => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck"), "Loop");

        IWebElement? PlayButton => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]"), "PlayButton");

        IWebElement? AddtoBookmark => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite"), "AddtoBookmark");


    }
}
