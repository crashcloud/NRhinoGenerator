public class NMeshQuery : NBaseGeometryQuery<Mesh>
{
	public override Mesh Inside(BoundingBox box)
	{
		Box meshBox = NRhino.Random.Geometry.NBox.Inside(box);
		Assert.That(meshBox.IsValid, Is.True);

		Mesh mesh = Mesh.CreateFromBox(meshBox, 2, 2, 2);
		Assert.That(mesh.IsValid, Is.True);

		return mesh;
	}

	public override Mesh Invalid() => new Mesh();

}
