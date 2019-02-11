using Flying;
using NUnit.Framework;

namespace Tests
{
    public class UnitTestAirplane
    {
        [Test]
        public void AirPlaneCreation()
        {
            Airplane ap = new Airplane();

            int defaultAirplaneMaxAltitue = ap.MaxAltitude;
            int airplaneMaxAltitude = 41000;
            bool defaultEngineState = ap.Engine.IsStarted;
            int defaultAirplaneCurrentAlt = ap.CurrentAltitude;
            bool defaultAirplaneIsFlying = ap.IsFlying;

            Assert.AreEqual(defaultAirplaneMaxAltitue, airplaneMaxAltitude);
            Assert.False(defaultEngineState);
            Assert.Zero(defaultAirplaneCurrentAlt);
            Assert.False(defaultAirplaneIsFlying);
        }

        [Test]
        public void AirplaneInfo()
        {
            Airplane ap = new Airplane();


            string defaultAirplaneInfo = ap.About();
            string AirplaneExpectedInfoDefault = string.Format("This OOPAerialVehicle has a max altitude of {0}" +
                "\nIt's current altitude is {1} ft." +
                "\n{2}", ap.MaxAltitude, ap.CurrentAltitude, ap.Engine.About());

            ap.StartEngine();
            ap.TakeOff();
            ap.FlyUp();
            string flyUpAirplaneInfo = ap.About();
            string AirplaneExpectedInfoflyUp = string.Format("This OOPAerialVehicle has a max altitude of {0}" +
                "\nIt's current altitude is {1} ft." +
                "\n{2}", ap.MaxAltitude, ap.CurrentAltitude, ap.Engine.About());

            ap.FlyDown();
            string flyDownAirplaneInfo = ap.About();
            string AirplaneExpectedInfoflyDown = string.Format("This OOPAerialVehicle has a max altitude of {0}" +
                "\nIt's current altitude is {1} ft." +
                "\n{2}", ap.MaxAltitude, ap.CurrentAltitude, ap.Engine.About());

            int amountOfFeet = 2000;
            ap.FlyUp(amountOfFeet);
            string flyUpNumAirplaneInfo = ap.About();
            string AirplaneExpectedInfoflyUpNum = string.Format("This OOPAerialVehicle has a max altitude of {0}" +
                "\nIt's current altitude is {1} ft." +
                "\n{2}", ap.MaxAltitude, ap.CurrentAltitude, ap.Engine.About());

            ap.FlyDown(amountOfFeet);
            string flyDownNumAirplaneInfo = ap.About();
            string AirplaneExpectedInfoflyDownNum = string.Format("This OOPAerialVehicle has a max altitude of {0}" +
                "\nIt's current altitude is {1} ft." +
                "\n{2}", ap.MaxAltitude, ap.CurrentAltitude, ap.Engine.About());

            Assert.AreEqual(defaultAirplaneInfo, AirplaneExpectedInfoDefault);
            Assert.AreEqual(flyUpAirplaneInfo, AirplaneExpectedInfoflyUp);
            Assert.AreEqual(flyDownAirplaneInfo, AirplaneExpectedInfoflyDown);
            Assert.AreEqual(flyUpNumAirplaneInfo, AirplaneExpectedInfoflyUpNum);
            Assert.AreEqual(flyDownNumAirplaneInfo, AirplaneExpectedInfoflyDownNum);


        }


        [Test]
        public void AirplaneTakeOff()
        {
            Airplane ap = new Airplane();

            string defaultAirplaneTakeOff = ap.TakeOff();
            string AirplaneTakeOffDefault = string.Format("{0} can't fly it's engine is not started.", ap.GetType());

            ap.StartEngine();
            string engineStartAirplaneTakeOff = ap.TakeOff();
            string AirplaneTakeOffEngineStart = string.Format("{0} is flying", ap.GetType());

            Assert.AreEqual(defaultAirplaneTakeOff, AirplaneTakeOffDefault);
            Assert.AreEqual(engineStartAirplaneTakeOff, AirplaneTakeOffEngineStart);
        }

        [Test]
        public void AirplaneFlying()
        {
            Airplane ap = new Airplane();

            int defualtAirplaneAltitude = ap.CurrentAltitude;

            ap.StartEngine();
            ap.TakeOff();
            ap.FlyDown();
            int flyDownAirplaneAltitude = ap.CurrentAltitude;

            int someAmount = 20000;
            ap.FlyDown(someAmount);
            int flyDownNumAirplaneAltitude = ap.CurrentAltitude;

            ap.FlyUp();
            int flyUpAirplaneAltitude = ap.CurrentAltitude;

            ap.FlyUp(someAmount);
            int flyUpSumAirplaneAltitude = ap.CurrentAltitude;

            ap.FlyDown(ap.MaxAltitude);
            int landAirplaneAltitude = ap.CurrentAltitude;

            ap.FlyDown(ap.CurrentAltitude);
            int actualLandAirplaneAltitude = ap.CurrentAltitude;

            Assert.AreEqual(defualtAirplaneAltitude, 0);
            Assert.AreEqual(flyDownAirplaneAltitude, 0);
            Assert.AreEqual(flyDownNumAirplaneAltitude, 0);

            Assert.AreEqual(flyUpAirplaneAltitude, 1000);
            Assert.AreEqual(flyUpSumAirplaneAltitude, someAmount + 1000);
            Assert.AreEqual(landAirplaneAltitude, flyUpSumAirplaneAltitude);
            Assert.AreEqual(actualLandAirplaneAltitude, 0);

        }
    }
}
