namespace NRhinoGenerator;

public class NBoxQuery : NBaseGeometryQuery<Box>
{
	public override Box Inside(BoundingBox box)
	{
		NUtils.IsValid(box);

		Point3d min = NRhino.Random.Geometry.NPoint3d.Inside(box);
		Point3d max = NRhino.Random.Geometry.NPoint3d.Inside(new BoundingBox(min, box.Max));
		return new Box(new BoundingBox(min, max));
	}

	public override Box Invalid() => Box.Unset;

}
