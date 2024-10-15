// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqAddChatBlackList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001482")]
  [FlowNode.NodeType("System/ReqChat/ReqAddChatBlackList", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(10, "CanNotAddBlackList", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  public class FlowNode_ReqAddChatBlackList : FlowNode_Network
  {
    [Token(Token = "0x60055AD")]
    [Address(RVA = "0x12B58F0", Offset = "0x12B46F0", VA = "0x112B58F0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60055AE")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x60055AF")]
    [Address(RVA = "0x12B59D0", Offset = "0x12B47D0", VA = "0x112B59D0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60055B0")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqAddChatBlackList()
    {
    }
  }
}
