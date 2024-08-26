﻿// Copyright (c) 2018-2024 Files Community
// Licensed under the MIT License. See the LICENSE file in the root directory.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;

namespace Files.App.Data.Contracts
{
	public interface IDevToolsSettingsService : IBaseSettingsService, INotifyPropertyChanged
	{
		/// <summary>
		/// Gets or sets a value when the Open in IDE button should be displayed on the status bar.
		/// </summary>
		OpenInIDEOption OpenInIDEOption { get; set; }
	}
}
