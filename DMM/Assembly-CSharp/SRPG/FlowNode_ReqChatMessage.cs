// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqChatMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014B8")]
  [FlowNode.NodeType("System/ReqChat/ReqChatLog", 32741)]
  [FlowNode.Pin(100, "ChatFailure", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  public class FlowNode_ReqChatMessage : FlowNode_Network
  {
    [Token(Token = "0x4004C0F")]
    [FieldOffset(Offset = "0x20")]
    protected bool mSetup;

    [Token(Token = "0x6005663")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "23")]
    public virtual void SetChatMessageInfo(int channel, long start_id, int limit, long exclude_id)
    {
    }

    [Token(Token = "0x6005664")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "24")]
    public virtual void SetChatMessageInfo(
      string room_token,
      long start_id,
      int limit,
      long exclude_id,
      bool is_sys_msg_merge)
    {
    }

    [Token(Token = "0x6005665")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "25")]
    public virtual void SetChatMessageInfo(long start_id, int limit, long exclude_id)
    {
    }

    [Token(Token = "0x6005666")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005667")]
    [Address(RVA = "0x12BF210", Offset = "0x12BE010", VA = "0x112BF210", Slot = "26")]
    protected virtual void Success(ChatLog log)
    {
    }

    [Token(Token = "0x6005668")]
    [Address(RVA = "0x12BEF50", Offset = "0x12BDD50", VA = "0x112BEF50", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005669")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqChatMessage()
    {
    }
  }
}
