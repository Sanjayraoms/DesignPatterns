using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.BuilderComponents
{
    public class GPSNavigator
    {
        public string Navigation { get; private set; }

        public GPSNavigator(string navigation)
        {
            Navigation = navigation;
        }
    }
}
