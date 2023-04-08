public partial class NEventQuery : IRhinoQuery<EventArgs>
{

	public IEnumerable<RhinoObjectEventArgs> AddObjects(RhinoDoc doc, IEnumerable<GeometryBase> elements)
	{
		NUtils.CanBeRunInCurrentState(typeof(NEventQuery), doc);
		throw new NotImplementedException();
	}

	public IEnumerable<RhinoObjectEventArgs> AddObjects(RhinoDoc doc, int count)
	{
		NUtils.CanBeRunInCurrentState(typeof(NEventQuery), doc);
		throw new NotImplementedException();
	}

	public RhinoObjectEventArgs AddObject(RhinoDoc doc, GeometryBase element)
	{
		NUtils.CanBeRunInCurrentState(typeof(NEventQuery), doc);
		throw new NotImplementedException();
	}

	public RhinoObjectEventArgs AddObject(RhinoDoc doc)
	{
		NUtils.CanBeRunInCurrentState(typeof(NEventQuery), doc);
		throw new NotImplementedException();
	}

	private IEnumerable<Guid> AddObjects_Inner(RhinoDoc doc, int count)
	{
		for (int i = 0; i < count; i++)
		{
			yield return AddObject_Inner(doc);
		}
	}

	private IEnumerable<Guid> AddObjects_Inner(RhinoDoc doc, IEnumerable<GeometryBase> elements)
	{
		foreach (GeometryBase element in elements)
		{
			yield return AddObject_Inner(doc, element);
		}
	}

	private Guid AddObject_Inner(RhinoDoc doc, GeometryBase element)
	{
		return doc.Objects.Add(element);
	}

	private Guid AddObject_Inner(RhinoDoc doc) => AddObject_Inner(doc, NRhino.Random.Geometry.NLineCurve.Any());

}
