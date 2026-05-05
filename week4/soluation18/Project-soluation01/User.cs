using System;
using System.Collections.Generic;

class User
{
    public string Name { get; set; }

    private int watchCount;
    public int WatchCount => watchCount;

    private List<string> watchedMovies = new List<string>();

    public User(string name)
    {
        Name = name;
    }

    public void WatchMovie(Movie movie)
    {
        watchCount++;
        watchedMovies.Add(movie.Title);
    }

    public bool HasWatched(string title)
    {
        return watchedMovies.Contains(title);
    }

    public List<string> GetWatchedMovies()
    {
        return watchedMovies;
    }

    public void RateMovie(Movie movie, int rate)
    {
        if (rate < 1 || rate > 10)
            throw new Exception("Invalid rate!");

        movie.Rating = rate;
    }
}