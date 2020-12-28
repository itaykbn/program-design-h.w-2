using Queue;
using System;
using System.Collections.Generic;
using System.Text;

namespace program_design_h.w_2
{
    class DriveAndHike
    {
        public MyQueue<Trip> Trips;

        public DriveAndHike(MyQueue<Trip> trips)
        {
            if (trips == null)
            {
                Trips = new MyQueue<Trip>();
            }
            else
            {
                Trips = trips;
            }
        }

        public string RegisterTrip(Trip trip)
        {
            Trips.Insert(trip);
            return trip.ID + " registerd";
        }

        public double TotalIncome(string ID)
        {
            Trip trip = GetTrip(ID);
            MyQueue<Family> temp = null;
            double sum = 0;
            while (!trip.Families.IsEmpty())
            {
                Family family = trip.Families.Remove();
                temp.Insert(family);
                sum += family.PeopleCount * trip.CostPerHiker;
            }
            while (!temp.IsEmpty())
            {
                trip.Families.Insert(temp.Remove());
            }

            return sum;
        }

        private Trip GetTrip(string ID)
        {
            MyQueue<Trip> temp = new MyQueue<Trip>();
            Trip wantedTrip = null;
            while (!Trips.IsEmpty())
            {
                Trip trip = Trips.Remove();
                temp.Insert(trip);
                if (trip.ID == ID)
                {
                    wantedTrip = trip;
                }
            }

            while (!temp.IsEmpty())
            {
                Trips.Insert(temp.Remove());
            }
            return wantedTrip;
        }

        public double IncomeForPeriodOfTime(DateTime date1, DateTime date2)
        {
            double sum = 0;
            MyQueue<Trip> tempTrips = null;
            while (!Trips.IsEmpty())
            {
                Trip trip = Trips.Remove();
                tempTrips.Insert(trip);

                if (trip.Date >= date1 && trip.Date <= date2)
                {
                    MyQueue<Family> tempFamilies = null;
                    while (!trip.Families.IsEmpty())
                    {
                        Family family = trip.Families.Remove();
                        tempFamilies.Insert(family);
                        sum += family.PeopleCount * trip.CostPerHiker;
                    }
                    while (!tempFamilies.IsEmpty())
                    {
                        trip.Families.Insert(tempFamilies.Remove());
                    }
                }
            }
            while (!tempTrips.IsEmpty())
            {
                Trips.Insert(tempTrips.Remove());
            }

            return sum;
        }
    }
}
