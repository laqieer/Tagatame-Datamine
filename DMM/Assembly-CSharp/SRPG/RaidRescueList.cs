// Decompiled with JetBrains decompiler
// Type: SRPG.RaidRescueList
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
  [Token(Token = "0x20028EB")]
  [FlowNode.Pin(101, "Open Popup", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/Raid/RaidRescueList")]
  public class RaidRescueList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C4BE")]
    public const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400C4BF")]
    public const int PIN_OUTPUT_OPEN_POPUP = 101;
    [Token(Token = "0x400C4C0")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform mItemParent;
    [Token(Token = "0x400C4C1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RaidRescueListItem mItem;
    [Token(Token = "0x400C4C2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mNoRequest;
    [Token(Token = "0x400C4C3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button mUpdateButton;
    [Token(Token = "0x400C4C4")]
    [FieldOffset(Offset = "0x1C")]
    private List<RaidRescueListItem> mItemList;

    [Token(Token = "0x600B931")]
    [Address(RVA = "0x805D90", Offset = "0x804B90", VA = "0x10805D90")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B932")]
    [Address(RVA = "0x805D70", Offset = "0x804B70", VA = "0x10805D70", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B933")]
    [Address(RVA = "0x805DC0", Offset = "0x804BC0", VA = "0x10805DC0")]
    private void Init()
    {
    }

    [Token(Token = "0x600B934")]
    [Address(RVA = "0x806160", Offset = "0x804F60", VA = "0x10806160")]
    public void ListClick(RaidRescueListItem item)
    {
    }

    [Token(Token = "0x600B935")]
    [Address(RVA = "0x8061C0", Offset = "0x804FC0", VA = "0x108061C0")]
    private void Update()
    {
    }

    [Token(Token = "0x600B936")]
    [Address(RVA = "0x806280", Offset = "0x805080", VA = "0x10806280")]
    public RaidRescueList()
    {
    }
  }
}
