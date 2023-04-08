# NRhinoGenerator

NRhinoGenerator is an open source .NET library for generating Rhino geometry primitives such as points, lines, circles, arcs, curves, surfaces, meshes, and more. The library is designed to be consumed as a NuGet package and supports Rhino 7 and 8 (Rhino 8 only on Mac) on .NET Framework 4.8 and .NET 7.0.

## Features

- Generate Rhino geometry primitives with various input parameters and edge cases.
- Define custom constraints and rules for generated geometries.
- Export generated geometries to Rhino files or other formats for visualization and analysis.
- Run tests automatically and report any errors or failures.

## Requirements

- Valid Rhino 7 license.
- .NET Framework 4.8 or .NET 7.0.
- NRhinoGenerator NuGet package.

## Installation

1. Install the NRhinoGenerator NuGet package from the NuGet Gallery or using the package manager console:

```
Install-Package NRhinoGenerator
```


## Usage

The NRhinoGenerator library provides various methods and classes to control the generation and testing process. For example:

``` csharp
NRhino.Random.Geometry.NVector3d.Any();
NRhino.Random.Geometry.NPoint3d.Positive();
NRhino.Random.Geometry.NMesh.Inside(bounds);
```

## Contribution

Contributions are welcome! If you want to add new features, fix bugs, or improve the documentation, feel free to create a pull request or an issue.

## License

NRhinoGenerator is released under the MIT License