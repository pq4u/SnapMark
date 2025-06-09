namespace SnapMark.Domain.ValueObjects;

public sealed record FolderPath
{
    public string Value { get; }

    public FolderPath(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Folder path cannot be empty", nameof(value));

        if (value.Contains("..") || value.Contains('\\'))
            throw new ArgumentException("Invalid folder path", nameof(value));

        Value = value.TrimStart('/').Trim();
    }

    public override string ToString() => Value;
}
