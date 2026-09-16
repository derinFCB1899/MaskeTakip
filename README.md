# MaskeTakip

A C# learning project that uses a mask-distribution example to explore interfaces, constructor injection, and SOAP service integration. The repository also includes console exercises covering collections, methods, and value/reference behavior.

## Project structure

| Project | Purpose |
| --- | --- |
| `Entities` | The `Person` model. |
| `Business` | Applicant and supplier interfaces, service implementations, and a generated SOAP client. |
| `Workaround` | Console entry point and learning exercises. |

`PttManager` accepts an `IApplicantService` through its constructor. `PersonManager` implements that interface and calls a Turkish identity-verification SOAP service. The result determines which mask-distribution message is printed.

## Build and run

Requires the **.NET 8 SDK**, Git, and NuGet access. All three projects target `net8.0`.

```sh
git clone https://github.com/derinFCB1899/MaskeTakip.git
cd MaskeTakip
dotnet restore MaskeTakip.sln
dotnet build MaskeTakip.sln --no-restore
```

The entry point calls `pttManager.GiveMask(person2)`, which contacts the external SOAP service. The supplied `person2` is incomplete, so a successful verification is not an expected demo outcome. For offline study, comment out that call before running:

```sh
dotnet run --project Workaround/Workaround.csproj
```

Use synthetic data for learning and keep real identity details out of source control. External service availability and access requirements have not been revalidated.

## Scope and limitations

- This is a learning exercise with console output; it has no database, web interface, or persistent distribution records.
- `PersonManager.ApplyForMask` is empty and `GetList` returns `null`.
- `ForeignerManager` methods throw `NotImplementedException`.
- The SOAP call blocks on an asynchronous result and has no application-level error handling.
- No automated test project is included.

The commands match the checked-in solution and project paths. A clean build and runtime session have not been revalidated for this documentation update.
