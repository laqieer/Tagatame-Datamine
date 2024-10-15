// Decompiled with JetBrains decompiler
// Type: SRPG.GalleryItemListWindow
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
  [Token(Token = "0x20024C9")]
  [FlowNode.Pin(0, "Open", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "NextPage", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "PrevPage", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "TabChange", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(5, "ソート設定変更完了", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(6, "フィルタ設定変更ダイアログ表示要求", FlowNode.PinTypes.Input, 6)]
  [FlowNode.Pin(7, "フィルタ設定変更完了", FlowNode.PinTypes.Input, 7)]
  [FlowNode.Pin(10, "更新", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "ソート設定変更ダイアログ表示", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "フィルター設定変更ダイアログ表示", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("UI/GalleryItemListWindow")]
  [FlowNode.Pin(4, "ソート設定変更ダイアログ表示要求", FlowNode.PinTypes.Input, 4)]
  public class GalleryItemListWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A7F4")]
    private const int OPEN = 0;
    [Token(Token = "0x400A7F5")]
    private const int NEXT_PAGE = 1;
    [Token(Token = "0x400A7F6")]
    private const int PREV_PAGE = 2;
    [Token(Token = "0x400A7F7")]
    private const int TAB_CHANGE = 3;
    [Token(Token = "0x400A7F8")]
    private const int REQ_SORT_SETTING = 4;
    [Token(Token = "0x400A7F9")]
    private const int UPDATED_SORT_SETTING = 5;
    [Token(Token = "0x400A7FA")]
    private const int REQ_FILTER_SETTING = 6;
    [Token(Token = "0x400A7FB")]
    private const int UPDATED_FILTER_SETTING = 7;
    [Token(Token = "0x400A7FC")]
    private const int PIN_IN_REFRESH = 10;
    [Token(Token = "0x400A7FD")]
    private const int OUTPUT_SORT_SETTING = 100;
    [Token(Token = "0x400A7FE")]
    private const int OUTPUT_FILTER_SETTING = 101;
    [Token(Token = "0x400A7FF")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GridLayoutGroup ItemGrid;
    [Token(Token = "0x400A800")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text CurrentPage;
    [Token(Token = "0x400A801")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text TotalPage;
    [Token(Token = "0x400A802")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject ItemTemplate;
    [Token(Token = "0x400A803")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button NextButton;
    [Token(Token = "0x400A804")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button PrevButton;
    [Token(Token = "0x400A805")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Button FilterButton;
    [Token(Token = "0x400A806")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Sprite FilterButtonAllOnImage;
    [Token(Token = "0x400A807")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Sprite FilterButtonNotAllImage;
    [Token(Token = "0x400A808")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text SortButtonTitle;
    [Token(Token = "0x400A809")]
    [FieldOffset(Offset = "0x34")]
    private int mCellCount;
    [Token(Token = "0x400A80A")]
    [FieldOffset(Offset = "0x38")]
    private EItemTabType mCurrentTabType;
    [Token(Token = "0x400A80B")]
    [FieldOffset(Offset = "0x3C")]
    private GallerySettings mSettings;
    [Token(Token = "0x400A80C")]
    [FieldOffset(Offset = "0x40")]
    private List<ItemParam> mAllItems;
    [Token(Token = "0x400A80D")]
    [FieldOffset(Offset = "0x44")]
    private List<GameObject> mItemObjects;
    [Token(Token = "0x400A80E")]
    [FieldOffset(Offset = "0x48")]
    private Dictionary<EItemTabType, GalleryItemListWindow.TabInfo> mTabInfoList;
    [Token(Token = "0x400A80F")]
    [FieldOffset(Offset = "0x4C")]
    private GalleryItemListWindow.TabInfo mCurrentTabInfo;
    [Token(Token = "0x400A810")]
    [FieldOffset(Offset = "0x50")]
    private bool mInitialized;

    [Token(Token = "0x600A164")]
    [Address(RVA = "0x638100", Offset = "0x636F00", VA = "0x10638100")]
    private void Start()
    {
    }

    [Token(Token = "0x600A165")]
    [Address(RVA = "0x636000", Offset = "0x634E00", VA = "0x10636000", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A166")]
    [Address(RVA = "0x636B30", Offset = "0x635930", VA = "0x10636B30")]
    private List<ItemParam> GetAvailableItems(EItemTabType tabtype) => (List<ItemParam>) null;

    [Token(Token = "0x600A167")]
    [Address(RVA = "0x636A80", Offset = "0x635880", VA = "0x10636A80")]
    public static IEnumerable<ItemParam> FilterBySettings(
      IEnumerable<ItemParam> list,
      EItemTabType tabtype,
      GallerySettings settings)
    {
      return (IEnumerable<ItemParam>) null;
    }

    [Token(Token = "0x600A168")]
    [Address(RVA = "0x637DF0", Offset = "0x636BF0", VA = "0x10637DF0")]
    public static IEnumerable<ItemParam> SortBySettings(
      IEnumerable<ItemParam> list,
      GallerySettings settings)
    {
      return (IEnumerable<ItemParam>) null;
    }

    [Token(Token = "0x600A169")]
    [Address(RVA = "0x62F080", Offset = "0x62DE80", VA = "0x1062F080")]
    private void ChangeFilterButtonSprite()
    {
    }

    [Token(Token = "0x600A16A")]
    [Address(RVA = "0x6363D0", Offset = "0x6351D0", VA = "0x106363D0")]
    private void ChangeSortButtonText()
    {
    }

    [Token(Token = "0x600A16B")]
    [Address(RVA = "0x637B00", Offset = "0x636900", VA = "0x10637B00")]
    private void SaveSettingAndOutputPin(int pinID)
    {
    }

    [Token(Token = "0x600A16C")]
    [Address(RVA = "0x636FB0", Offset = "0x635DB0", VA = "0x10636FB0")]
    private GallerySettings LoadSetting() => (GallerySettings) null;

    [Token(Token = "0x600A16D")]
    [Address(RVA = "0x637BA0", Offset = "0x6369A0", VA = "0x10637BA0")]
    private void SaveSetting(GallerySettings settings)
    {
    }

    [Token(Token = "0x600A16E")]
    [Address(RVA = "0x637C10", Offset = "0x636A10", VA = "0x10637C10")]
    private void SetDirtyAllTabInfo()
    {
    }

    [Token(Token = "0x600A16F")]
    [Address(RVA = "0x637720", Offset = "0x636520", VA = "0x10637720")]
    private void RequestTabItems()
    {
    }

    [Token(Token = "0x600A170")]
    [Address(RVA = "0x6364A0", Offset = "0x6352A0", VA = "0x106364A0")]
    private void ChangeTab(EItemTabType tabtype)
    {
    }

    [Token(Token = "0x600A171")]
    [Address(RVA = "0x637970", Offset = "0x636770", VA = "0x10637970")]
    private void ResponseCallback(WWWResult www)
    {
    }

    [Token(Token = "0x600A172")]
    [Address(RVA = "0x636840", Offset = "0x635640", VA = "0x10636840")]
    private void ConnectionSucceeded(HashSet<string> itemAvailable)
    {
    }

    [Token(Token = "0x600A173")]
    [Address(RVA = "0x636E70", Offset = "0x635C70", VA = "0x10636E70")]
    private List<ItemParam> GetVisibleItems(List<ItemParam> allItems, HashSet<string> availables)
    {
      return (List<ItemParam>) null;
    }

    [Token(Token = "0x600A174")]
    [Address(RVA = "0x6371D0", Offset = "0x635FD0", VA = "0x106371D0")]
    private void RefreshPage()
    {
    }

    [Token(Token = "0x600A175")]
    [Address(RVA = "0x636610", Offset = "0x635410", VA = "0x10636610")]
    private void ClearAndDisableAll(List<GameObject> list)
    {
    }

    [Token(Token = "0x600A176")]
    [Address(RVA = "0x637690", Offset = "0x636490", VA = "0x10637690")]
    private DataSource RemoveBindedDataIfExists(GameObject obj) => (DataSource) null;

    [Token(Token = "0x600A177")]
    [Address(RVA = "0x637D60", Offset = "0x636B60", VA = "0x10637D60")]
    private void SetItemInteractable(GameObject obj, bool isInteractable)
    {
    }

    [Token(Token = "0x600A178")]
    [Address(RVA = "0x637170", Offset = "0x635F70", VA = "0x10637170")]
    private void NextPage()
    {
    }

    [Token(Token = "0x600A179")]
    [Address(RVA = "0x6371A0", Offset = "0x635FA0", VA = "0x106371A0")]
    private void PrevPage()
    {
    }

    [Token(Token = "0x600A17A")]
    [Address(RVA = "0x636310", Offset = "0x635110", VA = "0x10636310")]
    private void ChangeEnabledArrowButtons(int index, int max)
    {
    }

    [Token(Token = "0x600A17B")]
    [Address(RVA = "0x636C50", Offset = "0x635A50", VA = "0x10636C50")]
    private int GetCellCount() => new int();

    [Token(Token = "0x600A17C")]
    [Address(RVA = "0x6381B0", Offset = "0x636FB0", VA = "0x106381B0")]
    public GalleryItemListWindow()
    {
    }

    [Token(Token = "0x20024CA")]
    private class TabInfo
    {
      [Token(Token = "0x400A811")]
      [FieldOffset(Offset = "0x8")]
      public int CurrentPage;
      [Token(Token = "0x400A812")]
      [FieldOffset(Offset = "0xC")]
      public int TotalPage;
      [Token(Token = "0x400A813")]
      [FieldOffset(Offset = "0x10")]
      public List<ItemParam> AllItems;
      [Token(Token = "0x400A814")]
      [FieldOffset(Offset = "0x14")]
      public HashSet<string> AllAvailableItems;
      [Token(Token = "0x400A815")]
      [FieldOffset(Offset = "0x18")]
      public GallerySettings Setting;
      [Token(Token = "0x400A816")]
      [FieldOffset(Offset = "0x1C")]
      public bool IsDirty;

      [Token(Token = "0x600A17D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public TabInfo()
      {
      }
    }

    [Token(Token = "0x20024CB")]
    public class JSON_Body
    {
      [Token(Token = "0x400A817")]
      [FieldOffset(Offset = "0x8")]
      public string[] items;

      [Token(Token = "0x600A17E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_Body()
      {
      }
    }
  }
}
