The files repro-1.cs and repro-2.cs take 2 formatting passes before they are correctly formatted.

you can test this by doing

```
dotnet format dotnet-format-repro.sln
git add -A
dotnet format dotnet-format-repro.sln
git status
```