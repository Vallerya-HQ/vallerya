using Obsydian.Core;
using Obsydian.Core.ECS;
using Obsydian.Core.Logging;

namespace Vallerya.Game;

public static class Program
{
    public static void Main()
    {
        var engine = new Engine(new EngineConfig
        {
            Title = "Vallerya",
            WindowWidth = 1280,
            WindowHeight = 720,
            TargetFps = 60,
            VSync = true,
            Version = "0.1.0"
        });

        engine.OnInitialize += () =>
        {
            Log.Info("Game", "Vallerya starting...");
        };

        engine.OnUpdate += dt =>
        {
            // Game update logic goes here
        };

        engine.OnRender += dt =>
        {
            // Game render logic goes here
        };

        // For headless testing — windowed mode uses Platform.Desktop's DesktopWindow
        engine.Run();
    }
}
