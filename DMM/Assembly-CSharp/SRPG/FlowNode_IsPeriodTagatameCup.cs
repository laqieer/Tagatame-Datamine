// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_IsPeriodTagatameCup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001344")]
  [FlowNode.NodeType("TagatameCup/Period", 32741)]
  [FlowNode.Pin(0, "input", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "in_period", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "over", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  [FlowNode.Pin(12, "entry", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(13, "not_cup", FlowNode.PinTypes.Output, 13)]
  public class FlowNode_IsPeriodTagatameCup : FlowNode
  {
    [Token(Token = "0x4004759")]
    private const int PIN_INPUT = 0;
    [Token(Token = "0x400475A")]
    private const int PIN_OUTPUT_IN_PERIOD = 10;
    [Token(Token = "0x400475B")]
    private const int PIN_OUTPUT_OVER = 11;
    [Token(Token = "0x400475C")]
    private const int PIN_OUTPUT_ENTRY = 12;
    [Token(Token = "0x400475D")]
    private const int PIN_OUTPUT_NOT_TAGATAMECUP = 13;

    [Token(Token = "0x600510D")]
    [Address(RVA = "0x124FD30", Offset = "0x124EB30", VA = "0x1124FD30", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600510E")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_IsPeriodTagatameCup()
    {
    }
  }
}
