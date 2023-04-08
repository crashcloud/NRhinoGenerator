using NUnit.Framework;

using Rhino.Geometry;

public static class Utils
{

	public static void TestInside<T>(NBaseGeometryQuery<T> query)
	{
		Assert.IsNotNull(query);

		Assert.Throws<AssertionException>(
			() => query.Inside(new BoundingBox(Point3d.Origin,
												  new Point3d(-100, -100, -100)))
		);

		Assert.Throws<AssertionException>(
			() => query.Inside(BoundingBox.Empty)
		);

		Assert.Throws<AssertionException>(
			() => query.Inside(BoundingBox.Unset)
		);
	}

}
