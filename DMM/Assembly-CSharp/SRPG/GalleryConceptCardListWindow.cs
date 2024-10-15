// Decompiled with JetBrains decompiler
// Type: SRPG.GalleryConceptCardListWindow
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
  [Token(Token = "0x20024B8")]
  [FlowNode.Pin(0, "Open", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "NextPage", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "PrevPage", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "TabChange", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(6, "フィルタ設定変更ダイアログ表示要求", FlowNode.PinTypes.Input, 6)]
  [FlowNode.Pin(7, "フィルタ設定変更完了", FlowNode.PinTypes.Input, 7)]
  [FlowNode.Pin(10, "更新", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "ソート設定変更ダイアログ表示", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "フィルター設定変更ダイアログ表示", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("UI/GalleryConceptCardListWindow")]
  [FlowNode.Pin(5, "ソート設定変更完了", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(4, "ソート設定変更ダイアログ表示要求", FlowNode.PinTypes.Input, 4)]
  public class GalleryConceptCardListWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A785")]
    private const int OPEN = 0;
    [Token(Token = "0x400A786")]
    private const int NEXT_PAGE = 1;
    [Token(Token = "0x400A787")]
    private const int PREV_PAGE = 2;
    [Token(Token = "0x400A788")]
    private const int TAB_CHANGE = 3;
    [Token(Token = "0x400A789")]
    private const int REQ_SORT_SETTING = 4;
    [Token(Token = "0x400A78A")]
    private const int UPDATED_SORT_SETTING = 5;
    [Token(Token = "0x400A78B")]
    private const int REQ_FILTER_SETTING = 6;
    [Token(Token = "0x400A78C")]
    private const int UPDATED_FILTER_SETTING = 7;
    [Token(Token = "0x400A78D")]
    private const int PIN_IN_REFRESH = 10;
    [Token(Token = "0x400A78E")]
    private const int OUTPUT_SORT_SETTING = 100;
    [Token(Token = "0x400A78F")]
    private const int OUTPUT_FILTER_SETTING = 101;
    [Token(Token = "0x400A790")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GridLayoutGroup ItemGrid;
    [Token(Token = "0x400A791")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text CurrentPage;
    [Token(Token = "0x400A792")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text TotalPage;
    [Token(Token = "0x400A793")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject ItemTemplate;
    [Token(Token = "0x400A794")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button NextButton;
    [Token(Token = "0x400A795")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button PrevButton;
    [Token(Token = "0x400A796")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Button FilterButton;
    [Token(Token = "0x400A797")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Sprite FilterButtonAllOnImage;
    [Token(Token = "0x400A798")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Sprite FilterButtonNotAllImage;
    [Token(Token = "0x400A799")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text SortButtonTitle;
    [Token(Token = "0x400A79A")]
    [FieldOffset(Offset = "0x34")]
    private int mCellCount;
    [Token(Token = "0x400A79B")]
    [FieldOffset(Offset = "0x38")]
    private GalleryConceptCardListWindow.TabType mCurrentTabType;
    [Token(Token = "0x400A79C")]
    [FieldOffset(Offset = "0x3C")]
    private GallerySettings mSettings;
    [Token(Token = "0x400A79D")]
    [FieldOffset(Offset = "0x40")]
    private List<ConceptCardParam> mAllItems;
    [Token(Token = "0x400A79E")]
    [FieldOffset(Offset = "0x44")]
    private List<GameObject> mItemObjects;
    [Token(Token = "0x400A79F")]
    [FieldOffset(Offset = "0x48")]
    private Dictionary<GalleryConceptCardListWindow.TabType, GalleryConceptCardListWindow.TabInfo> mTabInfoList;
    [Token(Token = "0x400A7A0")]
    [FieldOffset(Offset = "0x4C")]
    private GalleryConceptCardListWindow.TabInfo mCurrentTabInfo;
    [Token(Token = "0x400A7A1")]
    [FieldOffset(Offset = "0x50")]
    private bool mInitialized;

    [Token(Token = "0x600A10F")]
    [Address(RVA = "0x633270", Offset = "0x632070", VA = "0x10633270")]
    private void Start()
    {
    }

    [Token(Token = "0x600A110")]
    [Address(RVA = "0x631000", Offset = "0x62FE00", VA = "0x10631000", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A111")]
    [Address(RVA = "0x631B30", Offset = "0x630930", VA = "0x10631B30")]
    private List<ConceptCardParam> GetAvailableItems(GalleryConceptCardListWindow.TabType tabtype)
    {
      return (List<ConceptCardParam>) null;
    }

    [Token(Token = "0x600A112")]
    [Address(RVA = "0x631A80", Offset = "0x630880", VA = "0x10631A80")]
    public static IEnumerable<ConceptCardParam> FilterBySettings(
      IEnumerable<ConceptCardParam> list,
      GalleryConceptCardListWindow.TabType tabtype,
      GallerySettings settings)
    {
      return (IEnumerable<ConceptCardParam>) null;
    }

    [Token(Token = "0x600A113")]
    [Address(RVA = "0x631F90", Offset = "0x630D90", VA = "0x10631F90")]
    private static bool IsSameTabType(
      ConceptCardParam conceptCard,
      GalleryConceptCardListWindow.TabType tabType)
    {
      return new bool();
    }

    [Token(Token = "0x600A114")]
    [Address(RVA = "0x632F60", Offset = "0x631D60", VA = "0x10632F60")]
    public static IEnumerable<ConceptCardParam> SortBySettings(
      IEnumerable<ConceptCardParam> list,
      GallerySettings settings)
    {
      return (IEnumerable<ConceptCardParam>) null;
    }

    [Token(Token = "0x600A115")]
    [Address(RVA = "0x62F080", Offset = "0x62DE80", VA = "0x1062F080")]
    private void ChangeFilterButtonSprite()
    {
    }

    [Token(Token = "0x600A116")]
    [Address(RVA = "0x6313D0", Offset = "0x6301D0", VA = "0x106313D0")]
    private void ChangeSortButtonText()
    {
    }

    [Token(Token = "0x600A117")]
    [Address(RVA = "0x632BD0", Offset = "0x6319D0", VA = "0x10632BD0")]
    private void SaveSettingAndOutputPin(int pinID)
    {
    }

    [Token(Token = "0x600A118")]
    [Address(RVA = "0x631FF0", Offset = "0x630DF0", VA = "0x10631FF0")]
    private GallerySettings LoadSetting() => (GallerySettings) null;

    [Token(Token = "0x600A119")]
    [Address(RVA = "0x632C70", Offset = "0x631A70", VA = "0x10632C70")]
    private void SaveSetting(GallerySettings settings)
    {
    }

    [Token(Token = "0x600A11A")]
    [Address(RVA = "0x632CE0", Offset = "0x631AE0", VA = "0x10632CE0")]
    private void SetDirtyAllTabInfo()
    {
    }

    [Token(Token = "0x600A11B")]
    [Address(RVA = "0x6327F0", Offset = "0x6315F0", VA = "0x106327F0")]
    private void RequestTabItems()
    {
    }

    [Token(Token = "0x600A11C")]
    [Address(RVA = "0x6314A0", Offset = "0x6302A0", VA = "0x106314A0")]
    private void ChangeTab(GalleryConceptCardListWindow.TabType tabtype)
    {
    }

    [Token(Token = "0x600A11D")]
    [Address(RVA = "0x632A40", Offset = "0x631840", VA = "0x10632A40")]
    private void ResponseCallback(WWWResult www)
    {
    }

    [Token(Token = "0x600A11E")]
    [Address(RVA = "0x631840", Offset = "0x630640", VA = "0x10631840")]
    private void ConnectionSucceeded(HashSet<string> itemAvailable)
    {
    }

    [Token(Token = "0x600A11F")]
    [Address(RVA = "0x631E70", Offset = "0x630C70", VA = "0x10631E70")]
    private List<ConceptCardParam> GetVisibleItems(
      List<ConceptCardParam> allItems,
      HashSet<string> availables)
    {
      return (List<ConceptCardParam>) null;
    }

    [Token(Token = "0x600A120")]
    [Address(RVA = "0x632210", Offset = "0x631010", VA = "0x10632210")]
    private void RefreshPage()
    {
    }

    [Token(Token = "0x600A121")]
    [Address(RVA = "0x632E30", Offset = "0x631C30", VA = "0x10632E30")]
    private void SetDummyCardData(GameObject obj, ConceptCardParam param)
    {
    }

    [Token(Token = "0x600A122")]
    [Address(RVA = "0x631610", Offset = "0x630410", VA = "0x10631610")]
    private void ClearAndDisableAll(List<GameObject> list)
    {
    }

    [Token(Token = "0x600A123")]
    [Address(RVA = "0x632760", Offset = "0x631560", VA = "0x10632760")]
    private DataSource RemoveBindedDataIfExists(GameObject obj) => (DataSource) null;

    [Token(Token = "0x600A124")]
    [Address(RVA = "0x632ED0", Offset = "0x631CD0", VA = "0x10632ED0")]
    private void SetItemInteractable(GameObject obj, bool isInteractable)
    {
    }

    [Token(Token = "0x600A125")]
    [Address(RVA = "0x6321B0", Offset = "0x630FB0", VA = "0x106321B0")]
    private void NextPage()
    {
    }

    [Token(Token = "0x600A126")]
    [Address(RVA = "0x6321E0", Offset = "0x630FE0", VA = "0x106321E0")]
    private void PrevPage()
    {
    }

    [Token(Token = "0x600A127")]
    [Address(RVA = "0x631310", Offset = "0x630110", VA = "0x10631310")]
    private void ChangeEnabledArrowButtons(int index, int max)
    {
    }

    [Token(Token = "0x600A128")]
    [Address(RVA = "0x631C50", Offset = "0x630A50", VA = "0x10631C50")]
    private int GetCellCount() => new int();

    [Token(Token = "0x600A129")]
    [Address(RVA = "0x633320", Offset = "0x632120", VA = "0x10633320")]
    public GalleryConceptCardListWindow()
    {
    }

    [Token(Token = "0x20024B9")]
    public enum TabType
    {
      [Token(Token = "0x400A7A3")] Equipment,
      [Token(Token = "0x400A7A4")] Enhance,
      [Token(Token = "0x400A7A5")] Others,
    }

    [Token(Token = "0x20024BA")]
    private class TabInfo
    {
      [Token(Token = "0x400A7A6")]
      [FieldOffset(Offset = "0x8")]
      public int CurrentPage;
      [Token(Token = "0x400A7A7")]
      [FieldOffset(Offset = "0xC")]
      public int TotalPage;
      [Token(Token = "0x400A7A8")]
      [FieldOffset(Offset = "0x10")]
      public List<ConceptCardParam> AllItems;
      [Token(Token = "0x400A7A9")]
      [FieldOffset(Offset = "0x14")]
      public HashSet<string> AllAvailableItems;
      [Token(Token = "0x400A7AA")]
      [FieldOffset(Offset = "0x18")]
      public GallerySettings Setting;
      [Token(Token = "0x400A7AB")]
      [FieldOffset(Offset = "0x1C")]
      public bool IsDirty;

      [Token(Token = "0x600A12A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public TabInfo()
      {
      }
    }

    [Token(Token = "0x20024BB")]
    public class JSON_Body
    {
      [Token(Token = "0x400A7AC")]
      [FieldOffset(Offset = "0x8")]
      public string[] items;

      [Token(Token = "0x600A12B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_Body()
      {
      }
    }
  }
}
