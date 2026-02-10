using Obsydian.Core.ECS;
using Obsydian.Core.Math;
using Vallerya.Game.Components;

namespace Vallerya.Game.Systems;

/// <summary>
/// Applies velocity to all entities with a transform.
/// </summary>
public sealed class MovementSystem : GameSystem
{
    public override void Update(World world, float deltaTime)
    {
        foreach (var entity in world.Query<TransformComponent, VelocityComponent>())
        {
            ref var transform = ref world.Get<TransformComponent>(entity);
            var velocity = world.Get<VelocityComponent>(entity);

            transform = transform with
            {
                Position = transform.Position + velocity.Velocity * deltaTime
            };
        }
    }
}
