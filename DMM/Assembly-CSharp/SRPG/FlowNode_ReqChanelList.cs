// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqChanelList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014B4")]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/ReqChat/ReqChatChannelList", 32741)]
  [FlowNode.Pin(1, "Request(SelectPageIndex)", FlowNode.PinTypes.Input, 1)]
  public class FlowNode_ReqChanelList : FlowNode_Network
  {
    [Token(Token = "0x4004C0C")]
    [FieldOffset(Offset = "0x20")]
    public int ChannelLimit;

    [Token(Token = "0x6005651")]
    [Address(RVA = "0x12BD770", Offset = "0x12BC570", VA = "0x112BD770", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005652")]
    [Address(RVA = "0x1292FD0", Offset = "0x1291DD0", VA = "0x11292FD0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005653")]
    [Address(RVA = "0x12BDA10", Offset = "0x12BC810", VA = "0x112BDA10", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005654")]
    [Address(RVA = "0x12BDBB0", Offset = "0x12BC9B0", VA = "0x112BDBB0")]
    public FlowNode_ReqChanelList()
    {
    }
  }
}
