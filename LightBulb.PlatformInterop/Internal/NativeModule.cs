using System.Runtime.InteropServices;

namespace LightBulb.PlatformInterop.Internal;

internal static class NativeModule
{
    [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    private static extern nint GetModuleHandle(string? lpModuleName);

    public static nint CurrentHandle { get; } = GetModuleHandle(null);
}
