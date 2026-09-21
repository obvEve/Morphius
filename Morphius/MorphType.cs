namespace Morphius;

/// <summary>
/// The type of morph.
/// </summary>
public enum MorphType
{
    /// <summary>
    /// Before the original.
    /// </summary>
    Prefix,

    /// <summary>
    /// After the original.
    /// </summary>
    Postfix,

    /// <summary>
    /// Modifies the original with IL.
    /// </summary>
    Transpiler,
}