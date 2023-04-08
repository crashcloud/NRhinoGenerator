namespace NRhinoGenerator.Attributes
{

	/// <summary>Potential Requirements for the current Rhino Instance</summary>
	[Flags]
	public enum RhinoRequirements
	{
		None = 0,

		Headless = 0 << 1,
		RequiresHeaded = 0 << 2,

		Requires_7 = 0 << 3,
		Requires_8 = 0 << 4,
	}

	/// <summary>Defines Requirements for an NQuery to run successfully</summary>
	public sealed class RhinoStateAttribute : Attribute
	{
		public readonly RhinoRequirements Requirements;

		/// <summary>Attribute Constructor</summary>
		public RhinoStateAttribute(RhinoRequirements requirements)
		{
			Requirements = requirements;
		}

	}

}
