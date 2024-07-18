public class ShapeDecoratorWithPolicy<T> : ShapeDecorator<T, ThrowOnCyclePolicy>
{
    public ShapeDecoratorWithPolicy(Shape shape) : base(shape)
    {
    }
}