public class NObjectQuery : IRhinoQuery<RhinoObject>
{
	public CurveObject Curve() => throw new NotImplementedException();

	public MeshObject Mesh() => throw new NotImplementedException();

	public BrepObject Brep() => throw new NotImplementedException();
	public DimensionObject Dimension() => throw new NotImplementedException();

	public RhinoObject Any() => throw new NotImplementedException();

	public RhinoObject DefaultOrNull() => null;

	public RhinoObject Invalid() => null;
}
