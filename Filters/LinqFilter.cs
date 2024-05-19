using ScreenSound_api.Models;

namespace ScreenSound_api.Filters;

internal class LinqFilter
{
    public static void FilterAllMusicGenres(List<Music> musics)
    {
        var allMusicGenres = musics
            .Select(music => music.Genre)
            .Distinct()
            .ToList();

        foreach (var genre in allMusicGenres)
        {
            Console.WriteLine($"- {genre}");
        }
    }
    public static void FilterArtistsByGenre(List<Music> musics, string genre)
    {
        var allArtistByGenre = musics
            .Where(music => music.Genre!.Contains(genre))
            .Select(music => music.Artist)
            .Distinct()
            .ToList();

        Console.WriteLine($"Exibindo os artistas por genero musical >>> {genre}");

        foreach (var artist in allArtistByGenre)
        {
            Console.WriteLine($"- {artist}");
        }
    }
    public static void FilterMusicsByArtist(List<Music> musics, string artistName)
    {
        var allMusicsByArtist = musics
            .Where(music => music.Artist!.Equals(artistName))
            .Select(music => music.Name)
            .Distinct()
            .ToList();

        Console.WriteLine($"Exibindo musicas do artista >>> {artistName}");

        foreach (var music in allMusicsByArtist)
        {
            Console.WriteLine($"- {music}");
        }
    }

    public static void FilterMusicByToneCSharp(List<Music> musics, string tone)
    {
        var musicsByToneCSharp = musics
            .Where(music => music.Tone.Equals(tone))
            .Select(music => music.Name)
            .ToList();

        Console.WriteLine($"Musicas em {tone}");

        foreach (var music in musicsByToneCSharp) 
        {
            Console.WriteLine($"- {music}");
        }
    }
}
