using Obsydian.Core.ECS;

namespace Vallerya.Game.Components;

public record struct HealthComponent(int Current, int Max) : IComponent
{
    public float Percentage => Max > 0 ? (float)Current / Max : 0;
    public bool IsDead => Current <= 0;
}
