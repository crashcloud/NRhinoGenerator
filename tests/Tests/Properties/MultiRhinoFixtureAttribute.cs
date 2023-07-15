using System.Collections.Generic;

public class MultiRhinoFixtureAttribute : RhinoFixtureAttribute
{

	public MultiRhinoFixtureAttribute()
	{
#if NET48
		string version = "Rhino 7";
#endif

#if NET5_0_OR_GREATER
		string version = "Rhino 8 WIP";
#endif

		var options = new FixtureOptions
		{
			Version = RhinoVersion.v7,
			AssemblyPaths = new List<string>
			{
				$"C:\\Program Files\\{version}\\System",
			}
		};
		Init(options);
	}

}
