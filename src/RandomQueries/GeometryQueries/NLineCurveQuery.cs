public class NLineCurveQuery : NBaseGeometryQuery<LineCurve>
{

	/// <summary>A Random LineCurve within the given boundingbox</summary>
	public override LineCurve Inside(BoundingBox bounds)
	{
		NUtils.IsValid(bounds);

		Point3d firstPoint = NRhino.Random.Geometry.NPoint3d.Inside(bounds);
		Point3d secondPoint = firstPoint;

		while (firstPoint.DistanceTo(secondPoint) < NRhino.TOLERANCE)
		{
			secondPoint = NRhino.Random.Geometry.NPoint3d.Inside(bounds);
		}

		return new LineCurve(firstPoint, secondPoint);
	}

	public override LineCurve Invalid() => new LineCurve(NRhino.Random.Geometry.NPoint3d.Invalid(),
														 NRhino.Random.Geometry.NPoint3d.Invalid());

}
