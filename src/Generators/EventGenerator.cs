using System.Threading.Tasks;

using Rhino;
using Rhino.Display;

public static partial class EventGenerator
{

	public static async Task<ViewEventArgs> GetViewEventArgs(RhinoDoc rhinoDoc)
	{
		ViewEventArgs viewArgs = null;

		RhinoView.Modified += (sender, args) =>
		{
			viewArgs = args;
		};

		Point3d randomPoint = NRhino.Random.Geometry.NPoint3d.Any();
		rhinoDoc.Views.ActiveView.ActiveViewport.SetCameraLocation(randomPoint, true);

		while (null == viewArgs)
		{
			await Task.Delay(100);
		}

		EventHandler<ViewEventArgs> _event = null;
		RhinoView.Modified -= _event;

		return viewArgs;
	}

}
