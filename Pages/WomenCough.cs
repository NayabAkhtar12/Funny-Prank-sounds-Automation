using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class WomenCough
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        Reusablemethods Reusablemethods;

        //Constructor
        public WomenCough(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            Reusablemethods = new Reusablemethods(driver, test);

        }


        public void WomenCoughSoundTest()
        {
            // Scroll to Women Cough menu
            Reusablemethods.ScrollToElementByText("Women Cough");

            // Click on the Women Cough menu and handle ads
            Reusablemethods.ClickwithAd(WoMenCoughMenu, "WoMenCoughMenu");
            //   Reusablemethods.HandleCBanner("Women cough");

            // Women Cough 1
            Reusablemethods.ClickwithAd(WoMenCough1, "WoMenCough1");
            Reusablemethods.SoundPlayScreen("Women Cough 1");

            // Women Cough 2
            Reusablemethods.ClickwithAd(WoMenCough2, "WoMenCough2");
            Reusablemethods.SoundPlayScreen("Women Cough 2");

            // Women Cough 3
            Reusablemethods.ClickwithAd(WoMenCough3, "WoMenCough3");
            Reusablemethods.SoundPlayScreen("Women Cough 3 and back to main screen");

            // Navigate back to the main screen
            Reusablemethods.NavigateBack("Main screen Back");
        }

        // Women Cough Menu and Sounds
        public IWebElement? WoMenCoughMenu => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Women Cough\"]"), "WoMenCoughMenu");
        public IWebElement? WoMenCough1 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Woman Cough 1\"]"), "WoMenCough1");
        public IWebElement? WoMenCough2 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Woman Cough 2\"]"), "WoMenCough2");
        public IWebElement? WoMenCough3 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Woman Cough 3\"]"), "WoMenCough3");

        // Common Buttons and Controls
        public IWebElement? AddtoBookmark => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite"), "AddtoBookmark");
        public IWebElement? BackButton1 => Reusablemethods.FindElement(By.Id("Navigate up"), "BackButton1");
        public IWebElement? VolumeUp => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus"), "VolumeUp");
        public IWebElement? VolumeDown => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus"), "VolumeDown");
        public IWebElement? Loop => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck"), "Loop");
        public IWebElement? PlayButton => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]"), "PlayButton");

    }
}
