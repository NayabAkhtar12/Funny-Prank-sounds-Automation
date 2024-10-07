using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class AirHorn
    {
        private AppiumDriver<AndroidElement> driver;
        Reusablemethods Reusablemethods;

        //Constructor
        public AirHorn(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            Reusablemethods = new Reusablemethods(driver, test);

        }
        //test web hook
        public void AirHornSoundTest()
        {
            Reusablemethods.SplashHandling2ndsessiont();
            //Air Horn 1
            Reusablemethods.ScrollToElementByText("Air Horn");
            Reusablemethods.ClickwithAd(AirHornMenu, "AirHornMenu");
            Reusablemethods.ClickwithAd(AirHorn1, "AirHorn1");
            Reusablemethods.SoundPlayScreen("Air Horn 1");


            //Air Horn 2
            Reusablemethods.ClickwithAd(AirHorn2, "AirHorn2");
            Reusablemethods.SoundPlayScreen("Air Horn 2");

            //Air Horn 3
            Reusablemethods.ClickwithAd(AirHorn3, "AirHorn3");
            Reusablemethods.SoundPlayScreen("Air Horn 3");

            //Air Horn 4
            Reusablemethods.ClickwithAd(AirHorn4, "AirHorn4");
            Reusablemethods.SoundPlayScreen("Air Horn 4 and back to air horn main screen");
            Reusablemethods.NavigateBack("Main screen Back ");
        }


        IWebElement? AirHornMenu => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Air Horn\"]"), "AirHornMenu");

        IWebElement? VolumeUp => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus"), "VolumeUp");

        IWebElement? VolumeDown => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus"), "VolumeDown");

        IWebElement? Loop => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck"), "Loop");

        IWebElement? AirHorn1 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Air Horn 1\"]"), "AirHorn1");

        IWebElement? AirHorn2 => Reusablemethods.FindElement(By.XPath("(//android.view.ViewGroup[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/content_container\"])[2]"), "AirHorn2");

        IWebElement? AirHorn3 => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[3]"), "AirHorn3");

        IWebElement? AirHorn4 => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[4]"), "AirHorn4");

        IWebElement? AirHorn5 => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[5]"), "AirHorn5");

        IWebElement? AirHorn6 => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[6]"), "AirHorn6");

        IWebElement? AirHorn7 => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[7]"), "AirHorn7");

        IWebElement? AirHorn8 => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[8]"), "AirHorn8");

        IWebElement? AirHorn9 => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[9]"), "AirHorn9");

        IWebElement PlayButton => driver.FindElementByXPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]");

    }
}
