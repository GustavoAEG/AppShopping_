﻿using System;
using System.Collections.Generic;
using System.Text;
using AppShopping_.Model;
using AppShopping_.Libraries.Enums;
namespace AppShopping_.Services
{
    public class AvailabilityService
    {
        public List
        <Availability>
        GetAvailabilities()
        {
            var availabilities = new List
            <Availability>
            ()
{
            new Availability()
            {
            Id=1,
            Type= OrderAvailability.PratosPrincipais,
            Apresentacao="https://upload.wikimedia.org/wikipedia/commons/thumb/6/60/Sushi_platter.jpg/220px-Sushi_platter.jpg",
            Name ="Sushi",
            Description="A forma tradicional do sushi é peixe fermentado e arroz, conservados com sal, em um processo originário do Sudeste Asiático, onde ainda continua popular nos dias de hoje.",
            Vegan=false,
            Price=29.90,
            },
             new Availability()
            {
            Id=1,
            Type= OrderAvailability.PratosPrincipais,
            Apresentacao="https://upload.wikimedia.org/wikipedia/commons/thumb/4/42/Traditional_Sashimi_with_a_twist.jpg/220px-Traditional_Sashimi_with_a_twist.jpg",
            Name ="Sashimi",
            Description="A forma tradicional do sushi é peixe fermentado e arroz, conservados com sal, em um processo originário do Sudeste Asiático, onde ainda continua popular nos dias de hoje.",
            Vegan=false,
            Price=29.90,
            },
              new Availability()
            {
            Id=1,
            Type= OrderAvailability.PratosPrincipais,
            Apresentacao="https://upload.wikimedia.org/wikipedia/commons/thumb/6/63/Sashimi_of_Chicken.jpg/220px-Sashimi_of_Chicken.jpg",
            Name ="Sashimi stzo",
            Description="A forma tradicional do sushi é peixe fermentado e arroz, conservados com sal, em um processo originário do Sudeste Asiático, onde ainda continua popular nos dias de hoje.",
            Vegan=false,
            Price=29.90,
            }
            };
            return availabilities;
        }
    }
}