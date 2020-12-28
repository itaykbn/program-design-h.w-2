using System;
using System.Collections.Generic;
using System.Text;

namespace program_design_h.w_2
{
    class Carrier
    {
        public string ID { get; set; }
        public int EngieneCapacity { get; set; }

        public Carrier(string ID, int engieneCapacity)
        {
            this.ID = ID;
            EngieneCapacity = engieneCapacity;
        }


    }
}
