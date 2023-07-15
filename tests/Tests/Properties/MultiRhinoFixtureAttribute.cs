public class MultiRhinoFixtureAttribute : RhinoFixtureAttribute
{

	public MultiRhinoFixtureAttribute()
	{
#if NET48
		RhinoVersion version = RhinoVersion.v7;
#endif

#if NET5_0_OR_GREATER
		RhinoVersion version = RhinoVersion.v8;
#endif

		var options = new FixtureOptions
		{
			Version = version,
		};
		Init(options);
	}

}
