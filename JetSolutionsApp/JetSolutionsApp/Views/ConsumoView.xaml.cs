using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jetSolutions.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jetSolutions.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsumoView : ContentPage
    {
        internal Insumo I { get; set; } = new Insumo();

        public string optionAgua => String.Format("Água  -  R$ {0}", I.agua);
        public string optionSuco => String.Format("Suco  -  R$ {0}", I.suco);
        public String optionSorvete => String.Format("Sorvete  -  R${0}", I.sorvete);
        public String optionNozes => String.Format("Nozes  -  R$ {0} ", I.nozes);
        public string optionCastanhas => String.Format("Castanhas  -  R$ {0}", I.castanhas);
        public string optionFrutas => String.Format("Frutas  -  R$ {0}", I.frutas); 

        public ConsumoView()
        {
            InitializeComponent();

            this.BindingContext = this;
        }


    }
}