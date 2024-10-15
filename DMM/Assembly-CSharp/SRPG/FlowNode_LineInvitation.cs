// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_LineInvitation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200141C")]
  [FlowNode.Pin(110, "Read", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("LINE/Invitation", 32741)]
  [FlowNode.Pin(100, "Send", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(200, "Send Done", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(200, "Read Done", FlowNode.PinTypes.Output, 0)]
  [AddComponentMenu("")]
  public class FlowNode_LineInvitation : FlowNode
  {
    [Token(Token = "0x6005401")]
    [Address(RVA = "0x1287BE0", Offset = "0x12869E0", VA = "0x11287BE0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005402")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_LineInvitation()
    {
    }
  }
}
