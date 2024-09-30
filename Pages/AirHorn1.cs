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
            //Air Horn 1
            Reusablemethods.ScrollToElementByText("Air Horn");
            Reusablemethods.ClickwithAd(AirHornMenu, "AirHornMenu");
            Reusablemethods.ClickwithAd(AirHorn1, "AirHorn1");
            Reusablemethods.SoundPlayScreen("Air Horn 1");

            //Air Horn 2
            Reusablemethods.ClickwithAd(AirHorn1, "AirHorn1");
            Reusablemethods.SoundPlayScreen("Air Horn 1");

            //Air Horn 3
            Reusablemethods.ClickwithAd(AirHorn2, "AirHorn2");
            Reusablemethods.SoundPlayScreen("Air Horn 2");

            //Air Horn 4
            Reusablemethods.ClickwithAd(AirHorn1, "AirHorn3");
            Reusablemethods.SoundPlayScreen("Air Horn 3 and back to air horn main screen");
            Reusablemethods.NavigateBack("Main screen Back ");
        }

        IWebElement AirHornMenu => driver.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Air Horn\"]"));
        IWebElement VolumeUp => driver.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus"));
        IWebElement VolumeDown => driver.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus"));
        IWebElement Loop => driver.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck"));
        IWebElement AirHorn1 => driver.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Air Horn 1\"]"));
        IWebElement AirHorn2 => driver.FindElement(By.XPath("(//android.view.ViewGroup[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/content_container\"])[2]"));
        IWebElement AirHorn3 => driver.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[3]"));
        IWebElement AirHorn4 => driver.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[4]"));
        IWebElement AirHorn5 => driver.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[5]"));
        IWebElement AirHorn6 => driver.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[6]"));
        IWebElement AirHorn7 => driver.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[7]"));
        IWebElement AirHorn8 => driver.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[8]"));
        IWebElement AirHorn9 => driver.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[9]"));

    }
}
