![License](https://img.shields.io/badge/license-MIT-8CBA04) [![NuGet](https://img.shields.io/nuget/v/OPPOSans.Medium.Avalonia)](https://www.nuget.org/packages/OPPOSans.Medium.Avalonia)

# OPPOSans Font for Avalonia
The OPPOSans Font released in 2019

# 💡 Install
Add nuget package:
```bash
dotnet add package OPPOSans.Medium.Avalonia
```

# 🚀 Quick Start
``` code
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
#if DEBUG
                .WithDeveloperTools()
#endif
                .WithOPPOSansMediumFont()
                .LogToTrace();
```