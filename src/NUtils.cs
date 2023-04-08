﻿using System.Reflection;

using NRhinoGenerator.Attributes;

internal static class NUtils
{

	internal static void IsValid(Box box)
	{
		string errorMessage = "Given Box is not valid!";

		Assert.That(box.IsValid, Is.True, errorMessage);
		Assert.That(box.X.Min, Is.GreaterThan(box.X.Max), errorMessage);
		Assert.That(box.Y.Min, Is.GreaterThan(box.Y.Max), errorMessage);
		Assert.That(box.Z.Min, Is.GreaterThan(box.Z.Max), errorMessage);
	}

	internal static void IsValid(BoundingBox box)
	{
		string errorMessage = "Given Bounding Box is not valid!";
		Assert.That(box.IsValid, Is.True, errorMessage);
		Assert.That(box.Min.X, Is.GreaterThan(box.Max.X), errorMessage);
		Assert.That(box.Min.Y, Is.GreaterThan(box.Max.Y), errorMessage);
		Assert.That(box.Min.Z, Is.GreaterThan(box.Max.Z), errorMessage);
	}

	internal static void CanBeRunInCurrentState(Type type, RhinoDoc doc)
	{
		var state = type.GetCustomAttribute<RhinoStateAttribute>();
		var requirements = state.Requirements;

		if (requirements.HasFlag(RhinoRequirements.Requires_7))
		{
			Assert.That(RhinoApp.Version.Major, Is.EqualTo(7));
		}

		if (requirements.HasFlag(RhinoRequirements.Requires_8))
		{
			Assert.That(RhinoApp.Version.Major, Is.EqualTo(8));
		}

		if (requirements.HasFlag(RhinoRequirements.RequiresHeaded))
		{
			Assert.That(RhinoApp.IsRunningHeadless, Is.False);
		}

	}

}
