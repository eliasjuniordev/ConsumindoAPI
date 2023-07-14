
using System.Text.Json.Serialization;

namespace ConsumoAPI.Modelos
{
    public class Musica
    {

        [JsonPropertyName("song")]
        public string? Nome { get; set; }

        [JsonPropertyName("artist")]
        public string? Artista { get; set; }

        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }

        [JsonPropertyName("genre")]
        public string? Genero { get; set; }

        public void ExibirDetalhesDaMusica()
        {
            Console.WriteLine($"Artista:{Artista}");
            Console.WriteLine($"Música:{Nome}");
            Console.WriteLine($"Duração em Segundos:{Duracao/1000}");
            Console.WriteLine($"Gênero musical:{Genero}");
        }





    }

   

}

