using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace Morphius;

/// <summary>
/// Handles creating a new method based on the original and its replacements using IL
/// </summary>
internal class MethodBuilder
{
    private readonly MethodInfo _original;
    private readonly DynamicMethod _dynamicMethod;

    private readonly MorpherDetails[] _morpherDetails;
    private readonly ILGenerator _ilGenerator;
    
    internal MethodBuilder(MethodInfo original, MorpherDetails[] morpherDetails)
    {
        _original = original;
        _morpherDetails = morpherDetails;

        _dynamicMethod = GetDynamicMethod();
        _ilGenerator = _dynamicMethod.GetILGenerator();
    }

    private void Build()
    {
        // Build the new method
    }

    private DynamicMethod GetDynamicMethod()
    {
        return new DynamicMethod($"{_original.Name}_Patch", _original.ReturnType, _original.GetParameters().Select(parameter => parameter.ParameterType).ToArray());
    }
}