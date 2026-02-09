namespace HandKit.Maui.MaterialIcons;

/// <summary>
/// Provides extension methods for adding Material Icons fonts to an IFontCollection.
/// </summary>
public static class FontExtensions
{
    /// <summary>
    /// Use Material Icons in the application.
    /// <code>
    /// Default name is "Icon"
    /// Add font to global. using: FontFamily="Icon" (Icon or IconFilled)
    /// </code>
    /// </summary>
    /// <param name="builder">The MauiAppBuilder instance.</param>
    /// <param name="name">The name of the font family. Default is "Icon".</param>
    /// <returns>The updated MauiAppBuilder instance.</returns>
    public static MauiAppBuilder UseMaterialIcons(this MauiAppBuilder builder, string name = "Icon")
    {
        builder.ConfigureFonts(fonts =>
        {
            fonts.AddFont("MaterialSymbolsOutlined.ttf", name);
            fonts.AddFont("MaterialSymbolsOutlinedFilled.ttf", $"{name}Filled");
        });
        return builder;
    }
}