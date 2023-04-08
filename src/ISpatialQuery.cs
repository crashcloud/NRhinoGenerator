public interface ISpatialQuery<T> : IRhinoQuery<T>
{
	public abstract T Inside(BoundingBox box);
}
