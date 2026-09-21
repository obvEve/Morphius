using System;
using System.Reflection;

namespace Morphius;

/// <summary>
/// Attribute used to define something as a morpher.
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public sealed class MorphAttribute : Attribute
{
    private const BindingFlags Flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
    
    public readonly MethodInfo Method;
    public readonly MorphType MorphType;
    /*public readonly MethodType MethodType; // Easy support for getters, setters, etc*/
    
    public MorphAttribute(Type targetType, string targetMethod, MorphType morphType, params Type[] methodParameters)
    {
        Method = targetType.GetMethod(targetMethod, Flags, null, methodParameters, null) ?? throw new MissingMethodException(targetType.FullName, targetMethod);
        MorphType = morphType;
    }
}