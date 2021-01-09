using System;
using System.Collections.Generic;
using System.Text;

namespace program_design_h.w_2
{
    class Supermarket
    {
        public Line[] Lines = new Line[10];

        public Supermarket()
        {
            for (int i = 0; i < Lines.Length; i++)
            {
                Lines[i] = new Line(true, 0);
            }
        }

        public void AddToSuperMarketQueue(string name) 
        {
            Line shortestLine = new Line(true, int.MaxValue);
            bool anyOpen = false;
            foreach (var line in Lines)
            {
                if (line.Open)
                {
                    anyOpen = true;
                    if(line.Length < shortestLine.Length)
                    {
                        shortestLine = line;
                    }
                }
            }
            if (anyOpen)
            {
                shortestLine.Length += 1;
                shortestLine.Clients.Insert(name);
            }
            else
            {
                Console.WriteLine("no lines available sorry");
            }
        }

        public void ArrangeAClosedLine(int lineNum)
        {
            Line line = Lines[lineNum - 1];
            while (!line.Clients.IsEmpty())
            {
                AddToSuperMarketQueue(line.Clients.Remove());
            }
        }
    }
}
