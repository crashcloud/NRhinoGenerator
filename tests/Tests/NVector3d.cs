using System;

using NUnit.Framework;

using Rhino.Geometry;

namespace Tests
{

	[MultiRhinoFixtureAttribute]
	public class NVector3d_Tests
	{
		public const int TEST_COUNT = 10_000;

		public NVector3d_Tests()
		{
			Assert.That(TEST_COUNT, Is.GreaterThan(10));
		}

		[Test]
		public void Any()
		{
			// Check that 90% are unique?

			for (int i = 0; i < TEST_COUNT; i++)
			{
				Vector3d vector = NRhino.Random.Geometry.NVector3d.Any();
				Assert.That(vector.IsValid, Is.True);
			}
		}

		[Test]
		public void Unit()
		{
			for (int i = 0; i < TEST_COUNT; i++)
			{
				Vector3d vector = NRhino.Random.Geometry.NVector3d.Unit();
				Assert.That(vector.IsValid, Is.True);
				Assert.That(vector.X, Is.GreaterThanOrEqualTo(-1).And.LessThanOrEqualTo(1));
				Assert.That(vector.Y, Is.GreaterThanOrEqualTo(-1).And.LessThanOrEqualTo(1));
				Assert.That(vector.Z, Is.GreaterThanOrEqualTo(-1).And.LessThanOrEqualTo(1));
			}
		}

		[Test]
		public void Inside()
		{
			int testCount = (int)Math.Sqrt(TEST_COUNT);

			for (int i = 0; i < testCount; i++)
			{
				var bounds = NRhino.Random.Geometry.NBox.Any().BoundingBox;
				Assert.That(bounds.IsValid, Is.True);

				for (int j = 0; j < TEST_COUNT; j++)
				{
					Vector3d vector = NRhino.Random.Geometry.NVector3d.Inside(bounds);
					Assert.That(vector.X, Is.GreaterThan(bounds.Min.X).And.LessThan(bounds.Max.X));
					Assert.That(vector.Y, Is.GreaterThan(bounds.Min.Y).And.LessThan(bounds.Max.Y));
					Assert.That(vector.Z, Is.GreaterThan(bounds.Min.Z).And.LessThan(bounds.Max.Z));
				}
			}
		}

		[Test]
		public void Positive()
		{
			for (int i = 0; i < TEST_COUNT; i++)
			{
				Vector3d vector = NRhino.Random.Geometry.NVector3d.Positive();
				Assert.That(vector.IsValid, Is.True);

				Assert.That(vector.X, Is.GreaterThanOrEqualTo(0));
				Assert.That(vector.Y, Is.GreaterThanOrEqualTo(0));
				Assert.That(vector.Z, Is.GreaterThanOrEqualTo(0));
			}
		}

		[Test]
		public void Negative()
		{
			for (int i = 0; i < TEST_COUNT; i++)
			{
				Vector3d vector = NRhino.Random.Geometry.NVector3d.Negative();
				Assert.That(vector.IsValid, Is.True);

				Assert.That(vector.X, Is.LessThanOrEqualTo(0));
				Assert.That(vector.Y, Is.LessThanOrEqualTo(0));
				Assert.That(vector.Z, Is.LessThanOrEqualTo(0));
			}
		}

		[Test]
		public void InvalidIputs() => Utils.TestInside(NRhino.Random.Geometry.NVector3d);

	}

}
