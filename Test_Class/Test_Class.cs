using AventStack.ExtentReports;
using Prank_Sound_App.Core;
using Prank_Sound_App.Pages;

namespace Prank_Sound_App.Test_Class
{
    [TestClass]
    public class Test_Class : TestInitiallize
    {
        AirHorn AirHorn;
        //  [TestMethod]
        public void AirHornSounds()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            AirHorn = new AirHorn(driver, test);
            AirHorn.NearByPlacesHome();
        }

        AnimalSounds AnimalSound;
        //   [TestMethod]
        public void AnimalSounds()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            AnimalSound = new AnimalSounds(driver, test);
            AnimalSound.AnimalSound();
        }

        FartSound FartSound;

        //  [TestMethod]
        public void FartSounds()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            FartSound = new FartSound(driver, test);
            FartSound.FartSoundTest();
        }
        CarHorn CarHorn;

        [TestMethod]
        public void CarHornTest()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            CarHorn = new CarHorn(driver, test);
            CarHorn.CarHornM();
        }
    }
}
