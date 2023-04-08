public class NGeometryQuery
{
	public NPoint3dQuery NPoint3d { get; set; }
	public NVector3dQuery NVector3d { get; set; }
	public NLineCurveQuery NLineCurve { get; set; }
	public NBoxQuery NBox { get; set; }
	public NMeshQuery NMesh { get; set; }
	public NBrepQuery NBrep { get; set; }

	public NGeometryQuery()
	{
		NPoint3d = new();
		NVector3d = new();
		NLineCurve = new();
		NBox = new();
		NMesh = new();
		NBrep = new();
	}

}
