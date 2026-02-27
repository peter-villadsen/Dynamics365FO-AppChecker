# .NET 8 Upgrade Plan

## Execution Steps

Execute steps below sequentially one by one in the order they are listed.

1. Validate that a .NET 8.0 SDK required for this upgrade is installed on the machine and if not, help to get it installed.
2. Ensure that the SDK version specified in global.json files is compatible with the .NET 8.0 upgrade.
3. Upgrade WorkflowLibrary\WorkflowLibrary.netcore.csproj to .NET 8.0
4. Upgrade BulkQuery\BulkQuery.netcore.csproj to .NET 8.0

## Settings

This section contains settings and data used by execution steps.

### Project upgrade details

This section contains details about each project upgrade and modifications that need to be done in the project.

#### WorkflowLibrary\WorkflowLibrary.netcore.csproj modifications

Project properties changes:
- Target framework should be changed from `netcoreapp3.1` to `net8.0`

#### BulkQuery\BulkQuery.netcore.csproj modifications

Project properties changes:
- Target framework should be changed from `netcoreapp3.1` to `net8.0`