﻿// Copyright (c) 2018-2024 Files Community
// Licensed under the MIT License. See the LICENSE.

namespace Files.Core.Storage.Extensions
{
	public static partial class StorageExtensions
	{
		/// <summary>
		/// Tries to obtain path from the storable.
		/// </summary>
		/// <param name="storable">The storable item to get the path from.</param>
		/// <returns>A path pointing to the <paramref name="storable"/> item.</returns>
		public static string TryGetPath(this IStorable storable)
		{
			return (storable as ILocatableStorable)?.Path ?? storable.Id;
		}
	}
}