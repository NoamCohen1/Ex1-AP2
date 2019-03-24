using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        public calc single;

        public SingleMission(calc function, string name)
        {
            this.single = function;
            this.Name = name;
        }

        public event EventHandler<double> OnCalculate;  // An Event of when a mission is activated

        public String Name { get; }
        public String Type { get { return "Single"; } }

        public double Calculate(double value)
        {
            double calculation = value;
            if (single != null)
            {
                calculation = single(value);
            }
            OnCalculate?.Invoke(this, calculation);
            return calculation;
        }
    }
}
