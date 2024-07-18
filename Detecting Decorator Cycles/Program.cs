// See https://aka.ms/new-console-template for more information

/*public class AbsorbCyclePolicy : ShapeDecoratorCyclePolicy
  {
    public override bool TypeAdditionAllowed(Type type, IList<Type> allTypes)
    {
      return true;
    }

    public override bool ApplicationAllowed(Type type, IList<Type> allTypes)
    {
      return !allTypes.Contains(type);
    }
  }*/




// can determine one policy for all classes



// dynamic


var circle = new Circle(2);
var colored1 = new ColoredShape(circle, "red");
var colored2 = new ColoredShape(colored1, "blue");

// Console.WriteLine(circle.AsString());
// Console.WriteLine(colored1.AsString());
Console.WriteLine(colored2.AsString());