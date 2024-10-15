// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MultiPlayContinueCoin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001434")]
  [FlowNode.NodeType("Multi/MultiPlayContinueCoin", 32741)]
  [FlowNode.Pin(0, "Revive", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(2, "コインが足りない", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(3, "Continue", FlowNode.PinTypes.Input, 3)]
  [AddComponentMenu("")]
  public class FlowNode_MultiPlayContinueCoin : FlowNode_Network
  {
    [Token(Token = "0x6005459")]
    [Address(RVA = "0x128FDE0", Offset = "0x128EBE0", VA = "0x1128FDE0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600545A")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x600545B")]
    [Address(RVA = "0x1273D70", Offset = "0x1272B70", VA = "0x11273D70")]
    private void Failure()
    {
    }

    [Token(Token = "0x600545C")]
    [Address(RVA = "0x1290140", Offset = "0x128EF40", VA = "0x11290140", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600545D")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MultiPlayContinueCoin()
    {
    }
  }
}
