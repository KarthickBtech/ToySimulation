# ToySimulation


Build and run
To build and run the sample, change to the src/NewTypes directory and execute the following command:

dotnet run
dotnet run builds the sample and runs the output executable. It implicitly runs dotnet restore (see note) to restore the dependencies of the sample. If you're using .NET Core 1.0 or .NET Core 1.1 instead of .NET Core 2.0 or a later version, you have to run dotnet restore yourself.

To run the tests, change to the test/NewTypesTests directory and execute the following two commands:

dotnet build
dotnet test
dotnet test runs the configured tests.

dotnet build will follow the dependency on the NewTypesMsBuild project and build both the app and unit tests projects. It implicitly runs dotnet restore on .NET Core 2.0 and later versions. If you're using .NET Core 1.0 or .NET Core 1.1, you first have to run dotnet restore yourself.


ctrl+ b - Build
f5 - Run the appication
