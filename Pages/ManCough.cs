using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;

namespace Prank_Sound_App.Pages
{
    class ManCough
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        TouchAction touchAction;
        Reusablemethods Reusablemethods;

        //Constructor
        public ManCough(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            touchAction = new TouchAction(driver);
            Reusablemethods = new Reusablemethods(driver, test);

        }

        public void MannCoughSoundTes1t()
        {
            Reusablemethods.ScrollToElementByText("Men Cough");

            ExtentTest test = Extent.CreateTest("NearBy Places Report 1");

            try
            {
                // Men Cough Menu
                ManCoughMenu.Click();

                try
                {
                    Reusablemethods.InterAdHandle();

                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Men Cough Menu", ex);
                }

                // Men Cough 1
                try
                {
                    ManCough1.Click();

                    Reusablemethods.InterAdHandle();


                    PlayButton.Click();
                    Thread.Sleep(3000);
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Men Cough 1", ex);
                }

                // Men Cough 2
                try
                {
                    ManCough2.Click();

                    Reusablemethods.InterAdHandle();

                    PlayButton.Click();
                    Thread.Sleep(3000);
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Men Cough 2", ex);
                }

                // Men Cough 3
                try
                {
                    ManCough3.Click();

                    Reusablemethods.InterAdHandle();


                    PlayButton.Click();
                    Thread.Sleep(3000);
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Men Cough 3", ex);
                }

                // Men Cough 4
                try
                {
                    ManCough4.Click();

                    Reusablemethods.InterAdHandle();


                    PlayButton.Click();
                    Thread.Sleep(3000);
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Men Cough 4", ex);
                }

            }
            catch (Exception ex)
            {
                Reusablemethods.HandleException("Men Cough Menu", ex);
            }
        }
        public void MannCoughSoundTest()
        {
            // Scroll to Men Cough menu
            Reusablemethods.ScrollToElementByText("Men Cough");

            // Click on the Men Cough menu and handle ads
            Reusablemethods.ClickwithAd(ManCoughMenu, "ManCoughMenu");

            // Men Cough 1
            Reusablemethods.ClickwithAd(ManCough1, "ManCough1");
            Reusablemethods.SoundPlayScreen("Men Cough 1");

            // Men Cough 2
            Reusablemethods.ClickwithAd(ManCough2, "ManCough2");
            Reusablemethods.SoundPlayScreen("Men Cough 2");

            // Men Cough 3
            Reusablemethods.ClickwithAd(ManCough3, "ManCough3");
            Reusablemethods.SoundPlayScreen("Men Cough 3");

            // Men Cough 4
            Reusablemethods.ClickwithAd(ManCough4, "ManCough4");
            Reusablemethods.SoundPlayScreen("Men Cough 4 and back to main screen");

            // Navigate back to the main screen
            Reusablemethods.NavigateBack("Main screen Back");
        }

        // Men Cough Menu and Sounds
        public IWebElement? ManCoughMenu => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Men Cough\"]"), "ManCoughMenu");
        public IWebElement? ManCough1 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Man Cough 1\"]"), "ManCough1");
        public IWebElement? ManCough2 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Man Cough 2\"]"), "ManCough2");
        public IWebElement? ManCough3 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Man Cough 3\"]"), "ManCough3");
        public IWebElement? ManCough4 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Man Cough 4\"]"), "ManCough4");
        public IWebElement? ManCough5 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Man Cough 5\"]"), "ManCough5");

        // Common Buttons and Controls
        public IWebElement? AddtoBookmark => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite"), "AddtoBookmark");
        public IWebElement? VolumeUp => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus"), "VolumeUp");
        public IWebElement? VolumeDown => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus"), "VolumeDown");
        public IWebElement? Loop => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck"), "Loop");
        public IWebElement? PlayButton => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]"), "PlayButton");

    }
}
