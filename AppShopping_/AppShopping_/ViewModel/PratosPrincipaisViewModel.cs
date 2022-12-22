using AppShopping_.Libraries.Enums;
using AppShopping_.Libraries.Helpers.MVVM;
using AppShopping_.Model;
using AppShopping_.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppShopping_.ViewModel
{
    public class PratosPrincipaisViewModel:BaseViewModel
    {
            public string SearchWord { get; set; }
            public ICommand SearchCommand { get; set; }

            public List<PratosPrincipais> _pratosPrincipais;

        public List<PratosPrincipais> PratosPrincipais {
                get
                {
                    return _pratosPrincipais;
                }
                set
                {
                    SetProperty(ref _pratosPrincipais, value);
                }
        }

        private List<PratosPrincipais> _allPratosPrincipais;

        public PratosPrincipaisViewModel()
        {
            SearchCommand = new Command(Search);

            var allPratosPrincipais = new PratosPrincipaisService().GetPratosPrincipais();
            var allPratos = allPratosPrincipais.Where(a => a.Type == OrderAvailability.PratosPrincipais).ToList();
            PratosPrincipais = allPratos;
            _allPratosPrincipais = allPratos;
        }

        private void Search()
        {
            PratosPrincipais = _allPratosPrincipais.Where(a => a.Name.ToLower().Contains(SearchWord.ToLower())).ToList();
        }
    }
}
