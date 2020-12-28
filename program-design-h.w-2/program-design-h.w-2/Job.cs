using System;
using System.Collections.Generic;
using System.Text;

namespace program_design_h.w_2
{
    class Job
    {
        public string WorkCode { get; set; }
        public int Deadline { get; set; }

        public Job(string workCode, int deadline)
        {
            WorkCode = workCode;
            Deadline = deadline;
        }
    }
}
