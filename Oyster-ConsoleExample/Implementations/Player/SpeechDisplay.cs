using Oyster.Core.AbstractTypes.Player;
using Oyster.Core.Interfaces.EngineImplementation;

namespace Oyster_ConsoleExample.Implementations.Player
{
    internal class SpeechDisplay : A_SpeechDisplay
    {
        public SpeechDisplay(
            ITextField nameText,
            ITextField mainText,
            IShowAndHide nameTextBacking,
            IShowAndHide mainTextBacking,
            IShowAndHide prompt
            ) : base(nameText, mainText, nameTextBacking, mainTextBacking, prompt)
        {
        }
    }
}
