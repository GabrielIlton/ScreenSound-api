using System.Text.Json.Serialization;

namespace ScreenSound_api.Models;

internal class Music
{
    private string[] tonalities = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

    [JsonPropertyName("song")]
    public string? Name { get; set; }

    [JsonPropertyName("artist")]
    public string? Artist { get; set; }

    [JsonPropertyName("duration_ms")]
    public int? Duration { get; set; }

    [JsonPropertyName("genre")]
    public string? Genre { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tone {
        get => tonalities[Key];
    }

    public void ShowMusic()
    {
        Console.WriteLine($"Artista {Artist}");
        Console.WriteLine($"Nome {Name}");
        Console.WriteLine($"Duração em segundos {Duration / 1000}");
        Console.WriteLine($"Gênero {Genre}");
        Console.WriteLine($"Tonalidade {Tone}");
    }
}
