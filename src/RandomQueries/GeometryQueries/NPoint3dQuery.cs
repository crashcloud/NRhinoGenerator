namespace NRhinoGenerator;

public class NPoint3dQuery : NBaseGeometryQuery<Point3d>
{

	/// <summary>A Random Point3d within the given boundingbox</summary>
	public override Point3d Inside(BoundingBox box)
	{
		NUtils.IsValid(box);

		double x = TestContext.CurrentContext.Random.NextDouble(box.Min.X, box.Max.X);
		double y = TestContext.CurrentContext.Random.NextDouble(box.Min.Y, box.Max.Y);
		double z = TestContext.CurrentContext.Random.NextDouble(box.Min.Z, box.Max.Z);

		return new Point3d(x, y, z);
	}

	public override Point3d Invalid() => Point3d.Unset;

}
