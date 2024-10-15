// Decompiled with JetBrains decompiler
// Type: SRPG.GalleryArtifactListWindow
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
  [Token(Token = "0x20024AF")]
  [FlowNode.Pin(100, "ソート設定変更ダイアログ表示", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(10, "更新", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(7, "フィルタ設定変更完了", FlowNode.PinTypes.Input, 7)]
  [FlowNode.Pin(6, "フィルタ設定変更ダイアログ表示要求", FlowNode.PinTypes.Input, 6)]
  [FlowNode.Pin(5, "ソート設定変更完了", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(4, "ソート設定変更ダイアログ表示要求", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(3, "TabChange", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "PrevPage", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "NextPage", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(0, "Open", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("UI/GalleryArtifactListWindow")]
  [FlowNode.Pin(101, "フィルター設定変更ダイアログ表示", FlowNode.PinTypes.Output, 101)]
  public class GalleryArtifactListWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A753")]
    private const int OPEN = 0;
    [Token(Token = "0x400A754")]
    private const int NEXT_PAGE = 1;
    [Token(Token = "0x400A755")]
    private const int PREV_PAGE = 2;
    [Token(Token = "0x400A756")]
    private const int TAB_CHANGE = 3;
    [Token(Token = "0x400A757")]
    private const int REQ_SORT_SETTING = 4;
    [Token(Token = "0x400A758")]
    private const int UPDATED_SORT_SETTING = 5;
    [Token(Token = "0x400A759")]
    private const int REQ_FILTER_SETTING = 6;
    [Token(Token = "0x400A75A")]
    private const int UPDATED_FILTER_SETTING = 7;
    [Token(Token = "0x400A75B")]
    private const int PIN_IN_REFRESH = 10;
    [Token(Token = "0x400A75C")]
    private const int OUTPUT_SORT_SETTING = 100;
    [Token(Token = "0x400A75D")]
    private const int OUTPUT_FILTER_SETTING = 101;
    [Token(Token = "0x400A75E")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GridLayoutGroup ItemGrid;
    [Token(Token = "0x400A75F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text CurrentPage;
    [Token(Token = "0x400A760")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text TotalPage;
    [Token(Token = "0x400A761")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject ItemTemplate;
    [Token(Token = "0x400A762")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button NextButton;
    [Token(Token = "0x400A763")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button PrevButton;
    [Token(Token = "0x400A764")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Button FilterButton;
    [Token(Token = "0x400A765")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Sprite FilterButtonAllOnImage;
    [Token(Token = "0x400A766")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Sprite FilterButtonNotAllImage;
    [Token(Token = "0x400A767")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text SortButtonTitle;
    [Token(Token = "0x400A768")]
    [FieldOffset(Offset = "0x34")]
    private int mCellCount;
    [Token(Token = "0x400A769")]
    [FieldOffset(Offset = "0x38")]
    private GalleryArtifactListWindow.TabType mCurrentTabType;
    [Token(Token = "0x400A76A")]
    [FieldOffset(Offset = "0x3C")]
    private GallerySettings mSettings;
    [Token(Token = "0x400A76B")]
    [FieldOffset(Offset = "0x40")]
    private List<ArtifactParam> mAllItems;
    [Token(Token = "0x400A76C")]
    [FieldOffset(Offset = "0x44")]
    private List<GameObject> mItemObjects;
    [Token(Token = "0x400A76D")]
    [FieldOffset(Offset = "0x48")]
    private Dictionary<GalleryArtifactListWindow.TabType, GalleryArtifactListWindow.TabInfo> mTabInfoList;
    [Token(Token = "0x400A76E")]
    [FieldOffset(Offset = "0x4C")]
    private GalleryArtifactListWindow.TabInfo mCurrentTabInfo;
    [Token(Token = "0x400A76F")]
    [FieldOffset(Offset = "0x50")]
    private bool mInitialized;

    [Token(Token = "0x600A0E5")]
    [Address(RVA = "0x630E50", Offset = "0x62FC50", VA = "0x10630E50")]
    private void Start()
    {
    }

    [Token(Token = "0x600A0E6")]
    [Address(RVA = "0x62ECB0", Offset = "0x62DAB0", VA = "0x1062ECB0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A0E7")]
    [Address(RVA = "0x62F850", Offset = "0x62E650", VA = "0x1062F850")]
    private List<ArtifactParam> GetAvailableItems(GalleryArtifactListWindow.TabType tabtype)
    {
      return (List<ArtifactParam>) null;
    }

    [Token(Token = "0x600A0E8")]
    [Address(RVA = "0x62F7A0", Offset = "0x62E5A0", VA = "0x1062F7A0")]
    public static IEnumerable<ArtifactParam> FilterBySettings(
      IEnumerable<ArtifactParam> list,
      GalleryArtifactListWindow.TabType tabtype,
      GallerySettings settings)
    {
      return (IEnumerable<ArtifactParam>) null;
    }

    [Token(Token = "0x600A0E9")]
    [Address(RVA = "0x62FCB0", Offset = "0x62EAB0", VA = "0x1062FCB0")]
    private static bool IsSameTabType(
      ArtifactParam conceptCard,
      GalleryArtifactListWindow.TabType tabType)
    {
      return new bool();
    }

    [Token(Token = "0x600A0EA")]
    [Address(RVA = "0x630B40", Offset = "0x62F940", VA = "0x10630B40")]
    public static IEnumerable<ArtifactParam> SortBySettings(
      IEnumerable<ArtifactParam> list,
      GallerySettings settings)
    {
      return (IEnumerable<ArtifactParam>) null;
    }

    [Token(Token = "0x600A0EB")]
    [Address(RVA = "0x62F080", Offset = "0x62DE80", VA = "0x1062F080")]
    private void ChangeFilterButtonSprite()
    {
    }

    [Token(Token = "0x600A0EC")]
    [Address(RVA = "0x62F0F0", Offset = "0x62DEF0", VA = "0x1062F0F0")]
    private void ChangeSortButtonText()
    {
    }

    [Token(Token = "0x600A0ED")]
    [Address(RVA = "0x630850", Offset = "0x62F650", VA = "0x10630850")]
    private void SaveSettingAndOutputPin(int pinID)
    {
    }

    [Token(Token = "0x600A0EE")]
    [Address(RVA = "0x62FD00", Offset = "0x62EB00", VA = "0x1062FD00")]
    private GallerySettings LoadSetting() => (GallerySettings) null;

    [Token(Token = "0x600A0EF")]
    [Address(RVA = "0x6308F0", Offset = "0x62F6F0", VA = "0x106308F0")]
    private void SaveSetting(GallerySettings settings)
    {
    }

    [Token(Token = "0x600A0F0")]
    [Address(RVA = "0x630960", Offset = "0x62F760", VA = "0x10630960")]
    private void SetDirtyAllTabInfo()
    {
    }

    [Token(Token = "0x600A0F1")]
    [Address(RVA = "0x630470", Offset = "0x62F270", VA = "0x10630470")]
    private void RequestTabItems()
    {
    }

    [Token(Token = "0x600A0F2")]
    [Address(RVA = "0x62F1C0", Offset = "0x62DFC0", VA = "0x1062F1C0")]
    private void ChangeTab(GalleryArtifactListWindow.TabType tabtype)
    {
    }

    [Token(Token = "0x600A0F3")]
    [Address(RVA = "0x6306C0", Offset = "0x62F4C0", VA = "0x106306C0")]
    private void ResponseCallback(WWWResult www)
    {
    }

    [Token(Token = "0x600A0F4")]
    [Address(RVA = "0x62F560", Offset = "0x62E360", VA = "0x1062F560")]
    private void ConnectionSucceeded(HashSet<string> itemAvailable)
    {
    }

    [Token(Token = "0x600A0F5")]
    [Address(RVA = "0x62FB90", Offset = "0x62E990", VA = "0x1062FB90")]
    private List<ArtifactParam> GetVisibleItems(
      List<ArtifactParam> allItems,
      HashSet<string> availables)
    {
      return (List<ArtifactParam>) null;
    }

    [Token(Token = "0x600A0F6")]
    [Address(RVA = "0x62FF20", Offset = "0x62ED20", VA = "0x1062FF20")]
    private void RefreshPage()
    {
    }

    [Token(Token = "0x600A0F7")]
    [Address(RVA = "0x62F330", Offset = "0x62E130", VA = "0x1062F330")]
    private void ClearAndDisableAll(List<GameObject> list)
    {
    }

    [Token(Token = "0x600A0F8")]
    [Address(RVA = "0x6303E0", Offset = "0x62F1E0", VA = "0x106303E0")]
    private DataSource RemoveBindedDataIfExists(GameObject obj) => (DataSource) null;

    [Token(Token = "0x600A0F9")]
    [Address(RVA = "0x630AB0", Offset = "0x62F8B0", VA = "0x10630AB0")]
    private void SetItemInteractable(GameObject obj, bool isInteractable)
    {
    }

    [Token(Token = "0x600A0FA")]
    [Address(RVA = "0x62FEC0", Offset = "0x62ECC0", VA = "0x1062FEC0")]
    private void NextPage()
    {
    }

    [Token(Token = "0x600A0FB")]
    [Address(RVA = "0x62FEF0", Offset = "0x62ECF0", VA = "0x1062FEF0")]
    private void PrevPage()
    {
    }

    [Token(Token = "0x600A0FC")]
    [Address(RVA = "0x62EFC0", Offset = "0x62DDC0", VA = "0x1062EFC0")]
    private void ChangeEnabledArrowButtons(int index, int max)
    {
    }

    [Token(Token = "0x600A0FD")]
    [Address(RVA = "0x62F970", Offset = "0x62E770", VA = "0x1062F970")]
    private int GetCellCount() => new int();

    [Token(Token = "0x600A0FE")]
    [Address(RVA = "0x630F00", Offset = "0x62FD00", VA = "0x10630F00")]
    public GalleryArtifactListWindow()
    {
    }

    [Token(Token = "0x20024B0")]
    public enum TabType
    {
      [Token(Token = "0x400A771")] Arms,
      [Token(Token = "0x400A772")] Armor,
      [Token(Token = "0x400A773")] Accessory,
    }

    [Token(Token = "0x20024B1")]
    private class TabInfo
    {
      [Token(Token = "0x400A774")]
      [FieldOffset(Offset = "0x8")]
      public int CurrentPage;
      [Token(Token = "0x400A775")]
      [FieldOffset(Offset = "0xC")]
      public int TotalPage;
      [Token(Token = "0x400A776")]
      [FieldOffset(Offset = "0x10")]
      public List<ArtifactParam> AllItems;
      [Token(Token = "0x400A777")]
      [FieldOffset(Offset = "0x14")]
      public HashSet<string> AllAvailableItems;
      [Token(Token = "0x400A778")]
      [FieldOffset(Offset = "0x18")]
      public GallerySettings Setting;
      [Token(Token = "0x400A779")]
      [FieldOffset(Offset = "0x1C")]
      public bool IsDirty;

      [Token(Token = "0x600A0FF")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public TabInfo()
      {
      }
    }

    [Token(Token = "0x20024B2")]
    public class JSON_Body
    {
      [Token(Token = "0x400A77A")]
      [FieldOffset(Offset = "0x8")]
      public string[] items;

      [Token(Token = "0x600A100")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_Body()
      {
      }
    }
  }
}
