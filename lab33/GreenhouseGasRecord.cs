using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab33
{
    public class GreenhouseGasRecord
    {
        public int Year { get; set; }
        public Dictionary<string, double> GasValues { get; set; } = new Dictionary<string, double>();
    }
}
