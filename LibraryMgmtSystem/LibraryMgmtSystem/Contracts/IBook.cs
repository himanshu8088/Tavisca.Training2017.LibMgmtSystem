namespace LibraryMgmtSystem
{
    public interface IBook
    {
        string Title { get; set; }
        string Publisher { get; set; }
        string Edition { get; set; }
        string Discription { get; set; }
    }
}