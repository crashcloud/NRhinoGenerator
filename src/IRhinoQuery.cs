public interface IRhinoQuery<T> : ITestQuery
{
	public abstract T Any();
	public abstract T Invalid();
	public abstract T DefaultOrNull();
}
