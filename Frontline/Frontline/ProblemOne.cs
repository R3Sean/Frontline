using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Frontline
{
    public class ProblemOne : ProblemBase
    {

        public ProblemOne()
        {
            //set the input string in constructor
            this.InputString = "(id,created,employee(id,firstname,employeeType(id), lastname),location)";
            //initialize the output collection
            this.OutputCollection = StringHelper.UnboxParenthesis(this.InputString);
        }

        /// <summary>
        /// Gets the Output Collection for this class
        /// </summary>
        /// <param name="alphabetize">If set to <c>true</c> alphabetize.</param>
        public void GetOutputCollection(bool alphabetize)
        {
            if (alphabetize)
            {
                this.OutputCollection = StringHelper.UnboxParenthesis(this.InputString).OrderBy(o => o).ToList();

            }

            string dash = string.Empty;
            while (OutputCollection.Where(o => o.Contains("(")).Any())
            {
                dash = dash + "-";
                string straggler = OutputCollection.FirstOrDefault(o => o.Contains("("));
                int index = OutputCollection.FindIndex(o => o.Contains("("));
                if (straggler != null)
                {
                    string keeper = StringHelper.GetLeader(straggler);
                    string collection = StringHelper.GetNestedString(straggler);
                    OutputCollection[index] = keeper;
                    GetNestedArray(index, collection, dash, alphabetize);


                }


            }
        }

        /// <summary>
        /// Gets the nested array.
        /// </summary>
        /// <param name="ct">Ct.</param>
        /// <param name="nestedString">Nested string.</param>
        /// <param name="dashes">Dashes.</param>
        /// <param name="alphabetize">If set to <c>true</c> alphabetize.</param>
        public void GetNestedArray(int ct, string nestedString, string dashes, bool alphabetize)
        {
            List<string> pump = new List<string>();
            pump = StringHelper.UnboxParenthesis(nestedString);
            if (alphabetize)
            {
                pump = pump.OrderBy(a => a).ToList();
            }
            foreach (var s in pump)
            {
                ct++;
                OutputCollection.Insert(ct, dashes + s);
            }

        }



    }
}
