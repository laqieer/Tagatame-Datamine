// Decompiled with JetBrains decompiler
// Type: SRPG.GuildTrainingEnergyCharge
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
  [Token(Token = "0x2002536")]
  [FlowNode.Pin(3, "選択クリア", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(11, "MAX自動計算", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(101, "回復API呼び出し", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "超過回復キャンセル", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(901, "予期せぬエラー検知", FlowNode.PinTypes.Output, 901)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "回復実行確認", FlowNode.PinTypes.Input, 2)]
  public class GuildTrainingEnergyCharge : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400AA55")]
    private const string GOLD_NAME_KEY = "guild_training_gold";
    [Token(Token = "0x400AA56")]
    private const int AFTER_BAR_CALC_NUM = 5;
    [Token(Token = "0x400AA57")]
    private const int ITEM_ENERGY_INCREASE_COEFFICIENT = 1;
    [Token(Token = "0x400AA58")]
    private const long INDEFINITE_PERIOD = -1;
    [Token(Token = "0x400AA59")]
    [FieldOffset(Offset = "0xC")]
    private readonly Color TextColorBlue;
    [Token(Token = "0x400AA5A")]
    [FieldOffset(Offset = "0x1C")]
    private readonly Color TextColorRed;
    [Token(Token = "0x400AA5B")]
    [FieldOffset(Offset = "0x2C")]
    private readonly string CAMPAIGN_LIMIT_TEXT;
    [Token(Token = "0x400AA5C")]
    [FieldOffset(Offset = "0x30")]
    private readonly string CAMPAIGN_CONJUNCTION_TEXT;
    [Token(Token = "0x400AA5D")]
    [FieldOffset(Offset = "0x34")]
    private readonly string CAMPAIGN_TAIL_TEXT;
    [Token(Token = "0x400AA5E")]
    [FieldOffset(Offset = "0x38")]
    private readonly string CAMPAIGN_CREATE_TIME_SHORTENING_TEXT;
    [Token(Token = "0x400AA5F")]
    [FieldOffset(Offset = "0x3C")]
    private readonly string CAMPAIGN_ITEM_ENERGY_INCREASE_TEXT;
    [Token(Token = "0x400AA60")]
    [FieldOffset(Offset = "0x40")]
    private readonly string UNLOCK_EXPANTION_CAMPAIGN_TEXT;
    [Token(Token = "0x400AA61")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400AA62")]
    private const int PIN_INPUT_EXECUTE_CHARGE = 2;
    [Token(Token = "0x400AA63")]
    private const int PIN_INPUT_SELECT_LIST_CLEAR = 3;
    [Token(Token = "0x400AA64")]
    private const int PIN_INPUT_BTN_MAX = 11;
    [Token(Token = "0x400AA65")]
    private const int PIN_OUTPUT_EXECUTE_CHARGE = 101;
    [Token(Token = "0x400AA66")]
    private const int PIN_OUTPUT_CANCEL_CHARGE = 102;
    [Token(Token = "0x400AA67")]
    private const int PIN_OUTPUT_ERROR = 901;
    [Token(Token = "0x400AA68")]
    private const string SVB_NAME_SLIDER = "slider";
    [Token(Token = "0x400AA69")]
    private const string SVB_NAME_BTN_PLUS = "btn_plus";
    [Token(Token = "0x400AA6A")]
    private const string SVB_NAME_BTN_MINUS = "btn_minus";
    [Token(Token = "0x400AA6B")]
    private const string SVB_NAME_TXT_HAVE_ITEM = "have_item_text";
    [Token(Token = "0x400AA6C")]
    private const string SVB_NAME_TXT_ENERGY_TITLE = "energy_title_text";
    [Token(Token = "0x400AA6D")]
    private const string SVB_NAME_TXT_ENERGY_VAL = "energy_value_text";
    [Token(Token = "0x400AA6E")]
    private const string SVB_NAME_TXT_USE_NUM = "use_num_text";
    [Token(Token = "0x400AA6F")]
    private const string SVB_NAME_TOGGLE_MAX_CHECK = "use_max_check";
    [Token(Token = "0x400AA70")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Transform mParent;
    [Token(Token = "0x400AA71")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private SerializeValueBehaviour mContentGold;
    [Token(Token = "0x400AA72")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private SerializeValueBehaviour mContent;
    [Token(Token = "0x400AA73")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private SRPG_Button mDecideBtn;
    [Token(Token = "0x400AA74")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private GameObject mTextTitle;
    [Token(Token = "0x400AA75")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject mTextCaution;
    [Token(Token = "0x400AA76")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private RectTransform mTsBeforeBar;
    [Token(Token = "0x400AA77")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Slider mBeforeBar;
    [Token(Token = "0x400AA78")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private RectTransform mTsAfterBar;
    [Token(Token = "0x400AA79")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Slider mAfterBar;
    [Token(Token = "0x400AA7A")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private SRPG_Button mMaxBtn;
    [Token(Token = "0x400AA7B")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text mEnergyNowTxt;
    [Token(Token = "0x400AA7C")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private Text mEnergyMaxTxt;
    [Token(Token = "0x400AA7D")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject mLockCampaignTextGroup;
    [Token(Token = "0x400AA7E")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    private Text mLockCampaignText;
    [Token(Token = "0x400AA7F")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject mCampaignTextGroup;
    [Token(Token = "0x400AA80")]
    [FieldOffset(Offset = "0x84")]
    [SerializeField]
    private Text mCampaignText;
    [Token(Token = "0x400AA81")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text mCampaignPeriodText;
    [Token(Token = "0x400AA82")]
    [FieldOffset(Offset = "0x8C")]
    [SerializeField]
    private Color mNormalTextColor;
    [Token(Token = "0x400AA83")]
    [FieldOffset(Offset = "0x9C")]
    [SerializeField]
    private Color mCampaignTextColor;
    [Token(Token = "0x400AA84")]
    [FieldOffset(Offset = "0x0")]
    private static GuildTrainingEnergyCharge mInstance;
    [Token(Token = "0x400AA85")]
    [FieldOffset(Offset = "0xAC")]
    private List<GuildTrainingEnergyCharge.EnergyChargeData> mEnergyChagerData;
    [Token(Token = "0x400AA86")]
    [FieldOffset(Offset = "0xB0")]
    private int mEnergyNow;
    [Token(Token = "0x400AA87")]
    [FieldOffset(Offset = "0xB4")]
    private int mEnergyMax;
    [Token(Token = "0x400AA88")]
    [FieldOffset(Offset = "0xB8")]
    private bool mIsItemEnergyIncreaseFlag;
    [Token(Token = "0x400AA89")]
    [FieldOffset(Offset = "0xBC")]
    private int mItemEnergyIncreaseValue;
    [Token(Token = "0x400AA8A")]
    [FieldOffset(Offset = "0xC0")]
    private bool mIsCampaign;

    [Token(Token = "0x170016D3")]
    public static GuildTrainingEnergyCharge Instance
    {
      [Token(Token = "0x600A3DA"), Address(RVA = "0x660EA0", Offset = "0x65FCA0", VA = "0x10660EA0")] get
      {
        return (GuildTrainingEnergyCharge) null;
      }
    }

    [Token(Token = "0x600A3DB")]
    [Address(RVA = "0x65E170", Offset = "0x65CF70", VA = "0x1065E170")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A3DC")]
    [Address(RVA = "0x65F820", Offset = "0x65E620", VA = "0x1065F820")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600A3DD")]
    [Address(RVA = "0x65DF90", Offset = "0x65CD90", VA = "0x1065DF90", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A3DE")]
    [Address(RVA = "0x65EF30", Offset = "0x65DD30", VA = "0x1065EF30")]
    private void Initialized()
    {
    }

    [Token(Token = "0x600A3DF")]
    [Address(RVA = "0x65EA60", Offset = "0x65D860", VA = "0x1065EA60")]
    private int GetSelectEnergyTotal(string exclusion_item_id = null) => new int();

    [Token(Token = "0x600A3E0")]
    [Address(RVA = "0x660790", Offset = "0x65F590", VA = "0x10660790")]
    private void UpdateViewAndBtn(bool is_init = false)
    {
    }

    [Token(Token = "0x600A3E1")]
    [Address(RVA = "0x65FF60", Offset = "0x65ED60", VA = "0x1065FF60")]
    private void SelectItemClear()
    {
    }

    [Token(Token = "0x600A3E2")]
    [Address(RVA = "0x65E620", Offset = "0x65D420", VA = "0x1065E620")]
    private void ExecuteEnergyAdd()
    {
    }

    [Token(Token = "0x600A3E3")]
    [Address(RVA = "0x65E200", Offset = "0x65D000", VA = "0x1065E200")]
    private void CalcAutoMaxEnergy()
    {
    }

    [Token(Token = "0x600A3E4")]
    [Address(RVA = "0x65FD00", Offset = "0x65EB00", VA = "0x1065FD00")]
    private void RefreshCampaign()
    {
    }

    [Token(Token = "0x600A3E5")]
    [Address(RVA = "0x660310", Offset = "0x65F110", VA = "0x10660310")]
    private void SetCampaignText()
    {
    }

    [Token(Token = "0x600A3E6")]
    [Address(RVA = "0x6600B0", Offset = "0x65EEB0", VA = "0x106600B0")]
    private void SetCampaignPeriodText()
    {
    }

    [Token(Token = "0x600A3E7")]
    [Address(RVA = "0x65E7C0", Offset = "0x65D5C0", VA = "0x1065E7C0")]
    private string GetCampaignExpantionText() => (string) null;

    [Token(Token = "0x600A3E8")]
    [Address(RVA = "0x660380", Offset = "0x65F180", VA = "0x10660380")]
    private void SetListData(
      GuildTrainingEnergyCharge.EnergyChargeData energyChargeData,
      string[] max_checks)
    {
    }

    [Token(Token = "0x600A3E9")]
    [Address(RVA = "0x65F7A0", Offset = "0x65E5A0", VA = "0x1065F7A0")]
    private void OnAddNum(
      GuildTrainingEnergyCharge.EnergyChargeData energyChargeData)
    {
    }

    [Token(Token = "0x600A3EA")]
    [Address(RVA = "0x65FAE0", Offset = "0x65E8E0", VA = "0x1065FAE0")]
    private void OnRemoveNum(
      GuildTrainingEnergyCharge.EnergyChargeData energyChargeData)
    {
    }

    [Token(Token = "0x600A3EB")]
    [Address(RVA = "0x65FB60", Offset = "0x65E960", VA = "0x1065FB60")]
    public void OnSelectUseNumChanged(
      GuildTrainingEnergyCharge.EnergyChargeData energyChargeData,
      float value)
    {
    }

    [Token(Token = "0x600A3EC")]
    [Address(RVA = "0x65EBC0", Offset = "0x65D9C0", VA = "0x1065EBC0")]
    public int GetSelectGold() => new int();

    [Token(Token = "0x600A3ED")]
    [Address(RVA = "0x65ED20", Offset = "0x65DB20", VA = "0x1065ED20")]
    public Json_GuildTrainingAdd[] GetSelectItems() => (Json_GuildTrainingAdd[]) null;

    [Token(Token = "0x600A3EE")]
    [Address(RVA = "0x305C10", Offset = "0x304A10", VA = "0x10305C10")]
    public int GetMaxEnergy() => new int();

    [Token(Token = "0x600A3EF")]
    [Address(RVA = "0x660D90", Offset = "0x65FB90", VA = "0x10660D90")]
    public GuildTrainingEnergyCharge()
    {
    }

    [Token(Token = "0x2002537")]
    public class EnergyChargeData
    {
      [Token(Token = "0x170016D4")]
      public int EnergyValue
      {
        [Token(Token = "0x600A3F4"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return new int();
        }
        [Token(Token = "0x600A3F5"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
        {
        }
      }

      [Token(Token = "0x170016D5")]
      public string ItemIname
      {
        [Token(Token = "0x600A3F6"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (string) null;
        }
        [Token(Token = "0x600A3F7"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
        {
        }
      }

      [Token(Token = "0x170016D6")]
      public int Amount
      {
        [Token(Token = "0x600A3F8"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return new int();
        }
        [Token(Token = "0x600A3F9"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
        {
        }
      }

      [Token(Token = "0x170016D7")]
      public int AmountNoneCap
      {
        [Token(Token = "0x600A3FA"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
        {
          return new int();
        }
        [Token(Token = "0x600A3FB"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
        {
        }
      }

      [Token(Token = "0x170016D8")]
      public int GoldCost
      {
        [Token(Token = "0x600A3FC"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
        {
          return new int();
        }
        [Token(Token = "0x600A3FD"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] private set
        {
        }
      }

      [Token(Token = "0x170016D9")]
      public bool IsGold
      {
        [Token(Token = "0x600A3FE"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
        {
          return new bool();
        }
        [Token(Token = "0x600A3FF"), Address(RVA = "0x2A5AE0", Offset = "0x2A48E0", VA = "0x102A5AE0")] private set
        {
        }
      }

      [Token(Token = "0x170016DA")]
      public Slider Slider
      {
        [Token(Token = "0x600A400"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
        {
          return (Slider) null;
        }
        [Token(Token = "0x600A401"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] private set
        {
        }
      }

      [Token(Token = "0x170016DB")]
      public Button PlusBtn
      {
        [Token(Token = "0x600A402"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
        {
          return (Button) null;
        }
        [Token(Token = "0x600A403"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] private set
        {
        }
      }

      [Token(Token = "0x170016DC")]
      public Button MinusBtn
      {
        [Token(Token = "0x600A404"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
        {
          return (Button) null;
        }
        [Token(Token = "0x600A405"), Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")] private set
        {
        }
      }

      [Token(Token = "0x170016DD")]
      public Text HaveItemTxt
      {
        [Token(Token = "0x600A406"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
        {
          return (Text) null;
        }
        [Token(Token = "0x600A407"), Address(RVA = "0x27FBD0", Offset = "0x27E9D0", VA = "0x1027FBD0")] private set
        {
        }
      }

      [Token(Token = "0x170016DE")]
      public Text EnergyTitleTxt
      {
        [Token(Token = "0x600A408"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
        {
          return (Text) null;
        }
        [Token(Token = "0x600A409"), Address(RVA = "0x34C010", Offset = "0x34AE10", VA = "0x1034C010")] private set
        {
        }
      }

      [Token(Token = "0x170016DF")]
      public Text EnergyValueTxt
      {
        [Token(Token = "0x600A40A"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
        {
          return (Text) null;
        }
        [Token(Token = "0x600A40B"), Address(RVA = "0x34C030", Offset = "0x34AE30", VA = "0x1034C030")] private set
        {
        }
      }

      [Token(Token = "0x170016E0")]
      public Text UseNumTxt
      {
        [Token(Token = "0x600A40C"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
        {
          return (Text) null;
        }
        [Token(Token = "0x600A40D"), Address(RVA = "0x36F5F0", Offset = "0x36E3F0", VA = "0x1036F5F0")] private set
        {
        }
      }

      [Token(Token = "0x170016E1")]
      public Toggle MaxCheckToggle
      {
        [Token(Token = "0x600A40E"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
        {
          return (Toggle) null;
        }
        [Token(Token = "0x600A40F"), Address(RVA = "0x36F610", Offset = "0x36E410", VA = "0x1036F610")] private set
        {
        }
      }

      [Token(Token = "0x170016E2")]
      public int UseNum
      {
        [Token(Token = "0x600A410"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
        {
          return new int();
        }
        [Token(Token = "0x600A411"), Address(RVA = "0x56B300", Offset = "0x56A100", VA = "0x1056B300")] private set
        {
        }
      }

      [Token(Token = "0x170016E3")]
      public int UseGoldNum
      {
        [Token(Token = "0x600A412"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
        {
          return new int();
        }
        [Token(Token = "0x600A413"), Address(RVA = "0x56B2E0", Offset = "0x56A0E0", VA = "0x1056B2E0")] private set
        {
        }
      }

      [Token(Token = "0x600A414")]
      [Address(RVA = "0x6582D0", Offset = "0x6570D0", VA = "0x106582D0")]
      public EnergyChargeData(
        SerializeValueBehaviour svb,
        int energy_val,
        string item_iname,
        int item_num,
        int item_num_nonecap,
        Color setColor,
        int gold_cost = 0)
      {
      }

      [Token(Token = "0x600A415")]
      [Address(RVA = "0x6581E0", Offset = "0x656FE0", VA = "0x106581E0")]
      public void SetUseItemNum(int use_num, int need_num = 0)
      {
      }

      [Token(Token = "0x600A416")]
      [Address(RVA = "0x6581D0", Offset = "0x656FD0", VA = "0x106581D0")]
      public int GetSelectEnergyNum() => new int();
    }
  }
}
