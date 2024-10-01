using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class FunnyPolice
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        Reusablemethods Reusablemethods;

        //Constructor
        public FunnyPolice(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            Reusablemethods = new Reusablemethods(driver, test);

        }

        public void FunnyPoliceTest1()
        {
            Reusablemethods.ScrollToElementByText("Funny Police");

            ExtentTest test = Extent.CreateTest("Funny Police Sound Test");
            try
            {
                // FunnyPoliceMenu
                try
                {
                    FunnyPoliceMenu.Click();
                    Reusablemethods.InterAdHandle();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Funny Police Menu", ex);
                }

                // Funny Police 1
                try
                {
                    FunnyPolice1.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Funny Police 1", ex);
                }

                // Funny Police 2
                try
                {
                    FunnyPolice2.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Funny Police 2", ex);
                }

                // Funny Police 3
                try
                {
                    FunnyPolice3.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Funny Police 3", ex);
                }
            }
            catch (Exception ex)
            {
                Reusablemethods.HandleException("Funny Police Sound Test", ex);
            }
        }
        public void FunnyPoliceTest()
        {
            // Scroll to Funny Police menu
            Reusablemethods.ScrollToElementByText("Funny Police");

            // Click on the Funny Police menu and handle ads
            Reusablemethods.ClickwithAd(FunnyPoliceMenu, "FunnyPoliceMenu");

            // Funny Police 1
            Reusablemethods.ClickwithAd(FunnyPolice1, "FunnyPolice1");
            Reusablemethods.SoundPlayScreen("Funny Police 1");

            // Funny Police 2
            Reusablemethods.ClickwithAd(FunnyPolice2, "FunnyPolice2");
            Reusablemethods.SoundPlayScreen("Funny Police 2");

            // Funny Police 3
            Reusablemethods.ClickwithAd(FunnyPolice3, "FunnyPolice3");
            Reusablemethods.SoundPlayScreen("Funny Police 3 and back to main screen");

            // Navigate back to the main screen
            Reusablemethods.NavigateBack("Main screen Back");
        }

        public IWebElement? FunnyPoliceMenu => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Funny Police\"]"), "FunnyPoliceMenu");

        public IWebElement? FunnyPolice1 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Funny Police 1\"]"), "FunnyPolice1");

        public IWebElement? FunnyPolice2 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Funny Police 2\"]"), "FunnyPolice2");

        public IWebElement? FunnyPolice3 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Funny Police 3\"]"), "FunnyPolice3");

        public IWebElement? FunnyPolice4 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Funny Police 4\"]"), "FunnyPolice4");

        public IWebElement? FunnyPolice5 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Funny Police 5\"]"), "FunnyPolice5");

        public IWebElement? FunnyPolice6 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Funny Police 6\"]"), "FunnyPolice6");

        public IWebElement? BackButton1 => Reusablemethods.FindElement(By.Id("Navigate up"), "BackButton1");

        public IWebElement? VolumeUp => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus"), "VolumeUp");

        public IWebElement? VolumeDown => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus"), "VolumeDown");

        public IWebElement? Loop => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck"), "Loop");

        public IWebElement? PlayButton => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]"), "PlayButton");

        public IWebElement? AddtoBookmark => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite"), "AddtoBookmark");


    }
}
