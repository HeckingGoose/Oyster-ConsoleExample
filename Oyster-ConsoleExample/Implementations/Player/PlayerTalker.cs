using Oyster.Core.AbstractTypes.Player;

namespace Oyster_ConsoleExample.Implementations.Player
{
    internal class PlayerTalker : A_PlayerTalker
    {
        // Constructor
        public PlayerTalker(A_SpeechDisplay speechDisplay) : base(speechDisplay) { }
    }
}
