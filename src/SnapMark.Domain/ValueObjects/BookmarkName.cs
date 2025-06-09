namespace SnapMark.Domain.ValueObjects;

public sealed record BookmarkName
{
    public string Value { get; }

    public BookmarkName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Bookmark name cannot be empty", nameof(value));

        Value = value.Trim();
    }

    public override string ToString() => Value;
}
