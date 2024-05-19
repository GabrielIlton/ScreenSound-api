using ScreenSound_api.Models;

namespace ScreenSound_api.Filters;

internal class LinqOrder
{
    public static void ListArtistsOrderByName(List<Music> musics)
    {
        var allArtistsOrderByName = musics.OrderBy(music => music.Artist).Select(music => music.Artist).Distinct().ToList();

        Console.WriteLine("Lista de artistas odernados");

        foreach (var artist in allArtistsOrderByName)
        {
            Console.WriteLine($"- {artist}");
        }
    }
}
