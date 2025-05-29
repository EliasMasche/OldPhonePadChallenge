# OldPhonePadChallenge

A console application that emulates the typing of an old phone pad

## Description

The `OldPhonePad` converts the numerical input of an old phone pad into a text message as typed; it emulates the behavior of an old phone pad.

## OldPhonePad Method

Works with the following mapping of numerical keys and corresponding letter values

| Key | Characters |
|-----|------------|
| 1   | &')        |
| 2   | ABC        |
| 3   | DEF        |
| 4   | GHI        |
| 5   | JKL        |
| 6   | MNO        |
| 7   | PQRS       |
| 8   | TUV        |
| 9   | WXYZ       |
| 0   | Space    |
| #   | Send Input       |
| *   | Backspace    |

### Example

```c#
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("4433555 555666 0 6 666 6#");
        Console.WriteLine(OldPhonePad("4433555 555666 0 6 666 6#")));
    }
}
```

### Output

> HELLO MOM

## Unit Tests

The project includes unit tests using `MSUnit` that are part of `Microsoft.NET.Testk.Sdk` and `MSTest`, running `dotnet restore` for building or before running will .NET handles the packages.

## How to Run Locally

Download locally with `git clone` or download the source code of the repo manually
```
git clone https://
```

Run in a terminal
```
cd OldPhonePadChallenge
dotnet run
```

Run in an IDE
```
From Visual Studio or JetBrains Rider
Open OldPhonePadChallenge.sln
Build or Run
```

Run the Unit Tests in a terminal
```
cd OldPhonePadChallengeUnitTest
dotnet test
```

Run the Unit Tests in an IDE
```
From Visual Studio or JetBrains Rider
Open OldPhonePadChallengeUnitTest.csproj
Build or Run the Unit Test
```

## License
This project is licensed under the MIT License. See "LICENSE.txt" for more information.