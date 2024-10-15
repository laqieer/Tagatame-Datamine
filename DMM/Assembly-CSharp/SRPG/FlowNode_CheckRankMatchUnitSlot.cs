// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckRankMatchUnitSlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001385")]
  [FlowNode.Pin(120, "Check Unit Slot", FlowNode.PinTypes.Input, 3)]
  [FlowNode.NodeType("Multi/CheckRankMatchUnitSlot", 32741)]
  [FlowNode.Pin(201, "Unit Slot NG", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  [FlowNode.Pin(203, "Unit Same NG", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(202, "Unit Place NG", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(200, "Unit Slot OK", FlowNode.PinTypes.Output, 10)]
  public class FlowNode_CheckRankMatchUnitSlot : FlowNode
  {
    [Token(Token = "0x4004806")]
    public const int PINID_CHECK_UNIT_SLOT = 120;
    [Token(Token = "0x4004807")]
    public const int PINID_UNIT_SLOT_OK = 200;
    [Token(Token = "0x4004808")]
    public const int PINID_UNIT_SLOT_NG = 201;
    [Token(Token = "0x4004809")]
    public const int PINID_UNIT_PLACE_NG = 202;
    [Token(Token = "0x400480A")]
    public const int PINID_UNIT_SAME_NG = 203;

    [Token(Token = "0x60051DD")]
    [Address(RVA = "0x126C200", Offset = "0x126B000", VA = "0x1126C200", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60051DE")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckRankMatchUnitSlot()
    {
    }
  }
}
