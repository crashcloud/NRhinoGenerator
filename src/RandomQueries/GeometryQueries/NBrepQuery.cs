public class NBrepQuery : NBaseGeometryQuery<Brep>
{
	public override Brep Inside(BoundingBox box)
	{
		NUtils.IsValid(box);

		Box brepBox = NRhino.Random.Geometry.NBox.Inside(box);
		NUtils.IsValid(brepBox);

		Brep brep = Brep.CreateFromBox(brepBox);
		Assert.That(brep.IsValid, Is.True);

		return brep;
	}

	public override Brep Invalid() => new Brep();

}
