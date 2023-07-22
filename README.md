# ThemeListener [![NuGet](https://img.shields.io/nuget/v/PicaPico.ThemeListener.svg)](https://nuget.org/packages/PicaPico.ThemeListener) [![Build AutoUpdate](https://github.com/HeHang0/ThemeListener/actions/workflows/library.nuget.yml/badge.svg)](https://github.com/HeHang0/ThemeListener/actions/workflows/library.nuget.yml)

ThemeListener is a library for monitoring changes in the dark or light mode of Windows system.

## Usage

-------

ThemeListener is available as [NuGet package](https://www.nuget.org/packages/PicaPico.ThemeListener).

```csharp
using PicaPico;

PicaPico.ThemeListener.ThemeChanged += OnThemeChanged;

static void OnThemeChanged(bool isDark)
{
    Console.WriteLine($"System theme is change, current theme is {(isDark ? "Dark" : "Light")}");
}

Console.WriteLine($"System theme is {(ThemeListener.ThemeListener.IsDarkMode ? "Dark" : "Light")}");
```

## Repository

-------

The source code for ThemeListener is hosted on GitHub. You can find it at the following URL: [https://github.com/HeHang0/ThemeListener](https://github.com/HeHang0/ThemeListener)

## License

-------

ThemeListener is released under the MIT license. This means you are free to use and modify it, as long as you comply with the terms of the license.
