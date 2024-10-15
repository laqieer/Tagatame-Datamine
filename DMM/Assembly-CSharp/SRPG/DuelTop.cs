// Decompiled with JetBrains decompiler
// Type: SRPG.DuelTop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002339")]
  [AddComponentMenu("UI/Duel/DuelTop")]
  [FlowNode.Pin(101, "ホームに戻すべきエラー", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(100, "初期化完了", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(60, "メイン画面を非表示", FlowNode.PinTypes.Input, 60)]
  [FlowNode.Pin(50, "メイン画面を表示", FlowNode.PinTypes.Input, 50)]
  [FlowNode.Pin(20, "パーティ更新", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  public class DuelTop : MonoBehaviour, IFlowInterface, IWebHelp
  {
    [Token(Token = "0x4009DA3")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4009DA4")]
    private const int PIN_INPUT_REFRESH_PARTY = 20;
    [Token(Token = "0x4009DA5")]
    private const int PIN_INPUT_MAIN_WINDOW_SHOW = 50;
    [Token(Token = "0x4009DA6")]
    private const int PIN_INPUT_MAIN_WINDOW_HIDE = 60;
    [Token(Token = "0x4009DA7")]
    private const int PIN_OUTPUT_INIT_FINISH = 100;
    [Token(Token = "0x4009DA8")]
    private const int PIN_OUTPUT_ERROR_GO_HOME = 101;
    [Token(Token = "0x4009DA9")]
    private const string DUEL_SVB_KEY_SAME_UNIT = "same_unit";
    [Token(Token = "0x4009DAA")]
    private const string DUEL_SVB_KEY_LEADER = "leader";
    [Token(Token = "0x4009DAB")]
    private const string DUEL_SVB_KEY_BONUS_UNIT = "bonus_unit";
    [Token(Token = "0x4009DAC")]
    private const string DUEL_SVB_KEY_UNIT_EMPTY = "empty";
    [Token(Token = "0x4009DAD")]
    private const string DUEL_SVB_KEY_UNIT_INFO_ROOT = "unit_info_root";
    [Token(Token = "0x4009DAE")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [HeaderBar("▼闘技場TOP")]
    private CanvasGroup MainWindowCanvas;
    [Token(Token = "0x4009DAF")]
    [FieldOffset(Offset = "0x10")]
    [HeaderBar("▼プレイヤー情報")]
    [SerializeField]
    private GameObject PartyInfo;
    [Token(Token = "0x4009DB0")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button ChangeLeaderSkillButton;
    [Token(Token = "0x4009DB1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text PartyTotalCombatPowerText;
    [Token(Token = "0x4009DB2")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject RankObjRootIn;
    [Token(Token = "0x4009DB3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject RankObjRootOut;
    [Token(Token = "0x4009DB4")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text RankText;
    [Token(Token = "0x4009DB5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text PointText;
    [Token(Token = "0x4009DB6")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject ChainWinRoot;
    [Token(Token = "0x4009DB7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text ChainWinText;
    [Token(Token = "0x4009DB8")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text ChainWinBonusText;
    [Token(Token = "0x4009DB9")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text LastBattleAtText;
    [Token(Token = "0x4009DBA")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject TotalWinRoot;
    [Token(Token = "0x4009DBB")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text TotalWinText;
    [Token(Token = "0x4009DBC")]
    [FieldOffset(Offset = "0x44")]
    [HeaderBar("▼ユニット表示")]
    [SerializeField]
    private GameObject PartyUnitImageTemplate;
    [Token(Token = "0x4009DBD")]
    [FieldOffset(Offset = "0x48")]
    [HeaderBar("▼BP表示")]
    [SerializeField]
    private GameObject CooldownTimer;
    [Token(Token = "0x4009DBE")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Text CoolTimeCount;
    [Token(Token = "0x4009DBF")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject BpHolder;
    [Token(Token = "0x4009DC0")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private CanvasRenderer BpHolderCanvas;
    [Token(Token = "0x4009DC1")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    [HeaderBar("▼ショップ")]
    private GameObject GoShopButton;
    [Token(Token = "0x4009DC2")]
    [FieldOffset(Offset = "0x5C")]
    private List<GameObject> mCreatedPartyUnitImages;
    [Token(Token = "0x4009DC3")]
    [FieldOffset(Offset = "0x60")]
    private List<UnitData> mCurrentPartyUnits;
    [Token(Token = "0x4009DC4")]
    [FieldOffset(Offset = "0x68")]
    private long mCurrentPartyTotalCombatPower;
    [Token(Token = "0x4009DC5")]
    [FieldOffset(Offset = "0x70")]
    private DuelSelfData mDuelSelf;
    [Token(Token = "0x4009DC6")]
    [FieldOffset(Offset = "0x74")]
    private List<DuelPlayerData> mDuelEnemies;
    [Token(Token = "0x4009DC7")]
    [FieldOffset(Offset = "0x78")]
    private DuelMapData mMapData;
    [Token(Token = "0x4009DC8")]
    [FieldOffset(Offset = "0x7C")]
    private DuelPlayerData mSelectedEnemyPlayer;
    [Token(Token = "0x4009DC9")]
    [FieldOffset(Offset = "0x80")]
    private DuelSeasonParam mDuelSeasonParam;
    [Token(Token = "0x4009DCA")]
    [FieldOffset(Offset = "0x84")]
    private List<string> mToDayDuelEnemies;
    [Token(Token = "0x4009DCB")]
    [FieldOffset(Offset = "0x88")]
    private string mDuelShopNamePrefix;
    [Token(Token = "0x4009DCC")]
    [FieldOffset(Offset = "0x0")]
    private static DuelTop mInstance;
    [Token(Token = "0x4009DCD")]
    [FieldOffset(Offset = "0x4")]
    public static int SEED;
    [Token(Token = "0x4009DCE")]
    [FieldOffset(Offset = "0x8")]
    public static int MAX_ACTION_NUM;

    [Token(Token = "0x17001536")]
    public DuelSelfData DuelSelf
    {
      [Token(Token = "0x60097A5"), Address(RVA = "0x288AD0", Offset = "0x2878D0", VA = "0x10288AD0")] get
      {
        return (DuelSelfData) null;
      }
    }

    [Token(Token = "0x17001537")]
    public List<UnitData> CurrentPartyUnits
    {
      [Token(Token = "0x60097A6"), Address(RVA = "0x2B5EA0", Offset = "0x2B4CA0", VA = "0x102B5EA0")] get
      {
        return (List<UnitData>) null;
      }
    }

    [Token(Token = "0x17001538")]
    public DuelPlayerData SelectedEnemyPlayer
    {
      [Token(Token = "0x60097A7"), Address(RVA = "0x2B5EF0", Offset = "0x2B4CF0", VA = "0x102B5EF0")] get
      {
        return (DuelPlayerData) null;
      }
      [Token(Token = "0x60097A8"), Address(RVA = "0x5A4130", Offset = "0x5A2F30", VA = "0x105A4130")] set
      {
      }
    }

    [Token(Token = "0x17001539")]
    public List<DuelPlayerData> DuelEnemies
    {
      [Token(Token = "0x60097A9"), Address(RVA = "0x349360", Offset = "0x348160", VA = "0x10349360")] get
      {
        return (List<DuelPlayerData>) null;
      }
    }

    [Token(Token = "0x1700153A")]
    public DuelMapData MapData
    {
      [Token(Token = "0x60097AA"), Address(RVA = "0x349370", Offset = "0x348170", VA = "0x10349370")] get
      {
        return (DuelMapData) null;
      }
    }

    [Token(Token = "0x1700153B")]
    public long CurrentPartyTotalCombatPower
    {
      [Token(Token = "0x60097AB"), Address(RVA = "0x5A40F0", Offset = "0x5A2EF0", VA = "0x105A40F0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x1700153C")]
    public string DuelShopNamePrefix
    {
      [Token(Token = "0x60097AC"), Address(RVA = "0x2B6030", Offset = "0x2B4E30", VA = "0x102B6030")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700153D")]
    public List<string> ToDayDuelEnemies
    {
      [Token(Token = "0x60097AD"), Address(RVA = "0x2B6020", Offset = "0x2B4E20", VA = "0x102B6020")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x1700153E")]
    public DuelSeasonParam SelectDuelSeasonParam
    {
      [Token(Token = "0x60097AE"), Address(RVA = "0x3197C0", Offset = "0x3185C0", VA = "0x103197C0")] get
      {
        return (DuelSeasonParam) null;
      }
    }

    [Token(Token = "0x1700153F")]
    public static DuelTop Instance
    {
      [Token(Token = "0x60097AF"), Address(RVA = "0x5A4100", Offset = "0x5A2F00", VA = "0x105A4100")] get
      {
        return (DuelTop) null;
      }
    }

    [Token(Token = "0x60097B0")]
    [Address(RVA = "0x5A34D0", Offset = "0x5A22D0", VA = "0x105A34D0")]
    public static void SetDuelParam(int seed, int max_act)
    {
    }

    [Token(Token = "0x60097B1")]
    [Address(RVA = "0x5A17A0", Offset = "0x5A05A0", VA = "0x105A17A0")]
    private void Awake()
    {
    }

    [Token(Token = "0x60097B2")]
    [Address(RVA = "0x5A2020", Offset = "0x5A0E20", VA = "0x105A2020")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60097B3")]
    [Address(RVA = "0x5A21B0", Offset = "0x5A0FB0", VA = "0x105A21B0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60097B4")]
    [Address(RVA = "0x5A2060", Offset = "0x5A0E60", VA = "0x105A2060")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x60097B5")]
    [Address(RVA = "0x5A3FA0", Offset = "0x5A2DA0", VA = "0x105A3FA0")]
    private void Update()
    {
    }

    [Token(Token = "0x60097B6")]
    [Address(RVA = "0x5A16A0", Offset = "0x5A04A0", VA = "0x105A16A0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60097B7")]
    [Address(RVA = "0x5A1AE0", Offset = "0x5A08E0", VA = "0x105A1AE0")]
    private void Init()
    {
    }

    [Token(Token = "0x60097B8")]
    [Address(RVA = "0x5A17E0", Offset = "0x5A05E0", VA = "0x105A17E0")]
    public static void CreatePartyUnitImages(GameObject template, ref List<GameObject> add_list)
    {
    }

    [Token(Token = "0x60097B9")]
    [Address(RVA = "0x5A2900", Offset = "0x5A1700", VA = "0x105A2900")]
    private void RefreshParty()
    {
    }

    [Token(Token = "0x60097BA")]
    [Address(RVA = "0x5A3990", Offset = "0x5A2790", VA = "0x105A3990")]
    public static void SetupPartyUnits(
      List<UnitData> units,
      List<GameObject> bind_targets,
      UnitData leader)
    {
    }

    [Token(Token = "0x60097BB")]
    [Address(RVA = "0x5A2CF0", Offset = "0x5A1AF0", VA = "0x105A2CF0")]
    private void RefreshSelfInfo()
    {
    }

    [Token(Token = "0x60097BC")]
    [Address(RVA = "0x5A2520", Offset = "0x5A1320", VA = "0x105A2520")]
    private void RefreshCoolTime()
    {
    }

    [Token(Token = "0x60097BD")]
    [Address(RVA = "0x5A23C0", Offset = "0x5A11C0", VA = "0x105A23C0")]
    private void RefreshBattleCount()
    {
    }

    [Token(Token = "0x60097BE")]
    [Address(RVA = "0x5A2290", Offset = "0x5A1090", VA = "0x105A2290")]
    private void RefreshBattleCountOnDayChange()
    {
    }

    [Token(Token = "0x60097BF")]
    [Address(RVA = "0x5A1D70", Offset = "0x5A0B70", VA = "0x105A1D70")]
    public bool IsCanBattle() => new bool();

    [Token(Token = "0x60097C0")]
    [Address(RVA = "0x5A3710", Offset = "0x5A2510", VA = "0x105A3710")]
    public void SetSelfData(
      JSON_DuelRankData json_rank,
      int bp,
      Json_DuelBattleRecode recode,
      long btl_at)
    {
    }

    [Token(Token = "0x60097C1")]
    [Address(RVA = "0x5A3600", Offset = "0x5A2400", VA = "0x105A3600")]
    public void SetMap(JSON_DuelMapData map)
    {
    }

    [Token(Token = "0x60097C2")]
    [Address(RVA = "0x5A3510", Offset = "0x5A2310", VA = "0x105A3510")]
    public void SetEnemies(JSON_DuelPlayerData[] enemies)
    {
    }

    [Token(Token = "0x60097C3")]
    [Address(RVA = "0x4602E0", Offset = "0x45F0E0", VA = "0x104602E0")]
    public void SetShopNamePrefix(string shop_name_prefix)
    {
    }

    [Token(Token = "0x60097C4")]
    [Address(RVA = "0x5A38D0", Offset = "0x5A26D0", VA = "0x105A38D0")]
    public void SetToDayDuelEnemie(string[] enemy_codes)
    {
    }

    [Token(Token = "0x60097C5")]
    [Address(RVA = "0x5A19A0", Offset = "0x5A07A0", VA = "0x105A19A0", Slot = "5")]
    public bool GetHelpURL(out string url, out string title) => new bool();

    [Token(Token = "0x60097C6")]
    [Address(RVA = "0x5A3480", Offset = "0x5A2280", VA = "0x105A3480")]
    public void SetActive_GoShopButton(bool is_active)
    {
    }

    [Token(Token = "0x60097C7")]
    [Address(RVA = "0x5A3FB0", Offset = "0x5A2DB0", VA = "0x105A3FB0")]
    public DuelTop()
    {
    }
  }
}
