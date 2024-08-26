// Copyright (c) 2018-2024 Files Community
// Licensed under the MIT License. See the LICENSE file in the root directory.

namespace Files.App.Utils.Storage
{
	public interface IStorageHistoryOperations : IDisposable
	{
		/// <summary>
		/// Redo an action with given <paramref name="history"/>
		/// </summary>
		/// <param name="history"></param>
		/// <returns></returns>
		Task<ReturnResult> Undo(IStorageHistory history);

		/// <summary>
		/// Redo an action with given <paramref name="history"/>
		/// </summary>
		/// <param name="history"></param>
		/// <returns></returns>
		Task<ReturnResult> Redo(IStorageHistory history);
	}
}