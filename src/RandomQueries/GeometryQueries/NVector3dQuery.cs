public class NVector3dQuery : NBaseGeometryQuery<Vector3d>
{

	/// <summary>A Random Unit Vector3d</summary>
	public Vector3d Unit()
		=> Inside(new BoundingBox(-1, -1, -1, 1, 1, 1));

	/// <summary>A Random Point3d within the given boundingbox</summary>
	public override Vector3d Inside(BoundingBox bounds)
	{
		Assert.That(bounds.IsValid, Is.True);

		double x = TestContext.CurrentContext.Random.NextDouble(bounds.Min.X, bounds.Max.X);
		double y = TestContext.CurrentContext.Random.NextDouble(bounds.Min.Y, bounds.Max.Y);
		double z = TestContext.CurrentContext.Random.NextDouble(bounds.Min.Z, bounds.Max.Z);

		return new Vector3d(x, y, z);
	}

	public override Vector3d Invalid() => Vector3d.Unset;

}
