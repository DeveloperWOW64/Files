﻿// Copyright (c) 2018-2024 Files Community
// Licensed under the MIT License. See the LICENSE.

namespace Files.App.Actions
{
	internal sealed class NewWindowAction : IAction
	{
		public string Label
			=> "NewWindow".GetLocalizedResource();

		public string Description
			=> "NewWindowDescription".GetLocalizedResource();

		public HotKey HotKey
			=> new(Keys.N, KeyModifiers.Ctrl);

		public RichGlyph Glyph
			=> new(themedIconStyle: "App.ThemedIcons.New.Window");

		public NewWindowAction()
		{
		}

		public Task ExecuteAsync(object? parameter = null)
		{
			return NavigationHelpers.LaunchNewWindowAsync();
		}
	}
}
