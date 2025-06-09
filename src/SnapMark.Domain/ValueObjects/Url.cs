namespace SnapMark.Domain.ValueObjects;

public sealed record Url
{
    public string Value { get; }

    public Url(string value)
    {
        if (!Uri.TryCreate(value, UriKind.Absolute, out var uri))
            throw new ArgumentException("Invalid absolute URL", nameof(value));

        Value = uri.ToString().Trim();
    }

    public override string ToString() => Value;
}
