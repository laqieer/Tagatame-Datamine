// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_BattleUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023D1")]
  [FlowNode.Pin(1301, "スキル選択終了", FlowNode.PinTypes.Output, 1301)]
  [FlowNode.Pin(1500, "入力打ち切り (マルチプレイ)", FlowNode.PinTypes.Output, 1500)]
  [FlowNode.Pin(1300, "スキル選択開始", FlowNode.PinTypes.Output, 1300)]
  [FlowNode.Pin(1201, "方向入力完了", FlowNode.PinTypes.Output, 1201)]
  [FlowNode.Pin(1200, "方向入力開始", FlowNode.PinTypes.Output, 1200)]
  [FlowNode.Pin(1111, "サブターゲット選択解除", FlowNode.PinTypes.Output, 1111)]
  [FlowNode.Pin(1110, "サブターゲット選択", FlowNode.PinTypes.Output, 1110)]
  [FlowNode.Pin(1101, "メインターゲット選択解除", FlowNode.PinTypes.Output, 1101)]
  [FlowNode.Pin(1100, "メインターゲット選択", FlowNode.PinTypes.Output, 1100)]
  [FlowNode.Pin(1070, "詠唱スキル発動", FlowNode.PinTypes.Output, 1070)]
  [FlowNode.Pin(1060, "ユニット行動開始", FlowNode.PinTypes.Output, 1060)]
  [FlowNode.Pin(1050, "マップ確認開始", FlowNode.PinTypes.Output, 1050)]
  [FlowNode.Pin(1041, "移動先の選択完了", FlowNode.PinTypes.Output, 1041)]
  [FlowNode.Pin(1036, "投げるターゲット選択終了", FlowNode.PinTypes.Output, 1036)]
  [FlowNode.Pin(1035, "投げるターゲット選択開始", FlowNode.PinTypes.Output, 1035)]
  [FlowNode.Pin(1032, "ターゲット選択終了", FlowNode.PinTypes.Output, 1032)]
  [FlowNode.Pin(1030, "ターゲット選択開始", FlowNode.PinTypes.Output, 1030)]
  [FlowNode.Pin(1020, "コマンドが選択された", FlowNode.PinTypes.Output, 1020)]
  [FlowNode.Pin(1010, "コマンド選択開始", FlowNode.PinTypes.Output, 1010)]
  [FlowNode.Pin(1006, "マップ終了", FlowNode.PinTypes.Output, 1006)]
  [FlowNode.Pin(1005, "マップ開始", FlowNode.PinTypes.Output, 1005)]
  [FlowNode.Pin(1002, "クエスト終了 (敗亡)", FlowNode.PinTypes.Output, 1002)]
  [FlowNode.Pin(1001, "クエスト終了 (勝利)", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(1000, "クエスト開始", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.NodeType("Battle/Events")]
  [FlowNode.Pin(1040, "移動先の選択開始", FlowNode.PinTypes.Output, 1040)]
  [FlowNode.Pin(1401, "アイテム選択終了", FlowNode.PinTypes.Output, 1401)]
  [FlowNode.Pin(1400, "アイテム選択開始", FlowNode.PinTypes.Output, 1400)]
  [FlowNode.Pin(1501, "BANされた (マルチプレイ)", FlowNode.PinTypes.Output, 1501)]
  [AddComponentMenu("")]
  [FlowNode.ShowInInspector]
  [FlowNode.Pin(7103, "ユニット交代確認終了", FlowNode.PinTypes.Output, 7103)]
  [FlowNode.Pin(7102, "ユニット交代確認開始", FlowNode.PinTypes.Output, 7102)]
  [FlowNode.Pin(7100, "ユニット交代選択開始", FlowNode.PinTypes.Output, 7100)]
  [FlowNode.Pin(7002, "パネルからターゲット切り替え", FlowNode.PinTypes.Input, 7002)]
  [FlowNode.Pin(7001, "ギミックからターゲット切り替え", FlowNode.PinTypes.Input, 7001)]
  [FlowNode.Pin(7000, "ユニットからターゲット切り替え", FlowNode.PinTypes.Input, 7000)]
  [FlowNode.Pin(7101, "ユニット交代選択終了", FlowNode.PinTypes.Output, 7101)]
  [FlowNode.Pin(5000, "購入ウインドウ表示", FlowNode.PinTypes.Output, 5000)]
  [FlowNode.Pin(2001, "バトル終了", FlowNode.PinTypes.Output, 2001)]
  [FlowNode.Pin(2000, "バトル開始", FlowNode.PinTypes.Output, 2000)]
  [FlowNode.Pin(1601, "グリッド上イベント選択終了", FlowNode.PinTypes.Output, 1601)]
  [FlowNode.Pin(1600, "グリッド上イベント選択開始", FlowNode.PinTypes.Output, 1600)]
  [FlowNode.Pin(1550, "初顔合わせ通知", FlowNode.PinTypes.Output, 1550)]
  [FlowNode.Pin(1503, "進行異常 (マルチプレイ)", FlowNode.PinTypes.Output, 1503)]
  [FlowNode.Pin(1502, "切断された (マルチプレイ)", FlowNode.PinTypes.Output, 1502)]
  [FlowNode.Pin(6000, "フレンド選択", FlowNode.PinTypes.Output, 6000)]
  public class FlowNode_BattleUI : FlowNodePersistent
  {
    [Token(Token = "0x400A1B0")]
    private const string ON_APP_PAUSE = "ON_APP_PAUSE";
    [Token(Token = "0x400A1B1")]
    [FieldOffset(Offset = "0x18")]
    [StringIsGameObjectID]
    public string CommandObjectID;
    [Token(Token = "0x400A1B2")]
    [FieldOffset(Offset = "0x1C")]
    [StringIsGameObjectID]
    public string QueueObjectID;
    [Token(Token = "0x400A1B3")]
    [FieldOffset(Offset = "0x20")]
    [StringIsGameObjectID]
    public string SkillListID;
    [Token(Token = "0x400A1B4")]
    [FieldOffset(Offset = "0x24")]
    [StringIsGameObjectID]
    public string ItemListID;
    [Token(Token = "0x400A1B5")]
    [FieldOffset(Offset = "0x28")]
    [StringIsGameObjectID]
    public string VirtualStickID;
    [Token(Token = "0x400A1B6")]
    [FieldOffset(Offset = "0x2C")]
    [StringIsGameObjectID]
    public string QuestStatusID;
    [Token(Token = "0x400A1B7")]
    [FieldOffset(Offset = "0x30")]
    [StringIsGameObjectID]
    public string CameraControllerID;
    [Token(Token = "0x400A1B8")]
    [FieldOffset(Offset = "0x34")]
    [StringIsGameObjectID]
    public string FukanCameraID;
    [Token(Token = "0x400A1B9")]
    [FieldOffset(Offset = "0x38")]
    [StringIsGameObjectID]
    public string NextTargetButtonID;
    [Token(Token = "0x400A1BA")]
    [FieldOffset(Offset = "0x3C")]
    [StringIsGameObjectID]
    public string PrevTargetButtonID;
    [Token(Token = "0x400A1BB")]
    [FieldOffset(Offset = "0x40")]
    [StringIsGameObjectID]
    public string MapHeightID;
    [Token(Token = "0x400A1BC")]
    [FieldOffset(Offset = "0x44")]
    [StringIsGameObjectID]
    public string ElementDiagram;
    [Token(Token = "0x400A1BD")]
    [FieldOffset(Offset = "0x48")]
    [StringIsGameObjectID]
    public string ArenaActionCountID;
    [Token(Token = "0x400A1BE")]
    [FieldOffset(Offset = "0x4C")]
    [StringIsGameObjectID]
    public string PlayerActionCountID;
    [Token(Token = "0x400A1BF")]
    [FieldOffset(Offset = "0x50")]
    [StringIsGameObjectID]
    public string EnemyActionCountID;
    [Token(Token = "0x400A1C0")]
    [FieldOffset(Offset = "0x54")]
    [StringIsGameObjectID]
    public string RankingQuestActionCountID;
    [Token(Token = "0x400A1C1")]
    [FieldOffset(Offset = "0x58")]
    [StringIsGameObjectID]
    public string UnitChgListID;
    [Token(Token = "0x400A1C2")]
    [FieldOffset(Offset = "0x5C")]
    [StringIsGameObjectID]
    public string WeatherInfoID;
    [Token(Token = "0x400A1C3")]
    [FieldOffset(Offset = "0x60")]
    public TargetPlate Prefab_TargetMain;
    [Token(Token = "0x400A1C4")]
    [FieldOffset(Offset = "0x64")]
    public TargetPlate Prefab_TargetSub;
    [Token(Token = "0x400A1C5")]
    [FieldOffset(Offset = "0x68")]
    public TargetPlate Prefab_ObjectTarget;
    [Token(Token = "0x400A1C6")]
    [FieldOffset(Offset = "0x6C")]
    public TargetPlate Prefab_TrickTarget;
    [Token(Token = "0x400A1C7")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject AttachTargetPanel;
    [Token(Token = "0x400A1C8")]
    [FieldOffset(Offset = "0x74")]
    [NonSerialized]
    public TargetPlate TargetMain;
    [Token(Token = "0x400A1C9")]
    [FieldOffset(Offset = "0x78")]
    [NonSerialized]
    public TargetPlate TargetSub;
    [Token(Token = "0x400A1CA")]
    [FieldOffset(Offset = "0x7C")]
    [NonSerialized]
    public TargetPlate TargetObjectSub;
    [Token(Token = "0x400A1CB")]
    [FieldOffset(Offset = "0x80")]
    [NonSerialized]
    public TargetPlate TargetTrickSub;
    [Token(Token = "0x400A1CC")]
    [FieldOffset(Offset = "0x84")]
    [StringIsLocalEventID]
    public string QuestStart;
    [Token(Token = "0x400A1CD")]
    [FieldOffset(Offset = "0x88")]
    [StringIsLocalEventID]
    public string QuestStart_Short;
    [Token(Token = "0x400A1CE")]
    [FieldOffset(Offset = "0x8C")]
    [StringIsLocalEventID]
    public string QuestStart_Arena;
    [Token(Token = "0x400A1CF")]
    [FieldOffset(Offset = "0x90")]
    [StringIsLocalEventID]
    public string QuestStart_LeagueMatch;
    [Token(Token = "0x400A1D0")]
    [FieldOffset(Offset = "0x94")]
    [StringIsLocalEventID]
    public string QuestStart_VS;
    [Token(Token = "0x400A1D1")]
    [FieldOffset(Offset = "0x98")]
    [StringIsLocalEventID]
    public string QuestStart_RankMatch;
    [Token(Token = "0x400A1D2")]
    [FieldOffset(Offset = "0x9C")]
    [StringIsLocalEventID]
    public string QuestStart_Raid;
    [Token(Token = "0x400A1D3")]
    [FieldOffset(Offset = "0xA0")]
    [StringIsLocalEventID]
    public string QuestStart_GuildRaidMock;
    [Token(Token = "0x400A1D4")]
    [FieldOffset(Offset = "0xA4")]
    [StringIsLocalEventID]
    public string QuestStart_GuildRaidTrial;
    [Token(Token = "0x400A1D5")]
    [FieldOffset(Offset = "0xA8")]
    [StringIsLocalEventID]
    public string QuestStart_GenesisBoss;
    [Token(Token = "0x400A1D6")]
    [FieldOffset(Offset = "0xAC")]
    [StringIsLocalEventID]
    public string QuestStart_AdvanceBoss;
    [Token(Token = "0x400A1D7")]
    [FieldOffset(Offset = "0xB0")]
    [StringIsLocalEventID]
    public string QuestEnd;
    [Token(Token = "0x400A1D8")]
    [FieldOffset(Offset = "0xB4")]
    [StringIsLocalEventID]
    public string QuestWin;
    [Token(Token = "0x400A1D9")]
    [FieldOffset(Offset = "0xB8")]
    [StringIsLocalEventID]
    public string QuestWin_Arena;
    [Token(Token = "0x400A1DA")]
    [FieldOffset(Offset = "0xBC")]
    [StringIsLocalEventID]
    public string QuestWin_Duel;
    [Token(Token = "0x400A1DB")]
    [FieldOffset(Offset = "0xC0")]
    [StringIsLocalEventID]
    public string QuestWin_Versus;
    [Token(Token = "0x400A1DC")]
    [FieldOffset(Offset = "0xC4")]
    [StringIsLocalEventID]
    public string QuestWin_GenesisBoss;
    [Token(Token = "0x400A1DD")]
    [FieldOffset(Offset = "0xC8")]
    [StringIsLocalEventID]
    public string QuestWin_AdvanceBoss;
    [Token(Token = "0x400A1DE")]
    [FieldOffset(Offset = "0xCC")]
    [StringIsLocalEventID]
    public string QuestWin_LeagueMatch;
    [Token(Token = "0x400A1DF")]
    [FieldOffset(Offset = "0xD0")]
    [StringIsLocalEventID]
    public string QuestWin_LeagueMatchSham;
    [Token(Token = "0x400A1E0")]
    [FieldOffset(Offset = "0xD4")]
    [StringIsLocalEventID]
    public string QuestLose;
    [Token(Token = "0x400A1E1")]
    [FieldOffset(Offset = "0xD8")]
    [StringIsLocalEventID]
    public string QuestLose_Arena;
    [Token(Token = "0x400A1E2")]
    [FieldOffset(Offset = "0xDC")]
    [StringIsLocalEventID]
    public string QuestLose_Duel;
    [Token(Token = "0x400A1E3")]
    [FieldOffset(Offset = "0xE0")]
    [StringIsLocalEventID]
    public string QuestLose_Versus;
    [Token(Token = "0x400A1E4")]
    [FieldOffset(Offset = "0xE4")]
    [StringIsLocalEventID]
    public string QuestLose_WorldRaid;
    [Token(Token = "0x400A1E5")]
    [FieldOffset(Offset = "0xE8")]
    [StringIsLocalEventID]
    public string QuestLoseVideoButton;
    [Token(Token = "0x400A1E6")]
    [FieldOffset(Offset = "0xEC")]
    [StringIsLocalEventID]
    public string QuestLose_ArenaVideoButton;
    [Token(Token = "0x400A1E7")]
    [FieldOffset(Offset = "0xF0")]
    [StringIsLocalEventID]
    public string QuestLose_VersusVideoButton;
    [Token(Token = "0x400A1E8")]
    [FieldOffset(Offset = "0xF4")]
    [StringIsLocalEventID]
    public string QuestLose_WorldRaidVideoButton;
    [Token(Token = "0x400A1E9")]
    [FieldOffset(Offset = "0xF8")]
    [StringIsLocalEventID]
    public string QuestLose_LeagueMatch;
    [Token(Token = "0x400A1EA")]
    [FieldOffset(Offset = "0xFC")]
    [StringIsLocalEventID]
    public string QuestLose_LeagueMatchSham;
    [Token(Token = "0x400A1EB")]
    [FieldOffset(Offset = "0x100")]
    [StringIsLocalEventID]
    public string QuestDraw_Versus;
    [Token(Token = "0x400A1EC")]
    [FieldOffset(Offset = "0x104")]
    [StringIsLocalEventID]
    public string QuestWin_Audience;
    [Token(Token = "0x400A1ED")]
    [FieldOffset(Offset = "0x108")]
    [StringIsLocalEventID]
    public string Result;
    [Token(Token = "0x400A1EE")]
    [FieldOffset(Offset = "0x10C")]
    [StringIsLocalEventID]
    public string Result_MP;
    [Token(Token = "0x400A1EF")]
    [FieldOffset(Offset = "0x110")]
    [StringIsLocalEventID]
    public string Result_Arena;
    [Token(Token = "0x400A1F0")]
    [FieldOffset(Offset = "0x114")]
    [StringIsLocalEventID]
    public string Result_Duel;
    [Token(Token = "0x400A1F1")]
    [FieldOffset(Offset = "0x118")]
    [StringIsLocalEventID]
    public string Result_Tower;
    [Token(Token = "0x400A1F2")]
    [FieldOffset(Offset = "0x11C")]
    [StringIsLocalEventID]
    public string Result_Versus;
    [Token(Token = "0x400A1F3")]
    [FieldOffset(Offset = "0x120")]
    [StringIsLocalEventID]
    public string Result_MultiTower;
    [Token(Token = "0x400A1F4")]
    [FieldOffset(Offset = "0x124")]
    [StringIsLocalEventID]
    public string Result_RankMatch;
    [Token(Token = "0x400A1F5")]
    [FieldOffset(Offset = "0x128")]
    [StringIsLocalEventID]
    public string Result_Raid;
    [Token(Token = "0x400A1F6")]
    [FieldOffset(Offset = "0x12C")]
    [StringIsLocalEventID]
    public string Result_GenesisBoss;
    [Token(Token = "0x400A1F7")]
    [FieldOffset(Offset = "0x130")]
    [StringIsLocalEventID]
    public string Result_AdvanceBoss;
    [Token(Token = "0x400A1F8")]
    [FieldOffset(Offset = "0x134")]
    [StringIsLocalEventID]
    public string Result_GuildRaid;
    [Token(Token = "0x400A1F9")]
    [FieldOffset(Offset = "0x138")]
    [StringIsLocalEventID]
    public string Result_GuildRaidTrial;
    [Token(Token = "0x400A1FA")]
    [FieldOffset(Offset = "0x13C")]
    [StringIsLocalEventID]
    public string Result_GvG;
    [Token(Token = "0x400A1FB")]
    [FieldOffset(Offset = "0x140")]
    [StringIsLocalEventID]
    public string Result_WorldRaid;
    [Token(Token = "0x400A1FC")]
    [FieldOffset(Offset = "0x144")]
    [StringIsLocalEventID]
    public string Result_PointQuest;
    [Token(Token = "0x400A1FD")]
    [FieldOffset(Offset = "0x148")]
    [StringIsLocalEventID]
    public string Result_LeagueMatch;
    [Token(Token = "0x400A1FE")]
    [FieldOffset(Offset = "0x14C")]
    [StringIsLocalEventID]
    public string Result_LeagueMatchSham;
    [Token(Token = "0x400A1FF")]
    [FieldOffset(Offset = "0x150")]
    [StringIsLocalEventID]
    public string Replay_Error;
    [Token(Token = "0x400A200")]
    [FieldOffset(Offset = "0x154")]
    [StringIsLocalEventID]
    public string PlayAgain;
    [Token(Token = "0x400A201")]
    [FieldOffset(Offset = "0x158")]
    [StringIsLocalEventID]
    public string MapViewStart;
    [Token(Token = "0x400A202")]
    [FieldOffset(Offset = "0x15C")]
    [StringIsLocalEventID]
    public string MapViewEnd;
    [Token(Token = "0x400A203")]
    [FieldOffset(Offset = "0x160")]
    [StringIsLocalEventID]
    public string MapViewSelectUnit;
    [Token(Token = "0x400A204")]
    [FieldOffset(Offset = "0x164")]
    [StringIsLocalEventID]
    public string MapViewSelectGrid;
    [Token(Token = "0x400A205")]
    [FieldOffset(Offset = "0x168")]
    [StringIsLocalEventID]
    public string VersusStart;
    [Token(Token = "0x400A206")]
    [FieldOffset(Offset = "0x16C")]
    [StringIsLocalEventID]
    public string VersusEnd;
    [Token(Token = "0x400A207")]
    [FieldOffset(Offset = "0x170")]
    [StringIsLocalEventID]
    public string MPSelectContinueWaitingStart;
    [Token(Token = "0x400A208")]
    [FieldOffset(Offset = "0x174")]
    [StringIsLocalEventID]
    public string MPSelectContinueWaitingEnd;
    [Token(Token = "0x400A209")]
    [FieldOffset(Offset = "0x178")]
    [StringIsLocalEventID]
    public string AutoBattleToggle;
    [Token(Token = "0x400A20A")]
    [FieldOffset(Offset = "0x17C")]
    [StringIsLocalEventID]
    public string BattleSpeedToggle;
    [Token(Token = "0x400A20B")]
    [FieldOffset(Offset = "0x180")]
    [StringIsLocalEventID]
    public string ContinueDecide;
    [Token(Token = "0x400A20C")]
    [FieldOffset(Offset = "0x184")]
    private VirtualStick2 mVirtualStick;
    [Token(Token = "0x400A20D")]
    [FieldOffset(Offset = "0x188")]
    private UnitAbilitySkillList mSkillListRef;
    [Token(Token = "0x400A20E")]
    [FieldOffset(Offset = "0x18C")]
    private UnitCommands mCommandWindow;
    [Token(Token = "0x400A20F")]
    [FieldOffset(Offset = "0x190")]
    private BattleInventory mItemWindow;
    [Token(Token = "0x400A210")]
    [FieldOffset(Offset = "0x194")]
    private BattleUnitChg mUnitChgWindow;
    [Token(Token = "0x400A212")]
    [FieldOffset(Offset = "0x199")]
    [HideInInspector]
    public bool IsEnableUnit;
    [Token(Token = "0x400A213")]
    [FieldOffset(Offset = "0x19A")]
    [HideInInspector]
    public bool IsEnableGimmick;
    [Token(Token = "0x400A214")]
    [FieldOffset(Offset = "0x19B")]
    [HideInInspector]
    public bool IsEnableTrick;

    [Token(Token = "0x6009B2C")]
    private T UpdateReference<T>(ref T obj, string path) where T : Component => (T) null;

    [Token(Token = "0x17001597")]
    public VirtualStick2 VirtualStick
    {
      [Token(Token = "0x6009B2D"), Address(RVA = "0x5EF1D0", Offset = "0x5EDFD0", VA = "0x105EF1D0")] get
      {
        return (VirtualStick2) null;
      }
    }

    [Token(Token = "0x17001598")]
    public UnitAbilitySkillList SkillWindow
    {
      [Token(Token = "0x6009B2E"), Address(RVA = "0x5EF150", Offset = "0x5EDF50", VA = "0x105EF150")] get
      {
        return (UnitAbilitySkillList) null;
      }
    }

    [Token(Token = "0x17001599")]
    public UnitCommands CommandWindow
    {
      [Token(Token = "0x6009B2F"), Address(RVA = "0x5EF0C0", Offset = "0x5EDEC0", VA = "0x105EF0C0")] get
      {
        return (UnitCommands) null;
      }
    }

    [Token(Token = "0x1700159A")]
    public BattleInventory ItemWindow
    {
      [Token(Token = "0x6009B30"), Address(RVA = "0x5EF110", Offset = "0x5EDF10", VA = "0x105EF110")] get
      {
        return (BattleInventory) null;
      }
    }

    [Token(Token = "0x1700159B")]
    public BattleUnitChg UnitChgWindow
    {
      [Token(Token = "0x6009B31"), Address(RVA = "0x5EF190", Offset = "0x5EDF90", VA = "0x105EF190")] get
      {
        return (BattleUnitChg) null;
      }
    }

    [Token(Token = "0x6009B32")]
    [Address(RVA = "0x5EED60", Offset = "0x5EDB60", VA = "0x105EED60")]
    private void Output(int pinID)
    {
    }

    [Token(Token = "0x6009B33")]
    [Address(RVA = "0x5EE840", Offset = "0x5ED640", VA = "0x105EE840")]
    public void OnQuestStart()
    {
    }

    [Token(Token = "0x6009B34")]
    [Address(RVA = "0x5EE800", Offset = "0x5ED600", VA = "0x105EE800")]
    public void OnQuestStart_Short()
    {
    }

    [Token(Token = "0x6009B35")]
    [Address(RVA = "0x5EE720", Offset = "0x5ED520", VA = "0x105EE720")]
    public void OnQuestStart_Arena()
    {
    }

    [Token(Token = "0x6009B36")]
    [Address(RVA = "0x5EE7A0", Offset = "0x5ED5A0", VA = "0x105EE7A0")]
    public void OnQuestStart_LeagueMatch()
    {
    }

    [Token(Token = "0x6009B37")]
    [Address(RVA = "0x5EE820", Offset = "0x5ED620", VA = "0x105EE820")]
    public void OnQuestStart_VS()
    {
    }

    [Token(Token = "0x6009B38")]
    [Address(RVA = "0x5EE7E0", Offset = "0x5ED5E0", VA = "0x105EE7E0")]
    public void OnQuestStart_RankMatch()
    {
    }

    [Token(Token = "0x6009B39")]
    [Address(RVA = "0x5EE7C0", Offset = "0x5ED5C0", VA = "0x105EE7C0")]
    public void OnQuestStart_Raid()
    {
    }

    [Token(Token = "0x6009B3A")]
    [Address(RVA = "0x5EE760", Offset = "0x5ED560", VA = "0x105EE760")]
    public void OnQuestStart_GuildRaidMock()
    {
    }

    [Token(Token = "0x6009B3B")]
    [Address(RVA = "0x5EE780", Offset = "0x5ED580", VA = "0x105EE780")]
    public void OnQuestStart_GuildRaidTrial()
    {
    }

    [Token(Token = "0x6009B3C")]
    [Address(RVA = "0x5EE740", Offset = "0x5ED540", VA = "0x105EE740")]
    public void OnQuestStart_GenesisBoss()
    {
    }

    [Token(Token = "0x6009B3D")]
    [Address(RVA = "0x5EE700", Offset = "0x5ED500", VA = "0x105EE700")]
    public void OnQuestStart_AdvanceBoss()
    {
    }

    [Token(Token = "0x6009B3E")]
    [Address(RVA = "0x5EE6A0", Offset = "0x5ED4A0", VA = "0x105EE6A0")]
    public void OnQuestEnd()
    {
    }

    [Token(Token = "0x6009B3F")]
    [Address(RVA = "0x5EE860", Offset = "0x5ED660", VA = "0x105EE860")]
    public void OnQuestWin()
    {
    }

    [Token(Token = "0x6009B40")]
    [Address(RVA = "0x5EE6E0", Offset = "0x5ED4E0", VA = "0x105EE6E0")]
    public void OnQuestLose()
    {
    }

    [Token(Token = "0x6009B41")]
    [Address(RVA = "0x5EE1C0", Offset = "0x5ECFC0", VA = "0x105EE1C0")]
    public void OnArenaWin()
    {
    }

    [Token(Token = "0x6009B42")]
    [Address(RVA = "0x5EE1A0", Offset = "0x5ECFA0", VA = "0x105EE1A0")]
    public void OnArenaLose()
    {
    }

    [Token(Token = "0x6009B43")]
    [Address(RVA = "0x5EE340", Offset = "0x5ED140", VA = "0x105EE340")]
    public void OnDuelWin()
    {
    }

    [Token(Token = "0x6009B44")]
    [Address(RVA = "0x5EE320", Offset = "0x5ED120", VA = "0x105EE320")]
    public void OnDuelLose()
    {
    }

    [Token(Token = "0x6009B45")]
    [Address(RVA = "0x5EED00", Offset = "0x5EDB00", VA = "0x105EED00")]
    public void OnVersusWin()
    {
    }

    [Token(Token = "0x6009B46")]
    [Address(RVA = "0x5EECC0", Offset = "0x5EDAC0", VA = "0x105EECC0")]
    public void OnVersusLose()
    {
    }

    [Token(Token = "0x6009B47")]
    [Address(RVA = "0x5EEC60", Offset = "0x5EDA60", VA = "0x105EEC60")]
    public void OnVersusDraw()
    {
    }

    [Token(Token = "0x6009B48")]
    [Address(RVA = "0x5EE1E0", Offset = "0x5ECFE0", VA = "0x105EE1E0")]
    public void OnAudienceWin()
    {
    }

    [Token(Token = "0x6009B49")]
    [Address(RVA = "0x5EE380", Offset = "0x5ED180", VA = "0x105EE380")]
    public void OnGenesisBossWin()
    {
    }

    [Token(Token = "0x6009B4A")]
    [Address(RVA = "0x5EE120", Offset = "0x5ECF20", VA = "0x105EE120")]
    public void OnAdvanceBossWin()
    {
    }

    [Token(Token = "0x6009B4B")]
    [Address(RVA = "0x5EE540", Offset = "0x5ED340", VA = "0x105EE540")]
    public void OnLeagueMatchWin()
    {
    }

    [Token(Token = "0x6009B4C")]
    [Address(RVA = "0x5EE4E0", Offset = "0x5ED2E0", VA = "0x105EE4E0")]
    public void OnLeagueMatchLose()
    {
    }

    [Token(Token = "0x6009B4D")]
    [Address(RVA = "0x5EE520", Offset = "0x5ED320", VA = "0x105EE520")]
    public void OnLeagueMatchShamWin()
    {
    }

    [Token(Token = "0x6009B4E")]
    [Address(RVA = "0x5EE500", Offset = "0x5ED300", VA = "0x105EE500")]
    public void OnLeagueMatchShamLose()
    {
    }

    [Token(Token = "0x6009B4F")]
    [Address(RVA = "0x5EED40", Offset = "0x5EDB40", VA = "0x105EED40")]
    public void OnWorldRaidLose()
    {
    }

    [Token(Token = "0x6009B50")]
    [Address(RVA = "0x5EE6C0", Offset = "0x5ED4C0", VA = "0x105EE6C0")]
    public void OnQuestLoseVideoButton()
    {
    }

    [Token(Token = "0x6009B51")]
    [Address(RVA = "0x5EE180", Offset = "0x5ECF80", VA = "0x105EE180")]
    public void OnArenaLoseVideoButton()
    {
    }

    [Token(Token = "0x6009B52")]
    [Address(RVA = "0x5EECA0", Offset = "0x5EDAA0", VA = "0x105EECA0")]
    public void OnVersusLoseVideoButton()
    {
    }

    [Token(Token = "0x6009B53")]
    [Address(RVA = "0x5EED20", Offset = "0x5EDB20", VA = "0x105EED20")]
    public void OnWorldRaidLoseVideoButton()
    {
    }

    [Token(Token = "0x6009B54")]
    [Address(RVA = "0x5EEAC0", Offset = "0x5ED8C0", VA = "0x105EEAC0")]
    public void OnResult()
    {
    }

    [Token(Token = "0x6009B55")]
    [Address(RVA = "0x5EE9C0", Offset = "0x5ED7C0", VA = "0x105EE9C0")]
    public void OnResult_MP()
    {
    }

    [Token(Token = "0x6009B56")]
    [Address(RVA = "0x5EE8C0", Offset = "0x5ED6C0", VA = "0x105EE8C0")]
    public void OnResult_Arena()
    {
    }

    [Token(Token = "0x6009B57")]
    [Address(RVA = "0x5EE8E0", Offset = "0x5ED6E0", VA = "0x105EE8E0")]
    public void OnResult_Duel()
    {
    }

    [Token(Token = "0x6009B58")]
    [Address(RVA = "0x5EEA60", Offset = "0x5ED860", VA = "0x105EEA60")]
    public void OnResult_Tower()
    {
    }

    [Token(Token = "0x6009B59")]
    [Address(RVA = "0x5EEA80", Offset = "0x5ED880", VA = "0x105EEA80")]
    public void OnResult_Versus()
    {
    }

    [Token(Token = "0x6009B5A")]
    [Address(RVA = "0x5EE9E0", Offset = "0x5ED7E0", VA = "0x105EE9E0")]
    public void OnResult_MultiTower()
    {
    }

    [Token(Token = "0x6009B5B")]
    [Address(RVA = "0x5EEA40", Offset = "0x5ED840", VA = "0x105EEA40")]
    public void OnResult_RankMatch()
    {
    }

    [Token(Token = "0x6009B5C")]
    [Address(RVA = "0x5EEA20", Offset = "0x5ED820", VA = "0x105EEA20")]
    public void OnResult_Raid()
    {
    }

    [Token(Token = "0x6009B5D")]
    [Address(RVA = "0x5EE900", Offset = "0x5ED700", VA = "0x105EE900")]
    public void OnResult_GenesisBoss()
    {
    }

    [Token(Token = "0x6009B5E")]
    [Address(RVA = "0x5EE8A0", Offset = "0x5ED6A0", VA = "0x105EE8A0")]
    public void OnResult_AdvanceBoss()
    {
    }

    [Token(Token = "0x6009B5F")]
    [Address(RVA = "0x5EE940", Offset = "0x5ED740", VA = "0x105EE940")]
    public void OnResult_GuildRaid()
    {
    }

    [Token(Token = "0x6009B60")]
    [Address(RVA = "0x5EE920", Offset = "0x5ED720", VA = "0x105EE920")]
    public void OnResult_GuildRaidTrial()
    {
    }

    [Token(Token = "0x6009B61")]
    [Address(RVA = "0x5EE960", Offset = "0x5ED760", VA = "0x105EE960")]
    public void OnResult_GvG()
    {
    }

    [Token(Token = "0x6009B62")]
    [Address(RVA = "0x5EEAA0", Offset = "0x5ED8A0", VA = "0x105EEAA0")]
    public void OnResult_WorldRaid()
    {
    }

    [Token(Token = "0x6009B63")]
    [Address(RVA = "0x5EEA00", Offset = "0x5ED800", VA = "0x105EEA00")]
    public void OnResult_PointQuest()
    {
    }

    [Token(Token = "0x6009B64")]
    [Address(RVA = "0x5EE9A0", Offset = "0x5ED7A0", VA = "0x105EE9A0")]
    public void OnResult_LeagueMatch()
    {
    }

    [Token(Token = "0x6009B65")]
    [Address(RVA = "0x5EE980", Offset = "0x5ED780", VA = "0x105EE980")]
    public void OnResult_LeagueMatchSham()
    {
    }

    [Token(Token = "0x6009B66")]
    [Address(RVA = "0x5EE680", Offset = "0x5ED480", VA = "0x105EE680")]
    public void OnMapViewStart()
    {
    }

    [Token(Token = "0x6009B67")]
    [Address(RVA = "0x5EE620", Offset = "0x5ED420", VA = "0x105EE620")]
    public void OnMapViewEnd()
    {
    }

    [Token(Token = "0x6009B68")]
    [Address(RVA = "0x5EE660", Offset = "0x5ED460", VA = "0x105EE660")]
    public void OnMapViewSelectUnit()
    {
    }

    [Token(Token = "0x6009B69")]
    [Address(RVA = "0x5EE640", Offset = "0x5ED440", VA = "0x105EE640")]
    public void OnMapViewSelectGrid()
    {
    }

    [Token(Token = "0x6009B6A")]
    [Address(RVA = "0x5EECE0", Offset = "0x5EDAE0", VA = "0x105EECE0")]
    public void OnVersusStart()
    {
    }

    [Token(Token = "0x6009B6B")]
    [Address(RVA = "0x5EEC80", Offset = "0x5EDA80", VA = "0x105EEC80")]
    public void OnVersusEnd()
    {
    }

    [Token(Token = "0x6009B6C")]
    [Address(RVA = "0x5EE580", Offset = "0x5ED380", VA = "0x105EE580")]
    public void OnMPSelectContinueWaitingStart()
    {
    }

    [Token(Token = "0x6009B6D")]
    [Address(RVA = "0x5EE560", Offset = "0x5ED360", VA = "0x105EE560")]
    public void OnMPSelectContinueWaitingEnd()
    {
    }

    [Token(Token = "0x6009B6E")]
    [Address(RVA = "0x5EE200", Offset = "0x5ED000", VA = "0x105EE200")]
    public void OnAutoBattleToggle()
    {
    }

    [Token(Token = "0x6009B6F")]
    [Address(RVA = "0x5EE260", Offset = "0x5ED060", VA = "0x105EE260")]
    public void OnBattleSpeedToggle()
    {
    }

    [Token(Token = "0x6009B70")]
    [Address(RVA = "0x5EE2E0", Offset = "0x5ED0E0", VA = "0x105EE2E0")]
    public void OnContinueDecide()
    {
    }

    [Token(Token = "0x6009B71")]
    [Address(RVA = "0x5EE880", Offset = "0x5ED680", VA = "0x105EE880")]
    public void OnReplayError()
    {
    }

    [Token(Token = "0x6009B72")]
    [Address(RVA = "0x5EE140", Offset = "0x5ECF40", VA = "0x105EE140")]
    public void OnAppPause()
    {
    }

    [Token(Token = "0x6009B73")]
    [Address(RVA = "0x5EE600", Offset = "0x5ED400", VA = "0x105EE600")]
    public void OnMapStart()
    {
    }

    [Token(Token = "0x6009B74")]
    [Address(RVA = "0x5EE5C0", Offset = "0x5ED3C0", VA = "0x105EE5C0")]
    public void OnMapEnd()
    {
    }

    [Token(Token = "0x6009B75")]
    [Address(RVA = "0x5EDC20", Offset = "0x5ECA20", VA = "0x105EDC20")]
    public void OnUnitStart()
    {
    }

    [Token(Token = "0x6009B76")]
    [Address(RVA = "0x5EDC00", Offset = "0x5ECA00", VA = "0x105EDC00")]
    public void OnCastSkillStart()
    {
    }

    [Token(Token = "0x6009B77")]
    [Address(RVA = "0x5EE2A0", Offset = "0x5ED0A0", VA = "0x105EE2A0")]
    public void OnCommandSelectStart()
    {
    }

    [Token(Token = "0x6009B78")]
    [Address(RVA = "0x5EE2C0", Offset = "0x5ED0C0", VA = "0x105EE2C0")]
    public void OnCommandSelect()
    {
    }

    [Token(Token = "0x6009B79")]
    [Address(RVA = "0x5EE460", Offset = "0x5ED260", VA = "0x105EE460")]
    public void OnInputMoveStart()
    {
    }

    [Token(Token = "0x6009B7A")]
    [Address(RVA = "0x5EE440", Offset = "0x5ED240", VA = "0x105EE440")]
    public void OnInputMoveEnd()
    {
    }

    [Token(Token = "0x6009B7B")]
    [Address(RVA = "0x5EE5E0", Offset = "0x5ED3E0", VA = "0x105EE5E0")]
    public void OnMapModeStart()
    {
    }

    [Token(Token = "0x6009B7C")]
    [Address(RVA = "0x5EEBC0", Offset = "0x5ED9C0", VA = "0x105EEBC0")]
    public void OnThrowTargetSelectStart()
    {
    }

    [Token(Token = "0x6009B7D")]
    [Address(RVA = "0x5EEBA0", Offset = "0x5ED9A0", VA = "0x105EEBA0")]
    public void OnThrowTargetSelectEnd()
    {
    }

    [Token(Token = "0x6009B7E")]
    [Address(RVA = "0x5EEB80", Offset = "0x5ED980", VA = "0x105EEB80")]
    public void OnTargetSelectStart()
    {
    }

    [Token(Token = "0x6009B7F")]
    [Address(RVA = "0x5EEB60", Offset = "0x5ED960", VA = "0x105EEB60")]
    public void OnTargetSelectEnd()
    {
    }

    [Token(Token = "0x6009B80")]
    [Address(RVA = "0x5EE5A0", Offset = "0x5ED3A0", VA = "0x105EE5A0")]
    public void OnMainTargetSelect()
    {
    }

    [Token(Token = "0x6009B81")]
    [Address(RVA = "0x5EDE00", Offset = "0x5ECC00", VA = "0x105EDE00")]
    public void OnMainTargetDeselect()
    {
    }

    [Token(Token = "0x6009B82")]
    [Address(RVA = "0x5EEB20", Offset = "0x5ED920", VA = "0x105EEB20")]
    public void OnSubTargetSelect()
    {
    }

    [Token(Token = "0x6009B83")]
    [Address(RVA = "0x5EEB00", Offset = "0x5ED900", VA = "0x105EEB00")]
    public void OnSubTargetDeselect()
    {
    }

    [Token(Token = "0x1700159C")]
    public bool IsInputDirectionStarted
    {
      [Token(Token = "0x6009B84"), Address(RVA = "0x5EF100", Offset = "0x5EDF00", VA = "0x105EF100")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009B85"), Address(RVA = "0x5EF210", Offset = "0x5EE010", VA = "0x105EF210")] private set
      {
      }
    }

    [Token(Token = "0x6009B86")]
    [Address(RVA = "0x5EE410", Offset = "0x5ED210", VA = "0x105EE410")]
    public void OnInputDirectionStart()
    {
    }

    [Token(Token = "0x6009B87")]
    [Address(RVA = "0x5EE3E0", Offset = "0x5ED1E0", VA = "0x105EE3E0")]
    public void OnInputDirectionEnd()
    {
    }

    [Token(Token = "0x6009B88")]
    [Address(RVA = "0x5EDB80", Offset = "0x5EC980", VA = "0x105EDB80")]
    public void OnSkillSelectStart()
    {
    }

    [Token(Token = "0x6009B89")]
    [Address(RVA = "0x5EDB60", Offset = "0x5EC960", VA = "0x105EDB60")]
    public void OnSkillSelectEnd()
    {
    }

    [Token(Token = "0x6009B8A")]
    [Address(RVA = "0x5EE4C0", Offset = "0x5ED2C0", VA = "0x105EE4C0")]
    public void OnItemSelectStart()
    {
    }

    [Token(Token = "0x6009B8B")]
    [Address(RVA = "0x5EE4A0", Offset = "0x5ED2A0", VA = "0x105EE4A0")]
    public void OnItemSelectEnd()
    {
    }

    [Token(Token = "0x6009B8C")]
    [Address(RVA = "0x5EE480", Offset = "0x5ED280", VA = "0x105EE480")]
    public void OnInputTimeLimit()
    {
    }

    [Token(Token = "0x6009B8D")]
    [Address(RVA = "0x5EE300", Offset = "0x5ED100", VA = "0x105EE300")]
    public void OnDisconnected()
    {
    }

    [Token(Token = "0x6009B8E")]
    [Address(RVA = "0x5EE220", Offset = "0x5ED020", VA = "0x105EE220")]
    public void OnBan()
    {
    }

    [Token(Token = "0x6009B8F")]
    [Address(RVA = "0x5EEAE0", Offset = "0x5ED8E0", VA = "0x105EEAE0")]
    public void OnSequenceError()
    {
    }

    [Token(Token = "0x6009B90")]
    [Address(RVA = "0x5EE3C0", Offset = "0x5ED1C0", VA = "0x105EE3C0")]
    public void OnGridEventSelectStart()
    {
    }

    [Token(Token = "0x6009B91")]
    [Address(RVA = "0x5EE3A0", Offset = "0x5ED1A0", VA = "0x105EE3A0")]
    public void OnGridEventSelectEnd()
    {
    }

    [Token(Token = "0x6009B92")]
    [Address(RVA = "0x5EE280", Offset = "0x5ED080", VA = "0x105EE280")]
    public void OnBattleStart()
    {
    }

    [Token(Token = "0x6009B93")]
    [Address(RVA = "0x5EE240", Offset = "0x5ED040", VA = "0x105EE240")]
    public void OnBattleEnd()
    {
    }

    [Token(Token = "0x6009B94")]
    [Address(RVA = "0x5EEB40", Offset = "0x5ED940", VA = "0x105EEB40")]
    public void OnSupportSelectStart()
    {
    }

    [Token(Token = "0x6009B95")]
    [Address(RVA = "0x5EEC40", Offset = "0x5EDA40", VA = "0x105EEC40")]
    public void OnUnitChgSelectStart()
    {
    }

    [Token(Token = "0x6009B96")]
    [Address(RVA = "0x5EEC20", Offset = "0x5EDA20", VA = "0x105EEC20")]
    public void OnUnitChgSelectEnd()
    {
    }

    [Token(Token = "0x6009B97")]
    [Address(RVA = "0x5EEC00", Offset = "0x5EDA00", VA = "0x105EEC00")]
    public void OnUnitChgConfirmStart()
    {
    }

    [Token(Token = "0x6009B98")]
    [Address(RVA = "0x5EEBE0", Offset = "0x5ED9E0", VA = "0x105EEBE0")]
    public void OnUnitChgConfirmEnd()
    {
    }

    [Token(Token = "0x6009B99")]
    [Address(RVA = "0x5EEE00", Offset = "0x5EDC00", VA = "0x105EEE00")]
    private void Start()
    {
    }

    [Token(Token = "0x6009B9A")]
    [Address(RVA = "0x5ED640", Offset = "0x5EC440", VA = "0x105ED640")]
    public void Hide()
    {
    }

    [Token(Token = "0x6009B9B")]
    [Address(RVA = "0x5EED70", Offset = "0x5EDB70", VA = "0x105EED70")]
    public void Show()
    {
    }

    [Token(Token = "0x6009B9C")]
    [Address(RVA = "0x5EE360", Offset = "0x5ED160", VA = "0x105EE360")]
    public void OnFirstContact()
    {
    }

    [Token(Token = "0x6009B9D")]
    [Address(RVA = "0x5ED510", Offset = "0x5EC310", VA = "0x105ED510")]
    public void HideTargetWindows()
    {
    }

    [Token(Token = "0x6009B9E")]
    [Address(RVA = "0x5EDED0", Offset = "0x5ECCD0", VA = "0x105EDED0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6009B9F")]
    [Address(RVA = "0x5ED4F0", Offset = "0x5EC2F0", VA = "0x105ED4F0")]
    public void ClearEnableAll()
    {
    }

    [Token(Token = "0x6009BA0")]
    [Address(RVA = "0x5ED6D0", Offset = "0x5EC4D0", VA = "0x105ED6D0")]
    public bool IsNeedFlip() => new bool();

    [Token(Token = "0x6009BA1")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_BattleUI()
    {
    }
  }
}
