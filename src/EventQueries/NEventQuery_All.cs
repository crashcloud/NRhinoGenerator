
using NRhinoGenerator.Attributes;

[RhinoStateAttribute(RhinoRequirements.RequiresHeaded)]
public partial class NEventQuery : IRhinoQuery<EventArgs>
{
	public EventArgs Any() => throw new NotImplementedException();
	public EventArgs Invalid() => throw new NotImplementedException();

	public EventArgs DefaultOrNull() => throw new NotImplementedException();

}
