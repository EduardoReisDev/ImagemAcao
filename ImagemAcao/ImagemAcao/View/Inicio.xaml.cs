﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImagemAcao.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();

            BindingContext = new Grupo();
        }

        public class Grupo{
            public string NomeGrupo1 { get; set; }

            public Grupo()
            {
                NomeGrupo1 = "Os Machos";
            }

        }

    }
}