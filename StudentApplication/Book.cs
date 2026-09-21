public class Book
{
    public string Title;
    public string Author;
    public int Pages;

    public override string ToString()
    {
        // return base.ToString(); // default
        return $"{Title}, {Author} ({Pages} pages)";
    }
}
