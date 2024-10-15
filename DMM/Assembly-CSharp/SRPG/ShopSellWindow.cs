// Decompiled with JetBrains decompiler
// Type: SRPG.ShopSellWindow
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
  [Token(Token = "0x2002AA9")]
  [FlowNode.Pin(2, "Open", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "売却", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "売却数の選択", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("UI/ShopSellWindow")]
  public class ShopSellWindow : SRPG_FixedList, IFlowInterface
  {
    [Token(Token = "0x400CFF4")]
    [FieldOffset(Offset = "0x64")]
    public RectTransform ItemLayoutParent;
    [Token(Token = "0x400CFF5")]
    [FieldOffset(Offset = "0x68")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400CFF6")]
    [FieldOffset(Offset = "0x6C")]
    public Toggle ToggleShowAll;
    [Token(Token = "0x400CFF7")]
    [FieldOffset(Offset = "0x70")]
    public Toggle ToggleShowUsed;
    [Token(Token = "0x400CFF8")]
    [FieldOffset(Offset = "0x74")]
    public Toggle ToggleShowEquip;
    [Token(Token = "0x400CFF9")]
    [FieldOffset(Offset = "0x78")]
    public Toggle ToggleShowUnitPierce;
    [Token(Token = "0x400CFFA")]
    [FieldOffset(Offset = "0x7C")]
    public Toggle ToggleShowItemPierce;
    [Token(Token = "0x400CFFB")]
    [FieldOffset(Offset = "0x80")]
    public Toggle ToggleShowMaterial;
    [Token(Token = "0x400CFFC")]
    [FieldOffset(Offset = "0x84")]
    public Button BtnSort;
    [Token(Token = "0x400CFFD")]
    [FieldOffset(Offset = "0x88")]
    public Button BtnCleared;
    [Token(Token = "0x400CFFE")]
    [FieldOffset(Offset = "0x8C")]
    public Button BtnSell;
    [Token(Token = "0x400CFFF")]
    [FieldOffset(Offset = "0x90")]
    public Text TxtSort;
    [Token(Token = "0x400D000")]
    [FieldOffset(Offset = "0x94")]
    public string Msg_NoSelection;
    [Token(Token = "0x400D001")]
    private const int SELL_ITEM_MAX = 10;
    [Token(Token = "0x400D002")]
    [FieldOffset(Offset = "0x98")]
    private List<GameObject> mSellItemGameObjects;
    [Token(Token = "0x400D003")]
    [FieldOffset(Offset = "0x9C")]
    private List<SellItem> mSellItemListSelected;
    [Token(Token = "0x400D004")]
    [FieldOffset(Offset = "0xA0")]
    private List<SellItem> mSellItemList;
    [Token(Token = "0x400D005")]
    [FieldOffset(Offset = "0xA4")]
    public ShopSellWindow.SellListConfig ListConfig;
    [Token(Token = "0x400D006")]
    [FieldOffset(Offset = "0xA8")]
    private ShopSellWindow.FilterTypes mFilterType;
    [Token(Token = "0x400D007")]
    [FieldOffset(Offset = "0x0")]
    private static List<EItemType>[] FilterItemTypes;
    [Token(Token = "0x400D008")]
    [FieldOffset(Offset = "0x4")]
    private static string[] SortTypeTexts;
    [Token(Token = "0x400D009")]
    [FieldOffset(Offset = "0xAC")]
    private int[] mSortValues;
    [Token(Token = "0x400D00A")]
    [FieldOffset(Offset = "0xB0")]
    private int filteredCnt;
    [Token(Token = "0x400D00B")]
    [FieldOffset(Offset = "0xB4")]
    private ShopSellWindow.SortTypes sortType;

    [Token(Token = "0x170019F7")]
    protected override int DataCount
    {
      [Token(Token = "0x600C2CC"), Address(RVA = "0x5FC000", Offset = "0x5FAE00", VA = "0x105FC000", Slot = "19")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600C2CD")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x170019F8")]
    public override RectTransform ListParent
    {
      [Token(Token = "0x600C2CE"), Address(RVA = "0x8B52B0", Offset = "0x8B40B0", VA = "0x108B52B0", Slot = "17")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x600C2CF")]
    [Address(RVA = "0x8B2DC0", Offset = "0x8B1BC0", VA = "0x108B2DC0", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600C2D0")]
    [Address(RVA = "0x64FDE0", Offset = "0x64EBE0", VA = "0x1064FDE0", Slot = "20")]
    protected override void Update()
    {
    }

    [Token(Token = "0x600C2D1")]
    [Address(RVA = "0x8B1E40", Offset = "0x8B0C40", VA = "0x108B1E40", Slot = "32")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C2D2")]
    [Address(RVA = "0x8B1FA0", Offset = "0x8B0DA0", VA = "0x108B1FA0", Slot = "22")]
    protected override GameObject CreateItem() => (GameObject) null;

    [Token(Token = "0x600C2D3")]
    [Address(RVA = "0x8B5330", Offset = "0x8B4130", VA = "0x108B5330")]
    private bool isSellNGUnit(ItemData item) => new bool();

    [Token(Token = "0x600C2D4")]
    [Address(RVA = "0x8B4470", Offset = "0x8B3270", VA = "0x108B4470")]
    private void adjustPages()
    {
    }

    [Token(Token = "0x600C2D5")]
    [Address(RVA = "0x8B4B00", Offset = "0x8B3900", VA = "0x108B4B00")]
    private List<ItemData> getCurrentItem() => (List<ItemData>) null;

    [Token(Token = "0x600C2D6")]
    [Address(RVA = "0x8B22B0", Offset = "0x8B10B0", VA = "0x108B22B0", Slot = "25")]
    protected override void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x600C2D7")]
    [Address(RVA = "0x8B3C00", Offset = "0x8B2A00", VA = "0x108B3C00")]
    private void UpdateSellIndex()
    {
    }

    [Token(Token = "0x600C2D8")]
    [Address(RVA = "0x8B2D20", Offset = "0x8B1B20", VA = "0x108B2D20")]
    private SellItem SearchFromSelectedItem(ItemData item) => (SellItem) null;

    [Token(Token = "0x600C2D9")]
    [Address(RVA = "0x8B2000", Offset = "0x8B0E00", VA = "0x108B2000")]
    private SellItem CreateOrSearchSellItem(ItemData item) => (SellItem) null;

    [Token(Token = "0x600C2DA")]
    [Address(RVA = "0x8B44D0", Offset = "0x8B32D0", VA = "0x108B44D0")]
    private GameObject createDisplayObject() => (GameObject) null;

    [Token(Token = "0x600C2DB")]
    [Address(RVA = "0x8B4980", Offset = "0x8B3780", VA = "0x108B4980")]
    private void firstSetupDisplayItem()
    {
    }

    [Token(Token = "0x600C2DC")]
    [Address(RVA = "0x8B37B0", Offset = "0x8B25B0", VA = "0x108B37B0")]
    private void UpdateDispalyItem(List<ItemData> list)
    {
    }

    [Token(Token = "0x600C2DD")]
    [Address(RVA = "0x8B45F0", Offset = "0x8B33F0", VA = "0x108B45F0")]
    private void createDisplaySellItem(List<ItemData> list)
    {
    }

    [Token(Token = "0x600C2DE")]
    [Address(RVA = "0x8B2AA0", Offset = "0x8B18A0", VA = "0x108B2AA0", Slot = "26")]
    protected override void RefreshItems()
    {
    }

    [Token(Token = "0x600C2DF")]
    [Address(RVA = "0x8B39A0", Offset = "0x8B27A0", VA = "0x108B39A0", Slot = "29")]
    public override void UpdatePage()
    {
    }

    [Token(Token = "0x600C2E0")]
    [Address(RVA = "0x8B22C0", Offset = "0x8B10C0", VA = "0x108B22C0")]
    private void OnSelect(GameObject go)
    {
    }

    [Token(Token = "0x600C2E1")]
    [Address(RVA = "0x8B29E0", Offset = "0x8B17E0", VA = "0x108B29E0")]
    private void OnSort()
    {
    }

    [Token(Token = "0x600C2E2")]
    [Address(RVA = "0x8B2170", Offset = "0x8B0F70", VA = "0x108B2170")]
    private void OnCleared()
    {
    }

    [Token(Token = "0x600C2E3")]
    [Address(RVA = "0x8B28D0", Offset = "0x8B16D0", VA = "0x108B28D0")]
    private void OnSell()
    {
    }

    [Token(Token = "0x600C2E4")]
    [Address(RVA = "0x4F8E20", Offset = "0x4F7C20", VA = "0x104F8E20")]
    public ShopSellWindow()
    {
    }

    [Token(Token = "0x600C2E5")]
    [Address(RVA = "0x8B3C80", Offset = "0x8B2A80", VA = "0x108B3C80")]
    static ShopSellWindow()
    {
    }

    [Token(Token = "0x2002AAA")]
    [Serializable]
    public class SellListConfig
    {
      [Token(Token = "0x400D00C")]
      [FieldOffset(Offset = "0x8")]
      public bool MaxGentotuOnly;
      [Token(Token = "0x400D00D")]
      [FieldOffset(Offset = "0x9")]
      public bool ShowEmpty;
      [Token(Token = "0x400D00E")]
      [FieldOffset(Offset = "0xC")]
      public GameObject EmptyTemplate;

      [Token(Token = "0x600C2EC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public SellListConfig()
      {
      }
    }

    [Token(Token = "0x2002AAB")]
    [Serializable]
    public enum FilterTypes
    {
      [Token(Token = "0x400D010")] All,
      [Token(Token = "0x400D011")] Used,
      [Token(Token = "0x400D012")] Equip,
      [Token(Token = "0x400D013")] ItemPiece,
      [Token(Token = "0x400D014")] Material,
      [Token(Token = "0x400D015")] UnitPiece,
    }

    [Token(Token = "0x2002AAC")]
    private enum SortTypes
    {
      [Token(Token = "0x400D017")] Index,
      [Token(Token = "0x400D018")] Rarity,
    }
  }
}
