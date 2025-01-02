namespace NRhinoGenerator;

public class NRandomQuery
{
	public NGeometryQuery Geometry { get; set; }
	// Settings
	// Math?
	// Units?
	// View?
	// Object?
	public NObjectQuery NObject { get; set; }

	internal NRandomQuery()
	{
		Geometry = new();
		NObject = new();
	}

}
