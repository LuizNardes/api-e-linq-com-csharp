using ScreenSound04.Models;

namespace ScreenSound04.Filters;

internal class LinqOrder
{
    public static void ShowArtistsList(List<Music> musics)
    {
        var artistOrdered = musics.OrderBy(m => m.Artist).Select(m => m.Artist).Distinct().ToList();

        System.Console.WriteLine("Lista de artistas ordenados:");
        foreach (var artist in artistOrdered)
        {
            System.Console.WriteLine($" - {artist}");
        }
    }
}