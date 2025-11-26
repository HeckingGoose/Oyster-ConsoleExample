using Oyster.Core.Interfaces.EngineImplementation;

namespace Oyster_ConsoleExample.Implementations.Types
{
    internal class ContinuePrompt : IShowAndHide
    {
        // Private Variables
        private bool _shown = false;

        // Constructor
        public ContinuePrompt() { }

        // Public Methods
        public void Hide()
        {
            _shown = false;
        }
        public void Show()
        {
            _shown = true;
        }

        // Accessors
        public bool Shown { get { return _shown; } }
    }
}
