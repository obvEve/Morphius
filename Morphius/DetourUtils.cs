using System.Reflection;
using System.Runtime.CompilerServices;

namespace Morphius;

/// <summary>
/// Utilities for handling Detouring.
/// </summary>
public static class DetourUtils
{
    /// <summary>
    /// Detours the method and replaces it with another.
    /// </summary>
    /// <param name="from"></param>
    /// <param name="to"></param>
    public static void Detour(MethodInfo from, MethodInfo to)
    {
        // Force JIT
        RuntimeHelpers.PrepareMethod(from.MethodHandle);
        RuntimeHelpers.PrepareMethod(to.MethodHandle);
    }
}