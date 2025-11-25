
using Oyster.Core;
using Oyster_ConsoleExample.Implementations.Character;
using Oyster_ConsoleExample.Implementations.Player;
using Oyster_ConsoleExample.Implementations.Scene;
using Oyster_ConsoleExample.Implementations.Types;
using System.Diagnostics;

internal class Program
{
    private static bool _running = false;

    private static void Main(string[] args)
    {

        Console.WriteLine("Making Example objects...");
        TextField nameText = new TextField(System.Drawing.Color.White);
        TextField mainText = new TextField(System.Drawing.Color.White);
        DummyShowAndHide dummy = new DummyShowAndHide();
        SpeechDisplay sDisplay = new SpeechDisplay(nameText, mainText, dummy, dummy);
        PlayerTalker pTalker = new PlayerTalker(sDisplay);
        CharacterData cData = new CharacterData("Paul", System.Drawing.Color.White, 0.1f, "Scripts/Test.osf");
        CharacterTalker cTalker = new CharacterTalker(cData);
        SceneScript sScript = new SceneScript(Array.Empty<DummyShowAndHide>());
        Console.WriteLine("Finished!");

        Console.WriteLine("Waiting on chat to start...");
        OysterMain.OnScriptReady += Start;
        OysterMain.StartChat(sScript, pTalker, cTalker);

        // Wait until running gets set
        while (!_running) { }

        // Loop while running
        float deltaTime = 1f / 60;
        while (_running)
        {
            // Make new t
            Stopwatch sw = Stopwatch.StartNew();


            // Tell Oyster to run
            OysterMain.Update(deltaTime);

            // Clear screen
            Console.Clear();

            // Draw name text
            Console.WriteLine(nameText.Text);
            Console.WriteLine();

            // Draw main text
            Console.WriteLine(mainText.Text);

            // Wait a bit
            Thread.Sleep(200);

            // Take time
            deltaTime = (float)sw.ElapsedMilliseconds / 1000;
        }
    }

    private static void Start() { _running = true; }
}