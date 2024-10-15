// Decompiled with JetBrains decompiler
// Type: SRPG.ArenaWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FE0")]
  [FlowNode.Pin(101, "Player Selected", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(150, "Open IAP Window", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(151, "Reset Cooldown", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(152, "Reset Tickets", FlowNode.PinTypes.Output, 4)]
  [FlowNode.Pin(200, "Battle Start Confirm", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(201, "Battle Start (OK)", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(110, "Refresh Party", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(202, "Battle Start (Cancel)", FlowNode.PinTypes.Output, 102)]
  [AddComponentMenu("UI/ArenaWindow")]
  [FlowNode.Pin(120, "Refresh Party ToolTip", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "Refresh Enemy", FlowNode.PinTypes.Input, 0)]
  public class ArenaWindow : MonoBehaviour, IFlowInterface, IWebHelp
  {
    [Token(Token = "0x4008727")]
    public const int PINID_REFRESH_ENEMYLIST = 100;
    [Token(Token = "0x4008728")]
    public const int PINID_REFRESH_PARTY = 110;
    [Token(Token = "0x4008729")]
    public const int PINID_REFRESH_PARTY_TOOLTIP = 120;
    [Token(Token = "0x400872A")]
    public const int PINID_PLAYER_SELECTED = 101;
    [Token(Token = "0x400872B")]
    public const int PINID_OPEN_IAPWINDOW = 150;
    [Token(Token = "0x400872C")]
    public const int PINID_RESET_COOLDOWN = 151;
    [Token(Token = "0x400872D")]
    public const int PINID_RESET_TICKETS = 152;
    [Token(Token = "0x400872E")]
    public const int PINID_BATTLE_START_CONFIRM = 200;
    [Token(Token = "0x400872F")]
    public const int PINID_BATTLE_START_OK = 201;
    [Token(Token = "0x4008730")]
    public const int PINID_BATTLE_START_CANCEL = 202;
    [Token(Token = "0x4008731")]
    [FieldOffset(Offset = "0xC")]
    public GameObject PartyInfo;
    [Token(Token = "0x4008732")]
    [FieldOffset(Offset = "0x10")]
    public GameObject DefensePartyInfo;
    [Token(Token = "0x4008733")]
    [FieldOffset(Offset = "0x14")]
    public GameObject VsPartyInfo;
    [Token(Token = "0x4008734")]
    [FieldOffset(Offset = "0x18")]
    public GameObject VsEnemyPartyInfo;
    [Token(Token = "0x4008735")]
    [FieldOffset(Offset = "0x1C")]
    public SRPG_ListBase EnemyPlayerList;
    [Token(Token = "0x4008736")]
    [FieldOffset(Offset = "0x20")]
    public ListItemEvents EnemyPlayerItem;
    [Token(Token = "0x4008737")]
    [FieldOffset(Offset = "0x24")]
    public GameObject EnemyPlayerDetail;
    [Token(Token = "0x4008738")]
    [FieldOffset(Offset = "0x28")]
    public GameObject HistoryObject;
    [Token(Token = "0x4008739")]
    [FieldOffset(Offset = "0x2C")]
    public bool RefreshEnemyListOnStart;
    [Token(Token = "0x400873A")]
    [FieldOffset(Offset = "0x2D")]
    public bool RefreshPartyOnStart;
    [Token(Token = "0x400873B")]
    [FieldOffset(Offset = "0x30")]
    public GameObject[] PartyUnitSlots;
    [Token(Token = "0x400873C")]
    [FieldOffset(Offset = "0x34")]
    public GameObject[] PartyUnitSameObject;
    [Token(Token = "0x400873D")]
    [FieldOffset(Offset = "0x38")]
    public GameObject PartyUnitLeader;
    [Token(Token = "0x400873E")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject PartyUnitLeaderVS;
    [Token(Token = "0x400873F")]
    [FieldOffset(Offset = "0x40")]
    public GameObject[] DefenseUnitSlots;
    [Token(Token = "0x4008740")]
    [FieldOffset(Offset = "0x44")]
    public GameObject[] DefenseUnitSameObject;
    [Token(Token = "0x4008741")]
    [FieldOffset(Offset = "0x48")]
    public GameObject DefenseUnitLeader;
    [Token(Token = "0x4008742")]
    [FieldOffset(Offset = "0x4C")]
    public GameObject CooldownTimer;
    [Token(Token = "0x4008743")]
    [FieldOffset(Offset = "0x50")]
    public Button CooldownResetButton;
    [Token(Token = "0x4008744")]
    [FieldOffset(Offset = "0x54")]
    public GameObject BpHolder;
    [Token(Token = "0x4008745")]
    [FieldOffset(Offset = "0x58")]
    public GameObject BattlePreWindow;
    [Token(Token = "0x4008746")]
    [FieldOffset(Offset = "0x5C")]
    public GameObject AttackDeckWindow;
    [Token(Token = "0x4008747")]
    [FieldOffset(Offset = "0x60")]
    public GameObject AttackDeckWindowIcon;
    [Token(Token = "0x4008748")]
    [FieldOffset(Offset = "0x64")]
    public GameObject DefenseDeckWindow;
    [Token(Token = "0x4008749")]
    [FieldOffset(Offset = "0x68")]
    public GameObject DefenseDeckWindowIcon;
    [Token(Token = "0x400874A")]
    [FieldOffset(Offset = "0x6C")]
    public GameObject EnemyListWindow;
    [Token(Token = "0x400874B")]
    [FieldOffset(Offset = "0x70")]
    public GameObject PlayerStatusWindow;
    [Token(Token = "0x400874C")]
    [FieldOffset(Offset = "0x74")]
    [FormerlySerializedAs("TotalAtkText")]
    public Text AtkTotalCombatPowerText;
    [Token(Token = "0x400874D")]
    [FieldOffset(Offset = "0x78")]
    [FormerlySerializedAs("TotalDefText")]
    public Text DefTotalCombatPowerText;
    [Token(Token = "0x400874E")]
    [FieldOffset(Offset = "0x7C")]
    public Text ReadyPlayerTotalCombatPowerText;
    [Token(Token = "0x400874F")]
    [FieldOffset(Offset = "0x80")]
    private bool mIsActiveAttackParty;
    [Token(Token = "0x4008750")]
    [FieldOffset(Offset = "0x84")]
    public Button MatchingButton;
    [Token(Token = "0x4008751")]
    [FieldOffset(Offset = "0x88")]
    public Button DeckNextButton;
    [Token(Token = "0x4008752")]
    [FieldOffset(Offset = "0x8C")]
    public Button DeckPrevButton;
    [Token(Token = "0x4008753")]
    [FieldOffset(Offset = "0x90")]
    public Button MatchingCloseButton;
    [Token(Token = "0x4008754")]
    [FieldOffset(Offset = "0x94")]
    public Button BattleBackButton;
    [Token(Token = "0x4008755")]
    [FieldOffset(Offset = "0x98")]
    public Button ChangeLeaderSkillButton_Atk;
    [Token(Token = "0x4008756")]
    [FieldOffset(Offset = "0x9C")]
    public Button ChangeLeaderSkillButton_Def;
    [Token(Token = "0x4008757")]
    [FieldOffset(Offset = "0xA0")]
    public Text LastBattleAtText;
    [Token(Token = "0x4008758")]
    [FieldOffset(Offset = "0xA4")]
    [Space(10f)]
    public GameObject GoMapInfo;
    [Token(Token = "0x4008759")]
    [FieldOffset(Offset = "0xA8")]
    public GameObject GoMapInfoThumbnail;
    [Token(Token = "0x400875A")]
    [FieldOffset(Offset = "0xAC")]
    public GameObject GoMapInfoEndAt;
    [Token(Token = "0x400875B")]
    [FieldOffset(Offset = "0xB0")]
    public Text TextMapInfoEndAt;
    [Token(Token = "0x400875C")]
    [FieldOffset(Offset = "0xB4")]
    private bool mIsUpdateMapInfoEndAt;
    [Token(Token = "0x400875D")]
    [FieldOffset(Offset = "0xB8")]
    private float mPassedTimeMapInfoEndAt;
    [Token(Token = "0x400875E")]
    [FieldOffset(Offset = "0x0")]
    private static ArenaWindow mInstance;

    [Token(Token = "0x170012D2")]
    public static ArenaWindow Instance
    {
      [Token(Token = "0x6008340"), Address(RVA = "0x43E8E0", Offset = "0x43D6E0", VA = "0x1043E8E0")] get
      {
        return (ArenaWindow) null;
      }
    }

    [Token(Token = "0x6008341")]
    [Address(RVA = "0x43B100", Offset = "0x439F00", VA = "0x1043B100")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008342")]
    [Address(RVA = "0x43C100", Offset = "0x43AF00", VA = "0x1043C100")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6008343")]
    [Address(RVA = "0x43E000", Offset = "0x43CE00", VA = "0x1043E000")]
    private void Start()
    {
    }

    [Token(Token = "0x6008344")]
    [Address(RVA = "0x43B020", Offset = "0x439E20", VA = "0x1043B020", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008345")]
    [Address(RVA = "0x43B140", Offset = "0x439F40", VA = "0x1043B140")]
    private void BattleStartConfirm()
    {
    }

    [Token(Token = "0x6008346")]
    [Address(RVA = "0x43B810", Offset = "0x43A610", VA = "0x1043B810")]
    private void DownloadApproved()
    {
    }

    [Token(Token = "0x6008347")]
    [Address(RVA = "0x43B830", Offset = "0x43A630", VA = "0x1043B830")]
    private void DownloadNotApproved()
    {
    }

    [Token(Token = "0x6008348")]
    [Address(RVA = "0x43B830", Offset = "0x43A630", VA = "0x1043B830")]
    private void SameUnitInParty()
    {
    }

    [Token(Token = "0x6008349")]
    [Address(RVA = "0x43DF20", Offset = "0x43CD20", VA = "0x1043DF20")]
    private void RefreshParty()
    {
    }

    [Token(Token = "0x600834A")]
    [Address(RVA = "0x43CAD0", Offset = "0x43B8D0", VA = "0x1043CAD0")]
    private void RefreshAttackParty()
    {
    }

    [Token(Token = "0x600834B")]
    [Address(RVA = "0x43D440", Offset = "0x43C240", VA = "0x1043D440")]
    private void RefreshDefenseParty()
    {
    }

    [Token(Token = "0x600834C")]
    [Address(RVA = "0x43D890", Offset = "0x43C690", VA = "0x1043D890")]
    private void RefreshEnemyList()
    {
    }

    [Token(Token = "0x600834D")]
    [Address(RVA = "0x43DDC0", Offset = "0x43CBC0", VA = "0x1043DDC0")]
    private bool RefreshMapInfoEndAt() => new bool();

    [Token(Token = "0x600834E")]
    [Address(RVA = "0x43BBD0", Offset = "0x43A9D0", VA = "0x1043BBD0")]
    public static bool GetMapInfoViewData(
      out bool is_display,
      out string end_at_text,
      out bool is_need_refresh)
    {
      return new bool();
    }

    [Token(Token = "0x600834F")]
    [Address(RVA = "0x43E600", Offset = "0x43D400", VA = "0x1043E600")]
    private void UpdateMapInfoEndAt()
    {
    }

    [Token(Token = "0x6008350")]
    [Address(RVA = "0x43C470", Offset = "0x43B270", VA = "0x1043C470")]
    private void OnEnemySelect(GameObject go)
    {
    }

    [Token(Token = "0x6008351")]
    [Address(RVA = "0x43C850", Offset = "0x43B650", VA = "0x1043C850")]
    private void OnResetChallengeTickets(GameObject go)
    {
    }

    [Token(Token = "0x6008352")]
    [Address(RVA = "0x43CAB0", Offset = "0x43B8B0", VA = "0x1043CAB0")]
    private void OpenCoinShop(GameObject go)
    {
    }

    [Token(Token = "0x6008353")]
    [Address(RVA = "0x43C370", Offset = "0x43B170", VA = "0x1043C370")]
    private void OnEnemyDetailSelect(GameObject go)
    {
    }

    [Token(Token = "0x6008354")]
    [Address(RVA = "0x43C020", Offset = "0x43AE20", VA = "0x1043C020")]
    private void OnCooldownButtonClick()
    {
    }

    [Token(Token = "0x6008355")]
    [Address(RVA = "0x43C970", Offset = "0x43B770", VA = "0x1043C970")]
    private void OnResetCooldown(GameObject go)
    {
    }

    [Token(Token = "0x6008356")]
    [Address(RVA = "0x43E660", Offset = "0x43D460", VA = "0x1043E660")]
    private void Update()
    {
    }

    [Token(Token = "0x6008357")]
    [Address(RVA = "0x43D2C0", Offset = "0x43C0C0", VA = "0x1043D2C0")]
    private void RefreshCooldowns()
    {
    }

    [Token(Token = "0x6008358")]
    [Address(RVA = "0x43B5D0", Offset = "0x43A3D0", VA = "0x1043B5D0")]
    private void ChangeDrawDeck(bool attack)
    {
    }

    [Token(Token = "0x6008359")]
    [Address(RVA = "0x43B7C0", Offset = "0x43A5C0", VA = "0x1043B7C0")]
    private void ChangeDrawInformation(bool playerinfo)
    {
    }

    [Token(Token = "0x600835A")]
    [Address(RVA = "0x43D140", Offset = "0x43BF40", VA = "0x1043D140")]
    private void RefreshBattleCount()
    {
    }

    [Token(Token = "0x600835B")]
    [Address(RVA = "0x43CFF0", Offset = "0x43BDF0", VA = "0x1043CFF0")]
    private void RefreshBattleCountOnDayChange()
    {
    }

    [Token(Token = "0x600835C")]
    [Address(RVA = "0x43DF50", Offset = "0x43CD50", VA = "0x1043DF50")]
    private void SetGlobalVars_LeaderSkillChangeUnitUniqueID(bool is_attack)
    {
    }

    [Token(Token = "0x600835D")]
    [Address(RVA = "0x43E470", Offset = "0x43D270", VA = "0x1043E470")]
    public void SyncArenaGlobalVars()
    {
    }

    [Token(Token = "0x600835E")]
    [Address(RVA = "0x43C290", Offset = "0x43B090", VA = "0x1043C290")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600835F")]
    [Address(RVA = "0x43C140", Offset = "0x43AF40", VA = "0x1043C140")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6008360")]
    [Address(RVA = "0x43C7D0", Offset = "0x43B5D0", VA = "0x1043C7D0")]
    public void OnMatchingButtonClick()
    {
    }

    [Token(Token = "0x6008361")]
    [Address(RVA = "0x43C810", Offset = "0x43B610", VA = "0x1043C810")]
    public void OnMatchingCloseButtonClick()
    {
    }

    [Token(Token = "0x6008362")]
    [Address(RVA = "0x43C0C0", Offset = "0x43AEC0", VA = "0x1043C0C0")]
    public void OnDeckNextButtonClick()
    {
    }

    [Token(Token = "0x6008363")]
    [Address(RVA = "0x43C0E0", Offset = "0x43AEE0", VA = "0x1043C0E0")]
    public void OnDeckPrevButtonClick()
    {
    }

    [Token(Token = "0x6008364")]
    [Address(RVA = "0x43BFF0", Offset = "0x43ADF0", VA = "0x1043BFF0")]
    public void OnBattleBackButtonClick()
    {
    }

    [Token(Token = "0x6008365")]
    [Address(RVA = "0x43C710", Offset = "0x43B510", VA = "0x1043C710")]
    public void OnHellpButtonClick(GameObject go)
    {
    }

    [Token(Token = "0x6008366")]
    [Address(RVA = "0x43C740", Offset = "0x43B540", VA = "0x1043C740")]
    public void OnHistoryDisp()
    {
    }

    [Token(Token = "0x6008367")]
    [Address(RVA = "0x43BA90", Offset = "0x43A890", VA = "0x1043BA90", Slot = "5")]
    public bool GetHelpURL(out string url, out string title) => new bool();

    [Token(Token = "0x6008368")]
    [Address(RVA = "0x43B970", Offset = "0x43A770", VA = "0x1043B970")]
    private List<UnitData> GetBattleEntryUnits() => (List<UnitData>) null;

    [Token(Token = "0x6008369")]
    [Address(RVA = "0x43B850", Offset = "0x43A650", VA = "0x1043B850")]
    private List<UnitData> GetBattleEntryPlayerUnits() => (List<UnitData>) null;

    [Token(Token = "0x600836A")]
    [Address(RVA = "0x43E840", Offset = "0x43D640", VA = "0x1043E840")]
    public ArenaWindow()
    {
    }
  }
}
