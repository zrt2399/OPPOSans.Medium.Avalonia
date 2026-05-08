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