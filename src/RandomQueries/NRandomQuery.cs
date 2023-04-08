public class NRandomQuery
{
	public NGeometryQuery Geometry { get; set; }
	// Settings
	// Math?
	// Units?
	// View?
	// Object?
	public NObjectQuery Object { get; set; }

	internal NRandomQuery()
	{
		Geometry = new();
		Object = new();
	}

}
