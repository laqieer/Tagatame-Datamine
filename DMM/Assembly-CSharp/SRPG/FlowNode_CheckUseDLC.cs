// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_CheckUseDLC
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001391")]
  [FlowNode.NodeType("SRPG/CheckUseDLC", 32741)]
  [FlowNode.Pin(101, "Check", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(1001, "True", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(1002, "False", FlowNode.PinTypes.Output, 1002)]
  [AddComponentMenu("")]
  public class FlowNode_CheckUseDLC : FlowNode
  {
    [Token(Token = "0x4004851")]
    private const int PIN_INPUT_START_CHECK = 101;
    [Token(Token = "0x4004852")]
    private const int PIN_OUTPUT_TRUE = 1001;
    [Token(Token = "0x4004853")]
    private const int PIN_OUTPUT_FALSE = 1002;

    [Token(Token = "0x6005209")]
    [Address(RVA = "0x126DFD0", Offset = "0x126CDD0", VA = "0x1126DFD0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600520A")]
    [Address(RVA = "0x126DF70", Offset = "0x126CD70", VA = "0x1126DF70")]
    private void Check()
    {
    }

    [Token(Token = "0x600520B")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_CheckUseDLC()
    {
    }
  }
}
