namespace Vallerya.GameData.Characters;

public sealed record NpcData
{
    public required string Id { get; init; }
    public required string Name { get; init; }
    public string Description { get; init; } = "";
    public string? Portrait { get; init; }
    public string? SpriteSheet { get; init; }
    public Dictionary<string, string> Dialogue { get; init; } = [];
    public List<string> LikedGifts { get; init; } = [];
    public List<string> LovedGifts { get; init; } = [];
}
