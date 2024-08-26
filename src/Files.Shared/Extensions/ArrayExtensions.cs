﻿// Copyright (c) 2018-2024 Files Community
// Licensed under the MIT License. See the LICENSE file in the root directory.

using System;

namespace Files.Shared.Extensions
{
	public static class ArrayExtensions
	{
		public static T[] CloneArray<T>(this T[] array)
		{
			var clonedArray = new T[array.Length];
			Array.Copy(array, 0, clonedArray, 0, array.Length);

			return clonedArray;
		}
	}
}
