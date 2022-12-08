using System;
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
            Apresentacao="https://img.freepik.com/fotos-gratis/sushi-conjunto-rolos-quentes-abacate-california-e-salmao-rola_141793-1279.jpg"
            Name="Sushi",
            Description="sadasda",
            Vegan=false,
            Price=29.90,
            }
            };
            return availabilities;
        }
    }
}