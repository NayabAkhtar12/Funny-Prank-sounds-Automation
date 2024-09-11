using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;

namespace Prank_Sound_App.Pages
{
    class BurpSounds
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        Reusablemethods Reusablemethods;

        //Constructor
        public BurpSounds(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            Reusablemethods = new Reusablemethods(driver, test);

        }

        public void BurpSoundTest()
        {
            Reusablemethods.ScrollToElementByText("Burp Sounds");

            ExtentTest test = Extent.CreateTest("Burp Sound Test");
            try
            {
                // BurpSoundMenu
                try
                {
                    BurpSoundMenu.Click();
                    Reusablemethods.InterAdHandle();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Burp Sound Menu", ex);
                }

                // Burp Sound 1
                try
                {
                    BurpSound1.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Burp Sound 1", ex);
                }

                // Burp Sound 2
                try
                {
                    BurpSound2.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Burp Sound 2", ex);
                }

                // Burp Sound 3
                try
                {
                    BurpSound3.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    //   WaitForElement(AddtoBookmark);
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                    driver.Navigate().Back();

                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Burp Sound 3", ex);
                }
            }
            catch (Exception ex)
            {
                Reusablemethods.HandleException("Burp Sound Test", ex);
            }
        }


        private void WaitForElement(IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => element.Displayed);
        }
        IWebElement BurpSoundMenu => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp Sounds\"]");
        IWebElement BurpSound1 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp Sound 1\"]");
        IWebElement BurpSound2 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp Sound 2\"]");
        IWebElement BurpSound3 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp Sound 3\"]");
        IWebElement BurpSound4 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp 4\"]");
        IWebElement BurpSound5 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp 5\"]");
        IWebElement BurpSound6 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp 6\"]");
        IWebElement BurpSound7 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp 7\"]");
        IWebElement BurpSound8 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp 8\"]");
        IWebElement BurpSound9 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp 9\"]");
        IWebElement BurpSound10 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp 10\"]");
        IWebElement BurpSound11 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp 11\"]");
        IWebElement BurpSound12 => driver.FindElementByXPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp 12\"]");
        IWebElement AddtoBookmark => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite");

        IWebElement BackButton1 => driver.FindElementByAccessibilityId("Navigate up");
        IWebElement VolumeUp => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus");
        IWebElement VolumeDown => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus");
        IWebElement Loop => driver.FindElementById("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck");
        IWebElement PlayButton => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]");

    }
}
