using AventStack.ExtentReports;
using Live_Earth_Map.Core;
using Live_Earth_Map.Pages;

namespace Live_Earth_Map.Test_Class
{
    [TestClass]
    public class Test_Class : TestInitiallize
    {
        AirHorn AirHorn;
        [TestMethod]
        public void AirHornSounds()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            AirHorn = new AirHorn(driver, test);
            AirHorn.NearByPlacesHome();
        }

        AnimalSounds AnimalSound;
        [TestMethod]
        public void AnimalSounds()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            AnimalSound = new AnimalSounds(driver, test);
            AnimalSound.AnimalSound();
        }

        FartSound FartSound;

        [TestMethod]
        public void FartSounds()
        {
            ExtentTest test = Extent.CreateTest("Famous Places Report");
            FartSound = new FartSound(driver, test);
            FartSound.FartSoundTest();
        }
    }
}
