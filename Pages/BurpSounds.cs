using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

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
            // Scroll to Burp Sounds menu
            Reusablemethods.ScrollToElementByText("Burp Sounds");

            // Click on the Burp Sound menu and handle ads
            Reusablemethods.ClickwithAd(BurpSoundMenu, "BurpSoundMenu");

            // Burp Sound 1
            Reusablemethods.ClickwithAd(BurpSound1, "BurpSound1");
            Reusablemethods.SoundPlayScreen("Burp Sound 1");

            // Burp Sound 2
            Reusablemethods.ClickwithAd(BurpSound2, "BurpSound2");
            Reusablemethods.SoundPlayScreen("Burp Sound 2");

            // Burp Sound 3
            Reusablemethods.ClickwithAd(BurpSound3, "BurpSound3");
            Reusablemethods.SoundPlayScreen("Burp Sound 3 and back to main screen");

            // Navigate back to the main screen
            Reusablemethods.NavigateBack("Main screen Back");
        }


        // Burp Sounds Menu and Sounds
        public IWebElement? BurpSoundMenu => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp Sounds\"]"), "BurpSoundMenu");
        public IWebElement? BurpSound1 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp Sound 1\"]"), "BurpSound1");
        public IWebElement? BurpSound2 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp Sound 2\"]"), "BurpSound2");
        public IWebElement? BurpSound3 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp Sound 3\"]"), "BurpSound3");
        public IWebElement? BurpSound4 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp 4\"]"), "BurpSound4");
        public IWebElement? BurpSound5 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp 5\"]"), "BurpSound5");
        public IWebElement? BurpSound6 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp 6\"]"), "BurpSound6");
        public IWebElement? BurpSound7 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp 7\"]"), "BurpSound7");
        public IWebElement? BurpSound8 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp 8\"]"), "BurpSound8");
        public IWebElement? BurpSound9 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp 9\"]"), "BurpSound9");
        public IWebElement? BurpSound10 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp 10\"]"), "BurpSound10");
        public IWebElement? BurpSound11 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp 11\"]"), "BurpSound11");
        public IWebElement? BurpSound12 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Burp 12\"]"), "BurpSound12");

        // Bookmark element
        public IWebElement? AddtoBookmark => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite"), "AddtoBookmark");


    }
}
