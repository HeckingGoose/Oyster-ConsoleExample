using Oyster.Core.Interfaces.Things;
using Oyster.Core.Types;
using System.Drawing;

namespace Oyster_ConsoleExample.Implementations.Types
{
    internal class TextField : ITextField
    {
        // Private Variables
        private string _text;
        private Color _colour;

        // Constructor
        public TextField(Color colour)
        {
            _text = string.Empty;
            _colour = colour;
        }

        // Public Methods
        public void Hide() { }
        public void Show() { }
        public void Clear()
        {
            _text = string.Empty;
        }

        // Accessors
        public string Text { get { return _text; } set { _text = value; } }
        public Colour TextColour { get { return _colour.ToOysterColour(); } set { _colour = value.ToSystemColour(); } }
    }
}
