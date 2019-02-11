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
            Assert.AreEqual(defaultEngineState, false);
            Assert.AreEqual(defaultAirplaneCurrentAlt, 0);
            Assert.AreEqual(defaultAirplaneIsFlying, false);
            
        }
    }
}
