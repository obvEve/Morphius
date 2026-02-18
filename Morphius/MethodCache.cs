using System.Collections.Generic;
using System.Reflection;

namespace Morphius;

internal class MethodCache
{
    private static Dictionary<MethodInfo, MethodCache> _cache = new();

    private MethodInfo _original;
    private MethodInfo _detour;
    
    internal MethodCache(MethodInfo method, MethodInfo detour)
    {
        _original = method;
        _detour = detour;
        _cache.Add(method, this);
    }
}