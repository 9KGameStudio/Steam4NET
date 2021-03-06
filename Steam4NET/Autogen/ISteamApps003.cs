// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("STEAMAPPS_INTERFACE_VERSION003")]
	public interface ISteamApps003
	{
		[VTableSlot(0)]
		bool BIsSubscribed();
		[VTableSlot(1)]
		bool BIsLowViolence();
		[VTableSlot(2)]
		bool BIsCybercafe();
		[VTableSlot(3)]
		bool BIsVACBanned();
		[VTableSlot(4)]
		string GetCurrentGameLanguage();
		[VTableSlot(5)]
		string GetAvailableGameLanguages();
		[VTableSlot(6)]
		bool BIsSubscribedApp(UInt32 nAppID);
		[VTableSlot(7)]
		bool BIsDlcInstalled(UInt32 nAppID);
	};
}
