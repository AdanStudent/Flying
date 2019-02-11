using System;
using System.Collections.Generic;
using System.Text;

namespace Flying
{
    public class Airport
    {
        protected int MaxVehicles;
        private List<AerialVehicle> Vehicles;
        private string _airportCode;

        public string AirportCode
        {
            get { return _airportCode; }
            protected set { _airportCode = value; }
        }

        public Airport(string Code)
        {
            this.AirportCode = Code;
        }

        public Airport(string Code, int Max_Vehicles)
        {
            this.AirportCode = Code;
            this.MaxVehicles = Max_Vehicles;
        }

        public string AllTakeOff()
        {
            return "";
        }

        /// <summary>
        /// Landing AerialVehicles should FlyDown to the ground, set IsFlying to false and be added to the Airports Vehicles collection if the Airport is not full
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public string Land(AerialVehicle a)
        {
            return "";
        }

        /// <summary>
        /// Landing AerialVehicles should FlyDown to the ground, set IsFlying to false and be added to the Airports Vehicles collection if the Airport is not full
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public string Land(List<AerialVehicle> landing)
        {
            return "";
        }

        public string TakeOff(AerialVehicle a)
        {
            return "";
        }

    }
}
