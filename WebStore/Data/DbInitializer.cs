using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using WebStore.Data.Models;

namespace WebStore.Data
{
    public class DbInitializer
    {
        public static void Seed(IServiceProvider applicationBuilder)
        {
            AppDbContext context = applicationBuilder.GetRequiredService<AppDbContext>();

            if (!context.Categorias.Any())
            {
                context.Categorias.AddRange(Categorias.Select(c => c.Value));
            }

            if (!context.Roupas.Any())
            {
                context.AddRange(
                    new Roupa
                    {
                        Name = "Aishty",
                        Preco = 59.90M,
                        DescricaoPequena = "Camisa Aishty Lisa Branca",
                        DescricaoLonga = "Camisa Aishty Lisa Branca\nTipo de Produto: Camisa\nModelagem: Regular\nManga: Longa\nGola: Ponta\n\nTamanho: P\nFecho: Botão\nComposição: 100% Viscose\nMedidas da peça: Ombro: 12cm/ Ombro a ombro: 42cm/ Manga: 66cm/ Busto: 106cm/ Comprimento: 66cm (Medidas sem elasticidade)\nMedidas da Modelo: Altura 1,75m/ Busto: 83cm/ Cintura: 62cm/ Quadril: 90cm.\nTipo de Tecido: Plano",
                        Categoria = Categorias["Blusas"],
                        ImagemUrl = "https://t-static.dafiti.com.br/xNeOtIfyEV4g7yrdhjxL0_Om9R0=/fit-in/430x623/dafitistatic-a.akamaihd.net%2fp%2faishty-camisa-aishty-lisa-branca-9303-5599173-1-zoom.jpg",
                        ImagemThumbnailUrl = "https://t-static.dafiti.com.br/xNeOtIfyEV4g7yrdhjxL0_Om9R0=/fit-in/430x623/dafitistatic-a.akamaihd.net%2fp%2faishty-camisa-aishty-lisa-branca-9303-5599173-1-zoom.jpg",
                        RoupaPrefirada = false,
                        InStock = true
                    },
                    new Roupa
                    {
                        Name = "Camisa Real Madrid Third 17/18",
                        Preco = 199.90M,
                        DescricaoPequena = "Camisa Real Madrid Third 17/18 s/nº - Torcedor Adidas Masculina - Azul Claro",
                        DescricaoLonga = "Para vestir a torcida do Los Merengues com conforto e estilo, entra em\n campo a terceira Camisa do Real Madrid. Ela foge das cores tradicionais do clube,\n deixando seu visual esportivo completo.",
                        Categoria = Categorias["Blusas"],
                        ImagemUrl = "https://static.netshoes.com.br/produtos/camisa-real-madrid-third-1718-sn-torcedor-adidas-masculina/62/COL-0867-162/COL-0867-162_zoom1.jpg?resize=1200:*",
                        ImagemThumbnailUrl = "https://static.netshoes.com.br/produtos/camisa-real-madrid-third-1718-sn-torcedor-adidas-masculina/62/COL-0867-162/COL-0867-162_zoom1.jpg",
                        RoupaPrefirada = true,
                        InStock = true
                    },
                    new Roupa
                    {
                        Name = "Camisa Social Jade",
                        Preco = 99.00M,
                        DescricaoPequena = "Camisa Social Jade",
                        DescricaoLonga = "Gênero: Masculino\nEstilo de manga: Comprida\nTipo de estampa: Lisa\nOcasião: Trabalho,\nfesta e lazer\nTipo de fecho: Botão\nMaterial: Algodão e poliéster",
                        Categoria = Categorias["Blusas"],
                        ImagemUrl = "https://enjoytrend.com/image/cache/catalog/produtos/masculino/camisa/1206/12061-800x800.jpg",
                        ImagemThumbnailUrl = "https://enjoytrend.com/image/cache/catalog/produtos/masculino/camisa/1206/12061-800x800.jpg",
                        RoupaPrefirada = false,
                        InStock = true
                    },
                    new Roupa
                    {
                        Name = "Camisa Itália I 2018 Puma - Masculina",
                        Preco = 249.99M,
                        DescricaoPequena = "Camisa Itália I 2018 Puma - Masculina",
                        DescricaoLonga = "Com escudo da seleção italiana na parte frontal, essa Camisa Itália I é uma ótima opção para você mostrar sua paixão pela Azzurra em todos os jogos de futebol!",
                        Categoria = Categorias["Blusas"],
                        ImagemUrl = "https://imgcentauro-a.akamaihd.net/900x900/91599104/camisa-italia-i-2018-puma-masculina-img.jpg",
                        ImagemThumbnailUrl = "https://imgcentauro-a.akamaihd.net/900x900/91599104/camisa-italia-i-2018-puma-masculina-img.jpg",
                        RoupaPrefirada = false,
                        InStock = true
                    },
                    new Roupa
                    {
                        Name = "Calça Super Skinny",
                        Preco = 19.90M,
                        DescricaoPequena = "Calça Super Skinny Sawary Preta",
                        DescricaoLonga = "A calça foi desenvolvida em sarja. A modelagem super skinny\n tem caimento super ajustado desde o quadril até a barra. O modelo tem dois bolsos decorativos\n na parte frontal e posterior. O cós embutido tem fechamento por zíper e botão. Uma\n calça como essa não pode faltar no seu guarda-roupa, invista! Composição: 69%\n Algodão 29% Poliéster 2% Elastano\n Modelo Veste: 36 Altura: 1,74m Busto: 75cm Cintura: 60cm Quadril: 89cm",
                        Categoria = Categorias["Calças"],
                        ImagemUrl = "http://cea.vteximg.com.br/arquivos/ids/2363580-1000-1200/Calca-Super-Skinny-Sawary-Preta-9070148-Preto_2.jpg?v=636536170762200000",
                        ImagemThumbnailUrl = "http://cea.vteximg.com.br/arquivos/ids/2363580-1000-1200/Calca-Super-Skinny-Sawary-Preta-9070148-Preto_2.jpg?v=636536170762200000",
                        RoupaPrefirada = false,
                        InStock = true
                    },
                    new Roupa
                    {
                        Name = "Calça Super Skinny",
                        Preco = 22.49M,
                        DescricaoPequena = "Calça Super Skinny Energy Jeans em Algodão + Sustentável Preta",
                        DescricaoLonga = "Calça confeccionada em Energy jeans, o jeans mais elástico que você já experimentou. O jeans é de algodão + sustentável, um material que preserva os recursos naturais. Tem modelagem super skinny de cintura alta que se ajusta ao corpo sem tirar a liberdade de movimento. A parte frontal tem dois bolsos decorativos enquanto a parte posterior tem dois aplicados. O cós tem passantes e fechamento por botão e zíper.",
                        Categoria = Categorias["Calças"],
                        ImagemUrl = "http://cea.vteximg.com.br/arquivos/ids/1875417-1000-1200/Calca-Super-Skinny-Energy-Jeans-Preta-8878611-Preto_1.jpg?v=636439426259400000",
                        ImagemThumbnailUrl = "http://cea.vteximg.com.br/arquivos/ids/1875417-1000-1200/Calca-Super-Skinny-Energy-Jeans-Preta-8878611-Preto_1.jpg?v=636439426259400000",
                        RoupaPrefirada = false,
                        InStock = true
                    },
                    new Roupa
                    {
                        Name = "Calça Jeans Escuro Cintura Alta",
                        Preco = 79.99M,
                        DescricaoPequena = "Calça Jeans Escuro Cintura Alta",
                        DescricaoLonga = "Calça em jeans com elastano, bolsos traseiros com detalhe drapeado.\nPossui fechamento com zíper e botões e passantes para cinto.\nA calça jeans cintura alta valoriza as curvas.\nAs mais cheinhas podem abusar dessa peça!",
                        Categoria = Categorias["Calças"],
                        ImagemUrl = "https://ph-cdn1.ecosweb.com.br/Web/posthaus/foto/moda-feminina/calcas/calca-jeans-escuro-cintura-alta_120082_301_1.jpg",
                        ImagemThumbnailUrl = "https://ph-cdn1.ecosweb.com.br/Web/posthaus/foto/moda-feminina/calcas/calca-jeans-escuro-cintura-alta_120082_301_1.jpg",
                        RoupaPrefirada = false,
                        InStock = true
                    }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Categoria> categorias;

        private static Dictionary<string, Categoria> Categorias
        {
            get
            {
                if (categorias == null)
                {
                    var genresList = new Categoria[]
                    {
                        new Categoria {CategoriaNome = "Blusas", Descricao = "Todas as blusas"},
                        new Categoria {CategoriaNome = "Calças", Descricao = "Todas as calças"},
                    };

                    categorias = new Dictionary<string, Categoria>();

                    foreach (Categoria genre in genresList)
                    {
                        categorias.Add(genre.CategoriaNome, genre);
                    }
                }

                return categorias;
            }
        }
    }
}
