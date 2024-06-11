// See https://aka.ms/new-console-template for more information
using PrototypePattern;
using PrototypePattern.Shapes;

Console.WriteLine("Hello, World!");

List<Shape> shapes = new List<Shape>();
List<Shape> shapeCopy = new List<Shape>();

Circle Circle = new Circle();
Circle.x = 5;
Circle.y = 10;
Circle.radius = 5;
Circle.color = "Green";
shapes.Add(Circle);

Circle circle2 = (Circle)Circle.Clone();
shapes.Add(circle2);

Rectangle rectangle = new Rectangle();
rectangle.x = 5;
rectangle.y = 10;
rectangle.height = 15;
rectangle.width = 20;
rectangle.color = "Red";
shapes.Add(rectangle);

Rectangle rectangle2 = (Rectangle)rectangle.Clone();
shapes.Add(rectangle);

//CloneandCompare(shapes, shapeCopy);

PrototypeRegistry prototypeRegistry = new PrototypeRegistry();
Shape s1 = prototypeRegistry.GetShape("Green Circle");
Shape s2 = prototypeRegistry.GetShape("Red Rectangle");
Shape s3 = prototypeRegistry.GetShape("Red Rectangle");

if (s1!= s2 && !s1.Equals(s2))
{
	Console.WriteLine("Green Circle != Red Rectangle");
}
if (s2 != s3)
{
	Console.WriteLine("Objects are not the same");
	if (s2.Equals(s3))
	{
		Console.WriteLine("But Objects are equal");
	}
}
Console.ReadLine();

static void CloneandCompare(List<Shape> shapes, List<Shape> shapesCopy)
{
	foreach (Shape shape in shapes)
	{
		shapesCopy.Add(shape.Clone());
	}
	for (int i = 0; i < shapes.Count; i++)
	{
		if (shapes[i] != shapesCopy[i])
		{
			Console.WriteLine(i+" : Objects are not the same");
		}
		if (shapes[i].Equals(shapesCopy[i]))
		{
			Console.WriteLine(i + " : But Objects are identical");
		}
	}
}
