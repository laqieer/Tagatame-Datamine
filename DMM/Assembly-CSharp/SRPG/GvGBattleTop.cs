// Decompiled with JetBrains decompiler
// Type: SRPG.GvGBattleTop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200259E")]
  [AddComponentMenu("UI/GvG/GvGBattleTop")]
  [FlowNode.Pin(104, "Confirm Party", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(103, "Select Refresh", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(102, "Battle Start with Message", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "Battle Start", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(12, "Hide Chat", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(11, "Refresh Defense", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(10, "Refresh Offense", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(3, "Battle", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(13, "Open Chat", FlowNode.PinTypes.Input, 13)]
  public class GvGBattleTop : MonoBehaviour, IFlowInterface, IPagination
  {
    [Token(Token = "0x400AE76")]
    public const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400AE77")]
    public const int PIN_INPUT_BATTLE = 3;
    [Token(Token = "0x400AE78")]
    public const int PIN_INPUT_REFRESH_O = 10;
    [Token(Token = "0x400AE79")]
    public const int PIN_INPUT_REFRESH_D = 11;
    [Token(Token = "0x400AE7A")]
    public const int PIN_INPUT_HIDECHAT = 12;
    [Token(Token = "0x400AE7B")]
    public const int PIN_INPUT_OPENCHAT = 13;
    [Token(Token = "0x400AE7C")]
    public const int PIN_OUTPUT_BATTLE = 101;
    [Token(Token = "0x400AE7D")]
    public const int PIN_OUTPUT_BATTLE_WITH_MESSAGE = 102;
    [Token(Token = "0x400AE7E")]
    public const int PIN_OUTPUT_SELAUTOREFRESH = 103;
    [Token(Token = "0x400AE7F")]
    public const int PIN_OUTPUT_CONFIRMPARTY = 104;
    [Token(Token = "0x400AE80")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text PhaseText;
    [Token(Token = "0x400AE81")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text NextText;
    [Token(Token = "0x400AE82")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    [Space(10f)]
    private Text NodeName;
    [Token(Token = "0x400AE83")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject MapParent;
    [Token(Token = "0x400AE84")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GvGPartyContent PartyTemplate;
    [Token(Token = "0x400AE85")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GvGPartyContent SelfPartyContent;
    [Token(Token = "0x400AE86")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text TotalAttackText;
    [Token(Token = "0x400AE87")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ImageArray LeaderSkillTarget;
    [Token(Token = "0x400AE88")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Button ChangeLeaderSkillButton;
    [Token(Token = "0x400AE89")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button PartyEditorButton;
    [Token(Token = "0x400AE8A")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text TeamCountText;
    [Token(Token = "0x400AE8B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button OccupyButton;
    [Token(Token = "0x400AE8C")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private string SVBBattleButtonName;
    [Token(Token = "0x400AE8D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private bool ISBattleButtonNever;
    [Token(Token = "0x400AE8E")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Text RemainCoolTimeText;
    [Token(Token = "0x400AE8F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Button mUpdateButton;
    [Token(Token = "0x400AE90")]
    [FieldOffset(Offset = "0x4C")]
    [Space(10f)]
    [SerializeField]
    private Button PageNextButton;
    [Token(Token = "0x400AE91")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Button PagePrevButton;
    [Token(Token = "0x400AE92")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private Text PageCurrentText;
    [Token(Token = "0x400AE93")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text PageTotalText;
    [Token(Token = "0x400AE94")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private ScrollRect EnemyPartyScrollRect;
    [Token(Token = "0x400AE95")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    [Space(10f)]
    private Text mSelfpartyBeatNumText;
    [Token(Token = "0x400AE96")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private Text mSelfTotalBeatNumText;
    [Token(Token = "0x400AE97")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text mEnemyTotalBeatNumText;
    [Token(Token = "0x400AE98")]
    [FieldOffset(Offset = "0x70")]
    private DateTime CanRefreshTime;
    [Token(Token = "0x400AE99")]
    [FieldOffset(Offset = "0x78")]
    private DateTime EndTime;
    [Token(Token = "0x400AE9A")]
    [FieldOffset(Offset = "0x80")]
    private DateTime ElapsedTime;
    [Token(Token = "0x400AE9B")]
    [FieldOffset(Offset = "0x88")]
    private GvGNodeData CurrentNode;
    [Token(Token = "0x400AE9C")]
    [FieldOffset(Offset = "0x8C")]
    private int BattleSeed;
    [Token(Token = "0x400AE9D")]
    [FieldOffset(Offset = "0x90")]
    private float AttackCoolTime;
    [Token(Token = "0x400AE9E")]
    [FieldOffset(Offset = "0x94")]
    private bool IsCoolTime;
    [Token(Token = "0x400AE9F")]
    [FieldOffset(Offset = "0x98")]
    private List<GvGParty> DefenseParties;
    [Token(Token = "0x400AEA0")]
    [FieldOffset(Offset = "0x9C")]
    private List<GvGPartyContent> PartyList;
    [Token(Token = "0x400AEA1")]
    [FieldOffset(Offset = "0xA0")]
    private List<Button> BattleButtonList;
    [Token(Token = "0x400AEAA")]
    [FieldOffset(Offset = "0xC0")]
    private int TotalDefensePartyCount;
    [Token(Token = "0x400AEAB")]
    [FieldOffset(Offset = "0xC4")]
    private int TotalPage;
    [Token(Token = "0x400AEAC")]
    [FieldOffset(Offset = "0xC8")]
    private List<JSON_GvGUnitOverWriteData> mGvGtempParty;
    [Token(Token = "0x400AEAD")]
    [FieldOffset(Offset = "0xCC")]
    public bool IsExecAutoRefresh;

    [Token(Token = "0x17001763")]
    public static GvGBattleTop Instance
    {
      [Token(Token = "0x600A70D"), Address(RVA = "0x690E40", Offset = "0x68FC40", VA = "0x10690E40")] get
      {
        return (GvGBattleTop) null;
      }
      [Token(Token = "0x600A70E"), Address(RVA = "0x690EA0", Offset = "0x68FCA0", VA = "0x10690EA0")] private set
      {
      }
    }

    [Token(Token = "0x17001764")]
    public bool CanRefresh
    {
      [Token(Token = "0x600A70F"), Address(RVA = "0x690D90", Offset = "0x68FB90", VA = "0x10690D90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001765")]
    public long[] EditPartyIds
    {
      [Token(Token = "0x600A710"), Address(RVA = "0x4601D0", Offset = "0x45EFD0", VA = "0x104601D0")] get
      {
        return (long[]) null;
      }
      [Token(Token = "0x600A711"), Address(RVA = "0x460320", Offset = "0x45F120", VA = "0x10460320")] private set
      {
      }
    }

    [Token(Token = "0x17001766")]
    public int CurrentPage
    {
      [Token(Token = "0x600A712"), Address(RVA = "0x4601C0", Offset = "0x45EFC0", VA = "0x104601C0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A713"), Address(RVA = "0x690E80", Offset = "0x68FC80", VA = "0x10690E80")] private set
      {
      }
    }

    [Token(Token = "0x17001767")]
    public GvGParty SelfParty
    {
      [Token(Token = "0x600A714"), Address(RVA = "0x349120", Offset = "0x347F20", VA = "0x10349120")] get
      {
        return (GvGParty) null;
      }
      [Token(Token = "0x600A715"), Address(RVA = "0x690F00", Offset = "0x68FD00", VA = "0x10690F00")] private set
      {
      }
    }

    [Token(Token = "0x17001768")]
    public int SelfBeatNum
    {
      [Token(Token = "0x600A716"), Address(RVA = "0x5FC000", Offset = "0x5FAE00", VA = "0x105FC000")] get
      {
        return new int();
      }
      [Token(Token = "0x600A717"), Address(RVA = "0x5FC0B0", Offset = "0x5FAEB0", VA = "0x105FC0B0")] private set
      {
      }
    }

    [Token(Token = "0x17001769")]
    public int SelfTotalBeatNum
    {
      [Token(Token = "0x600A718"), Address(RVA = "0x305C10", Offset = "0x304A10", VA = "0x10305C10")] get
      {
        return new int();
      }
      [Token(Token = "0x600A719"), Address(RVA = "0x5FC0D0", Offset = "0x5FAED0", VA = "0x105FC0D0")] private set
      {
      }
    }

    [Token(Token = "0x1700176A")]
    public int EnemyTotalBeatNum
    {
      [Token(Token = "0x600A71A"), Address(RVA = "0x3E1690", Offset = "0x3E0490", VA = "0x103E1690")] get
      {
        return new int();
      }
      [Token(Token = "0x600A71B"), Address(RVA = "0x5FC0F0", Offset = "0x5FAEF0", VA = "0x105FC0F0")] private set
      {
      }
    }

    [Token(Token = "0x1700176B")]
    public bool IsConfirmParty
    {
      [Token(Token = "0x600A71C"), Address(RVA = "0x690E70", Offset = "0x68FC70", VA = "0x10690E70")] get
      {
        return new bool();
      }
      [Token(Token = "0x600A71D"), Address(RVA = "0x690EE0", Offset = "0x68FCE0", VA = "0x10690EE0")] private set
      {
      }
    }

    [Token(Token = "0x1700176C")]
    public List<JSON_GvGUnitOverWriteData> GvGtempParty
    {
      [Token(Token = "0x600A71E"), Address(RVA = "0x36A9E0", Offset = "0x3697E0", VA = "0x1036A9E0")] get
      {
        return (List<JSON_GvGUnitOverWriteData>) null;
      }
    }

    [Token(Token = "0x600A71F")]
    [Address(RVA = "0x68E550", Offset = "0x68D350", VA = "0x1068E550")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A720")]
    [Address(RVA = "0x68EDA0", Offset = "0x68DBA0", VA = "0x1068EDA0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600A721")]
    [Address(RVA = "0x6902F0", Offset = "0x68F0F0", VA = "0x106902F0")]
    private void Start()
    {
    }

    [Token(Token = "0x600A722")]
    [Address(RVA = "0x690530", Offset = "0x68F330", VA = "0x10690530")]
    private void Update()
    {
    }

    [Token(Token = "0x600A723")]
    [Address(RVA = "0x68E460", Offset = "0x68D260", VA = "0x1068E460", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A724")]
    [Address(RVA = "0x68EAD0", Offset = "0x68D8D0", VA = "0x1068EAD0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600A725")]
    [Address(RVA = "0x68F7B0", Offset = "0x68E5B0", VA = "0x1068F7B0")]
    private void RefreshOffense()
    {
    }

    [Token(Token = "0x600A726")]
    [Address(RVA = "0x68EED0", Offset = "0x68DCD0", VA = "0x1068EED0")]
    private void RefreshDefense()
    {
    }

    [Token(Token = "0x600A727")]
    [Address(RVA = "0x68FE40", Offset = "0x68EC40", VA = "0x1068FE40")]
    private void RefreshPhase()
    {
    }

    [Token(Token = "0x600A728")]
    [Address(RVA = "0x68E7F0", Offset = "0x68D5F0", VA = "0x1068E7F0")]
    private void Battle()
    {
    }

    [Token(Token = "0x600A729")]
    [Address(RVA = "0x68FC10", Offset = "0x68EA10", VA = "0x1068FC10")]
    private void RefreshPagination()
    {
    }

    [Token(Token = "0x600A72A")]
    [Address(RVA = "0x68ED80", Offset = "0x68DB80", VA = "0x1068ED80", Slot = "5")]
    public void NextPage()
    {
    }

    [Token(Token = "0x600A72B")]
    [Address(RVA = "0x68EEB0", Offset = "0x68DCB0", VA = "0x1068EEB0", Slot = "6")]
    public void PrevPage()
    {
    }

    [Token(Token = "0x600A72C")]
    [Address(RVA = "0x68EE90", Offset = "0x68DC90", VA = "0x1068EE90")]
    public void OnselectpartyEdit()
    {
    }

    [Token(Token = "0x600A72D")]
    [Address(RVA = "0x68FEB0", Offset = "0x68ECB0", VA = "0x1068FEB0")]
    public void SetEditParty(long[] units)
    {
    }

    [Token(Token = "0x600A72E")]
    [Address(RVA = "0x690190", Offset = "0x68EF90", VA = "0x10690190")]
    public bool SetupSelfParty(JSON_GvGParty json, int seed = -1, int cool_time = -1) => new bool();

    [Token(Token = "0x600A72F")]
    [Address(RVA = "0x68FF90", Offset = "0x68ED90", VA = "0x1068FF90")]
    public bool SetupDefenseParties(JSON_GvGParty[] json, int totalCount, int totalPage, int sec)
    {
      return new bool();
    }

    [Token(Token = "0x600A730")]
    [Address(RVA = "0x690160", Offset = "0x68EF60", VA = "0x10690160")]
    public bool SetupSelfBeatCount(int selfBeat, int selfTotalBeat) => new bool();

    [Token(Token = "0x600A731")]
    [Address(RVA = "0x690140", Offset = "0x68EF40", VA = "0x10690140")]
    public bool SetupEnemyBeatCount(int enemyTotalBeat) => new bool();

    [Token(Token = "0x600A732")]
    [Address(RVA = "0x68FEE0", Offset = "0x68ECE0", VA = "0x1068FEE0")]
    public void SetOverWriteParty(PartyOverWrite party)
    {
    }

    [Token(Token = "0x600A733")]
    [Address(RVA = "0x690C20", Offset = "0x68FA20", VA = "0x10690C20")]
    public GvGBattleTop()
    {
    }
  }
}
