using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public delegate double calc(double val);

    public class FunctionsContainer
    {
        private Dictionary<string, calc> dictionary = new Dictionary<string, calc>();

        public calc this[string calcName]
        {
            get
            {
                if (!dictionary.ContainsKey(calcName))
                {
                    dictionary[calcName] = val => val;
                }
                return dictionary[calcName];
            }

            set { dictionary[calcName] = value; }
        }

        public List<string> getAllMissions()
        {
            return new List<string>(this.dictionary.Keys);
        }
    }
}
