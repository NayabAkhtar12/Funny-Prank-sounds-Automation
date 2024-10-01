using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class OtherSounds
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        Reusablemethods Reusablemethods;

        //Constructor
        public OtherSounds(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            Reusablemethods = new Reusablemethods(driver, test);

        }
        public void OtherSoundsTest1()
        {
            Reusablemethods.ScrollToElementByText("Other Sounds");
            ExtentTest test = Extent.CreateTest("Other Sounds Test");
            try
            {
                // Other Sounds Menu
                try
                {
                    OtherSoundMenu.Click();
                    Reusablemethods.InterAdHandle();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Other Sounds Menu", ex);
                }

                // Clap Sound
                try
                {
                    ClapSound.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Clap Sound", ex);
                }

                // Camera Sound
                try
                {
                    Camera.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Camera Sound", ex);
                }

                // Open Door Sound
                try
                {
                    OpenDoor.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Open Door Sound", ex);
                }

                // Drum Beat Sound
                try
                {
                    DrumBeat.Click();
                    Reusablemethods.InterAdHandle();
                    PlayButton.Click();
                    AddtoBookmark.Click();
                    driver.Navigate().Back();
                    driver.Navigate().Back();
                }
                catch (Exception ex)
                {
                    Reusablemethods.HandleException("Drum Beat Sound", ex);
                }
            }
            catch (Exception ex)
            {
                Reusablemethods.HandleException("Other Sounds Test", ex);
            }
        }
        public void OtherSoundsTest()
        {
            // Scroll to Other Sounds section
            Reusablemethods.ScrollToElementByText("Other Sounds");

            // Create a test instance for reporting
            ExtentTest test = Extent.CreateTest("Other Sounds Test");

            // Click on Other Sounds menu and handle ads
            Reusablemethods.ClickwithAd(OtherSoundMenu, "OtherSoundMenu");

            // Clap Sound
            Reusablemethods.ClickwithAd(ClapSound, "ClapSound");
            Reusablemethods.SoundPlayScreen("Clap Sound");

            // Camera Sound
            Reusablemethods.ClickwithAd(Camera, "Camera");
            Reusablemethods.SoundPlayScreen("Camera Sound");

            // Open Door Sound
            Reusablemethods.ClickwithAd(OpenDoor, "OpenDoor");
            Reusablemethods.SoundPlayScreen("Open Door Sound");

            // Drum Beat Sound
            Reusablemethods.ClickwithAd(DrumBeat, "DrumBeat");
            Reusablemethods.SoundPlayScreen("Drum Beat Sound and back to main screen");

            // Navigate back to the main screen
            Reusablemethods.NavigateBack("Main screen Back");
        }


        IWebElement? OtherSoundMenu => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Other Sounds\"]"), "OtherSoundMenu");

        IWebElement? ClapSound => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Clap\"]"), "ClapSound");

        IWebElement? Camera => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Camera\"]"), "Camera");

        IWebElement? OpenDoor => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Open Door\"]"), "OpenDoor");

        IWebElement? DrumBeat => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Drum Beat\"]"), "DrumBeat");

        IWebElement? Call => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Call\"]"), "Call");

        IWebElement? Message => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Message\"]"), "Message");

        IWebElement? Hello => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Hello\"]"), "Hello");

        IWebElement? Kiss => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Kiss\"]"), "Kiss");

        IWebElement? VolumeUp => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus"), "VolumeUp");

        IWebElement? VolumeDown => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus"), "VolumeDown");

        IWebElement? Loop => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck"), "Loop");

        IWebElement? PlayButton => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]"), "PlayButton");

        IWebElement? AddtoBookmark => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite"), "AddtoBookmark");


    }
}
