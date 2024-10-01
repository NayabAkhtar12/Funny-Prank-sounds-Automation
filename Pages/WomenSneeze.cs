using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Prank_Sound_App.Pages
{
    class WomenSneeze
    {
        private AppiumDriver<AndroidElement> driver;
        private ExtentTest Test;
        ExtentReports Extent = new ExtentReports();
        Reusablemethods Reusablemethods;

        //Constructor
        public WomenSneeze(AppiumDriver<AndroidElement> driver, ExtentTest test)
        {
            this.driver = driver;
            this.Test = test;
            Reusablemethods = new Reusablemethods(driver, test);

        }

        public void WomenSneezeSoundTest()
        {
            // Scroll to Women Sneeze menu
            Reusablemethods.ScrollToElementByText("Women Sneeze");

            // Click on the Women Sneeze menu and handle ads
            Reusablemethods.ClickwithAd(WomenSneezeMenu, "WomenSneezeMenu");

            // Sneeze 1
            Reusablemethods.ClickwithAd(WomenSneeze1, "WomenSneeze1");
            Reusablemethods.SoundPlayScreen("Sneeze 1");

            // Sneeze 2
            Reusablemethods.ClickwithAd(WomenSneeze2, "WomenSneeze2");
            Reusablemethods.SoundPlayScreen("Sneeze 2");

            // Sneeze 3
            Reusablemethods.ClickwithAd(WomenSneeze3, "WomenSneeze3");
            Reusablemethods.SoundPlayScreen("Sneeze 3 and back to main screen");

            // Navigate back to the main screen
            Reusablemethods.NavigateBack("Main screen Back");
        }

        IWebElement? WomenSneezeMenu => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Women Sneeze\"]"), "WomenSneezeMenu");

        IWebElement? WomenSneeze1 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Woman Sneeze 1\"]"), "WomanSneeze1");

        IWebElement? WomenSneeze2 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Woman Sneeze 2\"]"), "WomenSneeze2");

        IWebElement? WomenSneeze3 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Woman Sneeze 3\"]"), "WomenSneeze3");

        IWebElement? WomenSneeze4 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Sneeze 4\"]"), "WomenSneeze4");

        IWebElement? WomenSneeze5 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Sneeze 5\"]"), "WomenSneeze5");

        IWebElement? WomenSneeze6 => Reusablemethods.FindElement(By.XPath("//android.widget.TextView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/name\" and @text=\"Sneeze 6\"]"), "WomenSneeze6");

        IWebElement? VolumeUp => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivolplus"), "VolumeUp");

        IWebElement? VolumeDown => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivvolminus"), "VolumeDown");

        IWebElement? Loop => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/sCheck"), "Loop");

        IWebElement? PlayButton => Reusablemethods.FindElement(By.XPath("(//android.widget.ImageView[@resource-id=\"com.pranksound.fartsound.hornsound.haircut.soundprank:id/icon\"])[1]"), "PlayButton");

        IWebElement? AddtoBookmark => Reusablemethods.FindElement(By.Id("com.pranksound.fartsound.hornsound.haircut.soundprank:id/ivFavourite"), "AddtoBookmark");


    }
}
