using Oyster.Core.AbstractTypes.Scene;
using Oyster.Core.Interfaces.Things;

namespace Oyster_ConsoleExample.Implementations.Scene
{
    internal class SceneScript : A_SceneScript
    {
        // Constructor
        public SceneScript(IShowAndHide[] thingsToBeHiddenMidConversation) : base(thingsToBeHiddenMidConversation, null) { }
    }
}
