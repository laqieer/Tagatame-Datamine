// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_PaymentOnAgree
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001452")]
  [AddComponentMenu("")]
  [FlowNode.Pin(100, "Out", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(0, "OnAgree", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Payment/OnAgree", 32741)]
  public class FlowNode_PaymentOnAgree : FlowNode
  {
    [Token(Token = "0x6005501")]
    [Address(RVA = "0x1296950", Offset = "0x1295750", VA = "0x11296950", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005502")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_PaymentOnAgree()
    {
    }
  }
}
