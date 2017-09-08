using System;
using System.Collections;
using System.Collections.Generic;


namespace Frontline
{
    public class ProblemTwo : ProblemBase
    {
        public ProblemTwo()
        {
            InputString = "My name is Albert McDonald.";
        }

        /// <summary>
        /// Processes the phrase.
        /// </summary>
        public void ProcessPhrase()
        {
            this.OutputString = StringHelper.ReverseWords(InputString);
        }

    }
}
