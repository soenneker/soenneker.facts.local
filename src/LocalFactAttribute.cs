using Soenneker.Utils.Environment;
using Xunit;

namespace Soenneker.Facts.Local;

/// <summary>
/// An xUnit Fact attribute derivation that when used to decorate a method it skips the test if used within a pipeline <para/>
/// Replace with [Fact] if you wish to run the test in all environments
/// </summary>
public sealed class LocalFactAttribute : FactAttribute
{
    private const string _defaultSkip = "LocalFact";

    public string? Reason { get; set; }

    public LocalFactAttribute()
    {
        if (!EnvironmentUtil.IsPipeline)
            return;

        if (Reason != null)
            Skip = $"{_defaultSkip}:{Reason}";
        else
            Skip = _defaultSkip;
    }
}