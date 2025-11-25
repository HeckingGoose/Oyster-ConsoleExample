using Oyster.Core.Interfaces.EngineImplementation;
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
        public Color TextColour { get { return _colour; } set { _colour = value; } }
    }
}
