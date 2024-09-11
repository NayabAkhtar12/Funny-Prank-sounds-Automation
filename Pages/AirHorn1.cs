using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class AirHorn
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        Reusablemethods Reusablemethods;

        //Constructor
        public AirHorn(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            Reusablemethods = new Reusablemethods(driver, test);

        }

        public void AirHornSoundTest()
        {
            Reusablemethods.ScrollToElementByText("Air Horn");

            ExtentTest test = Extent.CreateTest("NearBy Places Report 1");

            try
            {
                try
                {
                    AirHornMenu.Click();
                    Reusablemethods.InterAdHandle();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Air Horn Menu", ex);
                }


                AirHorn1.Click();

                try
                {
                    Reusablemethods.InterAdHandle();

                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Air Horn 1", ex);
                }

                //  Loop.Click();

                PlayButton.Click();
                Thread.Sleep(3000);
                // VolumeUp.Click();
                //   VolumeDown.Click();
                AddtoBookmark.Click();
                driver.Navigate().Back();
                //  Thread.Sleep(3000);

                //Air Horn2
                AirHorn2.Click();

                try
                {
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    Thread.Sleep(3000);
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Air Horn 2", ex);
                }

                //AirHorn3
                AirHorn3.Click();

                try
                {
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    Thread.Sleep(3000);
                    AddtoBookmark.Click();
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Air Horn 3", ex);
                }


                //AirHorn4

                AirHorn4.Click();

                try
                {
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    Thread.Sleep(3000);
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Air Horn 4", ex);
                }

            }
            catch (Exception ex)
            {
                Reusablemethods.HandleException("Air Horn ", ex);
            }
        }

        IWebElement AirHornMenu => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Air Horn\"]");

        IWebElement AddtoBookmark => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite");
        IWebElement VolumeUp => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus");
        IWebElement VolumeDown => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus");
        IWebElement Loop => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck");
        IWebElement PlayButton => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]");
        IWebElement AirHorn1 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Air Horn 1\"]");

        IWebElement AirHorn2 => driver.FindElementByXPath("(//android.view.ViewGroup[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/content_container\"])[2]");

        IWebElement AirHorn3 => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[3]");

        IWebElement AirHorn4 => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[4]");

        IWebElement AirHorn5 => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[5]");

        IWebElement AirHorn6 => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[6]");
        IWebElement AirHorn7 => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[7]");
        IWebElement AirHorn8 => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[8]");
        IWebElement AirHorn9 => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[9]");

    }
}
