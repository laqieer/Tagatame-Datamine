// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqCompensateReceiveTropy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014CC")]
  [AddComponentMenu("")]
  [FlowNode.Pin(101, "End", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Begin", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Trophy/CompensateReceiveTrophy", 32741)]
  public class FlowNode_ReqCompensateReceiveTropy : FlowNode_Network
  {
    [Token(Token = "0x4004C4D")]
    private const int PIN_INPUT_BEGIN_API = 1;
    [Token(Token = "0x4004C4E")]
    private const int PIN_OUTPUT_END_API = 101;

    [Token(Token = "0x60056A3")]
    [Address(RVA = "0x12C17E0", Offset = "0x12C05E0", VA = "0x112C17E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60056A4")]
    [Address(RVA = "0x12C1890", Offset = "0x12C0690", VA = "0x112C1890", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60056A5")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqCompensateReceiveTropy()
    {
    }
  }
}
