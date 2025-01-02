namespace NRhinoGenerator;

public class NPoint2dQuery : NBaseGeometryQuery<Point2d>
{
	public override Point2d Inside(BoundingBox box)
	{
		NUtils.IsValid(box);

		double x = TestContext.CurrentContext.Random.NextDouble(box.Min.X, box.Max.X);
		double y = TestContext.CurrentContext.Random.NextDouble(box.Min.X, box.Max.X);

		return new Point2d(x, y);
	}

	public override Point2d Invalid() => Point2d.Unset;

}
