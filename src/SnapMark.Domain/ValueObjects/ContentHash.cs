namespace SnapMark.Domain.ValueObjects;

public sealed record ContentHash
{
    public string Value { get; }

    public ContentHash(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length != 64)
            throw new ArgumentException("Invalid SHA-256 hash", nameof(value));

        Value = value.ToLowerInvariant();
    }

    public override string ToString() => Value;
}
