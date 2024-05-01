using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace Live_Earth_Map.Pages
{
    class CarHorn
    {
        private AppiumDriver<IWebElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        //Constructor
        public CarHorn(AppiumDriver<IWebElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
        }

        public void CarHornM()
        {
            //   ExtentTest test = Extent.CreateTest("NearBy Places Report 1");
            try
            {
                CarHornTestXpath.Click();
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
                CarHornMenu.Click();
                CarHorn1.Click();
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
                CarHorn2.Click();
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
                CarHorn3.Click();
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
                CarHorn4.Click();
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
                CarHorn5.Click();
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
                IWebElement ScrollelementtoLast = driver.FindElement(MobileBy.AndroidUIAutomator(
                "new UiScrollable(new UiSelector().scrollable(true))" +
                ".scrollIntoView(new UiSelector().text(\"Fart Sound 17\")) "));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);

            }

        }

        public IWebElement CarHornMenu => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Car Horn\"]");
        public IWebElement CarHorn1 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Car Horn 1\"]");
        public IWebElement CarHorn2 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Car Horn 2\"]");
        public IWebElement CarHorn3 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Car Horn 3\"]");
        public IWebElement CarHorn4 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Car Horn 4\"]");
        public IWebElement CarHorn5 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Car Horn 5\"]");
        public IWebElement CarHornTestXpath => driver.FindElementByXPath("//android.widget.TextView[@text=\"Car Horn 5\"]\r\n");

        public IWebElement BackButton1 => driver.FindElementByAccessibilityId("Navigate up");
        public IWebElement VolumeUp => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus");
        public IWebElement VolumeDown => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus");
        public IWebElement Loop => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck");
        public IWebElement PlayButton => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivPPCv");

    }
}
