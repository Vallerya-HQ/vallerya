using Obsydian.Core.ECS;
using Obsydian.Core.Math;

namespace Vallerya.Game.Components;

public record struct TransformComponent(Vec2 Position, Vec2 Scale, float Rotation) : IComponent
{
    public TransformComponent(Vec2 position) : this(position, Vec2.One, 0f) { }
    public TransformComponent(float x, float y) : this(new Vec2(x, y), Vec2.One, 0f) { }
}
