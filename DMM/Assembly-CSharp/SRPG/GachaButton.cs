// Decompiled with JetBrains decompiler
// Type: SRPG.GachaButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002418")]
  [AddComponentMenu("UI/GachaButton")]
  public class GachaButton : MonoBehaviour
  {
    [Token(Token = "0x400A334")]
    private const int BUTTON_IMAGE_DEFAULT = 0;
    [Token(Token = "0x400A335")]
    private const int BUTTON_IMAGE_COIN_PAID = 1;
    [Token(Token = "0x400A336")]
    private const int BUTTON_IMAGE_ITEM = 2;
    [Token(Token = "0x400A337")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject optionLayout2;
    [Token(Token = "0x400A338")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject optionLayout;
    [Token(Token = "0x400A339")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject paidOption;
    [Token(Token = "0x400A33A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject timerOption;
    [Token(Token = "0x400A33B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject timerObject;
    [Token(Token = "0x400A33C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject limitObject;
    [Token(Token = "0x400A33D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject haveOption;
    [Token(Token = "0x400A33E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject ticketState;
    [Token(Token = "0x400A33F")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject stepupOption;
    [Token(Token = "0x400A340")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject stepupState;
    [Token(Token = "0x400A341")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject gachaBtn;
    [Token(Token = "0x400A342")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject costBG;
    [Token(Token = "0x400A343")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject costIcon;
    [Token(Token = "0x400A344")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text costText;
    [Token(Token = "0x400A345")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private GameObject costFree;
    [Token(Token = "0x400A346")]
    [FieldOffset(Offset = "0x48")]
    private GameObject mCurrentStepup10;
    [Token(Token = "0x400A347")]
    [FieldOffset(Offset = "0x4C")]
    private GameObject mCurrentStepup1;
    [Token(Token = "0x400A348")]
    [FieldOffset(Offset = "0x50")]
    private GameObject mMaxStepup10;
    [Token(Token = "0x400A349")]
    [FieldOffset(Offset = "0x54")]
    private GameObject mMaxStepup1;
    [Token(Token = "0x400A34A")]
    [FieldOffset(Offset = "0x58")]
    public ImageArray Limit10;
    [Token(Token = "0x400A34B")]
    [FieldOffset(Offset = "0x5C")]
    public ImageArray Limit1;
    [Token(Token = "0x400A34C")]
    [FieldOffset(Offset = "0x60")]
    public ImageArray TimerH10;
    [Token(Token = "0x400A34D")]
    [FieldOffset(Offset = "0x64")]
    public ImageArray TimerH1;
    [Token(Token = "0x400A34E")]
    [FieldOffset(Offset = "0x68")]
    public ImageArray TimerM10;
    [Token(Token = "0x400A34F")]
    [FieldOffset(Offset = "0x6C")]
    public ImageArray TimerM1;
    [Token(Token = "0x400A350")]
    [FieldOffset(Offset = "0x70")]
    public ImageArray TimerS10;
    [Token(Token = "0x400A351")]
    [FieldOffset(Offset = "0x74")]
    public ImageArray TimerS1;
    [Token(Token = "0x400A352")]
    [FieldOffset(Offset = "0x78")]
    public Transform PaidCoin;
    [Token(Token = "0x400A353")]
    [FieldOffset(Offset = "0x7C")]
    private List<ImageArray> mPaidCoinNums;
    [Token(Token = "0x400A354")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject costItemObj;
    [Token(Token = "0x400A355")]
    [FieldOffset(Offset = "0x84")]
    [SerializeField]
    private GameObject costItemIcon;
    [Token(Token = "0x400A356")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text costItemValue;
    [Token(Token = "0x400A357")]
    [FieldOffset(Offset = "0x8C")]
    [SerializeField]
    private GameObject costItemFree;
    [Token(Token = "0x400A358")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject AppealOption;
    [Token(Token = "0x400A359")]
    [FieldOffset(Offset = "0x94")]
    private ImageArray AppealBgs;
    [Token(Token = "0x400A35A")]
    [FieldOffset(Offset = "0x98")]
    private Text AppealMessageText;
    [Token(Token = "0x400A35B")]
    [FieldOffset(Offset = "0x9C")]
    private bool mStarted;
    [Token(Token = "0x400A35C")]
    [FieldOffset(Offset = "0xA0")]
    private GameManager gm;
    [Token(Token = "0x400A35D")]
    [FieldOffset(Offset = "0xA4")]
    private StateMachine<GachaButton> mState;
    [Token(Token = "0x400A35E")]
    [FieldOffset(Offset = "0xA8")]
    private bool mUpdateTrigger;
    [Token(Token = "0x400A35F")]
    [FieldOffset(Offset = "0xAC")]
    private GachaButton.GachaCategoryType mCategoryType;
    [Token(Token = "0x400A360")]
    [FieldOffset(Offset = "0xB0")]
    private GachaCostType mCostType;
    [Token(Token = "0x400A361")]
    [FieldOffset(Offset = "0xB4")]
    private int mCost;
    [Token(Token = "0x400A362")]
    [FieldOffset(Offset = "0xB8")]
    private int mStepIndex;
    [Token(Token = "0x400A363")]
    [FieldOffset(Offset = "0xBC")]
    private int mStepMax;
    [Token(Token = "0x400A364")]
    [FieldOffset(Offset = "0xC0")]
    private int mTicketNum;
    [Token(Token = "0x400A365")]
    [FieldOffset(Offset = "0xC4")]
    private string mButtonText;
    [Token(Token = "0x400A366")]
    [FieldOffset(Offset = "0xC8")]
    private string mCategory;
    [Token(Token = "0x400A367")]
    [FieldOffset(Offset = "0xCC")]
    private Coroutine mUpdateCoroutine;
    [Token(Token = "0x400A368")]
    [FieldOffset(Offset = "0xD0")]
    private float mNextUpdateTime;
    [Token(Token = "0x400A369")]
    [FieldOffset(Offset = "0xD4")]
    private GachaButtonParam m_GachaButtonParam;
    [Token(Token = "0x400A36A")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private GameObject DiscountObject;
    [Token(Token = "0x400A36B")]
    [FieldOffset(Offset = "0xDC")]
    [SerializeField]
    private Text DiscountValueStrObject;
    [Token(Token = "0x400A36C")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private Text ButtonTextObject;

    [Token(Token = "0x170015E0")]
    public GameObject OptionLayout2
    {
      [Token(Token = "0x6009D25"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170015E1")]
    public GameObject OptionLayout
    {
      [Token(Token = "0x6009D26"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170015E2")]
    public GameObject PaidOption
    {
      [Token(Token = "0x6009D27"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170015E3")]
    public GameObject TimerOption
    {
      [Token(Token = "0x6009D28"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170015E4")]
    public GameObject TimerObject
    {
      [Token(Token = "0x6009D29"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170015E5")]
    public GameObject LimitObject
    {
      [Token(Token = "0x6009D2A"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170015E6")]
    public GameObject HaveOption
    {
      [Token(Token = "0x6009D2B"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170015E7")]
    public GameObject TicketState
    {
      [Token(Token = "0x6009D2C"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170015E8")]
    public GameObject StepupOption
    {
      [Token(Token = "0x6009D2D"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170015E9")]
    public GameObject StepupState
    {
      [Token(Token = "0x6009D2E"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170015EA")]
    public GameObject GachaBtn
    {
      [Token(Token = "0x6009D2F"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170015EB")]
    public GameObject CostBG
    {
      [Token(Token = "0x6009D30"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x170015EC")]
    public bool UpdateTrigger
    {
      [Token(Token = "0x6009D31"), Address(RVA = "0x5FC050", Offset = "0x5FAE50", VA = "0x105FC050")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009D32"), Address(RVA = "0x5FC150", Offset = "0x5FAF50", VA = "0x105FC150")] set
      {
      }
    }

    [Token(Token = "0x170015ED")]
    public bool IsUpdateTrigger
    {
      [Token(Token = "0x6009D33"), Address(RVA = "0x5FC050", Offset = "0x5FAE50", VA = "0x105FC050")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170015EE")]
    public GachaCostType CostType
    {
      [Token(Token = "0x6009D34"), Address(RVA = "0x5FC000", Offset = "0x5FAE00", VA = "0x105FC000")] get
      {
        return new GachaCostType();
      }
      [Token(Token = "0x6009D35"), Address(RVA = "0x5FC0B0", Offset = "0x5FAEB0", VA = "0x105FC0B0")] set
      {
      }
    }

    [Token(Token = "0x170015EF")]
    public bool IsSetCostType
    {
      [Token(Token = "0x6009D36"), Address(RVA = "0x5FC030", Offset = "0x5FAE30", VA = "0x105FC030")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170015F0")]
    public GachaButton.GachaCategoryType CategoryType
    {
      [Token(Token = "0x6009D37"), Address(RVA = "0x349120", Offset = "0x347F20", VA = "0x10349120")] get
      {
        return new GachaButton.GachaCategoryType();
      }
      [Token(Token = "0x6009D38"), Address(RVA = "0x5FC090", Offset = "0x5FAE90", VA = "0x105FC090")] set
      {
      }
    }

    [Token(Token = "0x170015F1")]
    public bool IsSetCategoryType
    {
      [Token(Token = "0x6009D39"), Address(RVA = "0x5FC010", Offset = "0x5FAE10", VA = "0x105FC010")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170015F2")]
    public int Cost
    {
      [Token(Token = "0x6009D3A"), Address(RVA = "0x305C10", Offset = "0x304A10", VA = "0x10305C10")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D3B"), Address(RVA = "0x5FC0D0", Offset = "0x5FAED0", VA = "0x105FC0D0")] set
      {
      }
    }

    [Token(Token = "0x170015F3")]
    public int StepIndex
    {
      [Token(Token = "0x6009D3C"), Address(RVA = "0x3E1690", Offset = "0x3E0490", VA = "0x103E1690")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D3D"), Address(RVA = "0x5FC0F0", Offset = "0x5FAEF0", VA = "0x105FC0F0")] set
      {
      }
    }

    [Token(Token = "0x170015F4")]
    public int StepMax
    {
      [Token(Token = "0x6009D3E"), Address(RVA = "0x36AA10", Offset = "0x369810", VA = "0x1036AA10")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D3F"), Address(RVA = "0x5FC110", Offset = "0x5FAF10", VA = "0x105FC110")] set
      {
      }
    }

    [Token(Token = "0x170015F5")]
    public int TicketNum
    {
      [Token(Token = "0x6009D40"), Address(RVA = "0x5FC060", Offset = "0x5FAE60", VA = "0x105FC060")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D41"), Address(RVA = "0x5FC130", Offset = "0x5FAF30", VA = "0x105FC130")] set
      {
      }
    }

    [Token(Token = "0x170015F6")]
    public string ButtonText
    {
      [Token(Token = "0x6009D42"), Address(RVA = "0x5FBFF0", Offset = "0x5FADF0", VA = "0x105FBFF0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009D43"), Address(RVA = "0x5FC070", Offset = "0x5FAE70", VA = "0x105FC070")] set
      {
      }
    }

    [Token(Token = "0x170015F7")]
    public string Category
    {
      [Token(Token = "0x6009D44"), Address(RVA = "0x36A9E0", Offset = "0x3697E0", VA = "0x1036A9E0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009D45"), Address(RVA = "0x45A300", Offset = "0x459100", VA = "0x1045A300")] set
      {
      }
    }

    [Token(Token = "0x6009D46")]
    [Address(RVA = "0x5F9FB0", Offset = "0x5F8DB0", VA = "0x105F9FB0")]
    private void Start()
    {
    }

    [Token(Token = "0x6009D47")]
    [Address(RVA = "0x5FBF40", Offset = "0x5FAD40", VA = "0x105FBF40")]
    private void Update()
    {
    }

    [Token(Token = "0x6009D48")]
    [Address(RVA = "0x5F9790", Offset = "0x5F8590", VA = "0x105F9790")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6009D49")]
    [Address(RVA = "0x5F9660", Offset = "0x5F8460", VA = "0x105F9660")]
    private bool IsObjectActivated(GameObject gobj) => new bool();

    [Token(Token = "0x6009D4A")]
    [Address(RVA = "0x5F9560", Offset = "0x5F8360", VA = "0x105F9560")]
    private bool IsFreeCoin() => new bool();

    [Token(Token = "0x6009D4B")]
    [Address(RVA = "0x5F95D0", Offset = "0x5F83D0", VA = "0x105F95D0")]
    private bool IsFreeGold() => new bool();

    [Token(Token = "0x6009D4C")]
    [Address(RVA = "0x5F9DA0", Offset = "0x5F8BA0", VA = "0x105F9DA0")]
    public bool SetGachaButtonEvent(UnityAction action) => new bool();

    [Token(Token = "0x6009D4D")]
    [Address(RVA = "0x5F9E60", Offset = "0x5F8C60", VA = "0x105F9E60")]
    public bool SetGachaButtonUIParameter(
      GachaCostType cost_type = GachaCostType.NONE,
      GachaButton.GachaCategoryType category_type = GachaButton.GachaCategoryType.NONE)
    {
      return new bool();
    }

    [Token(Token = "0x6009D4E")]
    [Address(RVA = "0x5F9F80", Offset = "0x5F8D80", VA = "0x105F9F80")]
    public bool SetupGachaButtonParam(GachaButtonParam _param) => new bool();

    [Token(Token = "0x6009D4F")]
    [Address(RVA = "0x5FBA40", Offset = "0x5FA840", VA = "0x105FBA40")]
    public bool UpdateUI() => new bool();

    [Token(Token = "0x6009D50")]
    [Address(RVA = "0x5FA6A0", Offset = "0x5F94A0", VA = "0x105FA6A0")]
    private bool UpdateCostBG(GachaCostType _cost_type = GachaCostType.NONE) => new bool();

    [Token(Token = "0x6009D51")]
    [Address(RVA = "0x5FA450", Offset = "0x5F9250", VA = "0x105FA450")]
    private bool UpdateButtonImage(GachaCostType cost = GachaCostType.NONE) => new bool();

    [Token(Token = "0x6009D52")]
    [Address(RVA = "0x5FA550", Offset = "0x5F9350", VA = "0x105FA550")]
    private bool UpdateButtonText(string _button_text = "", bool _show = true) => new bool();

    [Token(Token = "0x6009D53")]
    [Address(RVA = "0x5FA9B0", Offset = "0x5F97B0", VA = "0x105FA9B0")]
    private bool UpdateCostNumber(
      int _cost,
      int _exec_num,
      GachaCostType _cost_type,
      GachaCategory _gacha_category,
      bool _is_nouse_free,
      bool _is_discount)
    {
      return new bool();
    }

    [Token(Token = "0x6009D54")]
    [Address(RVA = "0x5FABA0", Offset = "0x5F99A0", VA = "0x105FABA0")]
    private bool UpdateCostNumber() => new bool();

    [Token(Token = "0x6009D55")]
    [Address(RVA = "0x5F97E0", Offset = "0x5F85E0", VA = "0x105F97E0")]
    private bool RefreshCostNum(GachaCostType costType, int cost = 0) => new bool();

    [Token(Token = "0x6009D56")]
    [Address(RVA = "0x5FAED0", Offset = "0x5F9CD0", VA = "0x105FAED0")]
    private bool UpdateOptionObject() => new bool();

    [Token(Token = "0x6009D57")]
    [Address(RVA = "0x5FB340", Offset = "0x5FA140", VA = "0x105FB340")]
    private bool UpdateStepup(int _index, int _max) => new bool();

    [Token(Token = "0x6009D58")]
    [Address(RVA = "0x5FB8B0", Offset = "0x5FA6B0", VA = "0x105FB8B0")]
    private bool UpdateTimer(long sec = 0) => new bool();

    [Token(Token = "0x6009D59")]
    [Address(RVA = "0x5FAE00", Offset = "0x5F9C00", VA = "0x105FAE00")]
    private bool UpdateLimit(int num) => new bool();

    [Token(Token = "0x6009D5A")]
    [Address(RVA = "0x5FB290", Offset = "0x5FA090", VA = "0x105FB290")]
    private IEnumerator UpdateOption() => (IEnumerator) null;

    [Token(Token = "0x6009D5B")]
    [Address(RVA = "0x5F9EA0", Offset = "0x5F8CA0", VA = "0x105F9EA0")]
    private void SetUpdateOption(float interval)
    {
    }

    [Token(Token = "0x6009D5C")]
    [Address(RVA = "0x5F9A60", Offset = "0x5F8860", VA = "0x105F9A60")]
    private bool RefreshTimerOption() => new bool();

    [Token(Token = "0x6009D5D")]
    [Address(RVA = "0x5FB300", Offset = "0x5FA100", VA = "0x105FB300")]
    private bool UpdatePaidCost() => new bool();

    [Token(Token = "0x6009D5E")]
    [Address(RVA = "0x5F9870", Offset = "0x5F8670", VA = "0x105F9870")]
    private bool RefreshPaidCost(int cost = 0) => new bool();

    [Token(Token = "0x6009D5F")]
    [Address(RVA = "0x5FA270", Offset = "0x5F9070", VA = "0x105FA270")]
    private bool UpdateAppeal(string message, int _appeal_type = 0) => new bool();

    [Token(Token = "0x6009D60")]
    [Address(RVA = "0x5F96D0", Offset = "0x5F84D0", VA = "0x105F96D0")]
    public void OnClick()
    {
    }

    [Token(Token = "0x6009D61")]
    [Address(RVA = "0x5FBF80", Offset = "0x5FAD80", VA = "0x105FBF80")]
    public GachaButton()
    {
    }

    [Token(Token = "0x2002419")]
    public enum GGachaCostType
    {
      [Token(Token = "0x400A36E")] NONE,
      [Token(Token = "0x400A36F")] COIN,
      [Token(Token = "0x400A370")] COIN_P,
      [Token(Token = "0x400A371")] GOLD,
      [Token(Token = "0x400A372")] TICKET,
      [Token(Token = "0x400A373")] FREE_COIN,
      [Token(Token = "0x400A374")] FREE_GOLD,
      [Token(Token = "0x400A375")] ITEM,
      [Token(Token = "0x400A376")] ALL,
    }

    [Token(Token = "0x200241A")]
    public enum GachaNumType
    {
      [Token(Token = "0x400A378")] NONE,
      [Token(Token = "0x400A379")] SINGLE,
      [Token(Token = "0x400A37A")] MULTI,
      [Token(Token = "0x400A37B")] ALL,
    }

    [Token(Token = "0x200241B")]
    public enum GachaCategoryType
    {
      [Token(Token = "0x400A37D")] NONE,
      [Token(Token = "0x400A37E")] RARE,
      [Token(Token = "0x400A37F")] NORMAL,
      [Token(Token = "0x400A380")] STEPUP,
      [Token(Token = "0x400A381")] ALL,
    }

    [Token(Token = "0x200241C")]
    private class State_Init : State<GachaButton>
    {
      [Token(Token = "0x6009D62")]
      [Address(RVA = "0x6077A0", Offset = "0x6065A0", VA = "0x106077A0", Slot = "4")]
      public override void Begin(GachaButton self)
      {
      }

      [Token(Token = "0x6009D63")]
      [Address(RVA = "0x607810", Offset = "0x606610", VA = "0x10607810")]
      public State_Init()
      {
      }
    }

    [Token(Token = "0x200241D")]
    private class State_Wait : State<GachaButton>
    {
      [Token(Token = "0x6009D64")]
      [Address(RVA = "0x607910", Offset = "0x606710", VA = "0x10607910", Slot = "4")]
      public override void Begin(GachaButton self)
      {
      }

      [Token(Token = "0x6009D65")]
      [Address(RVA = "0x607950", Offset = "0x606750", VA = "0x10607950", Slot = "5")]
      public override void Update(GachaButton self)
      {
      }

      [Token(Token = "0x6009D66")]
      [Address(RVA = "0x6079C0", Offset = "0x6067C0", VA = "0x106079C0")]
      public State_Wait()
      {
      }
    }

    [Token(Token = "0x200241E")]
    private class State_UpdateUI : State<GachaButton>
    {
      [Token(Token = "0x6009D67")]
      [Address(RVA = "0x607850", Offset = "0x606650", VA = "0x10607850", Slot = "4")]
      public override void Begin(GachaButton self)
      {
      }

      [Token(Token = "0x6009D68")]
      [Address(RVA = "0x6078D0", Offset = "0x6066D0", VA = "0x106078D0")]
      public State_UpdateUI()
      {
      }
    }
  }
}
