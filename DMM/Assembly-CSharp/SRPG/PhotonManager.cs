// Decompiled with JetBrains decompiler
// Type: SRPG.PhotonManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using ExitGames.Client.Photon;
using Il2CppDummyDll;
using Photon.Pun;
using Photon.Realtime;
using System.Collections.Generic;
using UnityEngine.Events;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001949")]
  public class PhotonManager : MonoBehaviourPunCallbacks
  {
    [Token(Token = "0x4005BBE")]
    [FieldOffset(Offset = "0x0")]
    private static PhotonManager instance;
    [Token(Token = "0x4005BBF")]
    private const int DisConnectTimeOut = 30000;
    [Token(Token = "0x4005BC0")]
    public const string ECK_ENCRYPT_SEED = "s";
    [Token(Token = "0x4005BC1")]
    public const string ECK_MESSAGE = "m";
    [Token(Token = "0x4005BC2")]
    public const string ECK_MESSAGE_BINARY = "bm";
    [Token(Token = "0x4005BC3")]
    public const string ECK_SEQUENCE_ID = "sq";
    [Token(Token = "0x4005BC4")]
    private const string GAME_VERSION = "1.0";
    [Token(Token = "0x4005BC5")]
    private const string PP_KEY_PLAYER_DATA = "data";
    [Token(Token = "0x4005BC6")]
    private const string PP_KEY_START_BATTLE = "start";
    [Token(Token = "0x4005BC7")]
    private const string PP_KEY_RESUME_ID = "resumeID";
    [Token(Token = "0x4005BC8")]
    private const string RP_KEY_ROOM_DATA = "json";
    [Token(Token = "0x4005BC9")]
    private const string RP_KEY_TOKEN = "token";
    [Token(Token = "0x4005BCA")]
    private const string RP_KEY_STARTING_PLAYER = "started";
    [Token(Token = "0x4005BCB")]
    private const string RP_KEY_START_ROOM = "start";
    [Token(Token = "0x4005BCC")]
    private const string RP_KEY_START_BATTLE = "battle";
    [Token(Token = "0x4005BCD")]
    private const string RP_KEY_START_DRAFT = "draft";
    [Token(Token = "0x4005BCE")]
    private const string RP_KEY_BATTLE_VERSION = "btlver";
    [Token(Token = "0x4005BCF")]
    private const string RP_KEY_LOBBY_TYPE = "lobby";
    [Token(Token = "0x4005BD0")]
    private const string RP_KEY_MATCH_KEY = "matchKey";
    [Token(Token = "0x4005BD1")]
    private const string RP_KEY_IS_LOCK = "lock";
    [Token(Token = "0x4005BD2")]
    private const string RP_KEY_MT_FLOOR = "floor";
    [Token(Token = "0x4005BD3")]
    private const string RP_KEY_BLOCK_LIST = "blockList";
    [Token(Token = "0x4005BD4")]
    private const string RP_KEY_UID = "uid";
    [Token(Token = "0x4005BD5")]
    private const string RP_KEY_LAST_FOUGHT_UID = "luid";
    [Token(Token = "0x4005BD6")]
    private const string RP_KEY_AUDIENCE = "Audience";
    [Token(Token = "0x4005BD7")]
    private const string RP_KEY_AUDIENCE_MAX = "AudienceMax";
    [Token(Token = "0x4005BD8")]
    private const string RP_KEY_PLAYER_LEVEL = "plv";
    [Token(Token = "0x4005BD9")]
    private const string RP_KEY_RANKMATCH_SCORE = "rmScore";
    [Token(Token = "0x4005BDA")]
    private const string RP_KEY_RANKMATCH_CLASS = "rmClass";
    [Token(Token = "0x4005BDB")]
    private const string RP_KEY_LOGGER = "logger";
    [Token(Token = "0x4005BE1")]
    [FieldOffset(Offset = "0x21")]
    public bool IsRoomExitWait;
    [Token(Token = "0x4005BE2")]
    [FieldOffset(Offset = "0x24")]
    private List<PhotonEventData> events;
    [Token(Token = "0x4005BE3")]
    [FieldOffset(Offset = "0x28")]
    private int sendRoomMessageId;
    [Token(Token = "0x4005BE4")]
    [FieldOffset(Offset = "0x2C")]
    private Dictionary<string, PhotonRoomParameter> cachedRoomList;
    [Token(Token = "0x4005BE5")]
    [FieldOffset(Offset = "0x30")]
    private Dictionary<string, Photon.Realtime.RoomInfo> cachedRoomInfoList;
    [Token(Token = "0x4005BE6")]
    [FieldOffset(Offset = "0x34")]
    private PhotonPlayerParameter selfPlayer;
    [Token(Token = "0x4005BE7")]
    [FieldOffset(Offset = "0x38")]
    private PhotonRoomParameter currentRoom;
    [Token(Token = "0x4005BE8")]
    [FieldOffset(Offset = "0x3C")]
    private List<PhotonPlayerParameter> currentRoomPlayers;
    [Token(Token = "0x4005BE9")]
    [FieldOffset(Offset = "0x40")]
    public UnityEvent onDisconnected;
    [Token(Token = "0x4005BEA")]
    [FieldOffset(Offset = "0x44")]
    public UnityEvent onLeaveRoom;
    [Token(Token = "0x4005BEB")]
    [FieldOffset(Offset = "0x48")]
    public UnityEvent onChangeRoomProperty;
    [Token(Token = "0x4005BEC")]
    [FieldOffset(Offset = "0x4C")]
    public PhotonManager.UnityEventPlayer onJoinPlayer;
    [Token(Token = "0x4005BED")]
    [FieldOffset(Offset = "0x50")]
    public PhotonManager.UnityEventPlayer onLeavePlayer;
    [Token(Token = "0x4005BEE")]
    [FieldOffset(Offset = "0x54")]
    public PhotonManager.UnityEventPlayer onChangePlayerProperty;
    [Token(Token = "0x4005BEF")]
    [FieldOffset(Offset = "0x58")]
    public UnityEvent onChangeRoomList;
    [Token(Token = "0x4005BF0")]
    private const string PLAYER_LOGGER_KEY = "Logger";

    [Token(Token = "0x17000A62")]
    public static PhotonManager Instance
    {
      [Token(Token = "0x60066C9"), Address(RVA = "0x32A5C0", Offset = "0x3293C0", VA = "0x1032A5C0")] get
      {
        return (PhotonManager) null;
      }
    }

    [Token(Token = "0x17000A63")]
    public PhotonManager.ErrorCause LastError
    {
      [Token(Token = "0x60066CA"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new PhotonManager.ErrorCause();
      }
      [Token(Token = "0x60066CB"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x17000A64")]
    public short LastReturnCode
    {
      [Token(Token = "0x60066CC"), Address(RVA = "0x32A980", Offset = "0x329780", VA = "0x1032A980")] get
      {
        return new short();
      }
      [Token(Token = "0x60066CD"), Address(RVA = "0x32A990", Offset = "0x329790", VA = "0x1032A990")] private set
      {
      }
    }

    [Token(Token = "0x17000A65")]
    public PhotonManager.State CurrentState
    {
      [Token(Token = "0x60066CE"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new PhotonManager.State();
      }
      [Token(Token = "0x60066CF"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] private set
      {
      }
    }

    [Token(Token = "0x17000A66")]
    public bool IsConnected
    {
      [Token(Token = "0x60066D0"), Address(RVA = "0x32A740", Offset = "0x329540", VA = "0x1032A740")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000A67")]
    public bool IsDisconnected
    {
      [Token(Token = "0x60066D1"), Address(RVA = "0x32A780", Offset = "0x329580", VA = "0x1032A780")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000A68")]
    public bool IsPeerCreated
    {
      [Token(Token = "0x60066D2"), Address(RVA = "0x32A8D0", Offset = "0x3296D0", VA = "0x1032A8D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000A69")]
    public bool IsInLobby
    {
      [Token(Token = "0x60066D3"), Address(RVA = "0x32A830", Offset = "0x329630", VA = "0x1032A830")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000A6A")]
    public bool IsInRoom
    {
      [Token(Token = "0x60066D4"), Address(RVA = "0x32A880", Offset = "0x329680", VA = "0x1032A880")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000A6B")]
    public bool IsGetRoomList
    {
      [Token(Token = "0x60066D5"), Address(RVA = "0x32A7D0", Offset = "0x3295D0", VA = "0x1032A7D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000A6C")]
    public List<PhotonPlayerParameter> StartedPlayers
    {
      [Token(Token = "0x60066D6"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (List<PhotonPlayerParameter>) null;
      }
      [Token(Token = "0x60066D7"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] private set
      {
      }
    }

    [Token(Token = "0x17000A6D")]
    public List<PhotonEventData> Events
    {
      [Token(Token = "0x60066D8"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (List<PhotonEventData>) null;
      }
    }

    [Token(Token = "0x17000A6E")]
    public bool IsRefreshRoomList
    {
      [Token(Token = "0x60066D9"), Address(RVA = "0x305F30", Offset = "0x304D30", VA = "0x10305F30")] get
      {
        return new bool();
      }
      [Token(Token = "0x60066DA"), Address(RVA = "0x305F50", Offset = "0x304D50", VA = "0x10305F50")] private set
      {
      }
    }

    [Token(Token = "0x17000A6F")]
    public bool IsRoomExit
    {
      [Token(Token = "0x60066DB"), Address(RVA = "0x32A920", Offset = "0x329720", VA = "0x1032A920")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60066DC")]
    [Address(RVA = "0x328A20", Offset = "0x327820", VA = "0x10328A20")]
    public void ResetLastError()
    {
    }

    [Token(Token = "0x60066DD")]
    [Address(RVA = "0x328A40", Offset = "0x327840", VA = "0x10328A40")]
    public void Reset()
    {
    }

    [Token(Token = "0x60066DE")]
    [Address(RVA = "0x328A10", Offset = "0x327810", VA = "0x10328A10")]
    public void ResetIsRefreshRoomList()
    {
    }

    [Token(Token = "0x60066DF")]
    [Address(RVA = "0x329E80", Offset = "0x328C80", VA = "0x10329E80")]
    public bool StartConnect(string appID, bool autoJoinLobby = false) => new bool();

    [Token(Token = "0x60066E0")]
    [Address(RVA = "0x323650", Offset = "0x322450", VA = "0x10323650")]
    public void Disconnect()
    {
    }

    [Token(Token = "0x60066E1")]
    [Address(RVA = "0x3236F0", Offset = "0x3224F0", VA = "0x103236F0")]
    public void EnableKeepAlive(bool isMessageQueueRunning)
    {
    }

    [Token(Token = "0x60066E2")]
    [Address(RVA = "0x322920", Offset = "0x321720", VA = "0x10322920")]
    public bool CreateRoom(
      int playerNumMax,
      string token,
      PhotonManager.LobbyType type,
      PhotonRoomData roomData,
      PhotonPlayerData playerData,
      string matchKey = null,
      int floor = -1,
      int plv = -1,
      string lastFoughtUid = null,
      string uid = null,
      int audienceMax = -1,
      int rmScore = 0,
      RankMatchClass rmClass = RankMatchClass.None)
    {
      return new bool();
    }

    [Token(Token = "0x60066E3")]
    [Address(RVA = "0x324010", Offset = "0x322E10", VA = "0x10324010")]
    public bool JoinDirectRoom(string token, PhotonPlayerData playerData, bool isResume = false)
    {
      return new bool();
    }

    [Token(Token = "0x60066E4")]
    [Address(RVA = "0x324CA0", Offset = "0x323AA0", VA = "0x10324CA0")]
    public bool JoinTowerRoomRandom(
      PhotonPlayerData playerData,
      string matchKey,
      int floor,
      string uid)
    {
      return new bool();
    }

    [Token(Token = "0x60066E5")]
    [Address(RVA = "0x325520", Offset = "0x324320", VA = "0x10325520")]
    public bool JoinVersusRoom(
      int playerNumMax,
      PhotonPlayerData playerData,
      string matchKey,
      string token = null,
      bool isLocked = false)
    {
      return new bool();
    }

    [Token(Token = "0x60066E6")]
    [Address(RVA = "0x3241D0", Offset = "0x322FD0", VA = "0x103241D0")]
    public bool JoinRankMatchRoom(
      PhotonPlayerData playerData,
      int plv,
      int rmScore,
      RankMatchClass rmClass,
      string uid,
      int lvRange,
      List<string> excludeUids)
    {
      return new bool();
    }

    [Token(Token = "0x60066E7")]
    [Address(RVA = "0x325AD0", Offset = "0x3248D0", VA = "0x10325AD0")]
    public bool LeaveRoom() => new bool();

    [Token(Token = "0x60066E8")]
    [Address(RVA = "0x325940", Offset = "0x324740", VA = "0x10325940")]
    public bool KickPlayer(int playerId) => new bool();

    [Token(Token = "0x60066E9")]
    [Address(RVA = "0x3257B0", Offset = "0x3245B0", VA = "0x103257B0")]
    public bool KickPlayer(PhotonPlayerParameter player) => new bool();

    [Token(Token = "0x60066EA")]
    [Address(RVA = "0x328E90", Offset = "0x327C90", VA = "0x10328E90")]
    public bool SendRoomMessage(
      byte[] message,
      PhotonManager.SendEventCode sendEventCode,
      bool isForce = false,
      bool reliable = true)
    {
      return new bool();
    }

    [Token(Token = "0x60066EB")]
    [Address(RVA = "0x328CB0", Offset = "0x327AB0", VA = "0x10328CB0")]
    public void SendFlush()
    {
    }

    [Token(Token = "0x60066EC")]
    [Address(RVA = "0x322690", Offset = "0x321490", VA = "0x10322690")]
    public bool CloseRoom() => new bool();

    [Token(Token = "0x60066ED")]
    [Address(RVA = "0x3224D0", Offset = "0x3212D0", VA = "0x103224D0")]
    public bool CloseRoomForResult() => new bool();

    [Token(Token = "0x60066EE")]
    [Address(RVA = "0x329D10", Offset = "0x328B10", VA = "0x10329D10")]
    public bool StartBattle() => new bool();

    [Token(Token = "0x60066EF")]
    [Address(RVA = "0x328850", Offset = "0x327650", VA = "0x10328850")]
    public bool OpenRoom(bool isVisible = true, bool isStarted = false) => new bool();

    [Token(Token = "0x60066F0")]
    [Address(RVA = "0x321FD0", Offset = "0x320DD0", VA = "0x10321FD0")]
    private void Awake()
    {
    }

    [Token(Token = "0x60066F1")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Update()
    {
    }

    [Token(Token = "0x60066F2")]
    [Address(RVA = "0x3261C0", Offset = "0x324FC0", VA = "0x103261C0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60066F3")]
    [Address(RVA = "0x325E30", Offset = "0x324C30", VA = "0x10325E30")]
    private void OnApplicationQuit()
    {
    }

    [Token(Token = "0x60066F4")]
    [Address(RVA = "0x326320", Offset = "0x325120", VA = "0x10326320")]
    private void OnEventHandler(EventData photonEvent)
    {
    }

    [Token(Token = "0x60066F5")]
    [Address(RVA = "0x323800", Offset = "0x322600", VA = "0x10323800")]
    private int GenerateCryptKey() => new int();

    [Token(Token = "0x60066F6")]
    [Address(RVA = "0x328D20", Offset = "0x327B20", VA = "0x10328D20")]
    public static void SendLogKit(string status, string msg)
    {
    }

    [Token(Token = "0x60066F7")]
    [Address(RVA = "0x325D90", Offset = "0x324B90", VA = "0x10325D90")]
    private void Log(string title, string message, bool includeRelease = false)
    {
    }

    [Token(Token = "0x60066F8")]
    [Address(RVA = "0x325CF0", Offset = "0x324AF0", VA = "0x10325CF0")]
    private void LogError(string title, string message, bool includeRelease = false)
    {
    }

    [Token(Token = "0x60066F9")]
    [Address(RVA = "0x323500", Offset = "0x322300", VA = "0x10323500")]
    public static string CreateSendLogKitMessage(
      string base_msg,
      PhotonManager.ErrorCause errorCause)
    {
      return (string) null;
    }

    [Token(Token = "0x60066FA")]
    [Address(RVA = "0x323390", Offset = "0x322190", VA = "0x10323390")]
    public static string CreateSendLogKitMessage(
      string base_msg,
      PhotonManager.ErrorCause errorCause,
      short returnCode)
    {
      return (string) null;
    }

    [Token(Token = "0x60066FB")]
    [Address(RVA = "0x323420", Offset = "0x322220", VA = "0x10323420")]
    public static string CreateSendLogKitMessage(
      string base_msg,
      PhotonManager.ErrorCause errorCause,
      short returnCode,
      string roomName)
    {
      return (string) null;
    }

    [Token(Token = "0x60066FC")]
    [Address(RVA = "0x326050", Offset = "0x324E50", VA = "0x10326050", Slot = "30")]
    public override void OnConnected()
    {
    }

    [Token(Token = "0x60066FD")]
    [Address(RVA = "0x325E80", Offset = "0x324C80", VA = "0x10325E80", Slot = "45")]
    public override void OnConnectedToMaster()
    {
    }

    [Token(Token = "0x60066FE")]
    [Address(RVA = "0x326A50", Offset = "0x325850", VA = "0x10326A50", Slot = "36")]
    public override void OnJoinedLobby()
    {
    }

    [Token(Token = "0x60066FF")]
    [Address(RVA = "0x327660", Offset = "0x326460", VA = "0x10327660", Slot = "40")]
    public override void OnRoomListUpdate(List<Photon.Realtime.RoomInfo> roomList)
    {
    }

    [Token(Token = "0x6006700")]
    [Address(RVA = "0x32A050", Offset = "0x328E50", VA = "0x1032A050")]
    private void UpdateCachedRoomInfoList(List<Photon.Realtime.RoomInfo> roomList)
    {
    }

    [Token(Token = "0x6006701")]
    [Address(RVA = "0x326BA0", Offset = "0x3259A0", VA = "0x10326BA0", Slot = "41")]
    public override void OnJoinedRoom()
    {
    }

    [Token(Token = "0x6006702")]
    [Address(RVA = "0x322160", Offset = "0x320F60", VA = "0x10322160")]
    private void CachePlayers()
    {
    }

    [Token(Token = "0x6006703")]
    [Address(RVA = "0x327090", Offset = "0x325E90", VA = "0x10327090", Slot = "31")]
    public override void OnLeftRoom()
    {
    }

    [Token(Token = "0x6006704")]
    [Address(RVA = "0x3271A0", Offset = "0x325FA0", VA = "0x103271A0", Slot = "42")]
    public override void OnPlayerEnteredRoom(Photon.Realtime.Player newPlayer)
    {
    }

    [Token(Token = "0x6006705")]
    [Address(RVA = "0x327360", Offset = "0x326160", VA = "0x10327360", Slot = "43")]
    public override void OnPlayerLeftRoom(Photon.Realtime.Player otherPlayer)
    {
    }

    [Token(Token = "0x6006706")]
    [Address(RVA = "0x327D10", Offset = "0x326B10", VA = "0x10327D10", Slot = "46")]
    public override void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged)
    {
    }

    [Token(Token = "0x6006707")]
    [Address(RVA = "0x3274E0", Offset = "0x3262E0", VA = "0x103274E0", Slot = "47")]
    public override void OnPlayerPropertiesUpdate(Photon.Realtime.Player targetPlayer, Hashtable changedProps)
    {
    }

    [Token(Token = "0x6006708")]
    [Address(RVA = "0x326200", Offset = "0x325000", VA = "0x10326200", Slot = "38")]
    public override void OnDisconnected(DisconnectCause cause)
    {
    }

    [Token(Token = "0x6006709")]
    [Address(RVA = "0x3260D0", Offset = "0x324ED0", VA = "0x103260D0", Slot = "33")]
    public override void OnCreateRoomFailed(short returnCode, string message)
    {
    }

    [Token(Token = "0x600670A")]
    [Address(RVA = "0x326930", Offset = "0x325730", VA = "0x10326930", Slot = "34")]
    public override void OnJoinRoomFailed(short returnCode, string message)
    {
    }

    [Token(Token = "0x600670B")]
    [Address(RVA = "0x326840", Offset = "0x325640", VA = "0x10326840", Slot = "44")]
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
    }

    [Token(Token = "0x600670C")]
    [Address(RVA = "0x3282E0", Offset = "0x3270E0", VA = "0x103282E0", Slot = "51")]
    public override void OnWebRpcResponse(OperationResponse response)
    {
    }

    [Token(Token = "0x600670D")]
    [Address(RVA = "0x328AF0", Offset = "0x3278F0", VA = "0x10328AF0")]
    public void SaveStartingPlayers()
    {
    }

    [Token(Token = "0x600670E")]
    [Address(RVA = "0x325B80", Offset = "0x324980", VA = "0x10325B80")]
    public PhotonPlayerStarted LoadStartingPlayers() => (PhotonPlayerStarted) null;

    [Token(Token = "0x600670F")]
    [Address(RVA = "0x321EC0", Offset = "0x320CC0", VA = "0x10321EC0")]
    public void AddBattleInfoJsonForAudience(string json)
    {
    }

    [Token(Token = "0x6006710")]
    [Address(RVA = "0x322430", Offset = "0x321230", VA = "0x10322430")]
    public bool CanResumeMultiTower(string roomname) => new bool();

    [Token(Token = "0x6006711")]
    [Address(RVA = "0x323B60", Offset = "0x322960", VA = "0x10323B60")]
    public PhotonRoomParameter GetVersusRoomForLobby(int roomId) => (PhotonRoomParameter) null;

    [Token(Token = "0x6006712")]
    [Address(RVA = "0x322490", Offset = "0x321290", VA = "0x10322490")]
    public void ClearPlayerProperties()
    {
    }

    [Token(Token = "0x6006713")]
    [Address(RVA = "0x3294E0", Offset = "0x3282E0", VA = "0x103294E0")]
    public void SetPlayerData(PhotonPlayerData playerData)
    {
    }

    [Token(Token = "0x6006714")]
    [Address(RVA = "0x329830", Offset = "0x328630", VA = "0x10329830")]
    public void SetPlayerStartBattle()
    {
    }

    [Token(Token = "0x6006715")]
    [Address(RVA = "0x329750", Offset = "0x328550", VA = "0x10329750")]
    public void SetPlayerResume(int resumeID, int seat)
    {
    }

    [Token(Token = "0x6006716")]
    [Address(RVA = "0x329630", Offset = "0x328430", VA = "0x10329630")]
    public void SetPlayerRejoin()
    {
    }

    [Token(Token = "0x6006717")]
    [Address(RVA = "0x323AF0", Offset = "0x3228F0", VA = "0x10323AF0")]
    public PhotonPlayerParameter GetSelfPlayerParameter() => (PhotonPlayerParameter) null;

    [Token(Token = "0x6006718")]
    [Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")]
    public List<PhotonPlayerParameter> GetCurrentRoomPlayerList()
    {
      return (List<PhotonPlayerParameter>) null;
    }

    [Token(Token = "0x6006719")]
    [Address(RVA = "0x3239F0", Offset = "0x3227F0", VA = "0x103239F0")]
    public List<PhotonRoomParameter> GetRoomList() => (List<PhotonRoomParameter>) null;

    [Token(Token = "0x600671A")]
    [Address(RVA = "0x329B40", Offset = "0x328940", VA = "0x10329B40")]
    public void SetRoomData(PhotonRoomData roomData)
    {
    }

    [Token(Token = "0x600671B")]
    [Address(RVA = "0x329900", Offset = "0x328700", VA = "0x10329900")]
    public void SetRoomDataUID()
    {
    }

    [Token(Token = "0x600671C")]
    [Address(RVA = "0x32A110", Offset = "0x328F10", VA = "0x1032A110")]
    public void UpdateRoomFloor(int floor)
    {
    }

    [Token(Token = "0x600671D")]
    [Address(RVA = "0x32A170", Offset = "0x328F70", VA = "0x1032A170")]
    public void UpdateRoomLock(bool isLock)
    {
    }

    [Token(Token = "0x600671E")]
    [Address(RVA = "0x32A1D0", Offset = "0x328FD0", VA = "0x1032A1D0")]
    public void UpdateRoomParam(string key, object data)
    {
    }

    [Token(Token = "0x600671F")]
    [Address(RVA = "0x3238B0", Offset = "0x3226B0", VA = "0x103238B0")]
    public PhotonRoomParameter GetCurrentRoom() => (PhotonRoomParameter) null;

    [Token(Token = "0x6006720")]
    [Address(RVA = "0x3291B0", Offset = "0x327FB0", VA = "0x103291B0")]
    public void SetHostUid(string uid)
    {
    }

    [Token(Token = "0x6006721")]
    [Address(RVA = "0x323FF0", Offset = "0x322DF0", VA = "0x10323FF0")]
    public bool IsHost() => new bool();

    [Token(Token = "0x6006722")]
    [Address(RVA = "0x323DF0", Offset = "0x322BF0", VA = "0x10323DF0")]
    public bool IsHost(PhotonPlayerParameter target) => new bool();

    [Token(Token = "0x6006723")]
    [Address(RVA = "0x323910", Offset = "0x322710", VA = "0x10323910")]
    public PhotonPlayerParameter GetHost() => (PhotonPlayerParameter) null;

    [Token(Token = "0x6006724")]
    [Address(RVA = "0x3292D0", Offset = "0x3280D0", VA = "0x103292D0")]
    private PhotonPlayerParameter SetPhotonPlayerParameter(
      Photon.Realtime.Player player,
      PhotonPlayerParameter playerParam = null)
    {
      return (PhotonPlayerParameter) null;
    }

    [Token(Token = "0x6006725")]
    [Address(RVA = "0x323560", Offset = "0x322360", VA = "0x10323560")]
    public static TypedLobby CreateTypedLobby(
      PhotonRoomData.RoomType roomType,
      VERSUS_TYPE versusType)
    {
      return (TypedLobby) null;
    }

    [Token(Token = "0x6006726")]
    [Address(RVA = "0x32A2D0", Offset = "0x3290D0", VA = "0x1032A2D0")]
    public PhotonManager()
    {
    }

    [Token(Token = "0x200194A")]
    public enum ErrorCause
    {
      [Token(Token = "0x4005BF2")] None,
      [Token(Token = "0x4005BF3")] Unknown,
      [Token(Token = "0x4005BF4")] IllegalState,
      [Token(Token = "0x4005BF5")] TimeOut,
      [Token(Token = "0x4005BF6")] LostConnection,
      [Token(Token = "0x4005BF7")] FullClients,
      [Token(Token = "0x4005BF8")] DuplicatedRoomName,
      [Token(Token = "0x4005BF9")] RoomIsFull,
      [Token(Token = "0x4005BFA")] RoomIsNotExist,
      [Token(Token = "0x4005BFB")] RoomIsClose,
      [Token(Token = "0x4005BFC")] FailedRaiseEvent,
    }

    [Token(Token = "0x200194B")]
    public enum State
    {
      [Token(Token = "0x4005BFE")] None,
      [Token(Token = "0x4005BFF")] Connecting,
      [Token(Token = "0x4005C00")] InLobby,
      [Token(Token = "0x4005C01")] JoiningRoom,
      [Token(Token = "0x4005C02")] InRoom,
      [Token(Token = "0x4005C03")] LeavingRoom,
    }

    [Token(Token = "0x200194C")]
    public enum SendEventCode : byte
    {
      [Token(Token = "0x4005C05")] Normal,
      [Token(Token = "0x4005C06")] Resume,
      [Token(Token = "0x4005C07")] Sync,
    }

    [Token(Token = "0x200194D")]
    public enum LobbyType
    {
      [Token(Token = "0x4005C09")] Coop,
      [Token(Token = "0x4005C0A")] VS,
      [Token(Token = "0x4005C0B")] Tower,
      [Token(Token = "0x4005C0C")] RankMatch,
    }

    [Token(Token = "0x200194E")]
    public class UnityEventPlayer : UnityEvent<PhotonPlayerParameter>
    {
      [Token(Token = "0x6006728")]
      [Address(RVA = "0x32ECA0", Offset = "0x32DAA0", VA = "0x1032ECA0")]
      public UnityEventPlayer()
      {
      }
    }
  }
}
