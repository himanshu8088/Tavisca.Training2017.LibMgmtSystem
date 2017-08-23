namespace LibraryMgmtSystem
{
    public enum DiscriptionTag { HorrorStory, FictionStory , Technical, Finance}

    public interface IBook
    {
        string Title { get; set; }
        string Publisher { get; set; }
        string Edition { get; set; }
        DiscriptionTag Discription { get; set; }
    }
}