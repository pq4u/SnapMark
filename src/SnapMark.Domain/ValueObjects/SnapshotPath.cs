namespace SnapMark.Domain.ValueObjects;
public sealed record SnapshotPath
{
    public string Value { get; }

    public SnapshotPath(ContentHash hash)
    {
        Value = $"/Snapshots/{hash.Value}/";
    }

    public override string ToString() => Value;
}
