﻿// Copyright (c) 2018-2024 Files Community
// Licensed under the MIT License. See the LICENSE file in the root directory.

namespace Files.App.Actions
{
	internal sealed class NewTabAction : IAction
	{
		public string Label
			=> "NewTab".GetLocalizedResource();

		public string Description
			=> "NewTabDescription".GetLocalizedResource();

		public HotKey HotKey
			=> new(Keys.T, KeyModifiers.Ctrl);

		public NewTabAction()
		{
		}

		public Task ExecuteAsync(object? parameter = null)
		{
			return NavigationHelpers.AddNewTabAsync();
		}
	}
}
