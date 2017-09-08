using System;
using System.Collections;
using System.Collections.Generic;

namespace Frontline
{
    public class ProblemBase
    {
        public string InputString { get; set; }
        public string OutputString { get; set; }
        public List<string> OutputCollection { get; set; }

        public ProblemBase()
        {
            this.OutputCollection = new List<string>();
        }
    }
}
