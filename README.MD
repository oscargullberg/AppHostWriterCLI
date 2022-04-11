# AppHostWriter CLI
Simple CLI wrapper for [dotnet's app host writer](https://github.com/dotnet/runtime/tree/main/src/installer/managed/Microsoft.NET.HostModel/AppHost).

Created this because I needed to create app hosts from custom app host templates in a build chain and found no better way. 🙃

**Usage**: `dotnet run "{pathToCustomAppHostTemplate}" "{pathToOutputAppHost}" "{pathToDllToUse}" "{isGui=false}"`