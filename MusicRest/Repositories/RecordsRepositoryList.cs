namespace MusicRest;

public class RecordsRepositoryList
{
    private int _nextId = 1;


    private readonly List<Record> _records = new List<Record>();

    public RecordsRepositoryList() { 
    
    _records.Add (new Record { Id = _nextId++, Title = "The Dark Side of the Moon", Artist = " Floyd", Duration = 43, PublicationYear = 1973 });
    _records.Add (new Record { Id = _nextId++, Title = "The Wall", Artist = "Pink Floyd", Duration = 81, PublicationYear = 1979 });
        _records.Add(new Record { Id = _nextId++, Title = "Wish You Were Here", Artist = "Pink ", Duration = 44, PublicationYear = 1975 });
        _records.Add (new Record { Id = _nextId++, Title = "Animals", Artist = "Pink Floyd", Duration = 41, PublicationYear = 1977 });
        _records.Add (new Record { Id = _nextId++, Title = "The Piper at the Gates of Dawn", Artist = "Pink Floyd", Duration = 42, PublicationYear = 1967 });
        _records.Add (new Record { Id = _nextId++, Title = "The Final Cut", Artist = "Pink Floyd", Duration = 43, PublicationYear = 1983 });
        _records.Add (new Record { Id = _nextId++, Title = "The Division Bell", Artist = "Pink Floyd", Duration = 66, PublicationYear = 1994 });
        _records.Add (new Record { Id = _nextId++, Title = "A Momentary Lapse of Reason", Artist = "Michael jackson", Duration = 51, PublicationYear = 1987 });
        _records.Add (new Record { Id = _nextId++, Title = "The Endless River", Artist = "YO", Duration = 53, PublicationYear = 2014 });
       _records.Add (new Record { Id = _nextId++, Title = "The Final Cut", Artist = "Pink ", Duration = 43, PublicationYear = 1983 });

    }


    public IEnumerable<Record> GetAll()
    {
        return new List<Record>(_records); // copy
    }

    public IEnumerable<Record> Get(int? id = null, string title = "", string artist = "", int? duration = 0, int? publicationYear = null)
    {
        var result = new List<Record>(_records);
        if (id != null)
            result = result.FindAll (x => x.Id == id);
        result = result.FindAll (x => x.Title.Contains(title) && x.Artist.Contains(artist));
        result = result.FindAll(x => x.Duration >= duration);
        if (publicationYear != null)
            result = result.FindAll (x => x.PublicationYear == publicationYear);
        return result;
    }
}