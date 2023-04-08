public class NBoxQuery : NBaseGeometryQuery<Box>
{
	public override Box Inside(BoundingBox bounds)
	{
		NUtils.IsValid(bounds);

		Point3d min = NRhino.Random.Geometry.NPoint3d.Inside(bounds);
		Point3d max = NRhino.Random.Geometry.NPoint3d.Inside(new BoundingBox(min, bounds.Max));
		return new Box(new BoundingBox(min, max));
	}

	public override Box Invalid() => Box.Unset;

}
