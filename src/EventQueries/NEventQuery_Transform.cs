public partial class NEventQuery : IRhinoQuery<EventArgs>
{
	public RhinoTransformObjectsEventArgs Transform(GeometryBase geometry, Transform transform) => throw new NotImplementedException();
	public RhinoTransformObjectsEventArgs Transform(Guid rhinoId, Transform transform) => throw new NotImplementedException();
	public RhinoTransformObjectsEventArgs Transform(Transform transform) => throw new NotImplementedException();
	public RhinoTransformObjectsEventArgs Transform() => throw new NotImplementedException();

}
