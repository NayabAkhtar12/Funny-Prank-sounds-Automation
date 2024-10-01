using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class CarHorn
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        Reusablemethods Reusablemethods;

        //Constructor
        public CarHorn(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            Reusablemethods = new Reusablemethods(driver, test);

        }

        public void CarHornSoundTest1()
        {
            Reusablemethods.ScrollToElementByText("Car Horn");

            ExtentTest test = Extent.CreateTest("Car Horn Sound Test");
            try
            {
                // CarHornMenu
                try
                {
                    CarHornMenu.Click();
                    Reusablemethods.InterAdHandle();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Car Horn Menu", ex);
                }

                // Car Horn 1
                try
                {
                    CarHorn1.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Car Horn 1", ex);
                }

                // Car Horn 2
                try
                {
                    CarHorn2.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Car Horn 2", ex);
                }

                // Car Horn 3
                try
                {
                    CarHorn3.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Car Horn 3", ex);
                }
            }
            catch (Exception ex)
            {
                Reusablemethods.HandleException("Car Horn Sound Test", ex);
            }
        }
        public void CarHornSoundTest()
        {
            // Scroll to Car Horn Sounds menu
            Reusablemethods.ScrollToElementByText("Car Horn");

            // Click on the Car Horn menu and handle ads
            Reusablemethods.ClickwithAd(CarHornMenu, "CarHornMenu");

            // Car Horn 1
            Reusablemethods.ClickwithAd(CarHorn1, "CarHorn1");
            Reusablemethods.SoundPlayScreen("Car Horn 1");

            // Car Horn 2
            Reusablemethods.ClickwithAd(CarHorn2, "CarHorn2");
            Reusablemethods.SoundPlayScreen("Car Horn 2");

            // Car Horn 3
            Reusablemethods.ClickwithAd(CarHorn3, "CarHorn3");
            Reusablemethods.SoundPlayScreen("Car Horn 3 and back to main screen");

            // Navigate back to the main screen
            Reusablemethods.NavigateBack("Main screen Back");
        }


        IWebElement? CarHornMenu => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Car Horn\"]"), "CarHornMenu");

        IWebElement? CarHorn1 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Car Horn 1\"]"), "CarHorn1");

        IWebElement? CarHorn2 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Car Horn 2\"]"), "CarHorn2");

        IWebElement? CarHorn3 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Car Horn 3\"]"), "CarHorn3");

        IWebElement? CarHorn4 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Car Horn 4\"]"), "CarHorn4");

        IWebElement? CarHorn5 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Car Horn 5\"]"), "CarHorn5");

        IWebElement? CarHornTestXpath => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@text=\"Car Horn 5\"]"), "CarHornTestXpath");

        IWebElement? BackButton1 => Reusablemethods.FindElement(By.Id("Navigate up"), "BackButton1");

        IWebElement? VolumeUp => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus"), "VolumeUp");

        IWebElement? VolumeDown => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.fartsound.hornsound.haircut.soundprank:id/ivvolminus"), "VolumeDown");

        IWebElement? Loop => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck"), "Loop");

        IWebElement? PlayButton => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]"), "PlayButton");

        IWebElement? AddtoBookmark => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite"), "AddtoBookmark");

    }
}
