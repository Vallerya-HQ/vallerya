using Obsydian.Core.ECS;
using Obsydian.Core.Math;

namespace Vallerya.Game.Components;

public record struct VelocityComponent(Vec2 Velocity) : IComponent
{
    public static readonly VelocityComponent Zero = new(Vec2.Zero);
}
