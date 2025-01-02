namespace NRhinoGenerator;

public static class NRhino
{
	public const double TOLERANCE = 0.01;

	public static NRandomQuery Random { get; set; }
	public static NEventQuery Event { get; set; }

	static NRhino()
	{
		Random = new();
		Event = new();
	}

}
