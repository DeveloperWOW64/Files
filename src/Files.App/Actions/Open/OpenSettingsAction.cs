﻿// Copyright (c) 2018-2024 Files Community
// Licensed under the MIT License. See the LICENSE file in the root directory.

namespace Files.App.Actions
{
	internal sealed class OpenSettingsAction : BaseUIAction, IAction
	{
		private readonly IDialogService dialogService = Ioc.Default.GetRequiredService<IDialogService>();

		private readonly SettingsDialogViewModel viewModel = new();

		public string Label
			=> "Settings".GetLocalizedResource();

		public string Description
			=> "OpenSettingsDescription".GetLocalizedResource();

		public HotKey HotKey
			=> new(Keys.OemComma, KeyModifiers.Ctrl);

		public Task ExecuteAsync(object? parameter = null)
		{
			var dialog = dialogService.GetDialog(viewModel);
			return dialog.TryShowAsync();
		}
	}
}
