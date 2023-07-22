using PicaPico;

ThemeListener.ThemeChanged += OnThemeChanged;

static void OnThemeChanged(bool isDark)
{
    Console.WriteLine($"[{DateTime.Now}] System theme is change, current theme is {(isDark ? "Dark" : "Light")}");
}

Console.WriteLine($"[{DateTime.Now}] System theme is {(ThemeListener.IsDarkMode ? "Dark" : "Light")}");

Console.ReadLine();