using Obsydian.Core;
using Obsydian.Core.Logging;
using Obsydian.Input;
using Vallerya.Game.Components;
using Vallerya.Game.Systems;

// ── Vallerya ──────────────────────────────────────────────────────
// Built on the Obsydian Game Engine

var input = new InputManager();

var engine = new Engine(new EngineConfig
{
    Title = "Vallerya",
    WindowWidth = 1280,
    WindowHeight = 720,
    TargetFps = 60,
    Version = "0.1.0"
});

// Register game systems
engine.Systems.Register(new PlayerInputSystem(input));
engine.Systems.Register(new MovementSystem());

engine.OnInitialize += () =>
{
    Log.Info("Vallerya", "Initializing world...");

    // Create the player
    var player = engine.World.CreateEntity();
    engine.World.Add(player, new TransformComponent(640, 360));
    engine.World.Add(player, new PlayerComponent("Player"));
    engine.World.Add(player, new VelocityComponent());
    engine.World.Add(player, new HealthComponent(100, 100));
    engine.World.Add(player, new ColliderComponent(new Obsydian.Core.Math.Vec2(16, 16)));
    engine.World.Add(player, new SpriteComponent("sprites/player"));

    Log.Info("Vallerya", "World ready. Welcome to Vallerya.");
};

engine.Run();
