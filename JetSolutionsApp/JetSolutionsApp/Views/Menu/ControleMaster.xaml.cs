﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JetSolutionsApp.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ControleMaster : MasterDetailPage
    {
        public ControleMaster()
        {
            InitializeComponent();
            Detail = new NavigationPage(new Home());
            Master = new MenuLateral();
            Application.Naveg = this;
        }
    }
}