# .NET 8 Upgrade Report

## Project target framework modifications

| Project name                                   | Old Target Framework | New Target Framework | Commits                   |
|:-----------------------------------------------|:--------------------:|:---------------------:|---------------------------|
| GraphExplorer.Core.netcore.csproj             | netcoreapp3.1        | net8.0                | 94e1bd3b                  |
| GraphExplorer.Common.netcore.csproj           | netcoreapp3.1        | net8.0-windows        | ba6b0ce4                  |
| GraphExplorer.LocalizableResources.netcore.csproj | netcoreapp3.1    | net8.0                | b4fb4d3d                  |
| GraphExplorer.SourceEditor.netcore.csproj     | netcoreapp3.1        | net8.0-windows        | 1230362c, 381c2a7c        |
| GraphExplorer.DefaultRenderers.netcore.csproj | netcoreapp3.1        | net8.0-windows        | 6de2c1df                  |
| GraphExplorer.Vis.netcore.csproj              | netcoreapp3.1        | net8.0-windows        | 8c15580e                  |

## NuGet Packages

| Package Name                           | Old Version | New Version | Commit ID                 |
|:---------------------------------------|:-----------:|:-----------:|---------------------------|
| Newtonsoft.Json                        | 13.0.1      | 13.0.4      | d0559744, 33c584a6        |
| System.ComponentModel.Composition      | 5.0.0       | 10.0.3      | 5e24bca4                  |

## All commits

| Commit ID  | Description                                              |
|:-----------|:---------------------------------------------------------|
| 60b482c8   | Commit upgrade plan                                      |
| 94e1bd3b   | Upgrade GraphExplorer.Core target framework             |
| d0559744   | Update Newtonsoft.Json to 13.0.4                        |
| ba6b0ce4   | Update .NET target framework to net8.0-windows          |
| b4fb4d3d   | Update Graph Explorer resources to .NET 8.0             |
| 1230362c   | Update .NET target framework to net8.0                  |
| 381c2a7c   | Store final changes for step 'Upgrade GraphExplorer.SourceEditor.netcore.csproj to .NET 8.0' |
| 6de2c1df   | Update .NET target to net8.0-windows                    |
| 5e24bca4   | Update System.ComponentModel.Composition to v10.0.3     |
| 8c15580e   | Update GraphExplorer to .NET 8.0                        |
| 33c584a6   | Update Newtonsoft.Json to version 13.0.4                |

## Project feature upgrades

### GraphExplorer.Core.netcore.csproj

Here is what changed for the project during upgrade:

- **Target Framework Upgrade**: Successfully upgraded from .NET Core 3.1 to .NET 8.0
- **NuGet Package Updates**: Updated Newtonsoft.Json from 13.0.1 to 13.0.4 for enhanced JSON serialization features and bug fixes

### GraphExplorer.Common.netcore.csproj

Here is what changed for the project during upgrade:

- **Target Framework Upgrade**: Successfully upgraded from .NET Core 3.1 to .NET 8.0-windows to support Windows-specific features

### GraphExplorer.LocalizableResources.netcore.csproj

Here is what changed for the project during upgrade:

- **Target Framework Upgrade**: Successfully upgraded from .NET Core 3.1 to .NET 8.0 for improved runtime performance and modern language features

### GraphExplorer.SourceEditor.netcore.csproj

Here is what changed for the project during upgrade:

- **Target Framework Upgrade**: Successfully upgraded from .NET Core 3.1 to .NET 8.0-windows
- **WPF Support Added**: Added UseWPF=true property to support AvalonEdit and other WPF controls properly

### GraphExplorer.DefaultRenderers.netcore.csproj

Here is what changed for the project during upgrade:

- **Target Framework Upgrade**: Successfully upgraded from .NET Core 3.1 to .NET 8.0-windows
- **NuGet Package Updates**: Updated System.ComponentModel.Composition from deprecated version 5.0.0 to 10.0.3

### GraphExplorer.Vis.netcore.csproj

Here is what changed for the project during upgrade:

- **Target Framework Upgrade**: Successfully upgraded from .NET Core 3.1 to .NET 8.0-windows
- **Legacy AssemblyInfo Removal**: Removed traditional AssemblyInfo.cs file and modernized to use SDK-style assembly metadata
- **NuGet Package Updates**: Updated Newtonsoft.Json from 13.0.1 to 13.0.4

## Next steps

- Build and test the upgraded solution to ensure all functionality works correctly with .NET 8.0
- Consider updating any remaining NuGet packages to their latest versions compatible with .NET 8.0
- Review and optimize code to take advantage of new .NET 8.0 performance features and language improvements
- Update deployment scripts and CI/CD pipelines to target .NET 8.0 runtime