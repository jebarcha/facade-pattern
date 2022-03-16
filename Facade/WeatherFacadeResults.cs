using Facade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class WeatherFacadeResults
    {
        public int Fahrenheith { get; set; }
        public int Celsius { get; set; }
        public City City { get; set; }
        public State State { get; set; }
    }
}
