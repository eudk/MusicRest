namespace MusicRest;

public class Record
{
    public int? Id { get; set; }
    public string? Title { get; set; }
    public string? Artist { get; set; }
    public int Duration { get; set; }
    public int PublicationYear { get; set; }

    public void Validate()
    {
        ValidateTitle();
        ValidateArtist();
        ValidateDuration();
        ValidatePublicationYear();
    }

    private void ValidateTitle()
    {
        if (Title == null)
        {
            throw new ArgumentNullException();
        }
        if (Title.Length == 0)
        {
            throw new ArgumentException("Title must be at least 1 character");
        }
    }

    private void ValidateArtist()
    {
        if (Artist == null)
        {
            throw new ArgumentNullException();
        }
        if (Artist.Length == 0)
        {
            throw new ArgumentException("Artist must be at least 1 character");
        }
    }

    private void ValidateDuration()
    {
        if (Duration < 1)
        {
            throw new ArgumentOutOfRangeException("Duration must be positive");
        }
    }

    private void ValidatePublicationYear()
    {
        if (PublicationYear < 1000)
        {
            throw new ArgumentException("Publication Year must be 1000 or later");
        }
    }

    public override string ToString()
    {
        return string.Format("Id: {0}, Title: {1}, Artist: {2}, Duration: {3}, Publication Year: {4}",Id ,Title, Artist, Duration, PublicationYear);
    }
}