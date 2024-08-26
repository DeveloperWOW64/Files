﻿// Copyright (c) 2018-2024 Files Community
// Licensed under the MIT License. See the LICENSE file in the root directory.

namespace Files.App.Data.EventArguments
{
	internal sealed class MainPageNavigationArguments
	{
		public object? Parameter { get; set; }

		public bool IgnoreStartupSettings { get; set; }
	}
}
