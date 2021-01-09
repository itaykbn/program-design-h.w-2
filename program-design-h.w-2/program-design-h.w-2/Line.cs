using Queue;
using System;
using System.Collections.Generic;
using System.Text;

namespace program_design_h.w_2
{
    class Line
    {
        public bool Open { get; set; }
        public int Length { get; set; }
        public MyQueue<string> Clients;

        public Line(bool open, int length)
        {
            Open = open;
            Length = length;
            Clients = new MyQueue<string>();
        }
    }
}
