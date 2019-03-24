using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        List<calc> list = new List<calc>();
        /*
         * constructor --
         */
        public ComposedMission(string name)
        {
            this.Name = name;
        }


        public event EventHandler<double> OnCalculate;  // An Event of when a mission is activated

        public String Name { get; }
        public String Type { get { return "Composed"; } }

        public ComposedMission Add(calc function)
        {
            list.Add(function);
            return this;
        }

        public double Calculate(double value)
        {
            foreach (var calc in list)
            {
                if (calc != null)
                {
                    value = calc(value);
                }
            }            
            OnCalculate?.Invoke(this, value);
            return value;
        }
    }
}
