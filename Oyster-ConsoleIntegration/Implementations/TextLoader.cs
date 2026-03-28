using Oyster.Core.AbstractTypes;

namespace Oyster_ConsoleExample.Implementations
{
    internal class TextLoader : A_BackgroundAssetLoader<string>
    {
        // Private Variables
        private string _path;

        // Constructor
        public TextLoader(string path) { _path = path; }

        // Public Methods
        public override void BeginAssetLoad()
        {
            try
            {
                // Try to load file
                _asset = File.ReadAllText(_path);

                // We must have succeeded so raise success
                InvokeOnAssetLoad(LoadResult.Succeeded);
            }
            catch (Exception e)
            {
                // On fail raise event
                InvokeOnAssetLoad(LoadResult.Failed, e.ToString());
            }
        }
    }
}
