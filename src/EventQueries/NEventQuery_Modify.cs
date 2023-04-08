public partial class NEventQuery : IRhinoQuery<EventArgs>
{
	public RhinoModifyObjectAttributesEventArgs Modify(ObjectAttributes newAttributes) => throw new NotImplementedException();
	public RhinoModifyObjectAttributesEventArgs Modify(IEnumerable<Guid> elements) => throw new NotImplementedException();
	public RhinoModifyObjectAttributesEventArgs Modify() => throw new NotImplementedException();

}
