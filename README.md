# DeciliterVsCupConverterLibrary

DeciliterVsCupConverterLibrary is a C# library for converting from deciliter to cup and from cup to deciliter.

## Installation

Use the Manage NuGet Packages on VisualStudio to install DeciliterVsCupConverterLibrary.

```bash
Install-Package DeciliterVsCupConverterLibrary -Version 1.0.0.27
```

## Example

Here I give you 3 examples of how you can convert the measurements in 3 different ways:

### Example 1

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

### Example 2
```csharp
Deciliter dl=5;
Cup cup=dl;

```
### Example 3
```csharp
Cup cup = (Deciliter)5;
```



## License
[MIT](https://choosealicense.com/licenses/mit/)
