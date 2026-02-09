# HandKit.Maui.MaterialIcons

![icon](https://handityo.my.id/icon_nuget.png)

[![NuGet](https://img.shields.io/nuget/v/HandKit.Maui.MaterialIcons)](https://www.nuget.org/packages/HandKit.Maui.MaterialIcons)
[![.NET MAUI](https://img.shields.io/badge/.NET%20MAUI-512BD4?style=flat&logo=dotnet&label=.NET%20MAUI)](https://dotnet.microsoft.com/en-us/apps/maui)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

[![Platform](https://img.shields.io/badge/Platform-Android-green)](https://www.android.com/)
[![Platform](https://img.shields.io/badge/Platform-iOS-blue)](https://www.apple.com/ios/ios-16/)
[![Platform](https://img.shields.io/badge/Platform-Windows-0078D7)](https://www.microsoft.com/en-us/windows)
[![Platform](https://img.shields.io/badge/Platform-macOS-00203a)](https://www.apple.com/macos/)

**A comprehensive Material Icons font library for .NET MAUI applications.**

## Overview

This library provides a seamless way to integrate Google's Material Icons (Outlined and Filled) into your .NET MAUI projects.

## Features

*   **Easy Integration:** Simple registration method in `MauiProgram.cs`.
*   **Dual Styles:** Includes both **Outlined** and **Filled** variants of Material Symbols.
*   **Customizable Alias:** Support for custom font family aliases to avoid conflicts.
*   **Broad Compatibility:** Supports Android, iOS, macOS, and Windows.

## Installation

Install the package via NuGet:

```bash
Install-Package HandKit.Maui.MaterialIcons
```

## Usage

### 1. Register the Fonts

In your `MauiProgram.cs`, call `UseMaterialIcons()` on the `MauiAppBuilder`:

```csharp
using HandKit.Maui.MaterialIcons; // Add this namespace

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMaterialIcons() // <-- Register the fonts here
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        return builder.Build();
    }
}
```

By default, this registers the fonts with the alias `"Icon"`.

### 2. Use in XAML

You can use the fonts by referencing the `FontFamily`.

#### Default Aliases:
*   **Outlined:** `Icon`
*   **Filled:** `IconFilled`

```xml
<!-- Outlined Icon -->
<Label Text="notifications" 
       FontFamily="Icon" 
       FontSize="32" />

<!-- Filled Icon -->
<Label Text="notifications" 
       FontFamily="IconFilled" 
       FontSize="32" />
```

### Advanced Usage (Custom Alias)

If you prefer a different font family name, you can pass it to the `UseMaterialIcons` method:

```csharp
// Registers "MyIcon" and "MyIconFilled"
builder.UseMaterialIcons("MyIcon");
```

Then in XAML:

```xml
<Label Text="home" FontFamily="MyIcon" FontSize="32" />
<Label Text="home" FontFamily="MyIconFilled" FontSize="32" />
```

## Contributing

Contributions are welcome! Please open an issue or submit a pull request.

## Contact

If you have any questions or suggestions, please feel free to contact me at andyapin@gmail.com
