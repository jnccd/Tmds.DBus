# Documentation

https://tmds.github.io/Tmds2.DBus/

# CI Packages

CI NuGet packages are built from the `main` branch and pushed to the https://www.myget.org/F/tmds/api/v3/index feed.

To add a package using `dotnet`:

```
dotnet add package --source https://www.myget.org/F/tmds/api/v3/index.json --prerelease Tmds2.DBus.Protocol
```

# Further Reading

- [D-Bus](docs/dbus.md): Short overview of D-Bus.
- [Tmds2.DBus Modelling](docs/modelling.md): Describes how to model D-Bus types in C# for use with Tmds2.DBus.
- [Tmds2.DBus.Tool](docs/tool.md): Documentation of dotnet dbus tool.
- [How-to](docs/howto.md): Documents some (advanced) use-cases.
- [Tmds2.DBus.Protocol](docs/protocol.md): Documentation of the protocol library.
