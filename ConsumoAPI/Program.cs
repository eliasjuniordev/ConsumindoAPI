using ConsumoAPI.Filtros;
using ConsumoAPI.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
	try
	{
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        
        Filtros.FiltrarTodosOsGenerosMusicais(musicas);
        Filtros.FiltrarMusicasDeUmArtista(musicas,"U2");

        var musicasPreferidas = new MusicasPreferidas("Anonimo");
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[377]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[4]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[6]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[1467]);

        musicasPreferidas.ExibirMusicasFavoritas();
        musicasPreferidas.GerarDocumentoTXTComAsMusicasFavoritas();


        musicasPreferidas.GerarArquivoJson();

    }
	catch (Exception ex)
	{

        Console.WriteLine($"Error no caminho:{ex.Message}");
    }
   
}

