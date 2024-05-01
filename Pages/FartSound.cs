using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace Prank_Sound_App.Pages
{
    class FartSound
    {
        private AppiumDriver<IWebElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        //Constructor
        public FartSound(AppiumDriver<IWebElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
        }

        public void FartSoundTest()
        {
            ExtentTest test = Extent.CreateTest("NearBy Places Report 1");
            try
            {
                FartSoundMenu.Click();
                FartSound1.Click();
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
                FartSound2.Click();
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
                FartSound3.Click();
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
                FartSound4.Click();
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
                FartSound5.Click();
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
                FartSound6.Click();
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
                FartSound7.Click();
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
                FartSound8.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occured: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");

            }

            try
            {
                FartSound9.Click();
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

            try
            {
                FartSound10.Click();
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
                FartSound11.Click();
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
                FartSound12.Click();
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
                FartSound13.Click();
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
                FartSound14.Click();
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
                FartSound15.Click();
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
                FartSound16.Click();
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
                FartSound17.Click();
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

        public IWebElement FartSoundMenu => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound\"]");
        public IWebElement FartSound1 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 1\"]");
        public IWebElement FartSound2 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 2\"]");
        public IWebElement FartSound3 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 3\"]");
        public IWebElement FartSound4 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 4\"]");
        public IWebElement FartSound5 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 5\"]");
        public IWebElement FartSound6 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 6\"]");
        public IWebElement FartSound7 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 7\"]");
        public IWebElement FartSound8 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 8\"]");
        public IWebElement FartSound9 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 9\"]");
        public IWebElement FartSound10 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 10\"]");
        public IWebElement FartSound11 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 11\"]");
        public IWebElement FartSound12 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 12\"]");
        public IWebElement FartSound13 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 13\"]");
        public IWebElement FartSound14 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 14\"]");
        public IWebElement FartSound15 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 15\"]");
        public IWebElement FartSound16 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 16\"]");
        public IWebElement FartSound17 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Fart Sound 17\"]");



        public IWebElement BackButton1 => driver.FindElementByAccessibilityId("Navigate up");
        public IWebElement VolumeUp => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus");
        public IWebElement VolumeDown => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus");
        public IWebElement Loop => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck");
        public IWebElement PlayButton => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivPPCv");

    }
}
