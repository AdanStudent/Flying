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
            this.Vehicles = new List<AerialVehicle>();
        }

        public Airport(string Code, int Max_Vehicles)
        {
            this.AirportCode = Code;
            this.MaxVehicles = Max_Vehicles;
            this.Vehicles = new List<AerialVehicle>();
        }

        public string AllTakeOff()
        {
            string takeOff = "";

            if (Vehicles.Count > 0)
            {
                for (int i = 0; i < Vehicles.Count-1; i++)
                {
                    takeOff += String.Format("{0} is taking off\n", Vehicles[i].GetType());
                }
            }

            this.Vehicles.Clear();

            return takeOff;
        }

        public string TakeOff(AerialVehicle a)
        {
            string takeOff = "";

            takeOff += String.Format("{0} is taking off\n", a.GetType());

            this.Vehicles.Remove(a);

            return takeOff;
        }

        /// <summary>
        /// Landing AerialVehicles should FlyDown to the ground, set IsFlying to false and be added to the Airports Vehicles collection if the Airport is not full
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public string Land(AerialVehicle a)
        {
            //check if AerialVehicle is at ground level
            if (a.CurrentAltitude == 0)
            {
                //and if the Airport isn't full then add it
                if (Vehicles.Count-1 < MaxVehicles)
                {
                    //set it's IsFlying to false
                    a.IsFlying = false;
                    Vehicles.Add(a);
                    return String.Format("{0} has landed", a.GetType());
                }
            }

            return String.Format("{0} was unable to land", a.GetType());
        }

        /// <summary>
        /// Landing AerialVehicles should FlyDown to the ground, set IsFlying to false and be added to the Airports Vehicles collection if the Airport is not full
        /// </summary>
        /// <param name="Landing"></param>
        /// <returns></returns>
        public string Land(List<AerialVehicle> Landing)
        {
            string takeOff = "\n";

            //check if AerialVehicle is at ground level
            foreach (var a in Landing)
            {
                if (a.CurrentAltitude == 0)
                {
                    //and if the Airport isn't full then add it
                    if (Vehicles.Count - 1 < MaxVehicles)
                    {
                        //set it's IsFlying to false
                        a.IsFlying = false;
                        Vehicles.Add(a);
                        takeOff += String.Format("{0} has landed\n", a.GetType());
                    }
                    else
                    {
                        takeOff += String.Format("{0} was unable to land\n", a.GetType());
                    }
                }
            }

            return takeOff;

        }


    }
}
