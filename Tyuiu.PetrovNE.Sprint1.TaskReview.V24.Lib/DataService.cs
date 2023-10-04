using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PetrovNE.Sprint1.TaskReview.V24.Lib
{
    public class DataService : ISprint1Task7V24
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(( 1 + Math.Cos( (Math.Sqrt(x + 1) ) ) ) / ( Math.Sin(15 * y - 4) ), 3);
        }
    }
}
