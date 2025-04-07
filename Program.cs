using System.Text.Json;
using ScreenSound04.Filters;
using ScreenSound04.Models;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        System.Console.WriteLine(resposta);
        var musics = JsonSerializer.Deserialize<List<Music>>(resposta)!;

        LinqFilter.FiltrarMusicasEmCSharp(musics);
        
        // musics[463].ShowDetails();
        // LinqFilter.FilterAllGenre(musics);
        // LinqOrder.ShowArtistsList(musics);
        // LinqFilter.FilterArtistByGenre(musics, "hip hop");
        // LinqFilter.FilterMusicByArtist(musics, "Evanescence");
        

        var luizMyMusic = new MyMusic("Playlist do Luiz");
        luizMyMusic.AddMyMusic(musics[235]);
        luizMyMusic.AddMyMusic(musics[869]);
        luizMyMusic.AddMyMusic(musics[1569]);
        luizMyMusic.AddMyMusic(musics[1493]);

        // luizMyMusic.ShowMyMusic();

        // luizMyMusic.GenerateJson();
        
    }
    catch (System.Exception ex)
    {
        System.Console.WriteLine($"Temos um problema: {ex.Message}");
    }   
}