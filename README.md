# OutputManager library for .Net

OutputManager is a simple library managing the look of the console output.

## Usage examples

Display an error.

```c#
OutputManager om = new OutputManager();
OutputManager.WriteLine_Status("Test Error Message", true);
```

## Getting Started

###### Package Manager:

```
Install-Package OutputManager -Version 1.0.0
```

###### .NET CLI:

```
dotnet add package OutputManager --version 1.0.0
```

###### PackageReference:

```
<PackageReference Include="OutputManager" Version="1.0.0" />
```

###### Package CLI:

```
paket add OutputManager --version 1.0.0
```


### Beta packages ###
Unstable NuGet packages that track the master branch of this repository are available at
[https://ci.appveyor.com/nuget/octokit-net](https://ci.appveyor.com/nuget/octokit-net)

In Xamarin Studio you can find this option under the project's context menu: **Add | Add Packages...***.

## Documentation

Documentation is available at http://octokitnet.readthedocs.io/en/latest/.

## Build

Octokit is a single assembly designed to be easy to deploy anywhere.

To clone and build it locally click the "Clone in Desktop" button above or run the 
following git commands.

```
git clone git@github.com:octokit/Octokit.net.git Octokit
cd Octokit
```

To build the libraries, run the following command:

Windows: `.\build.ps1`

Linux/OSX: `./build.sh`

## Contribute

Visit the [Contributor Guidelines](https://github.com/octokit/octokit.net/blob/master/CONTRIBUTING.md)
for more details. All contributors are expected to follow our
[Code of Conduct](https://github.com/octokit/octokit.net/blob/master/CODE_OF_CONDUCT.md).

## Problems?

If you find an issue with our library, please visit the [issue tracker](https://github.com/octokit/octokit.net/issues)
and report the issue.

Please be kind and search to see if the issue is already logged before creating
a new one. If you're pressed for time, log it anyways.

When creating an issue, clearly explain

* What you were trying to do.
* What you expected to happen.
* What actually happened.
* Steps to reproduce the problem.

Also include any other information you think is relevant to reproduce the
problem.

## Related Projects

 - [ScriptCs.OctoKit](https://github.com/hnrkndrssn/ScriptCs.OctoKit) - a [script pack](https://github.com/scriptcs/scriptcs/wiki/Script-Packs) to use Octokit in scriptcs 
 - [ScriptCs.OctokitLibrary](https://github.com/ryanrousseau/ScriptCs.OctokitLibrary) - a [script library](https://github.com/scriptcs/scriptcs/wiki/Script-Libraries) to use Octokit in scriptcs

## Copyright and License

Copyright 2017 GitHub, Inc.

Licensed under the [MIT License](https://github.com/octokit/octokit.net/blob/master/LICENSE.txt)
