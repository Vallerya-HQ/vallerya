using Obsydian.Core.ECS;
using Obsydian.Core.Math;

namespace Vallerya.Game.Components;

public record struct ColliderComponent(Vec2 Size, Vec2 Offset, bool IsTrigger) : IComponent
{
    public ColliderComponent(Vec2 size) : this(size, Vec2.Zero, false) { }
}
