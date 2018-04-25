using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data.Interfaces;
using WebStore.Data.Models;

namespace WebStore.Data.Mocks
{
    public class MockRoupaRepository : IRoupaRepository
    {
        private readonly ICategoriaRepository _categoriaRepository = new MockCategoryRepository();

        public IEnumerable<Roupa> Roupas
        {
            get
            {
                return new List<Roupa>
                {
                    new Roupa
                    {
                        Name = "Aishty",
                        Preco = 59.90M,
                        DescricaoPequena = "Camisa Aishty Lisa Branca",
                        DescricaoLonga = "Camisa Aishty Lisa Branca\nTipo de Produto: Camisa\nModelagem: Regular\nManga: Longa\nGola: Ponta\n\nTamanho: P\nFecho: Botão\nComposição: 100% Viscose\nMedidas da peça: Ombro: 12cm/ Ombro a ombro: 42cm/ Manga: 66cm/ Busto: 106cm/ Comprimento: 66cm (Medidas sem elasticidade)\nMedidas da Modelo: Altura 1,75m/ Busto: 83cm/ Cintura: 62cm/ Quadril: 90cm.\nTipo de Tecido: Plano",
                        Categoria = _categoriaRepository.Categorias.First(),
                        ImagemUrl = "https://t-static.dafiti.com.br/xNeOtIfyEV4g7yrdhjxL0_Om9R0=/fit-in/430x623/dafitistatic-a.akamaihd.net%2fp%2faishty-camisa-aishty-lisa-branca-9303-5599173-1-zoom.jpg",
                        ImagemThumbnailUrl = "https://t-static.dafiti.com.br/5JoR0B3-0iqIGpVxRD2wfDB6hnc=/fit-in/60x87/dafitistatic-a.akamaihd.net%2fp%2faishty-camisa-aishty-lisa-branca-9303-5599173-1-feed.jpg",
                        InStock = true,
                        RoupaPrefirada = true
                    }
                };
            }
        }

        public IEnumerable<Roupa> RoupasPreferidas { get;}

        public Roupa GetRoupaById(int roupaId)
        {
            throw new NotImplementedException();
        }
    }
}
