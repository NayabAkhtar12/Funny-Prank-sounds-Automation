using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class HairClipper
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        Reusablemethods Reusablemethods;
        //Constructor
        public HairClipper(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            Reusablemethods = new Reusablemethods(driver, test);
        }

        public void HairClipperSoundTest1()
        {
            Reusablemethods.ScrollToElementByText("Hair Clipper");
            ExtentTest test = Extent.CreateTest("Hair Clipper Sound Test");
            try
            {
                // HairClipperMenu
                try
                {
                    HairClipperMenu.Click();
                    Reusablemethods.InterAdHandle();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Hair Clipper Menu", ex);
                }

                // Hair Clipper 1
                try
                {
                    HairClipper1.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Hair Clipper 1", ex);
                }

                // Hair Clipper 2
                try
                {
                    HairClipper2.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Hair Clipper 2", ex);
                }

                // Hair Clipper 3
                try
                {
                    HairClipper3.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Hair Clipper 3", ex);
                }
            }
            catch (Exception ex)
            {
                Reusablemethods.HandleException("Hair Clipper Sound Test", ex);
            }
        }
        public void HairClipperSoundTest()
        {
            // Scroll to Hair Clipper menu
            Reusablemethods.ScrollToElementByText("Hair Clipper");

            // Click on the Hair Clipper menu and handle ads
            Reusablemethods.ClickwithAd(HairClipperMenu, "HairClipperMenu");

            // Hair Clipper 1
            Reusablemethods.ClickwithAd(HairClipper1, "HairClipper1");
            Reusablemethods.SoundPlayScreen("Hair Clipper 1");

            // Hair Clipper 2
            Reusablemethods.ClickwithAd(HairClipper2, "HairClipper2");
            Reusablemethods.SoundPlayScreen("Hair Clipper 2");

            // Hair Clipper 3
            Reusablemethods.ClickwithAd(HairClipper3, "HairClipper3");
            Reusablemethods.SoundPlayScreen("Hair Clipper 3 and back to main screen");

            // Navigate back to the main screen
            Reusablemethods.NavigateBack("Main screen Back");
        }


        IWebElement? HairClipperMenu => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Clipper\"]"), "HairClipperMenu");

        IWebElement? HairClipper1 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Clipper 1\"]"), "HairClipper1");

        IWebElement? HairClipper2 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Clipper 2\"]"), "HairClipper2");

        IWebElement? HairClipper3 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Clipper 3\"]"), "HairClipper3");

        IWebElement? HairClipper4 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Clipper 4\"]"), "HairClipper4");

        IWebElement? HairClipper5 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Clipper 5\"]"), "HairClipper5");

        IWebElement? HairClipper6 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Clipper 6\"]"), "HairClipper6");

        IWebElement? HairClipper7 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Clipper 7\"]"), "HairClipper7");

        IWebElement? HairClipper8 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Clipper 8\"]"), "HairClipper8");

        IWebElement? HairClipper9 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hair Clipper 9\"]"), "HairClipper9");

        IWebElement? VolumeUp => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus"), "VolumeUp");

        IWebElement? VolumeDown => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus"), "VolumeDown");

        IWebElement? Loop => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck"), "Loop");

        IWebElement? PlayButton => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]"), "PlayButton");

        IWebElement? AddtoBookmark => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite"), "AddtoBookmark");


    }
}
