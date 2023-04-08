public class NPoint2dQuery : NBaseGeometryQuery<Point2d>
{
	public override Point2d Inside(BoundingBox bounds)
	{
		NUtils.IsValid(bounds);

		double x = TestContext.CurrentContext.Random.NextDouble(bounds.Min.X, bounds.Max.X);
		double y = TestContext.CurrentContext.Random.NextDouble(bounds.Min.X, bounds.Max.X);

		return new Point2d(x, y);
	}

	public override Point2d Invalid() => Point2d.Unset;

}
