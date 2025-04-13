using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game.Core;

/// <summary>
///     Provides utility methods for working with textures in a graphical application.
/// </summary>
public static class TextureUtilities
{
    /// <summary>
    ///     Calculates the scale factor needed to resize a texture to the specified desired width and height.
    /// </summary>
    /// <param name="texture">The texture to calculate the scale factor for.</param>
    /// <param name="desiredWidth">The desired width to scale the texture to.</param>
    /// <param name="desiredHeight">The desired height to scale the texture to.</param>
    /// <returns>A <see cref="Vector2" /> representing the scale factors for the X and Y dimensions.</returns>
    public static Vector2 CalculateScaleFactor(Texture2D texture, float desiredWidth, float desiredHeight)
    {
        float scaleX = desiredWidth / texture.Width;
        float scaleY = desiredHeight / texture.Height;
        return new Vector2(scaleX, scaleY);
    }
}
