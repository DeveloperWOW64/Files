﻿// Copyright (c) 2018-2024 Files Community
// Licensed under the MIT License. See the LICENSE file in the root directory.

using Files.Shared.Utils;
using Microsoft.UI.Xaml.Media.Imaging;

namespace Files.App.Data.Models
{
	/// <inheritdoc cref="IImage"/>
	internal sealed class BitmapImageModel : IImage
	{
		public BitmapImage Image { get; }

		public BitmapImageModel(BitmapImage image)
		{
			Image = image;
		}
	}
}
