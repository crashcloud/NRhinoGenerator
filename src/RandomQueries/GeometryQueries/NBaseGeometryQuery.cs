public abstract class NBaseGeometryQuery<T> : ISpatialQuery<T>
{
	public T Any() => Inside(new BoundingBox(short.MinValue, short.MinValue, short.MinValue,
								short.MaxValue, short.MaxValue, short.MaxValue));

	public virtual T DefaultOrNull() => default(T);

	public abstract T Inside(BoundingBox box);

	public abstract T Invalid();

	public T Negative() => Inside(new BoundingBox(short.MinValue, short.MinValue, short.MinValue, 0, 0, 0));

	public T Positive() => Inside(new BoundingBox(0, 0, 0, short.MaxValue, short.MaxValue, short.MaxValue));

}
