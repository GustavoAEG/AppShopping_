using AppShopping_.Libraries.Helpers.MVVM;
using AppShopping_.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppShopping_.ViewModel
{
    class PratosPrincipaisDetailViewModel:BaseViewModel
    {

        public Pratos Pratos { get; set; }

        public PratosPrincipaisDetailViewModel() //ctor vai definir valor p estabelecimento
        {
            Pratos = new PratosService().getPratos().First();
        }
    }
}
