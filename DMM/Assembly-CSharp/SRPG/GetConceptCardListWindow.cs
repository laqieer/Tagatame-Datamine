// Decompiled with JetBrains decompiler
// Type: SRPG.GetConceptCardListWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002501")]
  [FlowNode.Pin(100, "念装詳細　開く", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/GetConceptCardListWindow")]
  [FlowNode.Pin(2, "名称検索", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "念装詳細　閉じ", FlowNode.PinTypes.Input, 1)]
  public class GetConceptCardListWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A91F")]
    private const int INPUT_CLOSED_DETAIL = 1;
    [Token(Token = "0x400A920")]
    private const int INPUT_NAME_SERACH = 2;
    [Token(Token = "0x400A921")]
    private const int OUTPUT_OPEN_DETAIL = 100;
    [Token(Token = "0x400A922")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject m_ListItemTemplate;
    [Token(Token = "0x400A923")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RectTransform m_ContentRoot;
    [Token(Token = "0x400A924")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Transform mNameBoxParent;
    [Token(Token = "0x400A925")]
    [FieldOffset(Offset = "0x18")]
    private List<ConceptCardData> mConceptCardDatas;
    [Token(Token = "0x400A926")]
    [FieldOffset(Offset = "0x1C")]
    private List<GameObject> m_ListItems;
    [Token(Token = "0x400A927")]
    [FieldOffset(Offset = "0x0")]
    private static string s_SelectedConceptCardID;
    [Token(Token = "0x400A928")]
    private const string NAME_SEARCH_WINDOW_UI_PATH = "UI/NameSearchBox/namesearch_select_conceptcard";
    [Token(Token = "0x400A929")]
    [FieldOffset(Offset = "0x20")]
    private NameSearchBox mNameSearchBox;
    [Token(Token = "0x400A92A")]
    [FieldOffset(Offset = "0x24")]
    private string mNameSearchInput;
    [Token(Token = "0x400A92B")]
    [FieldOffset(Offset = "0x28")]
    private SearchUtility.CONDITIONS mNameSearchType;

    [Token(Token = "0x600A289")]
    [Address(RVA = "0x64A620", Offset = "0x649420", VA = "0x1064A620")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A28A")]
    [Address(RVA = "0x64A780", Offset = "0x649580", VA = "0x1064A780")]
    private void ClearListItems()
    {
    }

    [Token(Token = "0x600A28B")]
    [Address(RVA = "0x64A900", Offset = "0x649700", VA = "0x1064A900")]
    private GameObject CreateListItem(ConceptCardData data) => (GameObject) null;

    [Token(Token = "0x600A28C")]
    [Address(RVA = "0x64B270", Offset = "0x64A070", VA = "0x1064B270")]
    public void Setup(List<ConceptCardData> data)
    {
    }

    [Token(Token = "0x600A28D")]
    [Address(RVA = "0x64AEF0", Offset = "0x649CF0", VA = "0x1064AEF0")]
    public void Refresh(List<ConceptCardData> data)
    {
    }

    [Token(Token = "0x600A28E")]
    [Address(RVA = "0x64B190", Offset = "0x649F90", VA = "0x1064B190")]
    public static void SetSelectedConceptCard(ConceptCardData data)
    {
    }

    [Token(Token = "0x600A28F")]
    [Address(RVA = "0x64ACC0", Offset = "0x649AC0", VA = "0x1064ACC0")]
    public static string GetSelectedConceptCard() => (string) null;

    [Token(Token = "0x600A290")]
    [Address(RVA = "0x64A890", Offset = "0x649690", VA = "0x1064A890")]
    public static void ClearSelectedConceptCard()
    {
    }

    [Token(Token = "0x600A291")]
    [Address(RVA = "0x64A530", Offset = "0x649330", VA = "0x1064A530", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A292")]
    [Address(RVA = "0x64AD00", Offset = "0x649B00", VA = "0x1064AD00")]
    private void OnListItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x600A293")]
    [Address(RVA = "0x64AAD0", Offset = "0x6498D0", VA = "0x1064AAD0")]
    public void CreateNameSearchBox()
    {
    }

    [Token(Token = "0x600A294")]
    [Address(RVA = "0x64ABF0", Offset = "0x6499F0", VA = "0x1064ABF0")]
    public void DeleteNameSearchBox()
    {
    }

    [Token(Token = "0x600A295")]
    [Address(RVA = "0x64B0B0", Offset = "0x649EB0", VA = "0x1064B0B0")]
    public void SetNameSearchInfo()
    {
    }

    [Token(Token = "0x600A296")]
    [Address(RVA = "0x64B2F0", Offset = "0x64A0F0", VA = "0x1064B2F0")]
    public GetConceptCardListWindow()
    {
    }

    [Token(Token = "0x600A297")]
    [Address(RVA = "0x64B2A0", Offset = "0x64A0A0", VA = "0x1064B2A0")]
    static GetConceptCardListWindow()
    {
    }
  }
}
