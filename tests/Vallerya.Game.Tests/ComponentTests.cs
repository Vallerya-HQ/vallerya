using Obsydian.Core.ECS;
using Obsydian.Core.Math;
using Vallerya.Game.Components;

namespace Vallerya.Game.Tests;

public class ComponentTests
{
    [Fact]
    public void PlayerEntity_HasAllComponents()
    {
        var world = new World();
        var player = world.CreateEntity();

        world.Add(player, new TransformComponent(100, 200));
        world.Add(player, new PlayerComponent("Test"));
        world.Add(player, new HealthComponent(100, 100));

        Assert.True(world.Has<TransformComponent>(player));
        Assert.True(world.Has<PlayerComponent>(player));
        Assert.True(world.Has<HealthComponent>(player));

        var health = world.Get<HealthComponent>(player);
        Assert.Equal(1f, health.Percentage);
        Assert.False(health.IsDead);
    }

    [Fact]
    public void HealthComponent_DeathDetection()
    {
        var dead = new HealthComponent(0, 100);
        Assert.True(dead.IsDead);
        Assert.Equal(0f, dead.Percentage);
    }
}
