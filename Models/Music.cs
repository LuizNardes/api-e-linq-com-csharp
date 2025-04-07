using System.Text.Json.Serialization;

namespace ScreenSound04.Models;

internal class Music
{
    private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
    [JsonPropertyName("song")]
    public string? Song { get; set; }
    [JsonPropertyName("artist")]
    public string? Artist { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duration { get; set; }
    [JsonPropertyName("genre")]
    public string? Genre { get; set; }
    [JsonPropertyName("key")]
    public int Key { get; set; }
    public string Tonalidade { 
        get
        {
            return tonalidades[Key];
        } 
    }

    public void ShowDetails()
    {
        System.Console.WriteLine($"Artista: {Artist}");
        System.Console.WriteLine($"Música: {Song}");
        System.Console.WriteLine($"Duralçao em segundos: {Duration/1000}");
        System.Console.WriteLine($"Gênero: {Genre}");
        System.Console.WriteLine($"Tonalidade: {Tonalidade}");
    }
}