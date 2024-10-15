// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002010")]
  [FlowNode.Pin(20, "Clear Selection", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(101, "Detail Selected", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(200, "Refresh", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(201, "Update Selection", FlowNode.PinTypes.Input, 201)]
  [AddComponentMenu("UI/ArtifactList")]
  [FlowNode.Pin(100, "Selected", FlowNode.PinTypes.Output, 100)]
  public class ArtifactList : UIBehaviour, IFlowInterface, ISortableList
  {
    [Token(Token = "0x40088D9")]
    private const int PIN_ID_CLEAR_SELECTION = 20;
    [Token(Token = "0x40088DA")]
    private const int PIN_ID_SELECTED = 100;
    [Token(Token = "0x40088DB")]
    private const int PIN_ID_DETAIL_SELECTED = 101;
    [Token(Token = "0x40088DC")]
    private const int PIN_ID_REFRESH = 200;
    [Token(Token = "0x40088DD")]
    private const int PIN_ID_UPDATE_SELECTION = 201;
    [Token(Token = "0x40088DE")]
    [FieldOffset(Offset = "0xC")]
    public ArtifactList.ListSource Source;
    [Token(Token = "0x40088DF")]
    [FieldOffset(Offset = "0x10")]
    [BitMask]
    public ArtifactList.KakeraHideFlags KakeraFlags;
    [Token(Token = "0x40088E0")]
    [FieldOffset(Offset = "0x14")]
    public GameObject ListItem;
    [Token(Token = "0x40088E1")]
    [FieldOffset(Offset = "0x18")]
    private int mPage;
    [Token(Token = "0x40088E2")]
    [FieldOffset(Offset = "0x1C")]
    private int mMaxPages;
    [Token(Token = "0x40088E3")]
    [FieldOffset(Offset = "0x20")]
    private int mPageSize;
    [Token(Token = "0x40088E4")]
    [FieldOffset(Offset = "0x24")]
    private bool mStarted;
    [Token(Token = "0x40088E5")]
    [FieldOffset(Offset = "0x25")]
    private bool mShouldRefresh;
    [Token(Token = "0x40088E6")]
    [FieldOffset(Offset = "0x26")]
    private bool mInvokeSelChange;
    [Token(Token = "0x40088E7")]
    [FieldOffset(Offset = "0x28")]
    public Scrollbar PageScrollBar;
    [Token(Token = "0x40088E8")]
    [FieldOffset(Offset = "0x2C")]
    public Text PageIndex;
    [Token(Token = "0x40088E9")]
    [FieldOffset(Offset = "0x30")]
    public Text PageIndexMax;
    [Token(Token = "0x40088EA")]
    [FieldOffset(Offset = "0x34")]
    public Button ForwardButton;
    [Token(Token = "0x40088EB")]
    [FieldOffset(Offset = "0x38")]
    public Button BackButton;
    [Token(Token = "0x40088EC")]
    [FieldOffset(Offset = "0x3C")]
    public Button ApplyButton;
    [Token(Token = "0x40088ED")]
    [FieldOffset(Offset = "0x40")]
    public bool UseGridLayout;
    [Token(Token = "0x40088EE")]
    [FieldOffset(Offset = "0x44")]
    public float CellWidth;
    [Token(Token = "0x40088EF")]
    [FieldOffset(Offset = "0x48")]
    public float CellHeight;
    [Token(Token = "0x40088F0")]
    [FieldOffset(Offset = "0x4C")]
    public float PaddingX;
    [Token(Token = "0x40088F1")]
    [FieldOffset(Offset = "0x50")]
    public float PaddingY;
    [Token(Token = "0x40088F2")]
    [FieldOffset(Offset = "0x54")]
    public float SpacingX;
    [Token(Token = "0x40088F3")]
    [FieldOffset(Offset = "0x58")]
    public float SpacingY;
    [Token(Token = "0x40088F4")]
    [FieldOffset(Offset = "0x5C")]
    public bool TruncateX;
    [Token(Token = "0x40088F5")]
    [FieldOffset(Offset = "0x5D")]
    public bool TruncateY;
    [Token(Token = "0x40088F6")]
    [FieldOffset(Offset = "0x60")]
    public string SelectionState;
    [Token(Token = "0x40088F7")]
    [FieldOffset(Offset = "0x64")]
    public int Item_Normal;
    [Token(Token = "0x40088F8")]
    [FieldOffset(Offset = "0x68")]
    public int Item_Selected;
    [Token(Token = "0x40088F9")]
    [FieldOffset(Offset = "0x6C")]
    public int Item_Disabled;
    [Token(Token = "0x40088FA")]
    [FieldOffset(Offset = "0x70")]
    public Text NumSelection;
    [Token(Token = "0x40088FB")]
    [FieldOffset(Offset = "0x74")]
    public int MaxSelection;
    [Token(Token = "0x40088FC")]
    [FieldOffset(Offset = "0x78")]
    public bool ShowSelection;
    [Token(Token = "0x40088FD")]
    [FieldOffset(Offset = "0x79")]
    public bool OnlyEquippable;
    [Token(Token = "0x40088FE")]
    [FieldOffset(Offset = "0x7C")]
    public UnitData TestOwner;
    [Token(Token = "0x40088FF")]
    [FieldOffset(Offset = "0x80")]
    public GameObject[] ExtraItems;
    [Token(Token = "0x4008900")]
    [FieldOffset(Offset = "0x84")]
    public Text TotalDecomposeCost;
    [Token(Token = "0x4008901")]
    [FieldOffset(Offset = "0x88")]
    public GameObject ArtifactDetail;
    [Token(Token = "0x4008902")]
    [FieldOffset(Offset = "0x8C")]
    public GameObject ArtifactDetailRef;
    [Token(Token = "0x4008903")]
    [FieldOffset(Offset = "0x90")]
    public GameObject EmptyMessage;
    [Token(Token = "0x4008904")]
    [FieldOffset(Offset = "0x94")]
    public Text TotalSellCost;
    [Token(Token = "0x4008905")]
    [FieldOffset(Offset = "0x98")]
    public bool ExcludeEquiped;
    [Token(Token = "0x4008906")]
    [FieldOffset(Offset = "0x99")]
    public bool KakeraCreateOnly;
    [Token(Token = "0x4008907")]
    [FieldOffset(Offset = "0x9C")]
    public ArtifactList.SlotExcludeEquipType ExcludeEquipType;
    [Token(Token = "0x4008908")]
    [FieldOffset(Offset = "0xA0")]
    public List<string> ExcludeEquipTypeIname;
    [Token(Token = "0x4008909")]
    [FieldOffset(Offset = "0xA4")]
    private List<GameObject> mItems;
    [Token(Token = "0x400890A")]
    [FieldOffset(Offset = "0xA8")]
    private System.Type mDataType;
    [Token(Token = "0x400890B")]
    [FieldOffset(Offset = "0xAC")]
    private bool mFocusSelection;
    [Token(Token = "0x400890C")]
    [FieldOffset(Offset = "0xB0")]
    private object[] mData;
    [Token(Token = "0x400890D")]
    [FieldOffset(Offset = "0xB4")]
    private BaseStatus mTmpVal0;
    [Token(Token = "0x400890E")]
    [FieldOffset(Offset = "0xB8")]
    private BaseStatus mTmpVal1;
    [Token(Token = "0x400890F")]
    [FieldOffset(Offset = "0xBC")]
    private int[] mTmpSortVal;
    [Token(Token = "0x4008910")]
    [FieldOffset(Offset = "0xC0")]
    private string mSortMethod;
    [Token(Token = "0x4008911")]
    [FieldOffset(Offset = "0xC4")]
    private bool mDescending;
    [Token(Token = "0x4008912")]
    [FieldOffset(Offset = "0xC5")]
    private bool mEmptyMessageChanged;
    [Token(Token = "0x4008913")]
    [FieldOffset(Offset = "0xC8")]
    private string mNameSearchString;
    [Token(Token = "0x4008914")]
    [FieldOffset(Offset = "0xCC")]
    private SearchUtility.CONDITIONS mNameSearchType;
    [Token(Token = "0x4008915")]
    [FieldOffset(Offset = "0xD0")]
    private ArtifactData mBaseArtifactData;
    [Token(Token = "0x4008916")]
    [FieldOffset(Offset = "0xD4")]
    private bool mAutoSelected;
    [Token(Token = "0x4008917")]
    [FieldOffset(Offset = "0xD8")]
    private List<object> mSelection;
    [Token(Token = "0x4008918")]
    [FieldOffset(Offset = "0xDC")]
    public Scrollbar AbilityScrollBar;
    [Token(Token = "0x4008919")]
    [FieldOffset(Offset = "0xE0")]
    public ArtifactList.SelectionChangeEvent OnSelectionChange;
    [Token(Token = "0x400891A")]
    [FieldOffset(Offset = "0xE4")]
    public int MaxCellCount;
    [Token(Token = "0x400891B")]
    [FieldOffset(Offset = "0xE8")]
    private string[] mFiltersPriority;
    [Token(Token = "0x400891C")]
    [FieldOffset(Offset = "0xEC")]
    private string[] mFilters;

    [Token(Token = "0x6008490")]
    [Address(RVA = "0x454500", Offset = "0x453300", VA = "0x10454500", Slot = "17")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x170012EB")]
    public string NameSearchString
    {
      [Token(Token = "0x6008491"), Address(RVA = "0x45A300", Offset = "0x459100", VA = "0x1045A300")] set
      {
      }
    }

    [Token(Token = "0x170012EC")]
    public SearchUtility.CONDITIONS NameSearchType
    {
      [Token(Token = "0x6008492"), Address(RVA = "0x45A320", Offset = "0x459120", VA = "0x1045A320")] set
      {
      }
    }

    [Token(Token = "0x170012ED")]
    public ArtifactData BaseArtifactData
    {
      [Token(Token = "0x6008493"), Address(RVA = "0x45A2C0", Offset = "0x4590C0", VA = "0x1045A2C0")] set
      {
      }
    }

    [Token(Token = "0x170012EE")]
    public object[] Selection
    {
      [Token(Token = "0x6008494"), Address(RVA = "0x45A270", Offset = "0x459070", VA = "0x1045A270")] get
      {
        return (object[]) null;
      }
    }

    [Token(Token = "0x170012EF")]
    public bool HasSelection
    {
      [Token(Token = "0x6008495"), Address(RVA = "0x45A230", Offset = "0x459030", VA = "0x1045A230")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170012F0")]
    public int CellCount
    {
      [Token(Token = "0x6008496"), Address(RVA = "0x459F10", Offset = "0x458D10", VA = "0x10459F10")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6008497")]
    [Address(RVA = "0x455920", Offset = "0x454720", VA = "0x10455920")]
    public void GotoPreviousPage()
    {
    }

    [Token(Token = "0x6008498")]
    [Address(RVA = "0x4558F0", Offset = "0x4546F0", VA = "0x104558F0")]
    public void GotoNextPage()
    {
    }

    [Token(Token = "0x6008499")]
    [Address(RVA = "0x4575C0", Offset = "0x4563C0", VA = "0x104575C0", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600849A")]
    [Address(RVA = "0x456040", Offset = "0x454E40", VA = "0x10456040", Slot = "10")]
    protected override void OnRectTransformDimensionsChange()
    {
    }

    [Token(Token = "0x600849B")]
    [Address(RVA = "0x455D30", Offset = "0x454B30", VA = "0x10455D30")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x170012F1")]
    public string[] FiltersPriority
    {
      [Token(Token = "0x600849C"), Address(RVA = "0x45A220", Offset = "0x459020", VA = "0x1045A220")] get
      {
        return (string[]) null;
      }
      [Token(Token = "0x600849D"), Address(RVA = "0x45A2E0", Offset = "0x4590E0", VA = "0x1045A2E0")] set
      {
      }
    }

    [Token(Token = "0x600849E")]
    [Address(RVA = "0x456060", Offset = "0x454E60", VA = "0x10456060")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600849F")]
    [Address(RVA = "0x455950", Offset = "0x454750", VA = "0x10455950")]
    private bool IsCreatableArtifact(List<ArtifactData> artifactDataList) => new bool();

    [Token(Token = "0x60084A0")]
    [Address(RVA = "0x4545A0", Offset = "0x4533A0", VA = "0x104545A0")]
    private List<GenericBadge<ArtifactData>> AddCreatableInfo(List<ArtifactData> artifactDataList)
    {
      return (List<GenericBadge<ArtifactData>>) null;
    }

    [Token(Token = "0x60084A1")]
    [Address(RVA = "0x458570", Offset = "0x457370", VA = "0x10458570")]
    private void _Refresh()
    {
    }

    [Token(Token = "0x60084A2")]
    [Address(RVA = "0x454C20", Offset = "0x453A20", VA = "0x10454C20")]
    public static object[] FilterArtifacts(object[] artifacts, string[] filter) => (object[]) null;

    [Token(Token = "0x60084A3")]
    [Address(RVA = "0x4553C0", Offset = "0x4541C0", VA = "0x104553C0")]
    public static bool FilterKakeraArtifacts(ArtifactParam artifact, string[] filter) => new bool();

    [Token(Token = "0x60084A4")]
    [Address(RVA = "0x4558A0", Offset = "0x4546A0", VA = "0x104558A0")]
    private static bool GetValue(string str, string key, ref string value) => new bool();

    [Token(Token = "0x60084A5")]
    [Address(RVA = "0x456480", Offset = "0x455280", VA = "0x10456480")]
    private static bool ShouldShowKakera(
      ArtifactParam artifact,
      GameManager gm,
      ArtifactList.KakeraHideFlags flags)
    {
      return new bool();
    }

    [Token(Token = "0x60084A6")]
    [Address(RVA = "0x457CC0", Offset = "0x456AC0", VA = "0x10457CC0")]
    public void UpdateSelection()
    {
    }

    [Token(Token = "0x60084A7")]
    [Address(RVA = "0x4562F0", Offset = "0x4550F0", VA = "0x104562F0")]
    public void SetSelection(object[] sel, bool invoke, bool focus)
    {
    }

    [Token(Token = "0x60084A8")]
    [Address(RVA = "0x457790", Offset = "0x456590", VA = "0x10457790")]
    public void UpdatePage()
    {
    }

    [Token(Token = "0x60084A9")]
    [Address(RVA = "0x455D60", Offset = "0x454B60", VA = "0x10455D60")]
    private void OnItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x60084AA")]
    [Address(RVA = "0x456000", Offset = "0x454E00", VA = "0x10456000")]
    private void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x60084AB")]
    [Address(RVA = "0x4579F0", Offset = "0x4567F0", VA = "0x104579F0")]
    public void UpdateSelection(object selection)
    {
    }

    [Token(Token = "0x60084AC")]
    [Address(RVA = "0x454BB0", Offset = "0x4539B0", VA = "0x10454BB0")]
    public void ClearSelection()
    {
    }

    [Token(Token = "0x60084AD")]
    [Address(RVA = "0x4576F0", Offset = "0x4564F0", VA = "0x104576F0")]
    private void TriggerSelectionChange()
    {
    }

    [Token(Token = "0x60084AE")]
    [Address(RVA = "0x4576B0", Offset = "0x4564B0", VA = "0x104576B0")]
    private void TriggerDetailSelectionChange()
    {
    }

    [Token(Token = "0x60084AF")]
    [Address(RVA = "0x456590", Offset = "0x455390", VA = "0x10456590")]
    private void SortById(object[] artifacts)
    {
    }

    [Token(Token = "0x60084B0")]
    [Address(RVA = "0x456830", Offset = "0x455630", VA = "0x10456830")]
    private void SortByMember(object[] artifacts, string key)
    {
    }

    [Token(Token = "0x60084B1")]
    [Address(RVA = "0x456AC0", Offset = "0x4558C0", VA = "0x10456AC0")]
    private void SortByStatus(object[] artifacts, string key)
    {
    }

    [Token(Token = "0x60084B2")]
    [Address(RVA = "0x456F00", Offset = "0x455D00", VA = "0x10456F00")]
    private void SortByType(object[] artifacts, string key)
    {
    }

    [Token(Token = "0x60084B3")]
    [Address(RVA = "0x457360", Offset = "0x456160", VA = "0x10457360")]
    private void SortItems(object[] items, int[] values)
    {
    }

    [Token(Token = "0x60084B4")]
    [Address(RVA = "0x456420", Offset = "0x455220", VA = "0x10456420", Slot = "18")]
    public void SetSortMethod(SortMenuData sortMenuData)
    {
    }

    [Token(Token = "0x60084B5")]
    [Address(RVA = "0x455770", Offset = "0x454570", VA = "0x10455770")]
    private int GetIndexOf(ArtifactData artifact) => new int();

    [Token(Token = "0x60084B6")]
    [Address(RVA = "0x454A60", Offset = "0x453860", VA = "0x10454A60")]
    public bool CheckEndOfIndex(ArtifactData artifact) => new bool();

    [Token(Token = "0x60084B7")]
    [Address(RVA = "0x454B10", Offset = "0x453910", VA = "0x10454B10")]
    public bool CheckStartOfIndex(ArtifactData artifact) => new bool();

    [Token(Token = "0x60084B8")]
    [Address(RVA = "0x456070", Offset = "0x454E70", VA = "0x10456070")]
    public bool SelectBack(ArtifactData artifactData) => new bool();

    [Token(Token = "0x60084B9")]
    [Address(RVA = "0x4561A0", Offset = "0x454FA0", VA = "0x104561A0")]
    public bool SelectFoward(ArtifactData artifactData) => new bool();

    [Token(Token = "0x60084BA")]
    [Address(RVA = "0x455740", Offset = "0x454540", VA = "0x10455740")]
    public bool GetAutoSelected(bool autoReset = false) => new bool();

    [Token(Token = "0x60084BB")]
    [Address(RVA = "0x459CD0", Offset = "0x458AD0", VA = "0x10459CD0")]
    public ArtifactList()
    {
    }

    [Token(Token = "0x2002011")]
    public enum SlotExcludeEquipType
    {
      [Token(Token = "0x400891E")] Non,
      [Token(Token = "0x400891F")] Arms,
      [Token(Token = "0x4008920")] Armor,
      [Token(Token = "0x4008921")] Mix,
    }

    [Token(Token = "0x2002012")]
    public enum ListSource
    {
      [Token(Token = "0x4008923")] Normal,
      [Token(Token = "0x4008924")] Kakera,
      [Token(Token = "0x4008925")] Skill,
      [Token(Token = "0x4008926")] Stone,
      [Token(Token = "0x4008927")] Single,
      [Token(Token = "0x4008928")] Exchange,
    }

    [Token(Token = "0x2002013")]
    [Flags]
    public enum KakeraHideFlags
    {
      [Token(Token = "0x400892A")] LeastKakera = 1,
      [Token(Token = "0x400892B")] EnoughKakera = 2,
      [Token(Token = "0x400892C")] EnoughGold = 4,
    }

    [Token(Token = "0x2002014")]
    public delegate void SelectionChangeEvent(ArtifactList list);

    [Token(Token = "0x2002015")]
    private class SortData
    {
      [Token(Token = "0x400892D")]
      [FieldOffset(Offset = "0x8")]
      public object mArtifact;
      [Token(Token = "0x400892E")]
      [FieldOffset(Offset = "0xC")]
      public int mStatusValue;

      [Token(Token = "0x170012F2")]
      public ArtifactParam artifactParam
      {
        [Token(Token = "0x60084C0"), Address(RVA = "0x478590", Offset = "0x477390", VA = "0x10478590")] get
        {
          return (ArtifactParam) null;
        }
      }

      [Token(Token = "0x170012F3")]
      public ArtifactData artifactData
      {
        [Token(Token = "0x60084C1"), Address(RVA = "0x478520", Offset = "0x477320", VA = "0x10478520")] get
        {
          return (ArtifactData) null;
        }
      }

      [Token(Token = "0x170012F4")]
      public bool isArtifactData
      {
        [Token(Token = "0x60084C2"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
        {
          return new bool();
        }
        [Token(Token = "0x60084C3"), Address(RVA = "0x2C73C0", Offset = "0x2C61C0", VA = "0x102C73C0")] private set
        {
        }
      }

      [Token(Token = "0x60084C4")]
      [Address(RVA = "0x478470", Offset = "0x477270", VA = "0x10478470")]
      public SortData(object artifact, int statusValue)
      {
      }
    }
  }
}
