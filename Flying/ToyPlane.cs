using System;
using System.Collections.Generic;
using System.Text;

namespace Flying
{
    public class ToyPlane : Airplane
    {
        public ToyPlane()
        {
            MaxAltitude = 50;
            isWoundUP = false;
        }

        public bool isWoundUP;

        public override string About()
        {
            return base.About();
        }

        public string getWindUpString()
        {
            return "";
        }

        public override void StartEngine()
        {
            base.StartEngine();
        }

        public override string TakeOff()
        {
            if (isWoundUP)
            {
                this.Engine.Start();
                return base.TakeOff();
            }
            else
            {
                return base.TakeOff();
            }
        }

        public void UnWind()
        {
            this.isWoundUP = false;
            this.Engine.Stop();
        }

        public void WindUp()
        {
            this.isWoundUP = true;
        }

    }
}
