using AppShopping_.Libraries.Helpers.MVVM;
using AppShopping_.Model;
using AppShopping_.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppShopping_.ViewModel
{
    class PratosPrincipaisDetailViewModel:BaseViewModel
    {
            
        public PratosPrincipais PratosPrincipais { get; set; }

        public PratosPrincipaisDetailViewModel()
        {
            PratosPrincipais = new PratosPrincipaisService().GetPratosPrincipais().First();
        }

    }
}
