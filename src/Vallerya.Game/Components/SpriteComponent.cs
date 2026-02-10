using Obsydian.Core.ECS;
using Obsydian.Core.Math;

namespace Vallerya.Game.Components;

public record struct SpriteComponent(
    string TexturePath,
    Rect SourceRect,
    Color Tint,
    int Layer
) : IComponent
{
    public SpriteComponent(string texturePath) : this(texturePath, default, Color.White, 0) { }
}
