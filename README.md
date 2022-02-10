# DeciliterVsCupConverterLibrary

DeciliterVsCupConverterLibrary is a C# library for converting from deciliter to cup and from cup to deciliter.

## Installation

Use the Manage NuGet Packages on VisualStudio to install DeciliterVsCupConverterLibrary.

```bash
Install-Package DeciliterVsCupConverterLibrary -Version 1.0.0.27
```

## Example

```csharp
using BakingConvertLibrary;

# returns '0,8333 Cup'
var Factory = new Factory();
var Deciliter = Factory.GetMeasurment("Deciliter");
Console.WriteLine(Deciliter.Convert(2));

# returns '2 Deciliter'
var Cup = Factory.GetMeasurment("Cup");
Console.WriteLine(Cup.Convert(5));

```



## License
[MIT](https://choosealicense.com/licenses/mit/)
