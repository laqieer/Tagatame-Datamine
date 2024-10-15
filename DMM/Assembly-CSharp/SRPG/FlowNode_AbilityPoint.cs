// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_AbilityPoint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200135E")]
  [FlowNode.NodeType("System/アビリティポイント回復", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(10, "石が足りない", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  public class FlowNode_AbilityPoint : FlowNode_Network
  {
    [Token(Token = "0x600514A")]
    [Address(RVA = "0x1264720", Offset = "0x1263520", VA = "0x11264720", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600514B")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x600514C")]
    [Address(RVA = "0x12648B0", Offset = "0x12636B0", VA = "0x112648B0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600514D")]
    [Address(RVA = "0x1264B10", Offset = "0x1263910", VA = "0x11264B10")]
    private int getRequiredCoin() => new int();

    [Token(Token = "0x600514E")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_AbilityPoint()
    {
    }
  }
}
