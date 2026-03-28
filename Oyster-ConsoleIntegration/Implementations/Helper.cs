using Oyster.Core.Types;
using System.Drawing;

namespace Oyster_ConsoleExample.Implementations
{
    public static class Helper
    {
        /// <summary>
        /// Converts a given Oyster colour into a System colour.
        /// </summary>
        /// <param name="colour"></param>
        /// <returns></returns>
        public static Color ToSystemColour(this Colour colour)
        {
            return Color.FromArgb(colour.ByteAlpha, colour.ByteRed, colour.ByteGreen, colour.ByteBlue);
        }
        /// <summary>
        /// Converts a given System colour into an Oyster colour.
        /// </summary>
        public static Colour ToOysterColour(this Color colour)
        {
            return new Colour
                (
                    colour.R,
                    colour.G,
                    colour.B,
                    colour.A
                );
        }
    }
}
