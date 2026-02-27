# .NET 8 Upgrade Plan

## Execution Steps

Execute steps below sequentially one by one in the order they are listed.

1. Validate that a .NET 8.0 SDK required for this upgrade is installed on the machine and if not, help to get it installed.
2. Ensure that the SDK version specified in global.json files is compatible with the .NET 8.0 upgrade.
3. Upgrade Socratex Explorer.netcore.csproj to .NET 8.0
4. Upgrade BaseXInterface.netcore.csproj to .NET 8.0

## Settings

This section contains settings and data used by execution steps.

### Aggregate NuGet packages modifications across all projects

NuGet packages used across all selected projects or their dependencies that need version update in projects that reference them.

| Package Name                           | Current Version | New Version | Description                                   |
|:---------------------------------------|:---------------:|:-----------:|:----------------------------------------------|
| Microsoft.ApplicationInsights          |     2.12.1      |    3.0.0    | Deprecated version - upgrade recommended      |
| System.Buffers                         |     4.5.0       |             | Package functionality included with framework |
| System.Numerics.Vectors                |     4.5.0       |             | Package functionality included with framework |
| System.Runtime.CompilerServices.Unsafe |     4.7.0       |    6.1.2    | Recommended for .NET 8.0                     |
| System.ValueTuple                      |     4.5.0       |             | Package functionality included with framework |

### Project upgrade details

This section contains details about each project upgrade and modifications that need to be done in the project.

#### Socratex Explorer.netcore.csproj modifications

Project properties changes:
- Target framework should be changed from `netcoreapp3.1` to `net8.0-windows`

NuGet packages changes:
- Microsoft.ApplicationInsights should be updated from `2.12.1` to `3.0.0` (*deprecated version*)
- System.Runtime.CompilerServices.Unsafe should be updated from `4.7.0` to `6.1.2` (*recommended for .NET 8.0*)
- System.Buffers should be removed (*package functionality included with framework*)
- System.Numerics.Vectors should be removed (*package functionality included with framework*)
- System.ValueTuple should be removed (*package functionality included with framework*)

#### BaseXInterface.netcore.csproj modifications

Project properties changes:
- Target framework should be changed from `netcoreapp3.1` to `net8.0-windows`