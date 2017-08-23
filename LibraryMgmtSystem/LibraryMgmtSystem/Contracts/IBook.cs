namespace LibraryMgmtSystem
{
    public enum DiscriptionTag { HorrorStory, FictionStory , Technical, Finance}

    public interface IBook
    {
        string Title { get; }
        string Publisher { get; }
        string Edition { get; }
        DiscriptionTag Discription { get; }
    }
}