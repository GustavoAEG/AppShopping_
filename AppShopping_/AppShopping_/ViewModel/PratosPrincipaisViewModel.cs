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
    class PratosPrincipaisViewModel:BaseViewModel
    {
        public string SearchWord { get; set; }

        public string Name { get; set; }
        public ICommand SearchCommand { get; set; }
        public List<PratosPrincipais> _allAvailabilities;

        public List<PratosPrincipais> pratosPrincipais
        {
            get
            {
                return _allAvailabilities;
            }
            set
            {
                SetProperty(ref _allAvailabilities, value);
            }
           

        }

        public PratosPrincipaisViewModel()
        {
            SearchCommand = new Command(Search);

            var allAvailabilities = new PratosPrincipaisService().GetAvailabilities();
            var allPratosPrincipais = allAvailabilities.Where(a => a.Type == OrderAvailability.PratosPrincipais).ToList();
            pratosPrincipais = allPratosPrincipais;
            _allAvailabilities = allPratosPrincipais;
        }

        private void Search()
        {
            pratosPrincipais = _allAvailabilities.Where(a => a.Name.ToLower().Contains(SearchWord.ToLower())).ToList();
        }
    }
}
