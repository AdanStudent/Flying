using System;
using System.Collections.Generic;
using System.Text;

namespace Flying
{
    public abstract class AerialVehicle
    {
        #region Fields

        private Engine _engine;
        private int _currentAltitude;
        private bool _isFlying;
        private int _maxAltitude;

        public Engine Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        public int CurrentAltitude
        {
            get { return this._currentAltitude; }
            set { this._currentAltitude = value; }
        }

        public bool IsFlying
        {
            get { return this._isFlying; }
            set { this._isFlying = value; }
        }

        public int MaxAltitude
        {
            get { return this._maxAltitude; }
            set { this._maxAltitude = value; }
        }
        #endregion

        virtual public string About()
        {
            return String.Format("This OOPAerialVehicle has a max altitude of {0}" +
                "\nIt's current altitude is {1} ft." +
                "\n{2}", this.MaxAltitude, this.CurrentAltitude, this.Engine.About());
        }

        public AerialVehicle()
        {
            this.Engine = new Engine();
            this.CurrentAltitude = 0;
            this.IsFlying = false;

            if (this.Engine.IsStarted)
            {
                this.Engine.Stop();
            }
        }

        virtual public void FlyDown()
        {
            if (this.CurrentAltitude < 1000)
            {
                return;
            }
            else if (this.CurrentAltitude == 1000)
            {
                this.CurrentAltitude = 0;
            }
            else
            {
                this.CurrentAltitude -= 1000;
            }

            this.About();
        }

        virtual public void FlyDown(int HowManyFeet)
        {
            if (this.CurrentAltitude < HowManyFeet)
            {
                return;
            }
            else if (this.CurrentAltitude == HowManyFeet)
            {
                this.CurrentAltitude = 0;
            }
            else
            {
                this.CurrentAltitude -= 1000;
            }

            this.About();

        }

        virtual public void FlyUp()
        {
            if (this.CurrentAltitude == this.MaxAltitude || this.CurrentAltitude + 1000 > this.MaxAltitude)
            {
                return;
            }
            else
            {
                this.CurrentAltitude += 1000;
            }
            this.About();

        }

        virtual public void FlyUp(int HowManyFeet)
        {
            if (HowManyFeet + this.CurrentAltitude > this.MaxAltitude)
            {
                return;
            }
            else
            {
                this.CurrentAltitude += HowManyFeet;
            }

            this.About();

        }

        virtual protected string getEngineStartedString()
        {
            return "";
        }

        virtual public void StartEngine()
        {
            this.Engine.Start();
        }

        virtual public void StopEngine()
        {
            this.Engine.Stop();
        }

        virtual public string TakeOff()
        {
            if (this.Engine.IsStarted)
            {
                IsFlying = true;
                return String.Format("{0} is flying", this.GetType());
            }
            else
            {
                return String.Format("{0} can't fly it's engine is not started.", this.GetType());

            }
        }





    }
}
