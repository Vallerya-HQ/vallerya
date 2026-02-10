using Obsydian.Core.ECS;

namespace Vallerya.Game.Components;

public record struct NpcComponent(string NpcId, string CurrentDialogue) : IComponent;
