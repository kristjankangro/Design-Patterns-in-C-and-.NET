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

  /*public class CyclesAllowedPolicy : ShapeDecoratorCyclePolicy
  {
    public override bool TypeAdditionAllowed(Type type, IList<Type> allTypes)
    {
      return true;
    }

    public override bool ApplicationAllowed(Type type, IList<Type> allTypes)
    {
      return true;
    }
  }*/

  /*public abstract class ShapeDecorator : Shape
  {
    protected internal readonly List<Type> types = new();
    protected internal Shape shape;

    public ShapeDecorator(Shape shape)
    {
      this.shape = shape;
      if (shape is ShapeDecorator sd)
        types.AddRange(sd.types);
    }
  }*/
  
  /*public abstract class ShapeDecorator<TSelf, TCyclePolicy> : ShapeDecorator
    where TCyclePolicy : ShapeDecoratorCyclePolicy, new()
  {
    protected readonly TCyclePolicy policy = new();
    
    public ShapeDecorator(Shape shape) : base(shape)
    { 
      if (policy.TypeAdditionAllowed(typeof(TSelf), types))
        types.Add(typeof(TSelf));
    }
  }*/
  
  // can determine one policy for all classes
  /*public class ShapeDecoratorWithPolicy<T>
    : ShapeDecorator<T, ThrowOnCyclePolicy>
  {
    public ShapeDecoratorWithPolicy(Shape shape) : base(shape)
    {
    }
  }*/

  // dynamic
  /*public class ColoredShape 
    : ShapeDecorator<ColoredShape, AbsorbCyclePolicy>
  {
    
    private readonly string color;

    public ColoredShape(Shape shape, string color) : base(shape)
    {
      this.color = color;
    }

    public override string AsString()
    {
      var sb = new StringBuilder($"{shape.AsString()}");

      if (policy.ApplicationAllowed(types[0], types.Skip(1).ToList())) 
        sb.Append($" has the color {color}");
      
      return sb.ToString();
    }
  }*/

  using _63.Models;

  var circle = new Circle(2);
  var colored1 = new ColoredShape(circle, "red");
  var colored2 = new ColoredShape(colored1, "blue");

  // Console.WriteLine(circle.AsString());
  // Console.WriteLine(colored1.AsString());
  Console.WriteLine(colored2.AsString());
