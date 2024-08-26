﻿// Copyright (c) 2018-2024 Files Community
// Licensed under the MIT License. See the LICENSE file in the root directory.

using Files.App.Views;
using Microsoft.UI.Xaml.Controls;
using Windows.ApplicationModel.DataTransfer;

namespace Files.App.Data.EventArguments
{
	public sealed class ToolbarPathItemLoadedEventArgs
	{
		public MenuFlyout OpenedFlyout { get; set; }

		public PathBoxItem Item { get; set; }
	}
}
