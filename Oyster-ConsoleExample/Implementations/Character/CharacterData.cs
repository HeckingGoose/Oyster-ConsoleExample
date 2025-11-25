using Oyster.Core.AbstractTypes;
using Oyster.Core.AbstractTypes.Character;
using System.Drawing;

namespace Oyster_ConsoleExample.Implementations.Character
{
    internal class CharacterData : A_CharacterData
    {
        private string _scriptPath;

        // Constructor
        public CharacterData(
            string name,
            Color nameColour,
            float timeBetweenCharacters,
            string scriptPath
            ) : base(name, nameColour, timeBetweenCharacters) { _scriptPath = scriptPath; }

        // Public Methods
        public override A_BackgroundAssetLoader<string> BeginScriptLoad()
        {
            // Make asset loader and return it
            return new TextLoader(_scriptPath);
        }
    }
}
