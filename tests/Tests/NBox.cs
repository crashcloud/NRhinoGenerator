using System;

using NUnit.Framework;

using Rhino.Geometry;

namespace Tests
{

	[MultiRhinoFixtureAttribute]
	public class NBox_Tests
	{
		public const int TEST_COUNT = 10_000;

		public NBox_Tests()
		{
			Assert.That(TEST_COUNT, Is.GreaterThan(10));
		}

		[Test]
		public void Any()
		{
			// Check that 90% are unique?

			for (int i = 0; i < TEST_COUNT; i++)
			{
				Box box = NRhino.Random.Geometry.NBox.Any();
				NUtils.IsValid(box);
			}
		}

		[Test]
		public void Inside()
		{
			int testCount = (int)Math.Sqrt(TEST_COUNT);

			for (int i = 0; i < testCount; i++)
			{
				var innerBox = NRhino.Random.Geometry.NBox.Any();
				NUtils.IsValid(innerBox);
				var bounds = innerBox.BoundingBox;

				for (int j = 0; j < TEST_COUNT; j++)
				{
					Box box = NRhino.Random.Geometry.NBox.Inside(bounds);
					NUtils.IsValid(box);

					Assert.That(bounds.Contains(box.BoundingBox, false), Is.True);
				}
			}
		}

		[Test]
		public void Positive()
		{
			for (int i = 0; i < TEST_COUNT; i++)
			{
				Box box = NRhino.Random.Geometry.NBox.Positive();
				NUtils.IsValid(box);

				Assert.That(box.X.Min, Is.GreaterThanOrEqualTo(0));
				Assert.That(box.Y.Min, Is.GreaterThanOrEqualTo(0));
				Assert.That(box.Z.Min, Is.GreaterThanOrEqualTo(0));
			}
		}

		[Test]
		public void Negative()
		{
			for (int i = 0; i < TEST_COUNT; i++)
			{
				Box box = NRhino.Random.Geometry.NBox.Negative();
				NUtils.IsValid(box);

				Assert.That(box.X.Max, Is.LessThanOrEqualTo(0));
				Assert.That(box.Y.Max, Is.LessThanOrEqualTo(0));
				Assert.That(box.Z.Max, Is.LessThanOrEqualTo(0));
			}
		}

		[Test]
		public void InvalidIputs() => Utils.TestInside(NRhino.Random.Geometry.NBox);

	}
}
