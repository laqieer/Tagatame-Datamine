// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidMyReportList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002583")]
  [AddComponentMenu("UI/GuildRaid/GuildRaidMyReportList")]
  [FlowNode.Pin(11, "Refresh", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(2, "Change Main", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(3, "Change Mock", FlowNode.PinTypes.Input, 3)]
  public class GuildRaidMyReportList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400ADD0")]
    private const int PIN_IN_INITIALIZE = 1;
    [Token(Token = "0x400ADD1")]
    private const int PIN_IN_BATTLE_TYPE_MAIN = 2;
    [Token(Token = "0x400ADD2")]
    private const int PIN_IN_BATTLE_TYPE_MOCK = 3;
    [Token(Token = "0x400ADD3")]
    private const int PIN_OUT_REFRESH = 11;
    [Token(Token = "0x400ADD4")]
    private const string TAB_BOSS_ID = "boss_id";
    [Token(Token = "0x400ADD5")]
    private const string DECK_PARENT = "DeckParent";
    [Token(Token = "0x400ADD6")]
    private const string PERIOD_PARENT = "PeriodParent";
    [Token(Token = "0x400ADD7")]
    private const string PERIOD_TITLE = "PeriodTitle";
    [Token(Token = "0x400ADD8")]
    [FieldOffset(Offset = "0x0")]
    private static GuildRaidMyReportList mInstance;
    [Token(Token = "0x400ADD9")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject ReportTemplate;
    [Token(Token = "0x400ADDA")]
    [FieldOffset(Offset = "0x10")]
    [StringIsResourcePath(typeof (GuildRaidPartyList))]
    [SerializeField]
    private string PartyListPrefabPath;
    [Token(Token = "0x400ADDB")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ToggleGroup ToggleGroup;
    [Token(Token = "0x400ADDC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Toggle[] Toggles;
    [Token(Token = "0x400ADDD")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SRPG_ScrollRect Scroll;
    [Token(Token = "0x400ADDE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform ScrollContent;
    [Token(Token = "0x400ADDF")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject SwitchTab;
    [Token(Token = "0x400ADE0")]
    [FieldOffset(Offset = "0x28")]
    private GuildRaidPartyList PartyListPrefab;
    [Token(Token = "0x400ADE1")]
    [FieldOffset(Offset = "0x2C")]
    private Dictionary<GuildRaidBattleType, Dictionary<int, GuildRaidMyReportList.ReportData>> Reports;
    [Token(Token = "0x400ADE4")]
    [FieldOffset(Offset = "0x38")]
    private List<GameObject> ReportGOList;
    [Token(Token = "0x400ADE5")]
    [FieldOffset(Offset = "0x3C")]
    private Coroutine loadDeck;
    [Token(Token = "0x400ADE6")]
    [FieldOffset(Offset = "0x40")]
    private bool IsLoading;
    [Token(Token = "0x400ADE7")]
    [FieldOffset(Offset = "0x41")]
    private bool NeedAllRefresh;

    [Token(Token = "0x1700175B")]
    public static GuildRaidMyReportList Instance
    {
      [Token(Token = "0x600A6A5"), Address(RVA = "0x687520", Offset = "0x686320", VA = "0x10687520")] get
      {
        return (GuildRaidMyReportList) null;
      }
    }

    [Token(Token = "0x1700175C")]
    public GuildRaidBattleType BattleType
    {
      [Token(Token = "0x600A6A6"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new GuildRaidBattleType();
      }
      [Token(Token = "0x600A6A7"), Address(RVA = "0x373930", Offset = "0x372730", VA = "0x10373930")] private set
      {
      }
    }

    [Token(Token = "0x1700175D")]
    public int BossId
    {
      [Token(Token = "0x600A6A8"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return new int();
      }
      [Token(Token = "0x600A6A9"), Address(RVA = "0x49D280", Offset = "0x49C080", VA = "0x1049D280")] private set
      {
      }
    }

    [Token(Token = "0x1700175E")]
    public GuildRaidMyReportList.ReportData CurrentReportData
    {
      [Token(Token = "0x600A6AA"), Address(RVA = "0x6874B0", Offset = "0x6862B0", VA = "0x106874B0")] get
      {
        return (GuildRaidMyReportList.ReportData) null;
      }
    }

    [Token(Token = "0x600A6AB")]
    [Address(RVA = "0x6858E0", Offset = "0x6846E0", VA = "0x106858E0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A6AC")]
    [Address(RVA = "0x6863D0", Offset = "0x6851D0", VA = "0x106863D0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600A6AD")]
    [Address(RVA = "0x687220", Offset = "0x686020", VA = "0x10687220")]
    private void Update()
    {
    }

    [Token(Token = "0x600A6AE")]
    [Address(RVA = "0x686430", Offset = "0x685230", VA = "0x10686430")]
    private void SetupNormalModeInAwake()
    {
    }

    [Token(Token = "0x600A6AF")]
    [Address(RVA = "0x686C20", Offset = "0x685A20", VA = "0x10686C20")]
    private void SetupTrainingModeInAwake()
    {
    }

    [Token(Token = "0x600A6B0")]
    [Address(RVA = "0x686A10", Offset = "0x685810", VA = "0x10686A10")]
    public void SetupReport(JSON_GuildRaidReport[] json, int totalPage)
    {
    }

    [Token(Token = "0x600A6B1")]
    [Address(RVA = "0x687010", Offset = "0x685E10", VA = "0x10687010")]
    public void SetupTrainingReport(JSON_GuildRaidTrainingBattleLog[] json)
    {
    }

    [Token(Token = "0x600A6B2")]
    [Address(RVA = "0x685890", Offset = "0x684690", VA = "0x10685890", Slot = "4")]
    public void Activated(int pinId)
    {
    }

    [Token(Token = "0x600A6B3")]
    [Address(RVA = "0x6859B0", Offset = "0x6847B0", VA = "0x106859B0")]
    private void ChangeBattleType(GuildRaidBattleType type)
    {
    }

    [Token(Token = "0x600A6B4")]
    [Address(RVA = "0x685A20", Offset = "0x684820", VA = "0x10685A20")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600A6B5")]
    [Address(RVA = "0x687380", Offset = "0x686180", VA = "0x10687380")]
    private IEnumerator _LoadDeck(Dictionary<Transform, List<UnitData>> decks)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600A6B6")]
    [Address(RVA = "0x686290", Offset = "0x685090", VA = "0x10686290")]
    private void OnChange(bool on)
    {
    }

    [Token(Token = "0x600A6B7")]
    [Address(RVA = "0x6873F0", Offset = "0x6861F0", VA = "0x106873F0")]
    public GuildRaidMyReportList()
    {
    }

    [Token(Token = "0x2002584")]
    public class ReportData
    {
      [Token(Token = "0x400ADE8")]
      [FieldOffset(Offset = "0x8")]
      public List<GuildRaidReportData> Reports;
      [Token(Token = "0x400ADE9")]
      [FieldOffset(Offset = "0xC")]
      public int CurrentPage;
      [Token(Token = "0x400ADEA")]
      [FieldOffset(Offset = "0x10")]
      public int TotalPage;

      [Token(Token = "0x600A6B8")]
      [Address(RVA = "0x691A40", Offset = "0x690840", VA = "0x10691A40")]
      public ReportData()
      {
      }
    }
  }
}
