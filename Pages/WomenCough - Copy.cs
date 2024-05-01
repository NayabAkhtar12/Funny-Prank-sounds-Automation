using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace Prank_Sound_App.Pages
{
    class WomenCough
    {
        private AppiumDriver<IWebElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        //Constructor
        public WomenCough(AppiumDriver<IWebElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
        }

        public void FartSoundTest()
        {
            ExtentTest test = Extent.CreateTest("NearBy Places Report 1");
            try
            {
                WoMenCoughMenu.Click();
                WoMenCough1.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred : " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                WoMenCough2.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred : " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                WoMenCough3.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred : " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
        }

        public IWebElement WoMenCoughMenu => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Women Cough\"]");
        public IWebElement WoMenCough1 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Women Cough 1\"]");
        public IWebElement WoMenCough2 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Women Cough 2\"]");
        public IWebElement WoMenCough3 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Women Cough 3\"]");

        public IWebElement BackButton1 => driver.FindElementByAccessibilityId("Navigate up");
        public IWebElement VolumeUp => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus");
        public IWebElement VolumeDown => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus");
        public IWebElement Loop => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck");
        public IWebElement PlayButton => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivPPCv");

    }
}
