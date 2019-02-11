using System;
using System.Collections.Generic;
using System.Text;
using Flying;
using NUnit.Framework;

namespace Tests
{
    class UnitTestToyPlane
    {
        [Test]
        public void ToyPlaneCreation()
        {
            ToyPlane tp = new ToyPlane();

            int defaultToyPlaneMaxAltitude = tp.MaxAltitude;
            bool defaultToyPlaneWoundUp = tp.isWoundUP;

            Assert.AreEqual(defaultToyPlaneMaxAltitude, 50);
            Assert.IsFalse(defaultToyPlaneWoundUp);
        }

        [Test]
        public void ToyPlaneWindUp()
        {
            ToyPlane tp = new ToyPlane();

            bool defaultToyPlaneIsWoundUp = tp.isWoundUP;

            tp.FlyUp(10);
            string unwoundToyPlaneInfo = tp.About();

            string ToyPlaneInfoUnWound = String.Format("This OOPAerialVehicle has a max altitude of {0}" +
                                "\nIt's current altitude is {1} ft." +
                                "\n{2}", tp.MaxAltitude, tp.CurrentAltitude, tp.Engine.About());

            tp.TakeOff();
            string unwoundTakeOffToyPlane = tp.TakeOff();
            string ToyPlaneUnwoundTakeOff = String.Format("{0} can't fly it's engine is not started.", tp.GetType());

            tp.WindUp();
            bool woundUpToyPlane = tp.isWoundUP;

            tp.TakeOff();
            string woundUpTakeOffToyPlane = tp.TakeOff();
            string ToyPlaneWoundUpTakeOff = String.Format("{0} is flying", tp.GetType());


            Assert.IsFalse(defaultToyPlaneIsWoundUp);
            Assert.AreEqual(unwoundToyPlaneInfo, ToyPlaneInfoUnWound);
            Assert.AreEqual(unwoundTakeOffToyPlane, ToyPlaneUnwoundTakeOff);
            Assert.IsTrue(woundUpToyPlane);
            Assert.AreEqual(woundUpTakeOffToyPlane, ToyPlaneWoundUpTakeOff);

        }

        [Test]
        public void ToyPlaneUnWind()
        {
            ToyPlane tp = new ToyPlane();

            bool defaultToyPlaneIsWoundUp = tp.isWoundUP;

            tp.WindUp();
            bool woundUpToyPlane = tp.isWoundUP;

            tp.TakeOff();
            string woundUpTakeOffToyPlane = tp.TakeOff();
            string ToyPlaneWoundUpTakeOff = String.Format("{0} is flying", tp.GetType());

            tp.UnWind();
            bool unwoundToyPlane = tp.isWoundUP;

            Assert.IsFalse(defaultToyPlaneIsWoundUp);
            Assert.IsTrue(woundUpToyPlane);
            Assert.AreEqual(woundUpTakeOffToyPlane, ToyPlaneWoundUpTakeOff);
            Assert.IsFalse(unwoundToyPlane);


        }
    }
}
