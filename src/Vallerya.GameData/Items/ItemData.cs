namespace Vallerya.GameData.Items;

public enum ItemCategory
{
    Material,
    Tool,
    Weapon,
    Armor,
    Consumable,
    Quest,
    Seed,
    Crop,
    Fish,
    Furniture,
    Misc
}

public enum ItemQuality
{
    Normal,
    Silver,
    Gold,
    Iridium
}

public sealed record ItemData
{
    public required string Id { get; init; }
    public required string Name { get; init; }
    public string Description { get; init; } = "";
    public ItemCategory Category { get; init; } = ItemCategory.Misc;
    public int BasePrice { get; init; }
    public int MaxStack { get; init; } = 999;
    public string? SpriteSheet { get; init; }
    public int SpriteIndex { get; init; }
}
