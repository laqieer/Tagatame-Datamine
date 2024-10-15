// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqOrdealPartyUpdate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001555")]
  [FlowNode.NodeType("System/Party/ReqOrdealPartyUpdate", 32741)]
  [FlowNode.Pin(1000, "Failed", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_ReqOrdealPartyUpdate : FlowNode_Network
  {
    [Token(Token = "0x6005829")]
    [Address(RVA = "0x12D6110", Offset = "0x12D4F10", VA = "0x112D6110", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600582A")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x600582B")]
    [Address(RVA = "0x12D6240", Offset = "0x12D5040", VA = "0x112D6240", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600582C")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqOrdealPartyUpdate()
    {
    }
  }
}
