namespace Vallerya.GameData.World;

public sealed record LocationData
{
    public required string Id { get; init; }
    public required string Name { get; init; }
    public string? MapFile { get; init; }
    public int Width { get; init; }
    public int Height { get; init; }
    public List<SpawnPoint> SpawnPoints { get; init; } = [];
    public List<string> ConnectedLocations { get; init; } = [];
}

public sealed record SpawnPoint
{
    public required string Id { get; init; }
    public float X { get; init; }
    public float Y { get; init; }
}
