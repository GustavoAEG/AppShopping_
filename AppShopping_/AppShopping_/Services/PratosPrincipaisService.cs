using System;
using System.Collections.Generic;
using System.Text;
using AppShopping_.ViewModel;
using AppShopping_.Model;
using AppShopping_.Libraries.Enums;
namespace AppShopping_.Services
{
    public class PratosPrincipaisService
    {
        public List<PratosPrincipais> GetPratosPrincipais()
        {
            var PratosPrincipais = new List<PratosPrincipais>()
{
            new PratosPrincipais()
            {
            Id=1,
            Type= OrderAvailability.PratosPrincipais,
            Apresentacao="https://soubh.uai.com.br/uploads/post/image/12596/main_IMG_2410.jpg",
            Name ="Sushi",
            Description="A forma tradicional do sushi é peixe fermentado e arroz, conservados com sal, em um processo originário do Sudeste Asiático, onde ainda continua popular nos dias de hoje.",
            Vegan=false,
            Price=29.90,
            },
             new PratosPrincipais()
            {
            Id=2,
            Type= OrderAvailability.PratosPrincipais,
            Apresentacao="https://upload.wikimedia.org/wikipedia/commons/thumb/4/42/Traditional_Sashimi_with_a_twist.jpg/220px-Traditional_Sashimi_with_a_twist.jpg",
            Name ="Sashimi",
            Description="A forma tradicional do sushi é peixe fermentado e arroz, conservados com sal, em um processo originário do Sudeste Asiático, onde ainda continua popular nos dias de hoje.",
            Vegan=false,
            Price=29.90,
            },
              new PratosPrincipais()
            {
            Id=3,
            Type= OrderAvailability.PratosPrincipais,
            Apresentacao="https://upload.wikimedia.org/wikipedia/commons/thumb/6/63/Sashimi_of_Chicken.jpg/220px-Sashimi_of_Chicken.jpg",
            Name ="Sashimi stzo",
            Description="A forma tradicional do sushi é peixe fermentado e arroz, conservados com sal, em um processo originário do Sudeste Asiático, onde ainda continua popular nos dias de hoje.",
            Vegan=false,
            Price=29.90,
            }
            };
            return PratosPrincipais;
        }
    }
}