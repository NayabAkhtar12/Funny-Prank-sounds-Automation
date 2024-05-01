using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace Prank_Sound_App.Pages
{
    class AnimalSounds
    {
        private AppiumDriver<IWebElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        //Constructor
        public AnimalSounds(AppiumDriver<IWebElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
        }

        public void AnimalSound()
        {
            ExtentTest test = Extent.CreateTest("NearBy Places Report 1");
            try
            {

                AnimalSoundMenu.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Zoo: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {

                AnimalSound1.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Zoo: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                AnimalSound2.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Zoo: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                AnimalSound3.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Zoo: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                AnimalSound4.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Zoo: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                AnimalSound5.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Zoo: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {
                AnimalSound6.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Zoo: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");

            }

            try
            {
                AnimalSound7.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Zoo: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");

            }

            try
            {
                AnimalSound8.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Zoo: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");

            }

            try
            {
                AnimalSound9.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Zoo: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");
            }
            try
            {

                IWebElement ScrollElement = driver.FindElement(MobileBy.AndroidUIAutomator(
                    "new UiScrollable(new UiSelector().scrollable(true))" +
                    ".scrollIntoView(new UiSelector().text(\"Bird\")) "));

                AnimalSound10.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Zoo: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");

            }
            try
            {
                AnimalSound11.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Zoo: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");

            }
            try
            {
                AnimalSound12.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Zoo: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");

            }
            try
            {
                AnimalSound13.Click();
                PlayButton.Click();
                VolumeUp.Click();
                VolumeDown.Click();
                Loop.Click();
                BackButton1.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred while clicking Zoo: " + ex.Message);
                Test.Log(Status.Fail, $"Test failed due to: {ex.Message}");

            }
        }


        public IWebElement AnimalSoundMenu => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Animal Sounds\"]");

        public IWebElement BackButtonMenu => driver.FindElementById("");

        public IWebElement BackButton1 => driver.FindElementByAccessibilityId("Navigate up");
        public IWebElement VolumeUp => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus");
        public IWebElement VolumeDown => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus");
        public IWebElement Loop => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck");
        public IWebElement PlayButton => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivPPCv");
        public IWebElement AnimalSound1 => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]");
        public IWebElement AnimalSound2 => driver.FindElementByXPath("(//android.view.ViewGroup[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/content_container\"])[2]");
        public IWebElement AnimalSound3 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Monkey\"]");
        public IWebElement AnimalSound4 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Mouse\"]");
        public IWebElement AnimalSound5 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Snake\"]");
        public IWebElement AnimalSound6 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Chicken\"]");
        public IWebElement AnimalSound7 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Dog\"]");
        public IWebElement AnimalSound8 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Cat\"]");
        public IWebElement AnimalSound9 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Wolf\"]");
        public IWebElement AnimalSound10 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Horse\"]");
        public IWebElement AnimalSound11 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Frog\"]");
        public IWebElement AnimalSound12 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Duck\"]");
        public IWebElement AnimalSound13 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Bird\"]");
    }
}
