using Obsydian.Core.ECS;
using Obsydian.Core.Math;
using Obsydian.Input;
using Vallerya.Game.Components;

namespace Vallerya.Game.Systems;

/// <summary>
/// Reads player input and converts it to velocity on the player entity.
/// </summary>
public sealed class PlayerInputSystem : GameSystem
{
    private readonly InputManager _input;

    public PlayerInputSystem(InputManager input)
    {
        _input = input;
    }

    public override void Update(World world, float deltaTime)
    {
        foreach (var entity in world.Query<PlayerComponent, VelocityComponent>())
        {
            var player = world.Get<PlayerComponent>(entity);
            var direction = Vec2.Zero;

            if (_input.IsKeyDown(Key.W) || _input.IsKeyDown(Key.Up)) direction += Vec2.Up;
            if (_input.IsKeyDown(Key.S) || _input.IsKeyDown(Key.Down)) direction += Vec2.Down;
            if (_input.IsKeyDown(Key.A) || _input.IsKeyDown(Key.Left)) direction += Vec2.Left;
            if (_input.IsKeyDown(Key.D) || _input.IsKeyDown(Key.Right)) direction += Vec2.Right;

            var velocity = direction.LengthSquared > 0
                ? direction.Normalized * player.MoveSpeed
                : Vec2.Zero;

            world.Add(entity, new VelocityComponent(velocity));

            // Update facing direction
            if (velocity.LengthSquared > 0)
            {
                var facing = MathF.Abs(velocity.X) > MathF.Abs(velocity.Y)
                    ? (velocity.X > 0 ? FacingDirection.Right : FacingDirection.Left)
                    : (velocity.Y > 0 ? FacingDirection.Down : FacingDirection.Up);

                world.Add(entity, player with { Facing = facing });
            }
        }
    }
}
