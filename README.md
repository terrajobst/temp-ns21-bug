# .NET Standard 2.1 Bug

## Repro

```
dotnet build
```

## Expected

Build succeeded

## Actual

```
Program.cs(11,37): error CS7069: Reference to type 'IAsyncEnumerable<>' claims
it is defined in 'netstandard', but it could not be found [console\console.csproj]
```