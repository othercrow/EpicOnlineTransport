// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.UserInfo
{
	/// <summary>
	/// Input parameters for the <see cref="UserInfoInterface.CopyExternalUserInfoByAccountType" /> function.
	/// </summary>
	public class CopyExternalUserInfoByAccountTypeOptions
	{
		/// <summary>
		/// The Epic Online Services Account ID of the local player requesting the information
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// The Epic Online Services Account ID of the player whose information is being retrieved
		/// </summary>
		public EpicAccountId TargetUserId { get; set; }

		/// <summary>
		/// Account type of the external user info to retrieve from the cache
		/// </summary>
		public ExternalAccountType AccountType { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct CopyExternalUserInfoByAccountTypeOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_TargetUserId;
		private ExternalAccountType m_AccountType;

		public EpicAccountId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public EpicAccountId TargetUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_TargetUserId, value);
			}
		}

		public ExternalAccountType AccountType
		{
			set
			{
				m_AccountType = value;
			}
		}

		public void Set(CopyExternalUserInfoByAccountTypeOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = UserInfoInterface.CopyexternaluserinfobyaccounttypeApiLatest;
				LocalUserId = other.LocalUserId;
				TargetUserId = other.TargetUserId;
				AccountType = other.AccountType;
			}
		}

		public void Set(object other)
		{
			Set(other as CopyExternalUserInfoByAccountTypeOptions);
		}

		public void Dispose()
		{
		}
	}
}