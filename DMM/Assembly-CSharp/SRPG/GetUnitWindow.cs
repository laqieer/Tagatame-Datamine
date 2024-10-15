// Decompiled with JetBrains decompiler
// Type: SRPG.GetUnitWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002517")]
  [FlowNode.Pin(100, "Refresh", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(110, "NameSearch", FlowNode.PinTypes.Input, 110)]
  [FlowNode.Pin(10, "Unit Detail", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(2, "Unit Unlocked", FlowNode.PinTypes.Output, 2)]
  [AddComponentMenu("UI/GetUnitWindow")]
  public class GetUnitWindow : SRPG_FixedList, IFlowInterface, ISortableList
  {
    [Token(Token = "0x400A983")]
    public const int PIN_INPUT_REFRESH = 100;
    [Token(Token = "0x400A984")]
    public const int PIN_INPUT_NAME_SEARCH = 110;
    [Token(Token = "0x400A985")]
    public const int PIN_OUTPUT_UNIT_UNLOCKED = 2;
    [Token(Token = "0x400A986")]
    public const int PIN_OUTPUT_UNIT_DETAIL = 10;
    [Token(Token = "0x400A987")]
    [FieldOffset(Offset = "0x64")]
    public GetUnitWindow.UnitSelectEvent OnUnitSelect;
    [Token(Token = "0x400A988")]
    [FieldOffset(Offset = "0x68")]
    public Transform ItemLayoutParent;
    [Token(Token = "0x400A989")]
    [FieldOffset(Offset = "0x6C")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400A98A")]
    [FieldOffset(Offset = "0x70")]
    public GameObject PieceTemplate;
    [Token(Token = "0x400A98B")]
    [FieldOffset(Offset = "0x74")]
    public Pulldown SortFilter;
    [Token(Token = "0x400A98C")]
    [FieldOffset(Offset = "0x78")]
    public GameObject UnitSortFilterButton;
    [Token(Token = "0x400A98D")]
    [FieldOffset(Offset = "0x7C")]
    public GameObject AscendingIcon;
    [Token(Token = "0x400A98E")]
    [FieldOffset(Offset = "0x80")]
    public GameObject DescendingIcon;
    [Token(Token = "0x400A98F")]
    [FieldOffset(Offset = "0x84")]
    public Transform mNameBoxParent;
    [Token(Token = "0x400A990")]
    [FieldOffset(Offset = "0x88")]
    private UnitSelectListData mUnitSelectListData;
    [Token(Token = "0x400A991")]
    [FieldOffset(Offset = "0x8C")]
    private UnitParam[] mCurrentUnitList;
    [Token(Token = "0x400A992")]
    private const string NAME_SEARCH_WINDOW_UI_PATH = "UI/NameSearchBox/namesearch_window_unit";
    [Token(Token = "0x400A993")]
    [FieldOffset(Offset = "0x90")]
    private NameSearchBox mNameSearchBox;
    [Token(Token = "0x400A994")]
    [FieldOffset(Offset = "0x94")]
    private string mNameSearchInput;
    [Token(Token = "0x400A995")]
    [FieldOffset(Offset = "0x98")]
    private SearchUtility.CONDITIONS mNameSearchType;

    [Token(Token = "0x600A2EF")]
    [Address(RVA = "0x64E2B0", Offset = "0x64D0B0", VA = "0x1064E2B0", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x170016BF")]
    public override RectTransform ListParent
    {
      [Token(Token = "0x600A2F0"), Address(RVA = "0x64FE40", Offset = "0x64EC40", VA = "0x1064FE40", Slot = "17")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x600A2F1")]
    [Address(RVA = "0x64FAD0", Offset = "0x64E8D0", VA = "0x1064FAD0", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600A2F2")]
    [Address(RVA = "0x64FDE0", Offset = "0x64EBE0", VA = "0x1064FDE0", Slot = "20")]
    protected override void Update()
    {
    }

    [Token(Token = "0x600A2F3")]
    [Address(RVA = "0x64E140", Offset = "0x64CF40", VA = "0x1064E140", Slot = "32")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A2F4")]
    [Address(RVA = "0x64F410", Offset = "0x64E210", VA = "0x1064F410")]
    private void OnSortModeChange(int index)
    {
    }

    [Token(Token = "0x600A2F5")]
    [Address(RVA = "0x64F430", Offset = "0x64E230", VA = "0x1064F430")]
    public void RefreshData()
    {
    }

    [Token(Token = "0x600A2F6")]
    [Address(RVA = "0x64E390", Offset = "0x64D190", VA = "0x1064E390", Slot = "22")]
    protected override GameObject CreateItem() => (GameObject) null;

    [Token(Token = "0x600A2F7")]
    [Address(RVA = "0x4558A0", Offset = "0x4546A0", VA = "0x104558A0")]
    private static bool GetValue(string str, string key, ref string value) => new bool();

    [Token(Token = "0x600A2F8")]
    [Address(RVA = "0x64E600", Offset = "0x64D400", VA = "0x1064E600")]
    public static void FilterUnits(List<UnitData> units, List<int> sortValues, string[] filter)
    {
    }

    [Token(Token = "0x600A2F9")]
    [Address(RVA = "0x64F440", Offset = "0x64E240", VA = "0x1064F440")]
    public void RefreshPieceUnit(bool clear, UnitSelectListData UnitSelectListData)
    {
    }

    [Token(Token = "0x600A2FA")]
    [Address(RVA = "0x64EE80", Offset = "0x64DC80", VA = "0x1064EE80", Slot = "25")]
    protected override void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x600A2FB")]
    [Address(RVA = "0x64F220", Offset = "0x64E020", VA = "0x1064F220")]
    private void OnSelectUnit(GameObject go)
    {
    }

    [Token(Token = "0x600A2FC")]
    [Address(RVA = "0x64EE90", Offset = "0x64DC90", VA = "0x1064EE90")]
    private void OnSelectPieceUnit(GameObject go)
    {
    }

    [Token(Token = "0x600A2FD")]
    [Address(RVA = "0x64F840", Offset = "0x64E640", VA = "0x1064F840", Slot = "33")]
    public void SetSortMethod(SortMenuData sortMenuData)
    {
    }

    [Token(Token = "0x600A2FE")]
    [Address(RVA = "0x64ED00", Offset = "0x64DB00", VA = "0x1064ED00")]
    public void OnHoldIcon(GameObject go)
    {
    }

    [Token(Token = "0x600A2FF")]
    [Address(RVA = "0x64E3F0", Offset = "0x64D1F0", VA = "0x1064E3F0")]
    public void CreateNameSearchBox()
    {
    }

    [Token(Token = "0x600A300")]
    [Address(RVA = "0x64E520", Offset = "0x64D320", VA = "0x1064E520")]
    public void DeleteNameSearchBox()
    {
    }

    [Token(Token = "0x600A301")]
    [Address(RVA = "0x64F700", Offset = "0x64E500", VA = "0x1064F700")]
    public void SetNameSearchInfo()
    {
    }

    [Token(Token = "0x600A302")]
    [Address(RVA = "0x64FDF0", Offset = "0x64EBF0", VA = "0x1064FDF0")]
    public GetUnitWindow()
    {
    }

    [Token(Token = "0x2002518")]
    public delegate void UnitSelectEvent(long uniqueID);
  }
}
