using System;
using System.Collections.Generic;
using System.Text;

namespace program_design_h.w_2
{
    class Family
    {
        public string TripID { get; set; }
        public string LastName { get; set; }
        public int PeopleCount { get; set; }

        public Family(string tripID, string lastName, int peopleCount)
        {
            TripID = tripID;
            LastName = lastName;
            PeopleCount = peopleCount;
        }

    }
}
