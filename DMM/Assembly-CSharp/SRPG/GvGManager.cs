// Decompiled with JetBrains decompiler
// Type: SRPG.GvGManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025E8")]
  [AddComponentMenu("UI/GvG/GvGManager")]
  [FlowNode.Pin(300, "Get ConceptCard", FlowNode.PinTypes.Output, 300)]
  [FlowNode.Pin(111, "Occupied Node", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(202, "Battle CoolTime End", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(201, "Battle CoolTime Start", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(112, "Select Refresh", FlowNode.PinTypes.Output, 112)]
  [FlowNode.Pin(901, "Error", FlowNode.PinTypes.Output, 901)]
  [FlowNode.Pin(103, "Start Anime", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(200, "League RankUp", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(101, "Selected Node", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(100, "Initialized", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(10, "Open Chat", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(2, "Refresh", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(102, "Restore Battle", FlowNode.PinTypes.Output, 102)]
  public class GvGManager : MonoBehaviour, IFlowInterface, IWebHelp
  {
    [Token(Token = "0x400B009")]
    public const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400B00A")]
    public const int PIN_INPUT_REFRESH = 2;
    [Token(Token = "0x400B00B")]
    public const int PIN_INPUT_OPEN_CHAT = 10;
    [Token(Token = "0x400B00C")]
    public const int PIN_OUTPUT_INITALIZED = 100;
    [Token(Token = "0x400B00D")]
    public const int PIN_OUTPUT_SELECTED_NODE = 101;
    [Token(Token = "0x400B00E")]
    public const int PIN_OUTPUT_RESTORE_BATTLE = 102;
    [Token(Token = "0x400B00F")]
    public const int PIN_OUTPUT_STARTANIME = 103;
    [Token(Token = "0x400B010")]
    public const int PIN_OUTPUT_OCCUPIED_NODE = 111;
    [Token(Token = "0x400B011")]
    public const int PIN_OUTPUT_SELAUTOREFRESH = 112;
    [Token(Token = "0x400B012")]
    public const int PIN_OUTPUT_LEAGUE_RANKUP = 200;
    [Token(Token = "0x400B013")]
    public const int PIN_OUTPUT_BATTLE_COOLTIME_START = 201;
    [Token(Token = "0x400B014")]
    public const int PIN_OUTPUT_BATTLE_COOLTIME_END = 202;
    [Token(Token = "0x400B015")]
    public const int PIN_OUTPUT_GETCONCEPTCARD = 300;
    [Token(Token = "0x400B016")]
    public const int PIN_OUTPUT_ERROR = 901;
    [Token(Token = "0x400B017")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GvGMapAssets GvGMapAssetsData;
    [Token(Token = "0x400B018")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform BgParent;
    [Token(Token = "0x400B019")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private List<int> PartyCountImageBorder;
    [Token(Token = "0x400B01A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private bool IsHideChat;
    [Token(Token = "0x400B01B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int OnePageDefensePartyCountMax;
    [Token(Token = "0x400B01C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<Color> GuildColorList;
    [Token(Token = "0x400B01D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private int SelfColor;
    [Token(Token = "0x400B01E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int NPCColor;
    [Token(Token = "0x400B01F")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private List<int> mStaminaIndexList;
    [Token(Token = "0x400B020")]
    public const int SELF_DEFAULT_COLOR = 0;
    [Token(Token = "0x400B021")]
    public const int NPC_DEFAULT_COLOR = 1;
    [Token(Token = "0x400B022")]
    public const int PARTY_UNIT_NUM_MAX = 3;
    [Token(Token = "0x400B023")]
    [FieldOffset(Offset = "0x0")]
    private static GvGManager mInstance;
    [Token(Token = "0x400B025")]
    [FieldOffset(Offset = "0x38")]
    private DateTime mCanRefreshTime;
    [Token(Token = "0x400B026")]
    [FieldOffset(Offset = "0x40")]
    private DateTime mCanAutoRefreshTime;
    [Token(Token = "0x400B027")]
    [FieldOffset(Offset = "0x48")]
    private DateTime mCanDeclareCoolTime;
    [Token(Token = "0x400B028")]
    [FieldOffset(Offset = "0x50")]
    private GvGManager.GvGAutoRefreshState AutoRefreshStatusOld;
    [Token(Token = "0x400B02A")]
    [FieldOffset(Offset = "0x58")]
    private GvGMap mGvGMap;
    [Token(Token = "0x400B02B")]
    [FieldOffset(Offset = "0x5C")]
    private LoadRequest mResourceRequest;
    [Token(Token = "0x400B02D")]
    [FieldOffset(Offset = "0x4")]
    public static int GvGGroupId;
    [Token(Token = "0x400B032")]
    [FieldOffset(Offset = "0x74")]
    public bool IsGvGBattleCoolTimeFirst;
    [Token(Token = "0x400B033")]
    [FieldOffset(Offset = "0x78")]
    private GvGManager.GvGStatus OldGvGStatusPhase;
    [Token(Token = "0x400B034")]
    [FieldOffset(Offset = "0x7C")]
    private GvGUsedData mGvGUsedList;
    [Token(Token = "0x400B035")]
    [FieldOffset(Offset = "0x80")]
    public string mUsedMessage;
    [Token(Token = "0x400B036")]
    [FieldOffset(Offset = "0x84")]
    private GvGRuleParam CacheCurrentRule;
    [Token(Token = "0x400B037")]
    [FieldOffset(Offset = "0x88")]
    private int CacheRuleIndex;
    [Token(Token = "0x400B038")]
    [FieldOffset(Offset = "0x8C")]
    private int CacheRulePeriodId;
    [Token(Token = "0x400B044")]
    [FieldOffset(Offset = "0xBC")]
    public bool IsExecAutoRefresh;

    [Token(Token = "0x170017B0")]
    public int ONE_PAGE_DEFENSE_PARTY_COUNT_MAX
    {
      [Token(Token = "0x600A886"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170017B1")]
    public int GvGSelfColor
    {
      [Token(Token = "0x600A887"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170017B2")]
    public int GvGNPCColor
    {
      [Token(Token = "0x600A888"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170017B3")]
    public static GvGManager Instance
    {
      [Token(Token = "0x600A889"), Address(RVA = "0x6BD8F0", Offset = "0x6BC6F0", VA = "0x106BD8F0")] get
      {
        return (GvGManager) null;
      }
    }

    [Token(Token = "0x170017B4")]
    public GvGPeriodParam GvGPeriod
    {
      [Token(Token = "0x600A88A"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (GvGPeriodParam) null;
      }
      [Token(Token = "0x600A88B"), Address(RVA = "0x34C010", Offset = "0x34AE10", VA = "0x1034C010")] private set
      {
      }
    }

    [Token(Token = "0x170017B5")]
    public GvGManager.GvGAutoRefreshState AutoRefreshStatus
    {
      [Token(Token = "0x600A88C"), Address(RVA = "0x349170", Offset = "0x347F70", VA = "0x10349170")] get
      {
        return new GvGManager.GvGAutoRefreshState();
      }
      [Token(Token = "0x600A88D"), Address(RVA = "0x374A40", Offset = "0x373840", VA = "0x10374A40")] private set
      {
      }
    }

    [Token(Token = "0x170017B6")]
    public RewardData ResultReward
    {
      [Token(Token = "0x600A88E"), Address(RVA = "0x2B5EA0", Offset = "0x2B4CA0", VA = "0x102B5EA0")] get
      {
        return (RewardData) null;
      }
      [Token(Token = "0x600A88F"), Address(RVA = "0x3706F0", Offset = "0x36F4F0", VA = "0x103706F0")] private set
      {
      }
    }

    [Token(Token = "0x170017B7")]
    public GvGLeagueParam GvGLeagueInfo
    {
      [Token(Token = "0x600A890"), Address(RVA = "0x2B6040", Offset = "0x2B4E40", VA = "0x102B6040")] get
      {
        return (GvGLeagueParam) null;
      }
      [Token(Token = "0x600A891"), Address(RVA = "0x370710", Offset = "0x36F510", VA = "0x10370710")] private set
      {
      }
    }

    [Token(Token = "0x170017B8")]
    public bool IsPrivilege
    {
      [Token(Token = "0x600A892"), Address(RVA = "0x352390", Offset = "0x351190", VA = "0x10352390")] get
      {
        return new bool();
      }
      [Token(Token = "0x600A893"), Address(RVA = "0x352470", Offset = "0x351270", VA = "0x10352470")] private set
      {
      }
    }

    [Token(Token = "0x170017B9")]
    public int SelectNodeId
    {
      [Token(Token = "0x600A894"), Address(RVA = "0x288AC0", Offset = "0x2878C0", VA = "0x10288AC0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A895"), Address(RVA = "0x55F7A0", Offset = "0x55E5A0", VA = "0x1055F7A0")] set
      {
      }
    }

    [Token(Token = "0x170017BA")]
    public bool CanRefresh
    {
      [Token(Token = "0x600A896"), Address(RVA = "0x6BD450", Offset = "0x6BC250", VA = "0x106BD450")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170017BB")]
    public bool CanAutoRefresh
    {
      [Token(Token = "0x600A897"), Address(RVA = "0x6BD2F0", Offset = "0x6BC0F0", VA = "0x106BD2F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170017BC")]
    public bool CanDeclareCoolTime
    {
      [Token(Token = "0x600A898"), Address(RVA = "0x6BD3A0", Offset = "0x6BC1A0", VA = "0x106BD3A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170017BD")]
    public TimeSpan DeclareCoolTime
    {
      [Token(Token = "0x600A899"), Address(RVA = "0x6BD860", Offset = "0x6BC660", VA = "0x106BD860")] get
      {
        return new TimeSpan();
      }
    }

    [Token(Token = "0x170017BE")]
    public List<GvGRankingGuildData> GvGRankingViewList
    {
      [Token(Token = "0x600A89A"), Address(RVA = "0x288AD0", Offset = "0x2878D0", VA = "0x10288AD0")] get
      {
        return (List<GvGRankingGuildData>) null;
      }
      [Token(Token = "0x600A89B"), Address(RVA = "0x288B00", Offset = "0x287900", VA = "0x10288B00")] set
      {
      }
    }

    [Token(Token = "0x170017BF")]
    public GvGUsedData GvGUsedList
    {
      [Token(Token = "0x600A89C"), Address(RVA = "0x2B5EF0", Offset = "0x2B4CF0", VA = "0x102B5EF0")] get
      {
        return (GvGUsedData) null;
      }
    }

    [Token(Token = "0x600A89D")]
    [Address(RVA = "0x6BA9D0", Offset = "0x6B97D0", VA = "0x106BA9D0")]
    public GvGManager.GvGStatus GvGStatusPhase() => new GvGManager.GvGStatus();

    [Token(Token = "0x600A89E")]
    [Address(RVA = "0x6BB0D0", Offset = "0x6B9ED0", VA = "0x106BB0D0")]
    public GvGManager.GvGStatus SetGvGStatusPhase() => new GvGManager.GvGStatus();

    [Token(Token = "0x170017C0")]
    public bool IsGvGStatusOffencePhase
    {
      [Token(Token = "0x600A89F"), Address(RVA = "0x6BD950", Offset = "0x6BC750", VA = "0x106BD950")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170017C1")]
    public bool IsGvGOffenceBetween
    {
      [Token(Token = "0x600A8A0"), Address(RVA = "0x6BD920", Offset = "0x6BC720", VA = "0x106BD920")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600A8A1")]
    [Address(RVA = "0x6BA980", Offset = "0x6B9780", VA = "0x106BA980")]
    public GvGManager.GvGStatus GvGStatusPhaseSetPeriod() => new GvGManager.GvGStatus();

    [Token(Token = "0x170017C2")]
    public GvGRuleParam CurrentRule
    {
      [Token(Token = "0x600A8A2"), Address(RVA = "0x6BD560", Offset = "0x6BC360", VA = "0x106BD560")] get
      {
        return (GvGRuleParam) null;
      }
    }

    [Token(Token = "0x170017C3")]
    public int CurrentRuleUnitCount
    {
      [Token(Token = "0x600A8A3"), Address(RVA = "0x6BD500", Offset = "0x6BC300", VA = "0x106BD500")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170017C4")]
    public int RemainDeclareCount
    {
      [Token(Token = "0x600A8A4"), Address(RVA = "0x3492D0", Offset = "0x3480D0", VA = "0x103492D0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A8A5"), Address(RVA = "0x6BDB70", Offset = "0x6BC970", VA = "0x106BDB70")] set
      {
      }
    }

    [Token(Token = "0x170017C5")]
    public List<GvGNodeData> NodeDataList
    {
      [Token(Token = "0x600A8A6"), Address(RVA = "0x349020", Offset = "0x347E20", VA = "0x10349020")] get
      {
        return (List<GvGNodeData>) null;
      }
      [Token(Token = "0x600A8A7"), Address(RVA = "0x6BDB50", Offset = "0x6BC950", VA = "0x106BDB50")] private set
      {
      }
    }

    [Token(Token = "0x170017C6")]
    public List<int> MatchingOrder
    {
      [Token(Token = "0x600A8A8"), Address(RVA = "0x289A70", Offset = "0x288870", VA = "0x10289A70")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x600A8A9"), Address(RVA = "0x685730", Offset = "0x684530", VA = "0x10685730")] private set
      {
      }
    }

    [Token(Token = "0x170017C7")]
    public List<long> UsedUnitList
    {
      [Token(Token = "0x600A8AA"), Address(RVA = "0x37DBB0", Offset = "0x37C9B0", VA = "0x1037DBB0")] get
      {
        return (List<long>) null;
      }
      [Token(Token = "0x600A8AB"), Address(RVA = "0x685710", Offset = "0x684510", VA = "0x10685710")] private set
      {
      }
    }

    [Token(Token = "0x170017C8")]
    public List<GvGUsedUnitData> UsedUnitData
    {
      [Token(Token = "0x600A8AC"), Address(RVA = "0x511530", Offset = "0x510330", VA = "0x10511530")] get
      {
        return (List<GvGUsedUnitData>) null;
      }
      [Token(Token = "0x600A8AD"), Address(RVA = "0x685750", Offset = "0x684550", VA = "0x10685750")] private set
      {
      }
    }

    [Token(Token = "0x170017C9")]
    public int UsedUnitTodayCount
    {
      [Token(Token = "0x600A8AE"), Address(RVA = "0x6BDA30", Offset = "0x6BC830", VA = "0x106BDA30")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170017CA")]
    public List<GvGLeagueViewGuild> OtherGuildList
    {
      [Token(Token = "0x600A8AF"), Address(RVA = "0x4601D0", Offset = "0x45EFD0", VA = "0x104601D0")] get
      {
        return (List<GvGLeagueViewGuild>) null;
      }
      [Token(Token = "0x600A8B0"), Address(RVA = "0x460320", Offset = "0x45F120", VA = "0x10460320")] private set
      {
      }
    }

    [Token(Token = "0x170017CB")]
    public GvGLeagueViewGuild MyGuild
    {
      [Token(Token = "0x600A8B1"), Address(RVA = "0x4601C0", Offset = "0x45EFC0", VA = "0x104601C0")] get
      {
        return (GvGLeagueViewGuild) null;
      }
      [Token(Token = "0x600A8B2"), Address(RVA = "0x460300", Offset = "0x45F100", VA = "0x10460300")] private set
      {
      }
    }

    [Token(Token = "0x170017CC")]
    public GvGResultData ResultDaily
    {
      [Token(Token = "0x600A8B3"), Address(RVA = "0x349120", Offset = "0x347F20", VA = "0x10349120")] get
      {
        return (GvGResultData) null;
      }
      [Token(Token = "0x600A8B4"), Address(RVA = "0x690F00", Offset = "0x68FD00", VA = "0x10690F00")] private set
      {
      }
    }

    [Token(Token = "0x170017CD")]
    public GvGResultData ResultSeason
    {
      [Token(Token = "0x600A8B5"), Address(RVA = "0x5FC000", Offset = "0x5FAE00", VA = "0x105FC000")] get
      {
        return (GvGResultData) null;
      }
      [Token(Token = "0x600A8B6"), Address(RVA = "0x6BDB90", Offset = "0x6BC990", VA = "0x106BDB90")] private set
      {
      }
    }

    [Token(Token = "0x170017CE")]
    public GvGLeagueResult ResultLeague
    {
      [Token(Token = "0x600A8B7"), Address(RVA = "0x305C10", Offset = "0x304A10", VA = "0x10305C10")] get
      {
        return (GvGLeagueResult) null;
      }
      [Token(Token = "0x600A8B8"), Address(RVA = "0x685600", Offset = "0x684400", VA = "0x10685600")] private set
      {
      }
    }

    [Token(Token = "0x170017CF")]
    public List<GvGHalfTime> HalfTimeList
    {
      [Token(Token = "0x600A8B9"), Address(RVA = "0x3E1690", Offset = "0x3E0490", VA = "0x103E1690")] get
      {
        return (List<GvGHalfTime>) null;
      }
      [Token(Token = "0x600A8BA"), Address(RVA = "0x685660", Offset = "0x684460", VA = "0x10685660")] private set
      {
      }
    }

    [Token(Token = "0x600A8BB")]
    [Address(RVA = "0x6BABC0", Offset = "0x6B99C0", VA = "0x106BABC0")]
    public bool IsPeriod() => new bool();

    [Token(Token = "0x170017D0")]
    public bool IsGvGUsedNotSelect
    {
      [Token(Token = "0x600A8BC"), Address(RVA = "0x6BD980", Offset = "0x6BC780", VA = "0x106BD980")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600A8BD")]
    [Address(RVA = "0x6BA1D0", Offset = "0x6B8FD0", VA = "0x106BA1D0")]
    public ViewGuildData FindViewGuild(int guildId) => (ViewGuildData) null;

    [Token(Token = "0x600A8BE")]
    [Address(RVA = "0x6B9D20", Offset = "0x6B8B20", VA = "0x106B9D20")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A8BF")]
    [Address(RVA = "0x6BABD0", Offset = "0x6B99D0", VA = "0x106BABD0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600A8C0")]
    [Address(RVA = "0x6BD0A0", Offset = "0x6BBEA0", VA = "0x106BD0A0")]
    private void Update()
    {
    }

    [Token(Token = "0x600A8C1")]
    [Address(RVA = "0x6B9A60", Offset = "0x6B8860", VA = "0x106B9A60", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A8C2")]
    [Address(RVA = "0x6BAB00", Offset = "0x6B9900", VA = "0x106BAB00")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600A8C3")]
    [Address(RVA = "0x6BADC0", Offset = "0x6B9BC0", VA = "0x106BADC0")]
    private void Refresh(bool isAuto = false)
    {
    }

    [Token(Token = "0x600A8C4")]
    [Address(RVA = "0x6BAD60", Offset = "0x6B9B60", VA = "0x106BAD60")]
    public void OpenNodeInfo(int nodeId)
    {
    }

    [Token(Token = "0x600A8C5")]
    [Address(RVA = "0x6B9DC0", Offset = "0x6B8BC0", VA = "0x106B9DC0")]
    public bool CanDeclareNode(GvGNodeData node) => new bool();

    [Token(Token = "0x600A8C6")]
    [Address(RVA = "0x6B9D70", Offset = "0x6B8B70", VA = "0x106B9D70")]
    public bool CanAttackNode(GvGNodeData node) => new bool();

    [Token(Token = "0x600A8C7")]
    [Address(RVA = "0x6BA7B0", Offset = "0x6B95B0", VA = "0x106BA7B0")]
    public GvGManager.WindowBGImageIndex GetNodeImageIndex(GvGNodeData node)
    {
      return new GvGManager.WindowBGImageIndex();
    }

    [Token(Token = "0x600A8C8")]
    [Address(RVA = "0x6BA780", Offset = "0x6B9580", VA = "0x106BA780")]
    public GvGManager.WindowBGImageIndex GetNodeIconColor(GvGNodeData node)
    {
      return new GvGManager.WindowBGImageIndex();
    }

    [Token(Token = "0x600A8C9")]
    [Address(RVA = "0x6BA6A0", Offset = "0x6B94A0", VA = "0x106BA6A0")]
    public GvGManager.WindowBGImageIndex GetNodeBattleImageIndex(GvGNodeData node, bool isAttack)
    {
      return new GvGManager.WindowBGImageIndex();
    }

    [Token(Token = "0x600A8CA")]
    [Address(RVA = "0x6BA550", Offset = "0x6B9350", VA = "0x106BA550")]
    public int GetNodeBattleGuildImageIndex(GvGNodeData node, bool isAttack) => new int();

    [Token(Token = "0x600A8CB")]
    [Address(RVA = "0x6BA2E0", Offset = "0x6B90E0", VA = "0x106BA2E0")]
    public int GetDefensePartyIconIndex(GvGNodeData node) => new int();

    [Token(Token = "0x600A8CC")]
    [Address(RVA = "0x6BBB90", Offset = "0x6BA990", VA = "0x106BBB90")]
    public void SetNodeColor(GvGNodeData node, ChangeMaterialList cc)
    {
    }

    [Token(Token = "0x600A8CD")]
    [Address(RVA = "0x6BBAE0", Offset = "0x6BA8E0", VA = "0x106BBAE0")]
    public void SetNodeColorIndex(int index, ChangeMaterialList cc)
    {
    }

    [Token(Token = "0x600A8CE")]
    [Address(RVA = "0x6BBA20", Offset = "0x6BA820", VA = "0x106BBA20")]
    public void SetNodeColorIndex(int index, Image image)
    {
    }

    [Token(Token = "0x600A8CF")]
    [Address(RVA = "0x6BACC0", Offset = "0x6B9AC0", VA = "0x106BACC0")]
    private void OpenChat()
    {
    }

    [Token(Token = "0x600A8D0")]
    [Address(RVA = "0x6BAA70", Offset = "0x6B9870", VA = "0x106BAA70")]
    public void HideChatButton(bool flag = false)
    {
    }

    [Token(Token = "0x600A8D1")]
    [Address(RVA = "0x6BA7F0", Offset = "0x6B95F0", VA = "0x106BA7F0")]
    public void GetStaminaImageIndex(
      GvGNodeData node,
      Slider slider,
      ImageArray image,
      int winNum)
    {
    }

    [Token(Token = "0x600A8D2")]
    [Address(RVA = "0x6BA160", Offset = "0x6B8F60", VA = "0x106BA160")]
    private IEnumerator DownloadMap() => (IEnumerator) null;

    [Token(Token = "0x600A8D3")]
    [Address(RVA = "0x6BA380", Offset = "0x6B9180", VA = "0x106BA380", Slot = "5")]
    public bool GetHelpURL(out string url, out string title) => new bool();

    [Token(Token = "0x600A8D4")]
    [Address(RVA = "0x6BA410", Offset = "0x6B9210", VA = "0x106BA410")]
    public int GetMatchingOrderIndex(int gid) => new int();

    [Token(Token = "0x600A8D5")]
    [Address(RVA = "0x6BB0B0", Offset = "0x6B9EB0", VA = "0x106BB0B0")]
    public void SetAutoRefreshStatus(GvGManager.GvGAutoRefreshState state)
    {
    }

    [Token(Token = "0x600A8D6")]
    [Address(RVA = "0x6BB0A0", Offset = "0x6B9EA0", VA = "0x106BB0A0")]
    public void RevertAutoRefreshStatus()
    {
    }

    [Token(Token = "0x600A8D7")]
    [Address(RVA = "0x6BC800", Offset = "0x6BB600", VA = "0x106BC800")]
    public void SetupRefreshWait(int sec)
    {
    }

    [Token(Token = "0x600A8D8")]
    [Address(RVA = "0x6BBE80", Offset = "0x6BAC80", VA = "0x106BBE80")]
    public void SetupAutoRefreshWait(int sec)
    {
    }

    [Token(Token = "0x600A8D9")]
    [Address(RVA = "0x6BBF20", Offset = "0x6BAD20", VA = "0x106BBF20")]
    public void SetupDeclareCoolTime(int sec)
    {
    }

    [Token(Token = "0x600A8DA")]
    [Address(RVA = "0x6BC480", Offset = "0x6BB280", VA = "0x106BC480")]
    public bool SetupNodeDataList(JSON_GvGNodeData[] json) => new bool();

    [Token(Token = "0x600A8DB")]
    [Address(RVA = "0x6BC270", Offset = "0x6BB070", VA = "0x106BC270")]
    public bool SetupMatchingOrder(int[] json) => new bool();

    [Token(Token = "0x600A8DC")]
    [Address(RVA = "0x6BCC00", Offset = "0x6BBA00", VA = "0x106BCC00")]
    public void SetupUsedUnitList(JSON_GvGUsedUnitData[] units)
    {
    }

    [Token(Token = "0x600A8DD")]
    [Address(RVA = "0x6BC6B0", Offset = "0x6BB4B0", VA = "0x106BC6B0")]
    public bool SetupOtherGuildList(JSON_GvGLeagueViewGuild[] json) => new bool();

    [Token(Token = "0x600A8DE")]
    [Address(RVA = "0x6BC3C0", Offset = "0x6BB1C0", VA = "0x106BC3C0")]
    public bool SetupMyGuild(JSON_GvGLeagueViewGuild json) => new bool();

    [Token(Token = "0x600A8DF")]
    [Address(RVA = "0x6BC8A0", Offset = "0x6BB6A0", VA = "0x106BC8A0")]
    public bool SetupResultDaily(JSON_GvGResult json) => new bool();

    [Token(Token = "0x600A8E0")]
    [Address(RVA = "0x6BCB40", Offset = "0x6BB940", VA = "0x106BCB40")]
    public bool SetupResultSeason(JSON_GvGResult json) => new bool();

    [Token(Token = "0x600A8E1")]
    [Address(RVA = "0x6BC0E0", Offset = "0x6BAEE0", VA = "0x106BC0E0")]
    public bool SetupLeagueResult(JSON_GvGLeagueResult json) => new bool();

    [Token(Token = "0x600A8E2")]
    [Address(RVA = "0x6BBF70", Offset = "0x6BAD70", VA = "0x106BBF70")]
    public bool SetupHalfTime(JSON_GvGHalfTime[] json) => new bool();

    [Token(Token = "0x600A8E3")]
    [Address(RVA = "0x6BBC60", Offset = "0x6BAA60", VA = "0x106BBC60")]
    public void SetRankingData(JSON_GvGRankingData[] guilds)
    {
    }

    [Token(Token = "0x600A8E4")]
    [Address(RVA = "0x6BCBD0", Offset = "0x6BB9D0", VA = "0x106BCBD0")]
    public void SetupUsedItems(int[] artis, int[] cards, int[] runes, long[] crystals)
    {
    }

    [Token(Token = "0x600A8E5")]
    [Address(RVA = "0x6BA130", Offset = "0x6B8F30", VA = "0x106BA130")]
    public void CreateUsedMessage(JSON_GvGUsedItems[] items)
    {
    }

    [Token(Token = "0x600A8E6")]
    [Address(RVA = "0x6B9F90", Offset = "0x6B8D90", VA = "0x106B9F90")]
    public List<JSON_GvGUnitOverWriteData> ConvertOverWriteUnits(UnitOverWriteData[] units)
    {
      return (List<JSON_GvGUnitOverWriteData>) null;
    }

    [Token(Token = "0x600A8E7")]
    [Address(RVA = "0x6BC930", Offset = "0x6BB730", VA = "0x106BC930")]
    public bool SetupResultReward(string[] json) => new bool();

    [Token(Token = "0x600A8E8")]
    [Address(RVA = "0x6BD1A0", Offset = "0x6BBFA0", VA = "0x106BD1A0")]
    public GvGManager()
    {
    }

    [Token(Token = "0x20025E9")]
    public enum GvGStatus
    {
      [Token(Token = "0x400B046")] Declaration,
      [Token(Token = "0x400B047")] OffenseFirstHalf,
      [Token(Token = "0x400B048")] OffenseCoolTime,
      [Token(Token = "0x400B049")] OffenseLatterHalf,
      [Token(Token = "0x400B04A")] DeclarationCoolTime,
      [Token(Token = "0x400B04B")] AggregationTime,
      [Token(Token = "0x400B04C")] Finished,
    }

    [Token(Token = "0x20025EA")]
    public enum WindowBGImageIndex
    {
      [Token(Token = "0x400B04E")] Blue,
      [Token(Token = "0x400B04F")] Purple,
      [Token(Token = "0x400B050")] Red,
      [Token(Token = "0x400B051")] Max,
    }

    [Token(Token = "0x20025EB")]
    public enum GvGAutoRefreshState
    {
      [Token(Token = "0x400B053")] Top = 0,
      [Token(Token = "0x400B054")] Battle = 10, // 0x0000000A
      [Token(Token = "0x400B055")] Stop = 20, // 0x00000014
    }
  }
}
