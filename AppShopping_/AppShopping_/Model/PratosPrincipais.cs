using System;
using System.Collections.Generic;
using System.Text;
using AppShopping_.Libraries.Enums;

namespace AppShopping_.Model
{
    public class PratosPrincipais
    {
        public int Id { get; set; }
        public OrderAvailability Type { get; set; }
        public string Apresentacao { get; set; }
        public string Prato_imagem1 { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Boolean Vegan { get; set; }
        public string Ingredints { get; set; }
        public double Price { get; set; }


    }
}
