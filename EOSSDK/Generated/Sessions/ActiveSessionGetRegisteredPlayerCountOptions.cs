// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="ActiveSession.GetRegisteredPlayerCount" /> function.
	/// </summary>
	public class ActiveSessionGetRegisteredPlayerCountOptions
	{
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct ActiveSessionGetRegisteredPlayerCountOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;

		public void Set(ActiveSessionGetRegisteredPlayerCountOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = ActiveSession.ActivesessionGetregisteredplayercountApiLatest;
			}
		}

		public void Set(object other)
		{
			Set(other as ActiveSessionGetRegisteredPlayerCountOptions);
		}

		public void Dispose()
		{
		}
	}
}