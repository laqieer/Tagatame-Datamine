// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_StartQuest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001633")]
  [FlowNode.Pin(251, "LoadRankMatchNpc", FlowNode.PinTypes.Input, 7)]
  [FlowNode.Pin(1300, "LoadAdvanceBoss", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(1200, "LoadGenesisBoss", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(1000, "LoadOrdeal", FlowNode.PinTypes.Input, 9)]
  [FlowNode.Pin(600, "LoadRaidBoss", FlowNode.PinTypes.Input, 8)]
  [FlowNode.Pin(1400, "LoadGuildRaid", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(250, "LoadRankMatch", FlowNode.PinTypes.Input, 6)]
  [FlowNode.Pin(20, "AudienceConnect", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(200, "LoadVersus", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(500, "LoadMultiTower", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(100, "LoadMultiPlay", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(0, "Load", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("System/Quest/Start", 32741)]
  [FlowNode.Pin(1500, "LoadGvG", FlowNode.PinTypes.Input, 13)]
  [FlowNode.Pin(700, "LoadVersusCpu", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(10, "Resume", FlowNode.PinTypes.Input, 51)]
  [FlowNode.Pin(904, "RaidTimeOverRescue", FlowNode.PinTypes.Output, 219)]
  [FlowNode.Pin(5001, "Download Timeout", FlowNode.PinTypes.Output, 5001)]
  [FlowNode.Pin(1450, "LoadGuildRaidTraining", FlowNode.PinTypes.Input, 111)]
  [FlowNode.Pin(1, "Started", FlowNode.PinTypes.Output, 201)]
  [AddComponentMenu("")]
  [FlowNode.Pin(2, "Failed", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(3, "NoMatchVersion", FlowNode.PinTypes.Output, 203)]
  [FlowNode.Pin(4, "MultiMaintenance", FlowNode.PinTypes.Output, 204)]
  [FlowNode.Pin(5, "NetworkSuccess", FlowNode.PinTypes.Output, 205)]
  [FlowNode.Pin(6, "ColoRankModify", FlowNode.PinTypes.Output, 206)]
  [FlowNode.Pin(7, "MatchSuccess", FlowNode.PinTypes.Output, 207)]
  [FlowNode.Pin(8, "NoRoom", FlowNode.PinTypes.Output, 208)]
  [FlowNode.Pin(9, "NoAudienceData", FlowNode.PinTypes.Output, 209)]
  [FlowNode.Pin(300, "AudienceFailed", FlowNode.PinTypes.Output, 210)]
  [FlowNode.Pin(301, "AudienceFailedMax", FlowNode.PinTypes.Output, 211)]
  [FlowNode.Pin(400, "NotGpsQuest", FlowNode.PinTypes.Output, 212)]
  [FlowNode.Pin(501, "NotRoomMT", FlowNode.PinTypes.Output, 213)]
  [FlowNode.Pin(800, "QuestResumeFailed_IsRehash", FlowNode.PinTypes.Output, 214)]
  [FlowNode.Pin(900, "RaidTimeOut", FlowNode.PinTypes.Output, 215)]
  [FlowNode.Pin(1720, "DragonGodOutOfPeriod", FlowNode.PinTypes.Output, 228)]
  [FlowNode.Pin(1710, "StartedRestorePositionSet", FlowNode.PinTypes.Output, 227)]
  [FlowNode.Pin(1620, "WorldRaidOutOfPeriod", FlowNode.PinTypes.Output, 226)]
  [FlowNode.Pin(1610, "WorldRaidNeedRefresh", FlowNode.PinTypes.Output, 225)]
  [FlowNode.Pin(1410, "GuildRaidNeedRefresh", FlowNode.PinTypes.Output, 224)]
  [FlowNode.Pin(1260, "AdvanceNotOpen", FlowNode.PinTypes.Output, 223)]
  [FlowNode.Pin(30, "AudienceStart", FlowNode.PinTypes.Input, 102)]
  [FlowNode.Pin(906, "RaidScheduleTimeOut", FlowNode.PinTypes.Output, 222)]
  [FlowNode.Pin(905, "RaidAlreadyRescueCancel", FlowNode.PinTypes.Output, 220)]
  [FlowNode.Pin(1600, "LoadWorldRaid", FlowNode.PinTypes.Input, 14)]
  [FlowNode.Pin(903, "RaidOutOfPeriod", FlowNode.PinTypes.Output, 218)]
  [FlowNode.Pin(902, "RaidBeatRescue", FlowNode.PinTypes.Output, 217)]
  [FlowNode.Pin(901, "RaidOverRescue", FlowNode.PinTypes.Output, 216)]
  [FlowNode.Pin(1250, "GenesisOutOfPeriod", FlowNode.PinTypes.Output, 221)]
  [FlowNode.Pin(5000, "Download Cancel", FlowNode.PinTypes.Output, 5000)]
  public class FlowNode_StartQuest : FlowNode_Network
  {
    [Token(Token = "0x4005066")]
    protected const int PIN_IN_LOAD = 0;
    [Token(Token = "0x4005067")]
    protected const int PIN_IN_LOAD_MULTI_PLAY = 100;
    [Token(Token = "0x4005068")]
    protected const int PIN_IN_LOAD_VERSUS = 200;
    [Token(Token = "0x4005069")]
    protected const int PIN_IN_LOAD_VERSUS_CPU = 700;
    [Token(Token = "0x400506A")]
    protected const int PIN_IN_LOAD_RANK_MATCH = 250;
    [Token(Token = "0x400506B")]
    protected const int PIN_IN_LOAD_RANK_MATCH_NPC = 251;
    [Token(Token = "0x400506C")]
    protected const int PIN_IN_LOAD_MULTI_TOWER = 500;
    [Token(Token = "0x400506D")]
    protected const int PIN_IN_LOAD_RAID_BOSS = 600;
    [Token(Token = "0x400506E")]
    protected const int PIN_IN_LOAD_ORDEAL = 1000;
    [Token(Token = "0x400506F")]
    protected const int PIN_IN_LOAD_GENESIS_BOSS = 1200;
    [Token(Token = "0x4005070")]
    protected const int PIN_IN_LOAD_ADVANCE_BOSS = 1300;
    [Token(Token = "0x4005071")]
    protected const int PIN_IN_LOAD_GUILD_RAID = 1400;
    [Token(Token = "0x4005072")]
    protected const int PIN_IN_LOAD_GUILD_RAID_TRAINING = 1450;
    [Token(Token = "0x4005073")]
    protected const int PIN_IN_LOAD_GVG = 1500;
    [Token(Token = "0x4005074")]
    protected const int PIN_IN_LOAD_WORLD_RAID = 1600;
    [Token(Token = "0x4005075")]
    protected const int PIN_IN_RESUME = 10;
    [Token(Token = "0x4005076")]
    protected const int PIN_IN_AUDIENCE_CONNECT = 20;
    [Token(Token = "0x4005077")]
    protected const int PIN_IN_AUDIENCE_START = 30;
    [Token(Token = "0x4005078")]
    protected const int PIN_OUT_STARTED = 1;
    [Token(Token = "0x4005079")]
    protected const int PIN_OUT_FAILED = 2;
    [Token(Token = "0x400507A")]
    protected const int PIN_OUT_NO_MATCH_VERSION = 3;
    [Token(Token = "0x400507B")]
    protected const int PIN_OUT_MULTI_MAINTENANCE = 4;
    [Token(Token = "0x400507C")]
    protected const int PIN_OUT_NETWORK_SUCCESS = 5;
    [Token(Token = "0x400507D")]
    protected const int PIN_OUT_COLOSEUM_RANK_MODIFY = 6;
    [Token(Token = "0x400507E")]
    protected const int PIN_OUT_MATCH_SUCCESS = 7;
    [Token(Token = "0x400507F")]
    protected const int PIN_OUT_NO_ROOM = 8;
    [Token(Token = "0x4005080")]
    protected const int PIN_OUT_NO_AUDIENCE_DATA = 9;
    [Token(Token = "0x4005081")]
    protected const int PIN_OUT_AUDIENCE_FAILED = 300;
    [Token(Token = "0x4005082")]
    protected const int PIN_OUT_AUDIENCE_FAILED_MAX = 301;
    [Token(Token = "0x4005083")]
    protected const int PIN_OUT_NOT_GPS_QUEST = 400;
    [Token(Token = "0x4005084")]
    protected const int PIN_OUT_NOT_ROOM_MULTI_TOWER = 501;
    [Token(Token = "0x4005085")]
    protected const int PIN_OUT_QUEST_RESUME_FAILED_IS_REHASH = 800;
    [Token(Token = "0x4005086")]
    protected const int PIN_OUT_RAID_TIMEOUT = 900;
    [Token(Token = "0x4005087")]
    protected const int PIN_OUT_RAID_OVER_RESCUE = 901;
    [Token(Token = "0x4005088")]
    protected const int PIN_OUT_RAID_BEAT_RESCUE = 902;
    [Token(Token = "0x4005089")]
    protected const int PIN_OUT_RAID_OUT_OF_PERIOD = 903;
    [Token(Token = "0x400508A")]
    protected const int PIN_OUT_RAID_CAN_NOT_RESCUE_TIME_OVER = 904;
    [Token(Token = "0x400508B")]
    protected const int PIN_OUT_RAID_ALREADY_RESCUE_CANCEL = 905;
    [Token(Token = "0x400508C")]
    protected const int PIN_OUT_RAID_SCHEDULE_TIMEOUT = 906;
    [Token(Token = "0x400508D")]
    protected const int PIN_OUT_GENESIS_OUT_OF_PERIOD = 1250;
    [Token(Token = "0x400508E")]
    protected const int PIN_OUT_ADVANCE_NOT_OPEN = 1260;
    [Token(Token = "0x400508F")]
    protected const int PIN_OUT_GUILDRAID_NEED_REFRESH = 1410;
    [Token(Token = "0x4005090")]
    protected const int PIN_OUT_WORLDRAID_NEED_REFRESH = 1610;
    [Token(Token = "0x4005091")]
    protected const int PIN_OUT_WORLDRAID_OUT_OF_PERIOD = 1620;
    [Token(Token = "0x4005092")]
    protected const int PIN_OUT_STARTED_RESTORE_SET = 1710;
    [Token(Token = "0x4005093")]
    protected const int PIN_OUT_DRAGONGOD_OUT_OF_PERIOD = 1720;
    [Token(Token = "0x4005094")]
    protected const int PIN_OUT_DOWNLOAD_CANCEL = 5000;
    [Token(Token = "0x4005095")]
    protected const int PIN_OUT_DOWNLOAD_TIMEOUT = 5001;
    [Token(Token = "0x4005096")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    public string QuestID;
    [Token(Token = "0x4005097")]
    [FieldOffset(Offset = "0x24")]
    public bool ReplaceScene;
    [Token(Token = "0x4005098")]
    [FieldOffset(Offset = "0x25")]
    [HideInInspector]
    public bool PlayOffline;
    [Token(Token = "0x4005099")]
    [FieldOffset(Offset = "0x26")]
    protected bool mResume;
    [Token(Token = "0x400509A")]
    [FieldOffset(Offset = "0x28")]
    [HideInInspector]
    public RestorePoints RestorePoint;
    [Token(Token = "0x400509B")]
    [FieldOffset(Offset = "0x2C")]
    public bool SetRestorePoint;
    [Token(Token = "0x400509C")]
    [FieldOffset(Offset = "0x30")]
    private BattleCore.Json_Battle mQuestData;
    [Token(Token = "0x400509D")]
    [FieldOffset(Offset = "0x34")]
    protected QuestParam mStartingQuest;
    [Token(Token = "0x400509E")]
    [FieldOffset(Offset = "0x38")]
    public int mReqID;
    [Token(Token = "0x400509F")]
    [FieldOffset(Offset = "0x3C")]
    private float mConnectTime;

    [Token(Token = "0x6005B2E")]
    [Address(RVA = "0x12FE7C0", Offset = "0x12FD5C0", VA = "0x112FE7C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005B2F")]
    [Address(RVA = "0x12FD290", Offset = "0x12FC090", VA = "0x112FD290")]
    private void LoadQuestStart()
    {
    }

    [Token(Token = "0x6005B30")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6005B31")]
    [Address(RVA = "0x12FF7E0", Offset = "0x12FE5E0", VA = "0x112FF7E0")]
    private void OnSceneLoad(GameObject sceneRoot)
    {
    }

    [Token(Token = "0x6005B32")]
    [Address(RVA = "0x12FF410", Offset = "0x12FE210", VA = "0x112FF410", Slot = "20")]
    public override void OnBack()
    {
    }

    [Token(Token = "0x6005B33")]
    [Address(RVA = "0x12FF570", Offset = "0x12FE370", VA = "0x112FF570")]
    public void OnMismatchVersion()
    {
    }

    [Token(Token = "0x6005B34")]
    [Address(RVA = "0x12FF600", Offset = "0x12FE400", VA = "0x112FF600")]
    public void OnMultiMaintenance()
    {
    }

    [Token(Token = "0x6005B35")]
    [Address(RVA = "0x1301080", Offset = "0x12FFE80", VA = "0x11301080")]
    public void OnVersusNoPlayer()
    {
    }

    [Token(Token = "0x6005B36")]
    [Address(RVA = "0x12FF890", Offset = "0x12FE690", VA = "0x112FF890", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005B37")]
    [Address(RVA = "0x12FCFE0", Offset = "0x12FBDE0", VA = "0x112FCFE0")]
    private void DownloadApproved(
      string text,
      WebAPI.JSON_BodyResponse<BattleCore.Json_Battle> res)
    {
    }

    [Token(Token = "0x6005B38")]
    [Address(RVA = "0x12FD1D0", Offset = "0x12FBFD0", VA = "0x112FD1D0")]
    private void DownloadNotApproved()
    {
    }

    [Token(Token = "0x6005B39")]
    [Address(RVA = "0x12FF460", Offset = "0x12FE260", VA = "0x112FF460")]
    public void OnForceBattleCancel(WWWResult www)
    {
    }

    [Token(Token = "0x6005B3A")]
    [Address(RVA = "0x12FD230", Offset = "0x12FC030", VA = "0x112FD230")]
    private void DownloadPopupTimeout()
    {
    }

    [Token(Token = "0x6005B3B")]
    [Address(RVA = "0x1301170", Offset = "0x12FFF70", VA = "0x11301170")]
    private void SetVersusAudienceParam(string text)
    {
    }

    [Token(Token = "0x6005B3C")]
    [Address(RVA = "0x1301300", Offset = "0x1300100", VA = "0x11301300")]
    protected IEnumerator StartScene(BattleCore.Json_Battle json) => (IEnumerator) null;

    [Token(Token = "0x6005B3D")]
    [Address(RVA = "0x12FF690", Offset = "0x12FE490", VA = "0x112FF690")]
    private void OnSceneAwake(GameObject scene)
    {
    }

    [Token(Token = "0x6005B3E")]
    [Address(RVA = "0x1301290", Offset = "0x1300090", VA = "0x11301290")]
    private IEnumerator StartAudience() => (IEnumerator) null;

    [Token(Token = "0x6005B3F")]
    [Address(RVA = "0x13013E0", Offset = "0x13001E0", VA = "0x113013E0")]
    public FlowNode_StartQuest()
    {
    }

    [Token(Token = "0x2001634")]
    private class QuestLauncher
    {
      [Token(Token = "0x40050A0")]
      [FieldOffset(Offset = "0x8")]
      public QuestParam Quest;
      [Token(Token = "0x40050A1")]
      [FieldOffset(Offset = "0xC")]
      public BattleCore.Json_Battle InitData;
      [Token(Token = "0x40050A2")]
      [FieldOffset(Offset = "0x10")]
      public bool Resume;

      [Token(Token = "0x6005B42")]
      [Address(RVA = "0x1302200", Offset = "0x1301000", VA = "0x11302200")]
      public void OnSceneAwake(GameObject scene)
      {
      }

      [Token(Token = "0x6005B43")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public QuestLauncher()
      {
      }
    }
  }
}
