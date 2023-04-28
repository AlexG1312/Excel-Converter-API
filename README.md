# Excel-Converter

In order to run the application you will have to install both .NET 7 SDK and Runtime.

If you are using Visual Studio to run the application, please use the Launch profile provided in the launchSettings.json
If you are using command line to build and run the application, use "dotnet run --urls=http://localhost:7199/"

If you're getting NET::ERR_CERT_INVALID

Try this fix: 
In Chrome, type chrome://flags in the address bar.
Search for "Allow invalid certificates for resources loaded from localhost."
Enable this option.
