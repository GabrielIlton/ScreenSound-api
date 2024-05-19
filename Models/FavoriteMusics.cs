using System.Text.Json;

namespace ScreenSound_api.Models;

internal class FavoriteMusics
{
    public string? Name { get; set; }
    public List<Music> ListFavoriteMusics { get; }

    public FavoriteMusics(string? name)
    {
        Name = name;
        ListFavoriteMusics = new();
    }

    public void AddFavoriteMusic(Music music) 
    {
        ListFavoriteMusics.Add(music);
    }

    public void ShowFavoriteMusics()
    {
        Console.WriteLine($"Essas são as musicas favoritas -> {Name}");

        foreach (var favoriteMusic in ListFavoriteMusics)
        {
            Console.WriteLine($"- {favoriteMusic.Name} de {favoriteMusic.Artist}");
        }

        Console.WriteLine();
    }

    public void CreateJsonFile()
    {
        string json = JsonSerializer.Serialize(new {
            name = Name,
            musics = ListFavoriteMusics
        });

        string filename = $"favorite-musics-{Name}.json";

        File.WriteAllText(filename, json);

        Console.WriteLine($"O arquivo Json foi criado com sucesso!\n {Path.GetFullPath(filename)}");
    }
}
