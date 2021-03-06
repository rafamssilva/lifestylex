﻿using System;

using Xamarin.Forms;

namespace LifeStyle
{
	public class InicioPage : ContentPage
	{
		public InicioPage ()
		{

			Title = "Cadastrar Treino";
			Icon = "icon.png";
			Content = new StackLayout {
				Spacing = 20, Padding = 40,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Entry { Placeholder = "Nome" },
					new Entry { Placeholder =  "Descrição"},
					new Entry { Placeholder = "Modalidade"},
					new Entry { Placeholder = "Frequencia"},


					new Button {
						Text = "Avançar",
						TextColor = Color.White,
						BackgroundColor = Color.FromHex("77D065") }}
			};
		}
	}
}