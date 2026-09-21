namespace Morphius;

/// <summary>
/// Contains information about a morph, think of the individual patch types in Harmony (e.g. each Prefix, Postfix, Transpiler be part of this)
/// </summary>
public sealed class MorpherDetails
{
    /// <summary>
    /// Gets the <see cref="MorphType"/> this is going to do.
    /// </summary>
    public readonly MorphType Type;
}