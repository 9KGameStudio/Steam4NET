// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("CLIENTENGINE_INTERFACE_VERSION003")]
	public interface IClientEngine
	{
		[VTableSlot(0)]
		Int32 CreateSteamPipe();
		[VTableSlot(1)]
		bool BReleaseSteamPipe(Int32 hSteamPipe);
		[VTableSlot(2)]
		Int32 CreateGlobalUser(ref Int32 phSteamPipe);
		[VTableSlot(3)]
		Int32 ConnectToGlobalUser(Int32 hSteamPipe);
		[VTableSlot(4)]
		Int32 CreateLocalUser(ref Int32 phSteamPipe, EAccountType eAccountType);
		[VTableSlot(5)]
		void CreatePipeToLocalUser(Int32 hSteamUser, ref Int32 phSteamPipe);
		[VTableSlot(6)]
		void ReleaseUser(Int32 hSteamPipe, Int32 hUser);
		[VTableSlot(7)]
		bool IsValidHSteamUserPipe(Int32 hSteamPipe, Int32 hUser);
		[VTableSlot(8)]
		TClass GetIClientUser<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(9)]
		TClass GetIClientGameServer<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(10)]
		void SetLocalIPBinding(UInt32 unIP, UInt16 usPort);
		[VTableSlot(11)]
		string GetUniverseName(EUniverse eUniverse);
		[VTableSlot(12)]
		TClass GetIClientFriends<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(13)]
		TClass GetIClientUtils<TClass>(Int32 hSteamPipe) where TClass : class;
		[VTableSlot(14)]
		TClass GetIClientBilling<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(15)]
		TClass GetIClientMatchmaking<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(16)]
		TClass GetIClientApps<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(17)]
		TClass GetIClientMatchmakingServers<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(18)]
		void RunFrame();
		[VTableSlot(19)]
		UInt32 GetIPCCallCount();
		[VTableSlot(20)]
		TClass GetIClientUserStats<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(21)]
		TClass GetIClientGameServerStats<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(22)]
		TClass GetIClientNetworking<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(23)]
		TClass GetIClientRemoteStorage<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(24)]
		TClass GetIClientScreenshots<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(25)]
		void SetWarningMessageHook(ref IntPtr pFunction);
		[VTableSlot(26)]
		TClass GetIClientGameCoordinator<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(27)]
		void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition);
		[VTableSlot(28)]
		bool HookScreenshots(bool bHook);
		[VTableSlot(29)]
		bool IsOverlayEnabled();
		[VTableSlot(30)]
		bool GetAPICallResult(Int32 hSteamPipe, UInt64 hSteamAPICall, Byte[] pCallback, Int32 cubCallback, Int32 iCallbackExpected, ref bool pbFailed);
		[VTableSlot(31)]
		TClass GetIClientProductBuilder<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(32)]
		TClass GetIClientDepotBuilder<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(33)]
		TClass GetIClientNetworkDeviceManager<TClass>(Int32 hSteamPipe) where TClass : class;
		[VTableSlot(34)]
		void ConCommandInit(ref IntPtr pAccessor);
		[VTableSlot(35)]
		TClass GetIClientAppManager<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(36)]
		TClass GetIClientConfigStore<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(37)]
		bool BOverlayNeedsPresent();
		[VTableSlot(38)]
		TClass GetIClientGameStats<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(39)]
		TClass GetIClientHTTP<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(40)]
		bool BShutdownIfAllPipesClosed();
		[VTableSlot(41)]
		TClass GetIClientAudio<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(42)]
		TClass GetIClientMusic<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(43)]
		TClass GetIClientUnifiedMessages<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(44)]
		TClass GetIClientController<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(45)]
		TClass GetIClientParentalSettings<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(46)]
		TClass GetIClientStreamLauncher<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(47)]
		TClass GetIClientDeviceAuth<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(48)]
		TClass GetIClientRemoteClientManager<TClass>(Int32 hSteamPipe) where TClass : class;
		[VTableSlot(49)]
		TClass GetIClientStreamClient<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(50)]
		TClass GetIClientShortcuts<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(51)]
		TClass GetIClientRemoteControlManager<TClass>(Int32 hSteamPipe) where TClass : class;
		[VTableSlot(52)]
		Int32 Set_ClientAPI_CPostAPIResultInProcess(ref IntPtr arg0);
		[VTableSlot(53)]
		Int32 Remove_ClientAPI_CPostAPIResultInProcess(ref IntPtr arg0);
		[VTableSlot(54)]
		TClass GetIClientUGC<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : class;
		[VTableSlot(55)]
		TClass GetIClientVR<TClass>() where TClass : class;
	};
}
