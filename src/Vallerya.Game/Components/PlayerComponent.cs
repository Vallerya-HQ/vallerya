using Obsydian.Core.ECS;

namespace Vallerya.Game.Components;

public enum FacingDirection { Up, Down, Left, Right }

public record struct PlayerComponent(
    string Name,
    float MoveSpeed,
    FacingDirection Facing
) : IComponent
{
    public PlayerComponent(string name) : this(name, 120f, FacingDirection.Down) { }
}
