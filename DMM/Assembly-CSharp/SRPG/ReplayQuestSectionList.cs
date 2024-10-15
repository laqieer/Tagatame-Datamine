// Decompiled with JetBrains decompiler
// Type: SRPG.ReplayQuestSectionList
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
  [Token(Token = "0x2002949")]
  [AddComponentMenu("UI/ReplayQuestSectionList")]
  [FlowNode.Pin(0, "更新", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "閲覧可能なストーリーがある", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(11, "閲覧可能なストーリーがない", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(12, "アイテムが選択された", FlowNode.PinTypes.Output, 102)]
  public class ReplayQuestSectionList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C6E4")]
    private const int PIN_ID_REFRESH = 0;
    [Token(Token = "0x400C6E5")]
    private const int PIN_ID_EXIST = 10;
    [Token(Token = "0x400C6E6")]
    private const int PIN_ID_NOT_EXIST = 11;
    [Token(Token = "0x400C6E7")]
    private const int PIN_ID_SELECT = 12;
    [Token(Token = "0x400C6E8")]
    [FieldOffset(Offset = "0xC")]
    public ListItemEvents ItemTemplate;
    [Token(Token = "0x400C6E9")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ItemContainer;
    [Token(Token = "0x400C6EA")]
    [FieldOffset(Offset = "0x14")]
    private bool isRefreshed;
    [Token(Token = "0x400C6EB")]
    [FieldOffset(Offset = "0x18")]
    public ScrollRect ScrollRect;
    [Token(Token = "0x400C6EC")]
    [FieldOffset(Offset = "0x1C")]
    private List<ListItemEvents> mItems;

    [Token(Token = "0x600BABC")]
    [Address(RVA = "0x822600", Offset = "0x821400", VA = "0x10822600", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BABD")]
    [Address(RVA = "0x822EF0", Offset = "0x821CF0", VA = "0x10822EF0")]
    private void Start()
    {
    }

    [Token(Token = "0x600BABE")]
    [Address(RVA = "0x8226D0", Offset = "0x8214D0", VA = "0x108226D0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600BABF")]
    [Address(RVA = "0x822620", Offset = "0x821420", VA = "0x10822620")]
    private void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x600BAC0")]
    [Address(RVA = "0x822F80", Offset = "0x821D80", VA = "0x10822F80")]
    public ReplayQuestSectionList()
    {
    }
  }
}
