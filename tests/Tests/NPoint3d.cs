using System;

using NUnit.Framework;

using Rhino.Geometry;

namespace Tests
{

	[TestFixture]
	public class NPoint3d_Tests
	{
		public const int TEST_COUNT = 10_000;

		public NPoint3d_Tests()
		{
			Assert.That(TEST_COUNT, Is.GreaterThan(10));
		}

		[Test]
		public void Any()
		{
			// Check that 90% are unique?

			for (int i = 0; i < TEST_COUNT; i++)
			{
				Point3d point = NRhino.Random.Geometry.NPoint3d.Any();
				Assert.That(point.IsValid, Is.True);
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
					Point3d point = NRhino.Random.Geometry.NPoint3d.Inside(bounds);

					Assert.That(bounds.Contains(point), Is.True);
				}
			}
		}

		[Test]
		public void Positive()
		{
			for (int i = 0; i < TEST_COUNT; i++)
			{
				Point3d point = NRhino.Random.Geometry.NPoint3d.Positive();
				Assert.That(point.IsValid, Is.True);

				Assert.That(point.X, Is.GreaterThanOrEqualTo(0));
				Assert.That(point.Y, Is.GreaterThanOrEqualTo(0));
				Assert.That(point.Z, Is.GreaterThanOrEqualTo(0));
			}
		}

		[Test]
		public void Negative()
		{
			for (int i = 0; i < TEST_COUNT; i++)
			{
				Point3d point = NRhino.Random.Geometry.NPoint3d.Negative();
				Assert.That(point.IsValid, Is.True);

				Assert.That(point.X, Is.LessThanOrEqualTo(0));
				Assert.That(point.Y, Is.LessThanOrEqualTo(0));
				Assert.That(point.Z, Is.LessThanOrEqualTo(0));
			}
		}

		[Test]
		public void InvalidIputs() => Utils.TestInside(NRhino.Random.Geometry.NPoint3d);

	}
}
