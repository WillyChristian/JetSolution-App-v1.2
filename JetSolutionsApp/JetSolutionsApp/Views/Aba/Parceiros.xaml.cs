﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JetSolutionsApp.Views.Aba
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Parceiros : ContentPage
    {
        public object slideTopo;

        public Parceiros() => InitializeComponent();
    }

}