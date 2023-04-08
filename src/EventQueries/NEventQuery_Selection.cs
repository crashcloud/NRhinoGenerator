public partial class NEventQuery : IRhinoQuery<EventArgs>
{
	public RhinoObjectSelectionEventArgs Select() => throw new NotImplementedException();
	public RhinoObjectSelectionEventArgs Select(IEnumerable<Guid> elements) => throw new NotImplementedException();
	public RhinoObjectSelectionEventArgs DeSelect() => throw new NotImplementedException();
	public RhinoObjectSelectionEventArgs DeSelect(IEnumerable<Guid> elements) => throw new NotImplementedException();
	public RhinoDeselectAllObjectsEventArgs DeselectAll() => throw new NotImplementedException();
	public RhinoDeselectAllObjectsEventArgs DeselectAll(IEnumerable<Guid> elements) => throw new NotImplementedException();

}
