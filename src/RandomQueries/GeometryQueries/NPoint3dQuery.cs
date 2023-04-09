public class NPoint3dQuery : NBaseGeometryQuery<Point3d>
{

	/// <summary>A Random Point3d within the given boundingbox</summary>
	public override Point3d Inside(BoundingBox bounds)
	{
		NUtils.IsValid(bounds);

		double x = TestContext.CurrentContext.Random.NextDouble(bounds.Min.X, bounds.Max.X);
		double y = TestContext.CurrentContext.Random.NextDouble(bounds.Min.Y, bounds.Max.Y);
		double z = TestContext.CurrentContext.Random.NextDouble(bounds.Min.Z, bounds.Max.Z);

		return new Point3d(x, y, z);
	}

	public override Point3d Invalid() => Point3d.Unset;

}
