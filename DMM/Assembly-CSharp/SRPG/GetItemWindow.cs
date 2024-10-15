// Decompiled with JetBrains decompiler
// Type: SRPG.GetItemWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002502")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "名称検索", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "アイテム選択", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "アイテム更新", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("UI/GetItemWindow")]
  public class GetItemWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A92C")]
    public const int PIN_INPUT_REFRESH = 1;
    [Token(Token = "0x400A92D")]
    public const int PIN_INPUT_NAME_SEARCH = 10;
    [Token(Token = "0x400A92E")]
    public const int PIN_OUTPUT_ITEM_SELECT = 100;
    [Token(Token = "0x400A92F")]
    public const int PIN_OUTPUT_ITEM_UPDATE = 101;
    [Token(Token = "0x400A930")]
    [FieldOffset(Offset = "0xC")]
    public RectTransform ItemLayoutParent;
    [Token(Token = "0x400A931")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400A932")]
    [FieldOffset(Offset = "0x14")]
    public Transform mNameBoxParent;
    [Token(Token = "0x400A933")]
    [FieldOffset(Offset = "0x18")]
    private List<GameObject> ItemSelectItem;
    [Token(Token = "0x400A934")]
    [FieldOffset(Offset = "0x1C")]
    private ItemSelectListItemData[] mItemDatas;
    [Token(Token = "0x400A935")]
    private const string NAME_SEARCH_WINDOW_UI_PATH = "UI/NameSearchBox/namesearch_select_item";
    [Token(Token = "0x400A936")]
    [FieldOffset(Offset = "0x20")]
    private NameSearchBox mNameSearchBox;
    [Token(Token = "0x400A937")]
    [FieldOffset(Offset = "0x24")]
    private string mNameSearchInput;
    [Token(Token = "0x400A938")]
    [FieldOffset(Offset = "0x28")]
    private SearchUtility.CONDITIONS mNameSearchType;

    [Token(Token = "0x600A298")]
    [Address(RVA = "0x64B480", Offset = "0x64A280", VA = "0x1064B480")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A299")]
    [Address(RVA = "0x64B380", Offset = "0x64A180", VA = "0x1064B380", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A29A")]
    [Address(RVA = "0x64BC30", Offset = "0x64AA30", VA = "0x1064BC30")]
    public void SetData(ItemSelectListItemData[] item_data)
    {
    }

    [Token(Token = "0x600A29B")]
    [Address(RVA = "0x64B8A0", Offset = "0x64A6A0", VA = "0x1064B8A0")]
    public void Refresh(ItemSelectListItemData[] item_data)
    {
    }

    [Token(Token = "0x600A29C")]
    [Address(RVA = "0x64B810", Offset = "0x64A610", VA = "0x1064B810")]
    private void OnSelect(GameObject go)
    {
    }

    [Token(Token = "0x600A29D")]
    [Address(RVA = "0x64B620", Offset = "0x64A420", VA = "0x1064B620")]
    public void CreateNameSearchBox()
    {
    }

    [Token(Token = "0x600A29E")]
    [Address(RVA = "0x64B740", Offset = "0x64A540", VA = "0x1064B740")]
    public void DeleteNameSearchBox()
    {
    }

    [Token(Token = "0x600A29F")]
    [Address(RVA = "0x64BC60", Offset = "0x64AA60", VA = "0x1064BC60")]
    public void SetNameSearchInfo()
    {
    }

    [Token(Token = "0x600A2A0")]
    [Address(RVA = "0x64BD40", Offset = "0x64AB40", VA = "0x1064BD40")]
    public GetItemWindow()
    {
    }
  }
}
