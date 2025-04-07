using ScreenSound04.Models;

namespace ScreenSound04.Filters;

internal class LinqFilter
{
    public static void FilterAllGenre(List<Music> musics)
    {
        var allGenre = musics.Select(m => m.Genre).Distinct().ToList();

        foreach (var genre in allGenre)
        {
            System.Console.WriteLine($"- {genre}");
        }
    }

    public static void FilterArtistByGenre(List<Music> musics, string genre)
    {
        var artistBygenre = musics.Where(musics => musics.Genre!.Contains(genre)).Select(m => m.Artist).ToList();

        System.Console.WriteLine($"\nExibindo os artistas por gênero musical >>> {genre}");

        foreach (var artist in artistBygenre)
        {
            Console.WriteLine($"- {artist}");
        }
    }

    public static void FilterMusicByArtist(List<Music> musics, string artist)
    {
        var artistMusics = musics.Where(m => m.Artist!.Equals(artist)).ToList();

        Console.WriteLine(artist);
        foreach (var music in artistMusics)
        {
            Console.WriteLine($"- {music.Song}");
        }
    }

    internal static void FiltrarMusicasEmCSharp(List<Music> musics)
    {
        var FiltrarMusicasEmCSharp = musics
            .Where(m => m.Tonalidade.Equals("C#"))
            .Select(m => m.Song)
            .ToList();
        Console.WriteLine("Músicas em C#:");
        foreach (var music in FiltrarMusicasEmCSharp)
        {
            System.Console.WriteLine($"- {music}");
        }
    }
}