namespace NRhinoGenerator.Attributes
{

	/// <summary>Potential Requirements for the current Rhino Instance</summary>
	[Flags]
	public enum RhinoRequirements
	{
		None = 0,

		Headless = 1 << 1,
		RequiresHeaded = 1 << 2,

		Requires7 = 1 << 3,
		Requires8 = 1 << 4,
	}

	/// <summary>Defines Requirements for an NQuery to run successfully</summary>
	/// <remarks>Attribute Constructor</remarks>
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class RhinoStateAttribute(RhinoRequirements requirements) : Attribute
	{
		public RhinoRequirements Requirements { get; } = requirements;
	}

}
