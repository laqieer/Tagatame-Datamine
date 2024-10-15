// Decompiled with JetBrains decompiler
// Type: SRPG.CoinBuyUseBonusWindow
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
  [Token(Token = "0x200219F")]
  [FlowNode.Pin(1000, "報酬受取", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(100, "初期化", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(110, "消費ボーナス表示", FlowNode.PinTypes.Input, 110)]
  [FlowNode.Pin(120, "購入ボーナス表示", FlowNode.PinTypes.Input, 120)]
  [FlowNode.Pin(101, "表示更新", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(130, "HOMEバッジ更新", FlowNode.PinTypes.Input, 130)]
  [FlowNode.Pin(1000, "報酬受取", FlowNode.PinTypes.Output, 1000)]
  [AddComponentMenu("UI/CoinBuyUseBonusWindow")]
  [FlowNode.Pin(1010, "真理念装詳細表示", FlowNode.PinTypes.Output, 1010)]
  public class CoinBuyUseBonusWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40092EA")]
    private const int PIN_INPUT_INIT = 100;
    [Token(Token = "0x40092EB")]
    private const int PIN_INPUT_REFRESH = 101;
    [Token(Token = "0x40092EC")]
    private const int PIN_INPUT_CHANGE_USE_BONUS = 110;
    [Token(Token = "0x40092ED")]
    private const int PIN_INPUT_CHANGE_BUY_BONUS = 120;
    [Token(Token = "0x40092EE")]
    private const int PIN_INPUT_REFRESH_BADGE = 130;
    [Token(Token = "0x40092EF")]
    private const int PIN_OUTPUT_RECEIVE_REWARD = 1000;
    [Token(Token = "0x40092F0")]
    private const int PIN_OUTPUT_OPEN_CONCEPTCARD_DETAIL = 1010;
    [Token(Token = "0x40092F1")]
    [FieldOffset(Offset = "0x0")]
    private static int PlayerCoin;
    [Token(Token = "0x40092F2")]
    [FieldOffset(Offset = "0xC")]
    private Dictionary<eCoinBuyUseBonusTrigger, Dictionary<eCoinBuyUseBonusType, CoinBuyUseBonusParam>> mBonusListAll;
    [Token(Token = "0x40092F3")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<eCoinBuyUseBonusTrigger, Dictionary<eCoinBuyUseBonusType, bool>> mBonusBadgeStates;
    [Token(Token = "0x40092F4")]
    [FieldOffset(Offset = "0x14")]
    private List<GameObject> mCreatedObjects;
    [Token(Token = "0x40092F5")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<eCoinBuyUseBonusType, Toggle> mTypeToggles;
    [Token(Token = "0x40092F6")]
    [FieldOffset(Offset = "0x1C")]
    private eCoinBuyUseBonusTrigger mSelectedTrigger;
    [Token(Token = "0x40092F7")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<eCoinBuyUseBonusTrigger, eCoinBuyUseBonusType> mSelectedType;
    [Token(Token = "0x40092F8")]
    [FieldOffset(Offset = "0x24")]
    private CoinBuyUseBonusParam mTargetBonusParam;
    [Token(Token = "0x40092F9")]
    [FieldOffset(Offset = "0x28")]
    private CoinBuyUseBonusContentParam mTargetContentParam;
    [Token(Token = "0x40092FA")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Text mBonusPeriodText;
    [Token(Token = "0x40092FB")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mBonusPeriodTextRoot;
    [Token(Token = "0x40092FC")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mRewardContentTemplate;
    [Token(Token = "0x40092FD")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject mRewardContentParent;
    [Token(Token = "0x40092FE")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject mSwitchButton_Use;
    [Token(Token = "0x40092FF")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject mSwitchButton_Buy;
    [Token(Token = "0x4009300")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Toggle mDaliyToggle;
    [Token(Token = "0x4009301")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Toggle mPeriodToggle;
    [Token(Token = "0x4009302")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private GameObject mTitleBackground_Use;
    [Token(Token = "0x4009303")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject mTitleBackground_Buy;
    [Token(Token = "0x4009304")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private Text mCurrentUseCoinCount;
    [Token(Token = "0x4009305")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text mCurrentBuyCoinCount;
    [Token(Token = "0x4009306")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private GameObject mUseDayResetExplainObject;
    [Token(Token = "0x4009307")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject mBuyDayResetExplainObject;
    [Token(Token = "0x4009308")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private GameObject mNoBonusText;
    [Token(Token = "0x4009309")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject mSwitchButton_Use_Badge;
    [Token(Token = "0x400930A")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private GameObject mSwitchButton_Buy_Badge;
    [Token(Token = "0x400930B")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject mDaliyToggle_Badge;
    [Token(Token = "0x400930C")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private GameObject mPeriodToggle_Badge;
    [Token(Token = "0x400930D")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject mItemIcon;
    [Token(Token = "0x400930E")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    private GameObject mStaminaIcon;
    [Token(Token = "0x400930F")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject mPlayerExpIcon;
    [Token(Token = "0x4009310")]
    [FieldOffset(Offset = "0x84")]
    [SerializeField]
    private GameObject mArtifactIcon;
    [Token(Token = "0x4009311")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject mCoinIcon;
    [Token(Token = "0x4009312")]
    [FieldOffset(Offset = "0x8C")]
    [SerializeField]
    private GameObject mGoldIcon;
    [Token(Token = "0x4009313")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject mSetItemIcon;
    [Token(Token = "0x4009314")]
    [FieldOffset(Offset = "0x94")]
    [SerializeField]
    private GameObject mUnitIcon;
    [Token(Token = "0x4009315")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject mAwardIcon;
    [Token(Token = "0x4009316")]
    [FieldOffset(Offset = "0x9C")]
    [SerializeField]
    private GameObject mArenaCoinIcon;
    [Token(Token = "0x4009317")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GameObject mMultiCoinIcon;
    [Token(Token = "0x4009318")]
    [FieldOffset(Offset = "0xA4")]
    [SerializeField]
    private GameObject mKakeraCoinIcon;
    [Token(Token = "0x4009319")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject mConceptCardIcon;
    [Token(Token = "0x400931A")]
    [FieldOffset(Offset = "0x4")]
    private static CoinBuyUseBonusWindow mInstance;

    [Token(Token = "0x170013EC")]
    public CoinBuyUseBonusParam TargetBonusParam
    {
      [Token(Token = "0x6008D53"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (CoinBuyUseBonusParam) null;
      }
    }

    [Token(Token = "0x170013ED")]
    public CoinBuyUseBonusContentParam TargetContentParam
    {
      [Token(Token = "0x6008D54"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (CoinBuyUseBonusContentParam) null;
      }
    }

    [Token(Token = "0x170013EE")]
    public GameObject ItemIcon
    {
      [Token(Token = "0x6008D55"), Address(RVA = "0x349370", Offset = "0x348170", VA = "0x10349370")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170013EF")]
    public GameObject StaminaIcon
    {
      [Token(Token = "0x6008D56"), Address(RVA = "0x2B5EF0", Offset = "0x2B4CF0", VA = "0x102B5EF0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170013F0")]
    public GameObject PlayerExpIcon
    {
      [Token(Token = "0x6008D57"), Address(RVA = "0x3197C0", Offset = "0x3185C0", VA = "0x103197C0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170013F1")]
    public GameObject ArtifactIcon
    {
      [Token(Token = "0x6008D58"), Address(RVA = "0x2B6020", Offset = "0x2B4E20", VA = "0x102B6020")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170013F2")]
    public GameObject CoinIcon
    {
      [Token(Token = "0x6008D59"), Address(RVA = "0x2B6030", Offset = "0x2B4E30", VA = "0x102B6030")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170013F3")]
    public GameObject GoldIcon
    {
      [Token(Token = "0x6008D5A"), Address(RVA = "0x2B5F90", Offset = "0x2B4D90", VA = "0x102B5F90")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170013F4")]
    public GameObject SetItemIcon
    {
      [Token(Token = "0x6008D5B"), Address(RVA = "0x3492D0", Offset = "0x3480D0", VA = "0x103492D0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170013F5")]
    public GameObject UnitIcon
    {
      [Token(Token = "0x6008D5C"), Address(RVA = "0x349020", Offset = "0x347E20", VA = "0x10349020")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170013F6")]
    public GameObject AwardIcon
    {
      [Token(Token = "0x6008D5D"), Address(RVA = "0x289A70", Offset = "0x288870", VA = "0x10289A70")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170013F7")]
    public GameObject ArenaCoinIcon
    {
      [Token(Token = "0x6008D5E"), Address(RVA = "0x37DBB0", Offset = "0x37C9B0", VA = "0x1037DBB0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170013F8")]
    public GameObject MultiCoinIcon
    {
      [Token(Token = "0x6008D5F"), Address(RVA = "0x511530", Offset = "0x510330", VA = "0x10511530")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170013F9")]
    public GameObject KakeraCoinIcon
    {
      [Token(Token = "0x6008D60"), Address(RVA = "0x4601D0", Offset = "0x45EFD0", VA = "0x104601D0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170013FA")]
    public GameObject ConceptCardIcon
    {
      [Token(Token = "0x6008D61"), Address(RVA = "0x4601C0", Offset = "0x45EFC0", VA = "0x104601C0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170013FB")]
    private eCoinBuyUseBonusType SelectedType
    {
      [Token(Token = "0x6008D62"), Address(RVA = "0x511540", Offset = "0x510340", VA = "0x10511540")] get
      {
        return new eCoinBuyUseBonusType();
      }
      [Token(Token = "0x6008D63"), Address(RVA = "0x511590", Offset = "0x510390", VA = "0x10511590")] set
      {
      }
    }

    [Token(Token = "0x170013FC")]
    public static CoinBuyUseBonusWindow Instance
    {
      [Token(Token = "0x6008D64"), Address(RVA = "0x5114F0", Offset = "0x5102F0", VA = "0x105114F0")] get
      {
        return (CoinBuyUseBonusWindow) null;
      }
    }

    [Token(Token = "0x6008D65")]
    [Address(RVA = "0x510690", Offset = "0x50F490", VA = "0x10510690")]
    public static bool IsDirtyBonusProgress() => new bool();

    [Token(Token = "0x6008D66")]
    [Address(RVA = "0x511350", Offset = "0x510150", VA = "0x10511350")]
    public static void SyncCoin()
    {
    }

    [Token(Token = "0x6008D67")]
    [Address(RVA = "0x510D80", Offset = "0x50FB80", VA = "0x10510D80")]
    public static void ResetParam()
    {
    }

    [Token(Token = "0x6008D68")]
    [Address(RVA = "0x50F090", Offset = "0x50DE90", VA = "0x1050F090")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008D69")]
    [Address(RVA = "0x50EF40", Offset = "0x50DD40", VA = "0x1050EF40", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008D6A")]
    [Address(RVA = "0x50FFA0", Offset = "0x50EDA0", VA = "0x1050FFA0")]
    private void Init_BonusDictionary()
    {
    }

    [Token(Token = "0x6008D6B")]
    [Address(RVA = "0x510180", Offset = "0x50EF80", VA = "0x10510180")]
    private void Init()
    {
    }

    [Token(Token = "0x6008D6C")]
    [Address(RVA = "0x510C50", Offset = "0x50FA50", VA = "0x10510C50")]
    private void RegisterBonus(eCoinBuyUseBonusTrigger trigger, eCoinBuyUseBonusType type)
    {
    }

    [Token(Token = "0x6008D6D")]
    [Address(RVA = "0x511000", Offset = "0x50FE00", VA = "0x10511000")]
    private void SelectDefaultTrigger()
    {
    }

    [Token(Token = "0x6008D6E")]
    [Address(RVA = "0x510DC0", Offset = "0x50FBC0", VA = "0x10510DC0")]
    private void SelectDefaultToggle(eCoinBuyUseBonusTrigger target_trigger)
    {
    }

    [Token(Token = "0x6008D6F")]
    [Address(RVA = "0x50FA50", Offset = "0x50E850", VA = "0x1050FA50")]
    private void ChangeTrigger(eCoinBuyUseBonusTrigger trigger, eCoinBuyUseBonusType type)
    {
    }

    [Token(Token = "0x6008D70")]
    [Address(RVA = "0x510610", Offset = "0x50F410", VA = "0x10510610")]
    private bool IsActiveBonusTriggerBadge(eCoinBuyUseBonusTrigger trigger) => new bool();

    [Token(Token = "0x6008D71")]
    [Address(RVA = "0x510A60", Offset = "0x50F860", VA = "0x10510A60")]
    private void RefreshBadge()
    {
    }

    [Token(Token = "0x6008D72")]
    [Address(RVA = "0x50F0F0", Offset = "0x50DEF0", VA = "0x1050F0F0")]
    private void ChangeTab(eCoinBuyUseBonusTrigger trigger, eCoinBuyUseBonusType type)
    {
    }

    [Token(Token = "0x6008D73")]
    [Address(RVA = "0x510770", Offset = "0x50F570", VA = "0x10510770")]
    public void OnChangeTypeToggle(Toggle toggle)
    {
    }

    [Token(Token = "0x6008D74")]
    [Address(RVA = "0x510A20", Offset = "0x50F820", VA = "0x10510A20")]
    public void ReceiveReward(
      CoinBuyUseBonusParam bonus_param,
      CoinBuyUseBonusContentParam content_param)
    {
    }

    [Token(Token = "0x6008D75")]
    [Address(RVA = "0x510970", Offset = "0x50F770", VA = "0x10510970")]
    public void OnClick_ConceptCardIcon(GameObject obj)
    {
    }

    [Token(Token = "0x6008D76")]
    [Address(RVA = "0x510BA0", Offset = "0x50F9A0", VA = "0x10510BA0")]
    private void RefreshHomeBadge()
    {
    }

    [Token(Token = "0x6008D77")]
    [Address(RVA = "0x511480", Offset = "0x510280", VA = "0x10511480")]
    public CoinBuyUseBonusWindow()
    {
    }

    [Token(Token = "0x6008D78")]
    [Address(RVA = "0x511420", Offset = "0x510220", VA = "0x10511420")]
    static CoinBuyUseBonusWindow()
    {
    }
  }
}
