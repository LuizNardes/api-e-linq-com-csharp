using System.Text.Json;

namespace ScreenSound04.Models;

internal class MyMusic
{
    public string? Name { get; set; }
    public List<Music> MyMusicList;

    public MyMusic(string name)
    {
        Name = name;
        MyMusicList = new List<Music>();
    }

    public void AddMyMusic(Music music)
    {
        MyMusicList.Add(music);
    }

    public void ShowMyMusic()
    {
        Console.WriteLine($"Essas são as músicas favoritas -> {Name}");
        foreach (var music in MyMusicList)
        {
            Console.WriteLine($"- {music.Song} de {music.Artist}");
        }
    }

    public void GenerateJson()
    {
        string json = JsonSerializer.Serialize(new {
            name = Name,
            musics = MyMusicList
        });
        string archive = $"musicas-favoritas-{Name}.json";
        File.WriteAllText(archive, json);
        Console.WriteLine($"Arquivo json foi criado com sucesso! {Path.GetFullPath(archive)}");
    }

}