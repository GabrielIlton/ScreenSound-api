using ScreenSound_api.Filters;
using ScreenSound_api.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musics = JsonSerializer.Deserialize<List<Music>>(response)!;
        
        musics[0].ShowMusic();

        //foreach (var music in musics)
        //{
        //    music.ShowMusic();
        //}

        //LinqFilter.FilterAllMusicGenres(musics);

        //LinqFilter.FilterArtistsByGenre(musics, "hip hop");

        //LinqFilter.FilterMusicsByArtist(musics, "Post Malone");

        LinqFilter.FilterMusicByToneCSharp(musics, "C#");

        //LinqOrder.ListArtistsOrderByName(musics);

        //FavoriteMusics myfavoriteMusics = new("Gabriel");
        //myfavoriteMusics.AddFavoriteMusic(musics[1]);
        //myfavoriteMusics.AddFavoriteMusic(musics[2]);
        //myfavoriteMusics.AddFavoriteMusic(musics[3]);
        //myfavoriteMusics.AddFavoriteMusic(musics[4]);
        //myfavoriteMusics.AddFavoriteMusic(musics[5]);

        //myfavoriteMusics.ShowFavoriteMusics();

        //myfavoriteMusics.CreateJsonFile();

    }
    catch (Exception exception)
    {
        Console.WriteLine($"Temos um problema: {exception.Message}");
    }
}

