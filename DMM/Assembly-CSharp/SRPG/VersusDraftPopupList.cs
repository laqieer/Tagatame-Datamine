// Decompiled with JetBrains decompiler
// Type: SRPG.VersusDraftPopupList
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
  [Token(Token = "0x2002735")]
  [FlowNode.Pin(2, "Page Prev", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(3, "Page Next", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(21, "Is First Page", FlowNode.PinTypes.Output, 5)]
  [FlowNode.Pin(22, "Is Last Page", FlowNode.PinTypes.Output, 6)]
  [AddComponentMenu("UI/Multi/Versus/Draft/VersusDraftPopupList")]
  [FlowNode.Pin(1, "Generate List", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "Generated", FlowNode.PinTypes.Output, 2)]
  public class VersusDraftPopupList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B903")]
    private const int PIN_INPUT_GENERATE_LIST = 1;
    [Token(Token = "0x400B904")]
    private const int PIN_INPUT_PAGE_PREV = 2;
    [Token(Token = "0x400B905")]
    private const int PIN_INPUT_PAGE_NEXT = 3;
    [Token(Token = "0x400B906")]
    private const int PIN_OUTPUT_GENERATED = 11;
    [Token(Token = "0x400B907")]
    private const int PIN_OUTPUT_FIRST_PAGE = 21;
    [Token(Token = "0x400B908")]
    private const int PIN_OUTPUT_LAST_PAGE = 22;
    [Token(Token = "0x400B909")]
    private const int UNIT_COUNT_PER_PAGE = 28;
    [Token(Token = "0x400B90A")]
    private const string TAB_INDEX_SVB_KEY = "VDPL_TAB_INDEX_KEY";
    [Token(Token = "0x400B90B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform mUnitParentTransform;
    [Token(Token = "0x400B90C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mGOUnitItem;
    [Token(Token = "0x400B90D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mPageMaxTxt;
    [Token(Token = "0x400B90E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mPageNowTxt;
    [Token(Token = "0x400B90F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ToggleGroup mTabGroup;
    [Token(Token = "0x400B910")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Toggle mTabItem;
    [Token(Token = "0x400B911")]
    [FieldOffset(Offset = "0x24")]
    private List<VersusDraftPopupList.DraftDeck> mDraftDeckList;
    [Token(Token = "0x400B912")]
    [FieldOffset(Offset = "0x28")]
    private List<GameObject> mUnitList;
    [Token(Token = "0x400B913")]
    [FieldOffset(Offset = "0x2C")]
    private int mNowDeck;

    [Token(Token = "0x600AFE2")]
    [Address(RVA = "0x742030", Offset = "0x740E30", VA = "0x10742030")]
    private void Awake()
    {
    }

    [Token(Token = "0x600AFE3")]
    [Address(RVA = "0x741EE0", Offset = "0x740CE0", VA = "0x10741EE0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AFE4")]
    [Address(RVA = "0x7425D0", Offset = "0x7413D0", VA = "0x107425D0")]
    private void GenerateList(int page = 0)
    {
    }

    [Token(Token = "0x600AFE5")]
    [Address(RVA = "0x742AB0", Offset = "0x7418B0", VA = "0x10742AB0")]
    private void OnChange(bool on)
    {
    }

    [Token(Token = "0x600AFE6")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public VersusDraftPopupList()
    {
    }

    [Token(Token = "0x2002736")]
    private class DraftDeck
    {
      [Token(Token = "0x400B914")]
      [FieldOffset(Offset = "0x8")]
      public List<VersusDraftUnitParam> mDraftUnitListCache;
      [Token(Token = "0x400B915")]
      [FieldOffset(Offset = "0xC")]
      public List<GameObject> mUnitList;
      [Token(Token = "0x400B916")]
      [FieldOffset(Offset = "0x10")]
      public int mPage;
      [Token(Token = "0x400B917")]
      [FieldOffset(Offset = "0x14")]
      public int mPageMax;
      [Token(Token = "0x400B918")]
      [FieldOffset(Offset = "0x18")]
      public Toggle mTab;

      [Token(Token = "0x600AFE7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public DraftDeck()
      {
      }
    }
  }
}
