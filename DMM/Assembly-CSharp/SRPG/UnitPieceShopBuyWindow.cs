// Decompiled with JetBrains decompiler
// Type: SRPG.UnitPieceShopBuyWindow
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
  [Token(Token = "0x2002CDF")]
  [FlowNode.Pin(25, "Filter Toggle All", FlowNode.PinTypes.Input, 25)]
  [FlowNode.Pin(26, "Filter Toggle Clear", FlowNode.PinTypes.Input, 26)]
  [FlowNode.Pin(27, "Filter Tab Change", FlowNode.PinTypes.Input, 27)]
  [FlowNode.Pin(22, "Filter Window Close", FlowNode.PinTypes.Input, 22)]
  [FlowNode.Pin(104, "商品の期限切れ警告表示", FlowNode.PinTypes.Output, 104)]
  [AddComponentMenu("UI/UnitPieceShopBuyWindow")]
  [FlowNode.Pin(100, "Buy Window Open", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(23, "Filter Decide", FlowNode.PinTypes.Input, 23)]
  [FlowNode.Pin(14, "Sort Toggle Change", FlowNode.PinTypes.Input, 14)]
  [FlowNode.Pin(13, "Sort Decide", FlowNode.PinTypes.Input, 13)]
  [FlowNode.Pin(21, "Filter Window Open", FlowNode.PinTypes.Input, 21)]
  [FlowNode.Pin(11, "Sort Window Open", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(3, "Bought", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "Item Select", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(12, "Sort Window Close", FlowNode.PinTypes.Input, 12)]
  public class UnitPieceShopBuyWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400DF11")]
    private const int PIN_IN_REFRESH = 1;
    [Token(Token = "0x400DF12")]
    private const int PIN_IN_SELECT_ITEM = 2;
    [Token(Token = "0x400DF13")]
    private const int PIN_IN_BOUGHT = 3;
    [Token(Token = "0x400DF14")]
    private const int PIN_IN_SORT_WINDOW_OPEN = 11;
    [Token(Token = "0x400DF15")]
    private const int PIN_IN_SORT_WINDOW_CLOSE = 12;
    [Token(Token = "0x400DF16")]
    private const int PIN_IN_SORT_WINDOW_OK = 13;
    [Token(Token = "0x400DF17")]
    private const int PIN_IN_SORT_WINDOW_TGLCHANGE = 14;
    [Token(Token = "0x400DF18")]
    private const int PIN_IN_FILTER_WINDOW_OPEN = 21;
    [Token(Token = "0x400DF19")]
    private const int PIN_IN_FILTER_WINDOW_CLOSE = 22;
    [Token(Token = "0x400DF1A")]
    private const int PIN_IN_FILTER_WINDOW_OK = 23;
    [Token(Token = "0x400DF1B")]
    private const int PIN_IN_FILTER_WINDOW_ALL = 25;
    [Token(Token = "0x400DF1C")]
    private const int PIN_IN_FILTER_WINDOW_CLEAR = 26;
    [Token(Token = "0x400DF1D")]
    private const int PIN_IN_FILTER_WINDOW_TABCHANGE = 27;
    [Token(Token = "0x400DF1E")]
    private const int PIN_OUT_OPEN_POPUP = 100;
    [Token(Token = "0x400DF1F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text TextCoinNum;
    [Token(Token = "0x400DF20")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ImageCoinIcon;
    [Token(Token = "0x400DF21")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ContentController mContentController;
    [Token(Token = "0x400DF22")]
    [FieldOffset(Offset = "0x18")]
    private UnitPieceShopBuyWindow.ItemSource mItemSource;
    [Token(Token = "0x400DF23")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private TabMaker m_Tab;
    [Token(Token = "0x400DF24")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Toggle mSoldOutToggle;
    [Token(Token = "0x400DF25")]
    [FieldOffset(Offset = "0x24")]
    public UnitListSortWindow.SerializeParam m_SortWindowParam;
    [Token(Token = "0x400DF26")]
    [FieldOffset(Offset = "0x28")]
    public UnitListFilterWindow.SerializeParam m_FilterWindowParam;
    [Token(Token = "0x400DF27")]
    [FieldOffset(Offset = "0x2C")]
    private UnitListSortWindow mSortWindow;
    [Token(Token = "0x400DF28")]
    [FieldOffset(Offset = "0x30")]
    private UnitListFilterWindow mFilterWindow;
    [Token(Token = "0x400DF29")]
    [FieldOffset(Offset = "0x34")]
    private UnitListSortWindow.SelectType mSortType;
    [Token(Token = "0x400DF2A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text mSortButtonText;
    [Token(Token = "0x400DF2B")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Image mFilterButtonImage;
    [Token(Token = "0x400DF2C")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Sprite mFilterImageDefault;
    [Token(Token = "0x400DF2D")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Sprite mFilterImageOn;

    [Token(Token = "0x600D0D6")]
    [Address(RVA = "0x9BF4D0", Offset = "0x9BE2D0", VA = "0x109BF4D0")]
    private bool TabEqual(UnitPieceShopBuyWindow.Tab tab, EElement element) => new bool();

    [Token(Token = "0x600D0D7")]
    [Address(RVA = "0x9BDDA0", Offset = "0x9BCBA0", VA = "0x109BDDA0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600D0D8")]
    [Address(RVA = "0x9BE770", Offset = "0x9BD570", VA = "0x109BE770")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600D0D9")]
    [Address(RVA = "0x9BF550", Offset = "0x9BE350", VA = "0x109BF550")]
    private void Update()
    {
    }

    [Token(Token = "0x600D0DA")]
    [Address(RVA = "0x9BDB30", Offset = "0x9BC930", VA = "0x109BDB30", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D0DB")]
    [Address(RVA = "0x9BF310", Offset = "0x9BE110", VA = "0x109BF310")]
    private void SetupTabNode(GameObject gobj, SerializeValueList value)
    {
    }

    [Token(Token = "0x600D0DC")]
    [Address(RVA = "0x9BE3A0", Offset = "0x9BD1A0", VA = "0x109BE3A0")]
    private UnitPieceShopBuyWindow.Tab GetCurrentTab() => new UnitPieceShopBuyWindow.Tab();

    [Token(Token = "0x600D0DD")]
    [Address(RVA = "0x9BEA70", Offset = "0x9BD870", VA = "0x109BEA70")]
    private void Refresh(bool keepScrollPos = false)
    {
    }

    [Token(Token = "0x600D0DE")]
    [Address(RVA = "0x9BF410", Offset = "0x9BE210", VA = "0x109BF410")]
    private void SortItem(Dictionary<string, UnitPieceShopItem> dict, List<UnitData> list)
    {
    }

    [Token(Token = "0x600D0DF")]
    [Address(RVA = "0x9BE420", Offset = "0x9BD220", VA = "0x109BE420")]
    private int GetSortPriority(UnitData unit, UnitListSortWindow.SelectType type) => new int();

    [Token(Token = "0x600D0E0")]
    [Address(RVA = "0x9BE860", Offset = "0x9BD660", VA = "0x109BE860")]
    private void OnSelect()
    {
    }

    [Token(Token = "0x600D0E1")]
    [Address(RVA = "0x9BF0F0", Offset = "0x9BDEF0", VA = "0x109BF0F0")]
    private void SetPossessionCoinParam()
    {
    }

    [Token(Token = "0x600D0E2")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public UnitPieceShopBuyWindow()
    {
    }

    [Token(Token = "0x2002CE0")]
    private enum Tab
    {
      [Token(Token = "0x400DF2F")] NONE = 0,
      [Token(Token = "0x400DF31")] FAVORITE = 1,
      [Token(Token = "0x400DF32")] FIRE = 2,
      [Token(Token = "0x400DF33")] WATER = 4,
      [Token(Token = "0x400DF34")] THUNDER = 8,
      [Token(Token = "0x400DF35")] WIND = 16, // 0x00000010
      [Token(Token = "0x400DF36")] LIGHT = 32, // 0x00000020
      [Token(Token = "0x400DF37")] DARK = 64, // 0x00000040
      [Token(Token = "0x400DF30")] ALL = 65535, // 0x0000FFFF
    }

    [Token(Token = "0x2002CE1")]
    public class ItemSource : ContentSource
    {
      [Token(Token = "0x400DF38")]
      [FieldOffset(Offset = "0x10")]
      private List<UnitPieceShopBuyWindow.ItemSource.ItemParam> m_Params;

      [Token(Token = "0x600D0E3")]
      [Address(RVA = "0x9B4590", Offset = "0x9B3390", VA = "0x109B4590", Slot = "8")]
      public override ContentNode Instantiate(ContentNode res) => (ContentNode) null;

      [Token(Token = "0x600D0E4")]
      [Address(RVA = "0x9B4530", Offset = "0x9B3330", VA = "0x109B4530", Slot = "4")]
      public override void Initialize(ContentController controller)
      {
      }

      [Token(Token = "0x600D0E5")]
      [Address(RVA = "0x9B44C0", Offset = "0x9B32C0", VA = "0x109B44C0")]
      public void Add(UnitPieceShopBuyWindow.ItemSource.ItemParam param)
      {
      }

      [Token(Token = "0x600D0E6")]
      [Address(RVA = "0x9B4680", Offset = "0x9B3480", VA = "0x109B4680")]
      public ItemSource()
      {
      }

      [Token(Token = "0x2002CE2")]
      public class ItemParam : ContentSource.Param
      {
        [Token(Token = "0x400DF39")]
        [FieldOffset(Offset = "0x10")]
        private UnitPieceShopItem m_Item;

        [Token(Token = "0x600D0E7")]
        [Address(RVA = "0x596DE0", Offset = "0x595BE0", VA = "0x10596DE0", Slot = "6")]
        public override bool IsValid() => new bool();

        [Token(Token = "0x17001B7A")]
        public UnitPieceShopItem data
        {
          [Token(Token = "0x600D0E8"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
          {
            return (UnitPieceShopItem) null;
          }
        }

        [Token(Token = "0x600D0E9")]
        [Address(RVA = "0x596EA0", Offset = "0x595CA0", VA = "0x10596EA0")]
        public ItemParam(UnitPieceShopItem item)
        {
        }

        [Token(Token = "0x600D0EA")]
        [Address(RVA = "0x9B4370", Offset = "0x9B3170", VA = "0x109B4370", Slot = "11")]
        public override void OnSetup(ContentNode node)
        {
        }
      }
    }
  }
}
