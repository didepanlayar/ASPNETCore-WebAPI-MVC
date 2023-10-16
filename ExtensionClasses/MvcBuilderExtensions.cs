namespace AdvWorksAPI.ExtensionClasses;

public static class MvcBuilderExtensions
{
    public static IMvcBuilder ConfigureJsonOptions(this IMvcBuilder builder)
    {
        // Configure JSON Options
        return builder.AddJsonOptions(options =>
        {
            // Make all property names start with upper-case
            options.JsonSerializerOptions.PropertyNamingPolicy = null;
            // Ignore "readonly" fields
            options.JsonSerializerOptions.IgnoreReadOnlyProperties = true;
        }).AddXmlSerializerFormatters();
    }
}
