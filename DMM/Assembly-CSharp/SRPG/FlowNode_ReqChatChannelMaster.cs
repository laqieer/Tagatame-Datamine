// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqChatChannelMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014B7")]
  [AddComponentMenu("")]
  [FlowNode.Pin(2, "Failed", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/ReqChat/ReqChatChannelMaster", 32741)]
  public class FlowNode_ReqChatChannelMaster : FlowNode_Network
  {
    [Token(Token = "0x600565E")]
    [Address(RVA = "0x12BE500", Offset = "0x12BD300", VA = "0x112BE500", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600565F")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005660")]
    [Address(RVA = "0x126BD30", Offset = "0x126AB30", VA = "0x1126BD30")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005661")]
    [Address(RVA = "0x12BE5B0", Offset = "0x12BD3B0", VA = "0x112BE5B0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005662")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqChatChannelMaster()
    {
    }
  }
}
