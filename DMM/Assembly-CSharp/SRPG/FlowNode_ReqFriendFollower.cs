// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqFriendFollower
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014F2")]
  [FlowNode.NodeType("Network/ReqFriendFollower", 32741)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_ReqFriendFollower : FlowNode_Network
  {
    [Token(Token = "0x6005713")]
    [Address(RVA = "0x12C7A00", Offset = "0x12C6800", VA = "0x112C7A00", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005714")]
    [Address(RVA = "0x107A1E0", Offset = "0x1078FE0", VA = "0x1107A1E0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005715")]
    [Address(RVA = "0x12C7B00", Offset = "0x12C6900", VA = "0x112C7B00", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005716")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqFriendFollower()
    {
    }
  }
}
