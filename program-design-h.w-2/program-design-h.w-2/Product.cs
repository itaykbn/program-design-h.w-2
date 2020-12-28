using System;
using System.Collections.Generic;
using System.Text;

namespace program_design_h.w_2
{
    class Product
    {
        public DateTime ExperationDate { get; set; }
        public string Name { get; set; }

        public Product(DateTime experationDate, string name)
        {
            ExperationDate = experationDate;
            Name = name;
        }
    }
}
