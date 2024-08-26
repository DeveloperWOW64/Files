﻿// Copyright (c) 2018-2024 Files Community
// Licensed under the MIT License. See the LICENSE file in the root directory.

using Microsoft.UI.Xaml.Controls;

namespace Files.App.Data.EventArguments
{
	public sealed class WidgetsRightClickedItemChangedEventArgs
	{
		public WidgetCardItem? Item { get; set; }

		public CommandBarFlyout? Flyout { get; set; }

		public WidgetsRightClickedItemChangedEventArgs(WidgetCardItem? item = null, CommandBarFlyout? flyout = null)
		{
			Item = item;
			Flyout = flyout;
		}
	}
}
