using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JetSolutionsApp.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Controle : MasterDetailPage
    {
        public Controle()
        {
            InitializeComponent();

            Master = new Menu();
            Detail = new NavigationPage(new Home());
        }
    }
}