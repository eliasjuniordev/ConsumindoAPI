﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsumoAPI.Modelos
{
    public class MusicasPreferidas
    {

        public string? Nome { get; set; }
        public List<Musica> ListaDeMusicasFavoritas { get; }


        public MusicasPreferidas( string nome)
        {
            Nome = nome;
            ListaDeMusicasFavoritas = new List<Musica>();
        }

        public void AdicionarMusicasFavoritas(Musica musica)
        {
            ListaDeMusicasFavoritas.Add(musica);
        }

        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"Essas são as musicas favoritas - {Nome}");

            foreach (var musica in ListaDeMusicasFavoritas)
            {
                Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
            }
        }


        public void GerarArquivoJson()
        {
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musica = ListaDeMusicasFavoritas
            });

            string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

            File.WriteAllText(nomeDoArquivo, json);

            Console.WriteLine($"O Arquivo Json foi Criado com Sucesso !!! {Path.GetFullPath(nomeDoArquivo)}");

        }

        public void GerarDocumentoTXTComAsMusicasFavoritas()
        {
            string nomeDoArquivo = $"musicas-favoritas-{Nome}.txt";
            using (StreamWriter arquivo = new StreamWriter(nomeDoArquivo))
            {
                arquivo.WriteLine($"Músicas favoritas do {Nome}\n");
                foreach (var musica in ListaDeMusicasFavoritas)
                {
                    arquivo.WriteLine($"- {musica.Artista}");
                }
            }
            Console.WriteLine($"txt gerado com sucesso!{Path.GetFullPath(nomeDoArquivo)}");
        }

    }
}
