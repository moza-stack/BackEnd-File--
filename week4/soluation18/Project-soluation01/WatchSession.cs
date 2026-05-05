public class WatchSession
{
    public string UserName { get; set; }
    public string MovieTitle { get; set; }

    public WatchSession(string userName, string movieTitle)
    {
        UserName = userName;
        MovieTitle = movieTitle;
    }
}