public partial class NEventQuery : IRhinoQuery<EventArgs>
{
	public RhinoObjectEventArgs DeleteObjects(IEnumerable<Guid> elements) => throw new NotImplementedException();
	public RhinoObjectEventArgs DeleteObjects(int count) => throw new NotImplementedException();
	public RhinoObjectEventArgs DeleteObject(Guid element) => throw new NotImplementedException();
	public RhinoObjectEventArgs DeleteObject() => throw new NotImplementedException();

}
