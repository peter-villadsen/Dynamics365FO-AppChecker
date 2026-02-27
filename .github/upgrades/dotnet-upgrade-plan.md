# .NET 8 Upgrade Plan

## Execution Steps

Execute steps below sequentially one by one in the order they are listed.

1. Validate that a .NET 8.0 SDK required for this upgrade is installed on the machine and if not, help to get it installed.
2. Ensure that the SDK version specified in global.json files is compatible with the .NET 8.0 upgrade.
3. Upgrade GraphExplorer.Core.netcore.csproj to .NET 8.0
4. Upgrade GraphExplorer.Common.netcore.csproj to .NET 8.0
5. Upgrade GraphExplorer.LocalizableResources.netcore.csproj to .NET 8.0
6. Upgrade GraphExplorer.SourceEditor.netcore.csproj to .NET 8.0
7. Upgrade GraphExplorer.DefaultRenderers.netcore.csproj to .NET 8.0
8. Upgrade GraphExplorer.Vis.netcore.csproj to .NET 8.0

## Settings

This section contains settings and data used by execution steps.

### Aggregate NuGet packages modifications across all projects

NuGet packages used across all selected projects or their dependencies that need version update in projects that reference them.

| Package Name                           | Current Version | New Version | Description                                   |
|:---------------------------------------|:---------------:|:-----------:|:----------------------------------------------|
| Newtonsoft.Json                        |     13.0.1      |    13.0.4   | Recommended for .NET 8.0                     |
| System.ComponentModel.Composition      |     5.0.0       |    10.0.3   | Deprecated version - upgrade recommended      |

### Project upgrade details

This section contains details about each project upgrade and modifications that need to be done in the project.

#### GraphExplorer.Core.netcore.csproj modifications

Project properties changes:
- Target framework should be changed from `netcoreapp3.1` to `net8.0`

NuGet packages changes:
- Newtonsoft.Json should be updated from `13.0.1` to `13.0.4` (*recommended for .NET 8.0*)

#### GraphExplorer.Common.netcore.csproj modifications

Project properties changes:
- Target framework should be changed from `netcoreapp3.1` to `net8.0-windows`

#### GraphExplorer.LocalizableResources.netcore.csproj modifications

Project properties changes:
- Target framework should be changed from `netcoreapp3.1` to `net8.0`

#### GraphExplorer.SourceEditor.netcore.csproj modifications

Project properties changes:
- Target framework should be changed from `netcoreapp3.1` to `net8.0`

#### GraphExplorer.DefaultRenderers.netcore.csproj modifications

Project properties changes:
- Target framework should be changed from `netcoreapp3.1` to `net8.0-windows`

NuGet packages changes:
- System.ComponentModel.Composition should be updated from `5.0.0` to `10.0.3` (*deprecated version - upgrade recommended*)

#### GraphExplorer.Vis.netcore.csproj modifications

Project properties changes:
- Target framework should be changed from `netcoreapp3.1` to `net8.0-windows`

NuGet packages changes:
- Newtonsoft.Json should be updated from `13.0.1` to `13.0.4` (*recommended for .NET 8.0*)