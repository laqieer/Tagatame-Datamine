// Decompiled with JetBrains decompiler
// Type: SRPG.BondItemSelectWindow
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
  [Token(Token = "0x20020B6")]
  [FlowNode.Pin(199, "ホームに戻すべきエラー", FlowNode.PinTypes.Output, 199)]
  [FlowNode.Pin(141, "初期化ボタンの処理", FlowNode.PinTypes.Output, 141)]
  [FlowNode.Pin(121, "キャンセルボタンの処理", FlowNode.PinTypes.Output, 121)]
  [FlowNode.Pin(131, "最大ボタンの処理", FlowNode.PinTypes.Output, 131)]
  [FlowNode.Pin(31, "最大ボタンをクリック", FlowNode.PinTypes.Input, 31)]
  [FlowNode.Pin(41, "初期化ボタンをクリック", FlowNode.PinTypes.Input, 41)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(111, "強化開始ボタンの処理", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(21, "キャンセルボタンをクリック", FlowNode.PinTypes.Input, 21)]
  [FlowNode.Pin(11, "決定ボタンをクリック", FlowNode.PinTypes.Input, 11)]
  public class BondItemSelectWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008D03")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4008D04")]
    private const int PIN_INPUT_OK = 11;
    [Token(Token = "0x4008D05")]
    private const int PIN_INPUT_CANCEL = 21;
    [Token(Token = "0x4008D06")]
    private const int PIN_INPUT_MAX = 31;
    [Token(Token = "0x4008D07")]
    private const int PIN_INPUT_CLEAR = 41;
    [Token(Token = "0x4008D08")]
    private const int PIN_OUTPUT_OK = 111;
    [Token(Token = "0x4008D09")]
    private const int PIN_OUTPUT_CANCEL = 121;
    [Token(Token = "0x4008D0A")]
    private const int PIN_OUTPUT_MAX = 131;
    [Token(Token = "0x4008D0B")]
    private const int PIN_OUTPUT_CLEAR = 141;
    [Token(Token = "0x4008D0C")]
    private const int PIN_OUTPUT_ERROR_GO_HOME = 199;
    [Token(Token = "0x4008D0D")]
    [FieldOffset(Offset = "0xC")]
    private readonly string BOND_CAUTION_TEXT;
    [Token(Token = "0x4008D0E")]
    private const string SVB_UNIT_REWARD_ICON = "reward_icon";
    [Token(Token = "0x4008D0F")]
    private const string SVB_UNIT_BTN_REWARD_ICON = "reward_icon_button";
    [Token(Token = "0x4008D10")]
    private const string SVB_UNIT_ITEMS_NEED = "items_need";
    [Token(Token = "0x4008D11")]
    private const string SVB_UNIT_ITEMS_HAVE_MAX = "items_haveMax";
    [Token(Token = "0x4008D12")]
    private const string SVB_UNIT_ITEMS_SELECT = "items_select";
    [Token(Token = "0x4008D13")]
    private const string SVB_UNIT_ITEMS_CHECK = "items_check";
    [Token(Token = "0x4008D14")]
    private const string SVB_ITEM_SLIDER = "slider";
    [Token(Token = "0x4008D15")]
    private const string SVB_ITEM_BTN_PLUS = "btn_plus";
    [Token(Token = "0x4008D16")]
    private const string SVB_ITEM_BTN_MINUS = "btn_minus";
    [Token(Token = "0x4008D17")]
    private const string SVB_ITEM_TXT_HAVE_NUM = "have_item_text";
    [Token(Token = "0x4008D18")]
    private const string SVB_ITEM_TXT_USE_NUM = "use_num_text";
    [Token(Token = "0x4008D19")]
    private const string SVB_ITEM_TOGGLE_IS_MAX = "max_check";
    [Token(Token = "0x4008D1A")]
    private const string SVB_ITEM_TXT_CAUTION = "caution_text";
    [Token(Token = "0x4008D1B")]
    private const string SVB_ITEM_COVER = "cover";
    [Token(Token = "0x4008D1C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text NeedPieceNumText;
    [Token(Token = "0x4008D1D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text UsePieceNumText;
    [Token(Token = "0x4008D1E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject ItemIcon;
    [Token(Token = "0x4008D1F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text HaveItemNumText;
    [Token(Token = "0x4008D20")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text UseItemNumText;
    [Token(Token = "0x4008D21")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject HaveItemCautionText;
    [Token(Token = "0x4008D22")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private SRPG_Button CancelButton;
    [Token(Token = "0x4008D23")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private SRPG_Button OkButton;
    [Token(Token = "0x4008D24")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private SRPG_Button UseClearButton;
    [Token(Token = "0x4008D25")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private SRPG_Button UseMaxButton;
    [Token(Token = "0x4008D26")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ContentScroller UnitScroller;
    [Token(Token = "0x4008D27")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Transform UnitParent;
    [Token(Token = "0x4008D28")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private SerializeValueBehaviour mUnitTemplete;
    [Token(Token = "0x4008D29")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private SRPG_ScrollRect ItemScroller;
    [Token(Token = "0x4008D2A")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Transform ItemParent;
    [Token(Token = "0x4008D2B")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private SerializeValueBehaviour mItemTemplete;
    [Token(Token = "0x4008D2C")]
    [FieldOffset(Offset = "0x50")]
    private PlayerData mPlayer;
    [Token(Token = "0x4008D2D")]
    [FieldOffset(Offset = "0x54")]
    private List<BondItemSelectWindow.BondSelectUnitData> UnitList;
    [Token(Token = "0x4008D2E")]
    [FieldOffset(Offset = "0x58")]
    private List<BondItemSelectWindow.BondPieceItemData> PieceItemList;
    [Token(Token = "0x4008D2F")]
    [FieldOffset(Offset = "0x5C")]
    private List<SerializeValueBehaviour> PieceItemContentList;
    [Token(Token = "0x4008D30")]
    [FieldOffset(Offset = "0x60")]
    private string CurrentUnitPage;
    [Token(Token = "0x4008D31")]
    [FieldOffset(Offset = "0x64")]
    private bool needItem;
    [Token(Token = "0x4008D32")]
    private const float VerticalScrollTop = 1f;
    [Token(Token = "0x4008D33")]
    private const float HorizontalScrollTop = 0.0f;
    [Token(Token = "0x4008D34")]
    [FieldOffset(Offset = "0x68")]
    private Dictionary<string, int> ItemNeedNumList;
    [Token(Token = "0x4008D35")]
    [FieldOffset(Offset = "0x6C")]
    private List<SRPG.BondLvUpMaterials> mBondLvUpMaterials;
    [Token(Token = "0x4008D36")]
    [FieldOffset(Offset = "0x70")]
    private List<string> checkItemList;
    [Token(Token = "0x4008D37")]
    [FieldOffset(Offset = "0x0")]
    private static BondItemSelectWindow mInstance;

    [Token(Token = "0x17001338")]
    public static BondItemSelectWindow Instance
    {
      [Token(Token = "0x6008825"), Address(RVA = "0x49AB20", Offset = "0x499920", VA = "0x1049AB20")] get
      {
        return (BondItemSelectWindow) null;
      }
    }

    [Token(Token = "0x6008826")]
    [Address(RVA = "0x496560", Offset = "0x495360", VA = "0x10496560")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008827")]
    [Address(RVA = "0x498BE0", Offset = "0x4979E0", VA = "0x10498BE0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6008828")]
    [Address(RVA = "0x49A360", Offset = "0x499160", VA = "0x1049A360")]
    private void Start()
    {
    }

    [Token(Token = "0x6008829")]
    [Address(RVA = "0x4964A0", Offset = "0x4952A0", VA = "0x104964A0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600882A")]
    [Address(RVA = "0x496AE0", Offset = "0x4958E0", VA = "0x10496AE0")]
    private void Initialized()
    {
    }

    [Token(Token = "0x600882B")]
    [Address(RVA = "0x49A4C0", Offset = "0x4992C0", VA = "0x1049A4C0")]
    public void UpdateNeedItem(string item_name, int need_num)
    {
    }

    [Token(Token = "0x600882C")]
    [Address(RVA = "0x4985F0", Offset = "0x4973F0", VA = "0x104985F0")]
    public void MakeUnitList()
    {
    }

    [Token(Token = "0x600882D")]
    [Address(RVA = "0x497F00", Offset = "0x496D00", VA = "0x10497F00")]
    public void MakeItemList(string current_unit)
    {
    }

    [Token(Token = "0x600882E")]
    [Address(RVA = "0x4965A0", Offset = "0x4953A0", VA = "0x104965A0")]
    public void ChangePage(string current_unit)
    {
    }

    [Token(Token = "0x600882F")]
    [Address(RVA = "0x49A7B0", Offset = "0x4995B0", VA = "0x1049A7B0")]
    public void UpdateNeedPiece()
    {
    }

    [Token(Token = "0x6008830")]
    [Address(RVA = "0x49A850", Offset = "0x499650", VA = "0x1049A850")]
    public void UpdateUsePiece()
    {
    }

    [Token(Token = "0x6008831")]
    [Address(RVA = "0x49A400", Offset = "0x499200", VA = "0x1049A400")]
    public void UpdateButtonIntaractable()
    {
    }

    [Token(Token = "0x6008832")]
    [Address(RVA = "0x49A460", Offset = "0x499260", VA = "0x1049A460")]
    public void UpdateMaxButtonIntaractable()
    {
    }

    [Token(Token = "0x6008833")]
    [Address(RVA = "0x496960", Offset = "0x495760", VA = "0x10496960")]
    public JSON_BondLvUpMaterials[] GetMaterialList() => (JSON_BondLvUpMaterials[]) null;

    [Token(Token = "0x6008834")]
    [Address(RVA = "0x288AC0", Offset = "0x2878C0", VA = "0x10288AC0")]
    public List<SRPG.BondLvUpMaterials> BondLvUpMaterials() => (List<SRPG.BondLvUpMaterials>) null;

    [Token(Token = "0x6008835")]
    [Address(RVA = "0x497AA0", Offset = "0x4968A0", VA = "0x10497AA0")]
    public int IsTotalPieceNum(string iname, string ename = "") => new int();

    [Token(Token = "0x6008836")]
    [Address(RVA = "0x497510", Offset = "0x496310", VA = "0x10497510")]
    public bool IsLvUpMaterials(string iname) => new bool();

    [Token(Token = "0x6008837")]
    [Address(RVA = "0x497740", Offset = "0x496540", VA = "0x10497740")]
    public bool IsLvUp() => new bool();

    [Token(Token = "0x6008838")]
    [Address(RVA = "0x4970B0", Offset = "0x495EB0", VA = "0x104970B0")]
    private bool IsCheckBox() => new bool();

    [Token(Token = "0x6008839")]
    [Address(RVA = "0x497220", Offset = "0x496020", VA = "0x10497220")]
    private bool IsExpireForMaterialsItem() => new bool();

    [Token(Token = "0x600883A")]
    [Address(RVA = "0x4990A0", Offset = "0x497EA0", VA = "0x104990A0")]
    private void PieceClear()
    {
    }

    [Token(Token = "0x600883B")]
    [Address(RVA = "0x499200", Offset = "0x498000", VA = "0x10499200")]
    private void PieceMax()
    {
    }

    [Token(Token = "0x600883C")]
    [Address(RVA = "0x499AD0", Offset = "0x4988D0", VA = "0x10499AD0")]
    private void SetError()
    {
    }

    [Token(Token = "0x600883D")]
    [Address(RVA = "0x49A290", Offset = "0x499090", VA = "0x1049A290")]
    private void SetUnitListData(
      BondItemSelectWindow.BondSelectUnitData bondSelectUnitData)
    {
    }

    [Token(Token = "0x600883E")]
    [Address(RVA = "0x499040", Offset = "0x497E40", VA = "0x10499040")]
    private void OnUnitButton(
      BondItemSelectWindow.BondSelectUnitData bondSelectUnitData)
    {
    }

    [Token(Token = "0x600883F")]
    [Address(RVA = "0x497A00", Offset = "0x496800", VA = "0x10497A00")]
    private int IsPieceCount(string pname = "") => new int();

    [Token(Token = "0x6008840")]
    [Address(RVA = "0x499900", Offset = "0x498700", VA = "0x10499900")]
    private void RefreshSliderButton(BondItemSelectWindow.BondPieceItemData exclude = null)
    {
    }

    [Token(Token = "0x6008841")]
    [Address(RVA = "0x499AF0", Offset = "0x4988F0", VA = "0x10499AF0")]
    private void SetItemListData(
      BondItemSelectWindow.BondPieceItemData bondPieceItemData,
      string[] max_checks)
    {
    }

    [Token(Token = "0x6008842")]
    [Address(RVA = "0x498D80", Offset = "0x497B80", VA = "0x10498D80")]
    private void OnSelectUseNumChanged(
      BondItemSelectWindow.BondPieceItemData bondPieceItemData,
      float value)
    {
    }

    [Token(Token = "0x6008843")]
    [Address(RVA = "0x4989F0", Offset = "0x4977F0", VA = "0x104989F0")]
    private void OnAddNum(
      BondItemSelectWindow.BondPieceItemData bondPieceItemData)
    {
    }

    [Token(Token = "0x6008844")]
    [Address(RVA = "0x498CB0", Offset = "0x497AB0", VA = "0x10498CB0")]
    private void OnRemoveNum(
      BondItemSelectWindow.BondPieceItemData bondPieceItemData)
    {
    }

    [Token(Token = "0x6008845")]
    [Address(RVA = "0x498AC0", Offset = "0x4978C0", VA = "0x10498AC0")]
    private bool OnCheckToggle(
      bool isCheck,
      BondItemSelectWindow.BondPieceItemData bondPieceItemData)
    {
      return new bool();
    }

    [Token(Token = "0x6008846")]
    [Address(RVA = "0x497CE0", Offset = "0x496AE0", VA = "0x10497CE0")]
    private void LimitSliderCheck(
      BondItemSelectWindow.BondPieceItemData bondPieceItemData)
    {
    }

    [Token(Token = "0x6008847")]
    [Address(RVA = "0x499A30", Offset = "0x498830", VA = "0x10499A30")]
    private void SavePrefab()
    {
    }

    [Token(Token = "0x6008848")]
    [Address(RVA = "0x497DE0", Offset = "0x496BE0", VA = "0x10497DE0")]
    private void LoadPrefab()
    {
    }

    [Token(Token = "0x6008849")]
    [Address(RVA = "0x49A940", Offset = "0x499740", VA = "0x1049A940")]
    public BondItemSelectWindow()
    {
    }

    [Token(Token = "0x20020B7")]
    private class BondSelectUnitData
    {
      [Token(Token = "0x17001339")]
      public ItemParam mItem
      {
        [Token(Token = "0x600884C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (ItemParam) null;
        }
        [Token(Token = "0x600884D"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
        {
        }
      }

      [Token(Token = "0x1700133A")]
      public Button mButton
      {
        [Token(Token = "0x600884E"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (Button) null;
        }
        [Token(Token = "0x600884F"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
        {
        }
      }

      [Token(Token = "0x1700133B")]
      public Text mItemsNeedTxt
      {
        [Token(Token = "0x6008850"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (Text) null;
        }
        [Token(Token = "0x6008851"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
        {
        }
      }

      [Token(Token = "0x1700133C")]
      public Text mItemsHaveMaxTxt
      {
        [Token(Token = "0x6008852"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
        {
          return (Text) null;
        }
        [Token(Token = "0x6008853"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] private set
        {
        }
      }

      [Token(Token = "0x1700133D")]
      public int BtnNum
      {
        [Token(Token = "0x6008854"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
        {
          return new int();
        }
        [Token(Token = "0x6008855"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] private set
        {
        }
      }

      [Token(Token = "0x1700133E")]
      public GameObject mItemsSelect
      {
        [Token(Token = "0x6008856"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
        {
          return (GameObject) null;
        }
        [Token(Token = "0x6008857"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] private set
        {
        }
      }

      [Token(Token = "0x1700133F")]
      public GameObject mItemsCheck
      {
        [Token(Token = "0x6008858"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
        {
          return (GameObject) null;
        }
        [Token(Token = "0x6008859"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] private set
        {
        }
      }

      [Token(Token = "0x600885A")]
      [Address(RVA = "0x49E200", Offset = "0x49D000", VA = "0x1049E200")]
      public BondSelectUnitData(
        SerializeValueBehaviour svb,
        ItemParam item,
        int need_num,
        int num)
      {
      }
    }

    [Token(Token = "0x20020B8")]
    private class BondPieceItemData
    {
      [Token(Token = "0x17001340")]
      public BondUsePiece mBondUsePiece
      {
        [Token(Token = "0x600885B"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (BondUsePiece) null;
        }
        [Token(Token = "0x600885C"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
        {
        }
      }

      [Token(Token = "0x17001341")]
      public ItemData mItem
      {
        [Token(Token = "0x600885D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (ItemData) null;
        }
        [Token(Token = "0x600885E"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
        {
        }
      }

      [Token(Token = "0x17001342")]
      public Slider mSlider
      {
        [Token(Token = "0x600885F"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (Slider) null;
        }
        [Token(Token = "0x6008860"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
        {
        }
      }

      [Token(Token = "0x17001343")]
      public Button mPlusBtn
      {
        [Token(Token = "0x6008861"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
        {
          return (Button) null;
        }
        [Token(Token = "0x6008862"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] private set
        {
        }
      }

      [Token(Token = "0x17001344")]
      public Button mMinusBtn
      {
        [Token(Token = "0x6008863"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
        {
          return (Button) null;
        }
        [Token(Token = "0x6008864"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
        {
        }
      }

      [Token(Token = "0x17001345")]
      public Text mHaveItemTxt
      {
        [Token(Token = "0x6008865"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
        {
          return (Text) null;
        }
        [Token(Token = "0x6008866"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] private set
        {
        }
      }

      [Token(Token = "0x17001346")]
      public Text mUseNumTxt
      {
        [Token(Token = "0x6008867"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
        {
          return (Text) null;
        }
        [Token(Token = "0x6008868"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] private set
        {
        }
      }

      [Token(Token = "0x17001347")]
      public int mUseNum
      {
        [Token(Token = "0x6008869"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
        {
          return new int();
        }
        [Token(Token = "0x600886A"), Address(RVA = "0x311230", Offset = "0x310030", VA = "0x10311230")] private set
        {
        }
      }

      [Token(Token = "0x17001348")]
      public Toggle mMaxCheck
      {
        [Token(Token = "0x600886B"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
        {
          return (Toggle) null;
        }
        [Token(Token = "0x600886C"), Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")] set
        {
        }
      }

      [Token(Token = "0x17001349")]
      public Text mCautionText
      {
        [Token(Token = "0x600886D"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
        {
          return (Text) null;
        }
        [Token(Token = "0x600886E"), Address(RVA = "0x27FBD0", Offset = "0x27E9D0", VA = "0x1027FBD0")] private set
        {
        }
      }

      [Token(Token = "0x1700134A")]
      public GameObject mCover
      {
        [Token(Token = "0x600886F"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
        {
          return (GameObject) null;
        }
        [Token(Token = "0x6008870"), Address(RVA = "0x34C010", Offset = "0x34AE10", VA = "0x1034C010")] private set
        {
        }
      }

      [Token(Token = "0x1700134B")]
      public int mCanUseItemNum
      {
        [Token(Token = "0x6008871"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
        {
          return new int();
        }
        [Token(Token = "0x6008872"), Address(RVA = "0x49D280", Offset = "0x49C080", VA = "0x1049D280")] set
        {
        }
      }

      [Token(Token = "0x6008873")]
      [Address(RVA = "0x49CF00", Offset = "0x49BD00", VA = "0x1049CF00")]
      public BondPieceItemData(SerializeValueBehaviour svb, ItemData item, BondUsePiece bup)
      {
      }

      [Token(Token = "0x6008874")]
      [Address(RVA = "0x49CE60", Offset = "0x49BC60", VA = "0x1049CE60")]
      public void SetUseItemNum(int use_num, int limit)
      {
      }

      [Token(Token = "0x6008875")]
      [Address(RVA = "0x49CE30", Offset = "0x49BC30", VA = "0x1049CE30")]
      public int GetItemApTotal() => new int();
    }
  }
}
