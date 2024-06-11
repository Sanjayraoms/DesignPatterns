using PrototypePattern.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class PrototypeRegistry
    {
        Dictionary<string,Shape> prototypeRegistry = new Dictionary<string,Shape>();

        public PrototypeRegistry()
        {
            Circle circle = new Circle();
            circle.x = 10;
            circle.y = 20;
            circle.radius = 15;
            circle.color = "Green";
            this.PutRegistry("Green Circle",circle);

            Rectangle rectangle1 = new Rectangle();
            rectangle1.x = 10;
            rectangle1.y = 20;
            rectangle1.width = 15;
            rectangle1.height = 25;
            rectangle1.color = "Red";
            this.PutRegistry("Red Rectangle",rectangle1);

        }

        public void PutRegistry(string shapeName, Shape shape)
        {
            prototypeRegistry.Add(shapeName, shape);
        }

        public Shape GetShape(string shapeName)
        {
            return prototypeRegistry[shapeName].Clone();
        }
    }
}
