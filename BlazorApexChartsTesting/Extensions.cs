using System.Runtime.CompilerServices;

namespace BlazorApexChartsTesting;

public static class Extensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string ToJson(this object obj)
    => System.Text.Json.JsonSerializer.Serialize(obj);

}
