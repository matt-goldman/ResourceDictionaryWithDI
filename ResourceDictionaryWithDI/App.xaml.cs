﻿namespace ResourceDictionaryWithDI;

public partial class App : Application
{
	public App(MainPage page)
	{
		InitializeComponent();

		MainPage = page;// new AppShell();
	}
}
