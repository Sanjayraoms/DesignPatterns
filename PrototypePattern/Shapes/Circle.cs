using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Shapes
{
    public class Circle : Shape
    {
        public int radius;
        public Circle()
        {

        }

        public Circle(Circle circle) : base(circle)
        {
            if (circle is not null)
            {
                this.radius = circle.radius;
            }
        }
        public override Shape Clone()
        {
            return new Circle(this);
        }

        public override bool Equals(object? obj)
        {
            if(obj is not Circle) return false;
            Circle other = obj as Circle;
            return other.radius == radius;
        }
    }
}
