// Decompiled with JetBrains decompiler
// Type: SRPG.UnitListV2
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
  [Token(Token = "0x2002CA4")]
  [FlowNode.Pin(2, "Unit Unlocked", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(1, "Unit Selected", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(100, "Refresh", FlowNode.PinTypes.Input, 100)]
  [AddComponentMenu("UI/リスト/ユニット")]
  public class UnitListV2 : SRPG_FixedList, IFlowInterface, ISortableList
  {
    [Token(Token = "0x400DD2D")]
    [FieldOffset(Offset = "0x64")]
    public UnitListV2.ItemTypes ItemType;
    [Token(Token = "0x400DD2E")]
    [FieldOffset(Offset = "0x68")]
    public UnitListV2.UnitSelectEvent OnUnitSelect;
    [Token(Token = "0x400DD2F")]
    [FieldOffset(Offset = "0x6C")]
    public Transform ItemLayoutParent;
    [Token(Token = "0x400DD30")]
    [FieldOffset(Offset = "0x70")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400DD31")]
    [FieldOffset(Offset = "0x74")]
    public GameObject PieceTemplate;
    [Token(Token = "0x400DD32")]
    [FieldOffset(Offset = "0x78")]
    public Pulldown SortFilter;
    [Token(Token = "0x400DD33")]
    [FieldOffset(Offset = "0x7C")]
    public GameObject UnitSortFilterButton;
    [Token(Token = "0x400DD34")]
    [FieldOffset(Offset = "0x80")]
    public GameObject AscendingIcon;
    [Token(Token = "0x400DD35")]
    [FieldOffset(Offset = "0x84")]
    public GameObject DescendingIcon;
    [Token(Token = "0x400DD36")]
    [FieldOffset(Offset = "0x88")]
    public List<Toggle> UnitToggle;
    [Token(Token = "0x400DD37")]
    [FieldOffset(Offset = "0x8C")]
    public bool IncludeShujinko;
    [Token(Token = "0x400DD38")]
    [FieldOffset(Offset = "0x8D")]
    public bool IsSorting;
    [Token(Token = "0x400DD39")]
    [FieldOffset(Offset = "0x8E")]
    public bool IsEnhanceEquipment;
    [Token(Token = "0x400DD3A")]
    [FieldOffset(Offset = "0x90")]
    public GameObject UnitBadge;
    [Token(Token = "0x400DD3B")]
    [FieldOffset(Offset = "0x94")]
    public GameObject UnitUnlockBadge;
    [Token(Token = "0x400DD3C")]
    [FieldOffset(Offset = "0x98")]
    private bool mPrevUnitBadgeState;
    [Token(Token = "0x400DD3D")]
    [FieldOffset(Offset = "0x99")]
    private bool mPrevUnlockBadgeState;
    [Token(Token = "0x400DD3E")]
    [FieldOffset(Offset = "0x9C")]
    protected GameUtility.UnitSortModes mUnitSortMode;
    [Token(Token = "0x400DD3F")]
    [FieldOffset(Offset = "0xA0")]
    protected string[] mUnitFilter;
    [Token(Token = "0x400DD40")]
    [FieldOffset(Offset = "0xA4")]
    protected bool mReverse;
    [Token(Token = "0x400DD41")]
    [FieldOffset(Offset = "0xA8")]
    public GameObject NoMatchingUnit;
    [Token(Token = "0x400DD42")]
    [FieldOffset(Offset = "0xAC")]
    public GameObject SortMode;
    [Token(Token = "0x400DD43")]
    [FieldOffset(Offset = "0xB0")]
    public Text SortModeCaption;
    [Token(Token = "0x400DD44")]
    [FieldOffset(Offset = "0xB4")]
    private UnitListV2.ItemTypes mLastItemType;
    [Token(Token = "0x400DD45")]
    [FieldOffset(Offset = "0xB8")]
    protected int[] mSortValues;
    [Token(Token = "0x400DD46")]
    [FieldOffset(Offset = "0xC0")]
    private long mSelectUnitUniqueID;
    [Token(Token = "0x400DD47")]
    [FieldOffset(Offset = "0xC8")]
    private int mSelectTabIndex;
    [Token(Token = "0x400DD48")]
    [FieldOffset(Offset = "0xCC")]
    public GameObject TabParentObject;
    [Token(Token = "0x400DD49")]
    [FieldOffset(Offset = "0xD0")]
    public SRPG_Button CloseButton;
    [Token(Token = "0x400DD4A")]
    [FieldOffset(Offset = "0xD4")]
    public GameObject TitleObject;
    [Token(Token = "0x400DD4B")]
    [FieldOffset(Offset = "0xD8")]
    public SRPG_Button SortButton;
    [Token(Token = "0x400DD4C")]
    [FieldOffset(Offset = "0xDC")]
    public SRPG_Button FilterButton;
    [Token(Token = "0x400DD4D")]
    [FieldOffset(Offset = "0xE0")]
    public SRPG_Button PieceButton;
    [Token(Token = "0x400DD4E")]
    [FieldOffset(Offset = "0xE4")]
    public GameObject HelpButton;
    [Token(Token = "0x400DD4F")]
    [FieldOffset(Offset = "0xE8")]
    public GameObject SelectTemplate;
    [Token(Token = "0x400DD50")]
    [FieldOffset(Offset = "0xEC")]
    public SRPG_Button RemoveTemplate;
    [Token(Token = "0x400DD51")]
    [FieldOffset(Offset = "0xF0")]
    public GameObject SelectTowerTemplate;
    [Token(Token = "0x400DD52")]
    [FieldOffset(Offset = "0xF4")]
    public SRPG_Button RemoveTowerTemplate;
    [Token(Token = "0x400DD53")]
    [FieldOffset(Offset = "0xF8")]
    public UnitPickerButtonChanger m_SortChanger;
    [Token(Token = "0x400DD54")]
    [FieldOffset(Offset = "0xFC")]
    public UnitPickerButtonChanger m_FilterChanger;
    [Token(Token = "0x400DD55")]
    [FieldOffset(Offset = "0x0")]
    public static readonly string UNIT_SORT_PATH;
    [Token(Token = "0x400DD56")]
    [FieldOffset(Offset = "0x4")]
    public static readonly string UNIT_FILTER_PATH;
    [Token(Token = "0x400DD57")]
    [FieldOffset(Offset = "0x100")]
    private GameObject mSortWindow;
    [Token(Token = "0x400DD58")]
    [FieldOffset(Offset = "0x104")]
    private UnitPickerSort mUnitPickerSort;
    [Token(Token = "0x400DD59")]
    [FieldOffset(Offset = "0x108")]
    private GameObject mFilterWindow;
    [Token(Token = "0x400DD5A")]
    [FieldOffset(Offset = "0x10C")]
    private UnitPickerFilter mUnitPickerFilter;
    [Token(Token = "0x400DD5B")]
    [FieldOffset(Offset = "0x110")]
    private UnitListV2.ViewMode mSelectViewMode;
    [Token(Token = "0x400DD5C")]
    [FieldOffset(Offset = "0x114")]
    public UnitListV2.ItemSelectEvents OnItemSelectAction;
    [Token(Token = "0x400DD5D")]
    [FieldOffset(Offset = "0x118")]
    public UnitListV2.CommonEvents OnCloseEvent;
    [Token(Token = "0x400DD5E")]
    [FieldOffset(Offset = "0x11C")]
    public UnitListV2.CommonEvents OnRemoveEvent;
    [Token(Token = "0x400DD5F")]
    [FieldOffset(Offset = "0x120")]
    private List<UnitData> mUnitDatas;
    [Token(Token = "0x400DD60")]
    [FieldOffset(Offset = "0x124")]
    private PartyEditData mCurrentParty;
    [Token(Token = "0x400DD61")]
    [FieldOffset(Offset = "0x128")]
    private QuestParam mCurrentQuest;
    [Token(Token = "0x400DD62")]
    [FieldOffset(Offset = "0x12C")]
    private bool mUseQuestInfo;
    [Token(Token = "0x400DD63")]
    [FieldOffset(Offset = "0x130")]
    private int mSelectedSlotIndex;
    [Token(Token = "0x400DD64")]
    [FieldOffset(Offset = "0x134")]
    public string MenuID;
    [Token(Token = "0x400DD65")]
    [FieldOffset(Offset = "0x138")]
    public Toggle SelectableToggle;
    [Token(Token = "0x400DD66")]
    [FieldOffset(Offset = "0x13C")]
    public RectTransform[] ChosenUnitBadges;
    [Token(Token = "0x400DD67")]
    [FieldOffset(Offset = "0x140")]
    public RectTransform[] ChosenUnitBadgesTower;
    [Token(Token = "0x400DD68")]
    [FieldOffset(Offset = "0x144")]
    public RectTransform UnitHilit;
    [Token(Token = "0x400DD69")]
    [FieldOffset(Offset = "0x148")]
    public RectTransform UnitHilitTower;
    [Token(Token = "0x400DD6A")]
    [FieldOffset(Offset = "0x14C")]
    private List<GameObject> mExtraItemList;
    [Token(Token = "0x400DD6B")]
    [FieldOffset(Offset = "0x150")]
    private bool mIsHeroOnly;
    [Token(Token = "0x400DD6C")]
    [FieldOffset(Offset = "0x154")]
    public GameObject mBackToHome;
    [Token(Token = "0x400DD6D")]
    [FieldOffset(Offset = "0x158")]
    private bool mIsSetRefresh;

    [Token(Token = "0x17001B3D")]
    public bool UseQuestInfo
    {
      [Token(Token = "0x600CF27"), Address(RVA = "0x9AD930", Offset = "0x9AC730", VA = "0x109AD930")] get
      {
        return new bool();
      }
      [Token(Token = "0x600CF28"), Address(RVA = "0x9AD980", Offset = "0x9AC780", VA = "0x109AD980")] set
      {
      }
    }

    [Token(Token = "0x17001B3E")]
    public int SelectedSlotIndex
    {
      [Token(Token = "0x600CF29"), Address(RVA = "0x9AD960", Offset = "0x9AC760", VA = "0x109AD960")] set
      {
      }
    }

    [Token(Token = "0x17001B3F")]
    public bool IsHeroOnly
    {
      [Token(Token = "0x600CF2A"), Address(RVA = "0x9AD8A0", Offset = "0x9AC6A0", VA = "0x109AD8A0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600CF2B"), Address(RVA = "0x9AD940", Offset = "0x9AC740", VA = "0x109AD940")] set
      {
      }
    }

    [Token(Token = "0x600CF2C")]
    [Address(RVA = "0x9A6DC0", Offset = "0x9A5BC0", VA = "0x109A6DC0", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x17001B40")]
    public override RectTransform ListParent
    {
      [Token(Token = "0x600CF2D"), Address(RVA = "0x9AD8B0", Offset = "0x9AC6B0", VA = "0x109AD8B0", Slot = "17")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x600CF2E")]
    [Address(RVA = "0x9AB810", Offset = "0x9AA610", VA = "0x109AB810", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600CF2F")]
    [Address(RVA = "0x9AD4E0", Offset = "0x9AC2E0", VA = "0x109AD4E0", Slot = "20")]
    protected override void Update()
    {
    }

    [Token(Token = "0x600CF30")]
    [Address(RVA = "0x9A88F0", Offset = "0x9A76F0", VA = "0x109A88F0", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600CF31")]
    [Address(RVA = "0x9A6D80", Offset = "0x9A5B80", VA = "0x109A6D80", Slot = "32")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600CF32")]
    [Address(RVA = "0x9A8DE0", Offset = "0x9A7BE0", VA = "0x109A8DE0")]
    private void OnSortModeChange(int index)
    {
    }

    [Token(Token = "0x600CF33")]
    [Address(RVA = "0x9A91C0", Offset = "0x9A7FC0", VA = "0x109A91C0")]
    public void RefreshData()
    {
    }

    [Token(Token = "0x600CF34")]
    [Address(RVA = "0x9A72C0", Offset = "0x9A60C0", VA = "0x109A72C0", Slot = "22")]
    protected override GameObject CreateItem() => (GameObject) null;

    [Token(Token = "0x600CF35")]
    [Address(RVA = "0x9A7230", Offset = "0x9A6030", VA = "0x109A7230", Slot = "23")]
    protected override GameObject CreateItem(int index) => (GameObject) null;

    [Token(Token = "0x600CF36")]
    [Address(RVA = "0x9AA490", Offset = "0x9A9290", VA = "0x109AA490", Slot = "34")]
    protected virtual void RefreshUnit(bool clear)
    {
    }

    [Token(Token = "0x600CF37")]
    [Address(RVA = "0x4558A0", Offset = "0x4546A0", VA = "0x104558A0")]
    private static bool GetValue(string str, string key, ref string value) => new bool();

    [Token(Token = "0x600CF38")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "21")]
    protected override void LateUpdate()
    {
    }

    [Token(Token = "0x600CF39")]
    [Address(RVA = "0x9A7AA0", Offset = "0x9A68A0", VA = "0x109A7AA0")]
    public static void FilterUnits(List<UnitData> units, List<int> sortValues, string[] filter)
    {
    }

    [Token(Token = "0x600CF3A")]
    [Address(RVA = "0x9A7330", Offset = "0x9A6130", VA = "0x109A7330")]
    public static void FilterUnitsRevert(
      List<UnitData> units,
      List<int> sortValues,
      string[] filter)
    {
    }

    [Token(Token = "0x600CF3B")]
    [Address(RVA = "0x9A8F80", Offset = "0x9A7D80", VA = "0x109A8F80", Slot = "24")]
    protected override void OnUpdateItem(GameObject go, int index)
    {
    }

    [Token(Token = "0x600CF3C")]
    [Address(RVA = "0x9AA070", Offset = "0x9A8E70", VA = "0x109AA070")]
    private void RefreshPieceUnit(bool clear)
    {
    }

    [Token(Token = "0x600CF3D")]
    [Address(RVA = "0x9A89F0", Offset = "0x9A77F0", VA = "0x109A89F0", Slot = "25")]
    protected override void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x600CF3E")]
    [Address(RVA = "0x9A8CD0", Offset = "0x9A7AD0", VA = "0x109A8CD0")]
    private void OnSelectUnit(GameObject go)
    {
    }

    [Token(Token = "0x600CF3F")]
    [Address(RVA = "0x9A8C40", Offset = "0x9A7A40", VA = "0x109A8C40")]
    private void OnSelectPieceUnit(GameObject go)
    {
    }

    [Token(Token = "0x600CF40")]
    [Address(RVA = "0x9A87F0", Offset = "0x9A75F0", VA = "0x109A87F0")]
    private void OnChangedToggle(int index)
    {
    }

    [Token(Token = "0x600CF41")]
    [Address(RVA = "0x9AB640", Offset = "0x9AA440", VA = "0x109AB640", Slot = "33")]
    public void SetSortMethod(SortMenuData sortMenuData)
    {
    }

    [Token(Token = "0x600CF42")]
    [Address(RVA = "0x9AB270", Offset = "0x9AA070", VA = "0x109AB270")]
    public void SetSortMethod(
      string method,
      bool ascending,
      string[] filters,
      bool is_ignore_element)
    {
    }

    [Token(Token = "0x600CF43")]
    [Address(RVA = "0x9ACAE0", Offset = "0x9AB8E0", VA = "0x109ACAE0")]
    public static string[] UpdateFilterElement(int index, string[] filter) => (string[]) null;

    [Token(Token = "0x600CF44")]
    [Address(RVA = "0x9AB6F0", Offset = "0x9AA4F0", VA = "0x109AB6F0")]
    public void SetViewMode(UnitListV2.ViewMode value)
    {
    }

    [Token(Token = "0x600CF45")]
    [Address(RVA = "0x9ACFD0", Offset = "0x9ABDD0", VA = "0x109ACFD0")]
    public void UpdateViewMode()
    {
    }

    [Token(Token = "0x600CF46")]
    [Address(RVA = "0x9AD000", Offset = "0x9ABE00", VA = "0x109AD000")]
    public void UpdateViewMode(UnitListV2.ViewMode mode)
    {
    }

    [Token(Token = "0x600CF47")]
    [Address(RVA = "0x9AB0B0", Offset = "0x9A9EB0", VA = "0x109AB0B0")]
    private void RefreshViewPieceList()
    {
    }

    [Token(Token = "0x600CF48")]
    [Address(RVA = "0x9AB1D0", Offset = "0x9A9FD0", VA = "0x109AB1D0")]
    private void RefreshViewUnitList()
    {
    }

    [Token(Token = "0x600CF49")]
    [Address(RVA = "0x9AB1B0", Offset = "0x9A9FB0", VA = "0x109AB1B0")]
    private void RefreshViewSelectList()
    {
    }

    [Token(Token = "0x600CF4A")]
    [Address(RVA = "0x9A88C0", Offset = "0x9A76C0", VA = "0x109A88C0")]
    private void OnCloseButton(SRPG_Button button)
    {
    }

    [Token(Token = "0x600CF4B")]
    [Address(RVA = "0x9A8F00", Offset = "0x9A7D00", VA = "0x109A8F00")]
    private void OnUnitSortOpen()
    {
    }

    [Token(Token = "0x600CF4C")]
    [Address(RVA = "0x9A8E80", Offset = "0x9A7C80", VA = "0x109A8E80")]
    private void OnUnitFilterOpen()
    {
    }

    [Token(Token = "0x600CF4D")]
    [Address(RVA = "0x9AB7E0", Offset = "0x9AA5E0", VA = "0x109AB7E0")]
    private void SetupSortMethod(string method, bool ascending)
    {
    }

    [Token(Token = "0x600CF4E")]
    [Address(RVA = "0x9AB710", Offset = "0x9AA510", VA = "0x109AB710")]
    private void SetupFilter(string[] filters)
    {
    }

    [Token(Token = "0x600CF4F")]
    [Address(RVA = "0x9A9230", Offset = "0x9A8030", VA = "0x109A9230", Slot = "26")]
    protected override void RefreshItems()
    {
    }

    [Token(Token = "0x600CF50")]
    [Address(RVA = "0x9A86D0", Offset = "0x9A74D0", VA = "0x109A86D0")]
    private bool IsSetRemoveObject(int slot) => new bool();

    [Token(Token = "0x600CF51")]
    [Address(RVA = "0x9AB670", Offset = "0x9AA470", VA = "0x109AB670")]
    public void SetUnitList(UnitData[] units)
    {
    }

    [Token(Token = "0x600CF52")]
    [Address(RVA = "0x9AB200", Offset = "0x9AA000", VA = "0x109AB200")]
    public void SetPartyData(PartyEditData party)
    {
    }

    [Token(Token = "0x600CF53")]
    [Address(RVA = "0x9AB220", Offset = "0x9AA020", VA = "0x109AB220")]
    public void SetQuestData(QuestParam quest)
    {
    }

    [Token(Token = "0x600CF54")]
    [Address(RVA = "0x9A8BD0", Offset = "0x9A79D0", VA = "0x109A8BD0")]
    public void OnRemoveUnitSelect(SRPG_Button button)
    {
    }

    [Token(Token = "0x600CF55")]
    [Address(RVA = "0x9A91A0", Offset = "0x9A7FA0", VA = "0x109A91A0")]
    private void OnValueChanged(bool value)
    {
    }

    [Token(Token = "0x600CF56")]
    [Address(RVA = "0x9A8720", Offset = "0x9A7520", VA = "0x109A8720")]
    private void MoveToOrigin(GameObject go)
    {
    }

    [Token(Token = "0x600CF57")]
    [Address(RVA = "0x9AB240", Offset = "0x9AA040", VA = "0x109AB240")]
    public void SetRefresh()
    {
    }

    [Token(Token = "0x600CF58")]
    [Address(RVA = "0x9A8370", Offset = "0x9A7170", VA = "0x109A8370")]
    private int GetSortModeValue(UnitData unit, GameUtility.UnitSortModes mode) => new int();

    [Token(Token = "0x600CF59")]
    [Address(RVA = "0x9A82E0", Offset = "0x9A70E0", VA = "0x109A82E0")]
    public string GetFilterInfo() => (string) null;

    [Token(Token = "0x600CF5A")]
    [Address(RVA = "0x9AD770", Offset = "0x9AC570", VA = "0x109AD770")]
    public UnitListV2()
    {
    }

    [Token(Token = "0x600CF5B")]
    [Address(RVA = "0x9AD6F0", Offset = "0x9AC4F0", VA = "0x109AD6F0")]
    static UnitListV2()
    {
    }

    [Token(Token = "0x2002CA5")]
    public enum ItemTypes
    {
      [Token(Token = "0x400DD6F")] PlayerUnits,
      [Token(Token = "0x400DD70")] PieceUnits,
    }

    [Token(Token = "0x2002CA6")]
    public enum PartyBadge
    {
      [Token(Token = "0x400DD72")] Main0,
      [Token(Token = "0x400DD73")] Main1,
      [Token(Token = "0x400DD74")] Main2,
      [Token(Token = "0x400DD75")] Main3,
      [Token(Token = "0x400DD76")] Sub0,
      [Token(Token = "0x400DD77")] Sub1,
      [Token(Token = "0x400DD78")] Max,
    }

    [Token(Token = "0x2002CA7")]
    public delegate void UnitSelectEvent(long uniqueID);

    [Token(Token = "0x2002CA8")]
    public delegate void ItemSelectEvents(GameObject go);

    [Token(Token = "0x2002CA9")]
    public delegate void CommonEvents(SRPG_Button button);

    [Token(Token = "0x2002CAA")]
    public enum ViewMode
    {
      [Token(Token = "0x400DD7A")] UNITLIST,
      [Token(Token = "0x400DD7B")] SELECTLIST,
      [Token(Token = "0x400DD7C")] TOWERSELECTLIST,
      [Token(Token = "0x400DD7D")] PIECELIST,
    }
  }
}
