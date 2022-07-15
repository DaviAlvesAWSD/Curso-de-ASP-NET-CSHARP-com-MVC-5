using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Rotas.Models
{
    public class News
    {
        public int NoticiaId { get; set; }
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public DateTime Data { get; set; }
        public string Conteudo { get; private set; }

        public IEnumerable<News> TodasAsNoticias()
        {
            var retorno = new Collection<News>
                {
                    new News
                        {
                            NoticiaId = 1,
                            Categoria = "Esportes",
                            Titulo = "Felipe Massa ganha F1",
                            Conteudo = "Numa tarde de chuva Felipe Massa ganha F1 no Brasil...",
                            Data = new DateTime(2017,3,1)
                        },
                    new News
                        {
                            NoticiaId = 2,
                            Categoria = "Política",
                            Titulo = "Presidente assina convênios",
                            Conteudo = "Durante reunião o presidente Ismael Freitas assinou os convênios...",
                            Data = new DateTime(2017,3,1)
                        },
                    new News
                        {
                            NoticiaId = 3,
                            Categoria = "Política",
                            Titulo = "Vereador é eleito pela 4ª vez",
                            Conteudo = "Vereador Fabio Pratt é eleito pela quarta vez...",
                            Data = new DateTime(2017,3,1)
                        },
                    new News
                        {
                            NoticiaId = 4,
                            Categoria = "Esportes",
                            Titulo = "O tão sonhado titulo chegou",
                            Conteudo = "Em um jogo que levou os torcedores ao delirio...",
                            Data = new DateTime(2017,3,1)
                        },
                    new News
                        {
                            NoticiaId = 5,
                            Categoria = "Humor",
                            Titulo = "O Comediante Anderson Renato fará shou hoje",
                            Conteudo = "O comediante mais engraçados dos comentários do Youtube fará show...",
                            Data = new DateTime(2017,3,1)
                        },
                    new News
                        {
                            NoticiaId = 6,
                            Categoria = "Policial",
                            Titulo = "Tenente coronel Lucas Farias Santos assume o controle",
                            Conteudo = "Durante a retomada do morro o tenente coronel disse...",
                            Data = new DateTime(2017,3,1)
                        },
                    new News
                        {
                            NoticiaId = 7,
                            Categoria = "Esportes",
                            Titulo = "Atacante do Barcelona faz 4 gols",
                            Conteudo = "O atacante Lucas Farias Santos Messi, fez 4 gols e decidiu o titulo...",
                            Data = new DateTime(2017,3,1)
                        }
                };
            return retorno;
        }
    }
}