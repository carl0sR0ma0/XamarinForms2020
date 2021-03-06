﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App01_ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryEditorPager : ContentPage
    {
        public EntryEditorPager()
        {
            InitializeComponent();

            TxtIdade.TextChanged += delegate (object sender, TextChangedEventArgs args)
            {
                Lbl_Duplicado.Text = args.NewTextValue;
            };

            TxtComentario.Completed += delegate (object sender, EventArgs args)
            {
                LblQtdCaracteres.Text = TxtComentario.Text.Length.ToString();
            };
        }
    }
}