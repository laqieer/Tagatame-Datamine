// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MultiPlayFirstContact
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001436")]
  [AddComponentMenu("")]
  [FlowNode.Pin(2, "no", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(1, "yes", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(0, "exist", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("Multi/MultiPlayFirstContact", 32741)]
  public class FlowNode_MultiPlayFirstContact : FlowNode
  {
    [Token(Token = "0x6005461")]
    [Address(RVA = "0x1290440", Offset = "0x128F240", VA = "0x11290440", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005462")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MultiPlayFirstContact()
    {
    }
  }
}
