// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MultiPlayErrorMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001435")]
  [FlowNode.NodeType("Multi/MultiPlayErrorMessage", 32741)]
  [FlowNode.Pin(10, "Open", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "Closed", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  public class FlowNode_MultiPlayErrorMessage : FlowNode
  {
    [Token(Token = "0x4004AE0")]
    [FieldOffset(Offset = "0x18")]
    private GameObject winGO;

    [Token(Token = "0x600545E")]
    [Address(RVA = "0x1290300", Offset = "0x128F100", VA = "0x11290300", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600545F")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MultiPlayErrorMessage()
    {
    }
  }
}
