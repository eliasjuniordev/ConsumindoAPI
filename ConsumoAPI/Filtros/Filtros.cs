using ConsumoAPI.Modelos;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoAPI.Filtros
{
    public class Filtros
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {
            var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
           
            foreach (var genero in todosOsGenerosMusicais)
            {
                Console.WriteLine($" - {genero}");
            }
        }

        public static void FiltrarMusicasDeUmArtista(List<Musica> musicas,string nomeDoArtista) 
        { 
        
          var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
           
            Console.WriteLine(nomeDoArtista);


            foreach (var musica in musicasDoArtista)
            {
                Console.WriteLine($"-{musica.Nome}");
            }
        }

    }
}
