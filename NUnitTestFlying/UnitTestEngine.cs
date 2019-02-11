using Flying;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void EngineIsStarted()
        {

            Engine e = new Engine();


            bool defaultEngineStarted = e.IsStarted;
            e.Start();
            bool startEngineStarted = e.IsStarted;
            e.Stop();
            bool stopEngineStarted = e.IsStarted;


            Assert.AreEqual(defaultEngineStarted, false);
            Assert.AreEqual(startEngineStarted, true);
            Assert.AreEqual(stopEngineStarted, false);
        }

        [Test]
        public void EngineInformation()
        {
            Engine e = new Engine();

            string defaultEngineInfo = e.About();
            e.Start();
            string startEngineInfo = e.About();
            e.Stop();
            string stopEngineInfo = e.About();

            string startedStringEngineAbout = string.Format("{0} is {1}", e.GetType(), "started");
            string stoppedStringEngineAbout = string.Format("{0} is {1}", e.GetType(), "not started");

            Assert.AreEqual(defaultEngineInfo, stoppedStringEngineAbout);
            Assert.AreEqual(startEngineInfo, startedStringEngineAbout);
            Assert.AreEqual(stopEngineInfo, stoppedStringEngineAbout);
        }


    }
}