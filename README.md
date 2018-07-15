# Xamarin Project Templates
This is a repo containing project templates that streamline Xamarin development. We have refined these patterns over many projects, and have found a combination of libraries and strategies that have worked well for us. We also found ourselves adding the same libraries and the same architecure to every project, so we decided to create a template repo for our most used Xamarin development strategies. We hope that you find these as useful as we have!

Used in this repo:
- MvvmCross for its excellent cross-platform application
- Serilog for its versatility
- Xam.Plugin.Settings for its versatility when persisting settings data
- Newtonsoft.Json because ... It's Json.Net!
- .NET Standard

## Projects in this repo

### Native Cross Platform
This is a template for using Xamarin Native for iOS, Android and UWP. It is a complete QuickStart containing the basic implementations for logging, DI, ViewModel binding and general good practices enabling maximum code re-use of code accross your platforms.

## Using these templates
All templates are in a workable state and can be found in the /Exports folder.
To install these, simple copy the .zip file into your ProjectTemaplates folder and it will appear in VisualStudio when creating a new Project/Solution
