// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqChatMessageRoom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014BA")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("System/ReqChat/ReqChatLogRoom", 32741)]
  public class FlowNode_ReqChatMessageRoom : FlowNode_ReqChatMessage
  {
    [Token(Token = "0x4004C13")]
    [FieldOffset(Offset = "0x24")]
    private string mRoomToken;
    [Token(Token = "0x4004C14")]
    [FieldOffset(Offset = "0x28")]
    private long mStartID;
    [Token(Token = "0x4004C15")]
    [FieldOffset(Offset = "0x30")]
    private int mLimit;
    [Token(Token = "0x4004C16")]
    [FieldOffset(Offset = "0x38")]
    private long mExcludeID;
    [Token(Token = "0x4004C17")]
    [FieldOffset(Offset = "0x40")]
    private bool mIsSystemMessageMerge;

    [Token(Token = "0x600566F")]
    [Address(RVA = "0x12BEAC0", Offset = "0x12BD8C0", VA = "0x112BEAC0")]
    private void ResetParam()
    {
    }

    [Token(Token = "0x6005670")]
    [Address(RVA = "0x12BEB10", Offset = "0x12BD910", VA = "0x112BEB10", Slot = "24")]
    public override void SetChatMessageInfo(
      string room_token,
      long start_id,
      int limit,
      long exclude_id,
      bool is_sys_msg_merge)
    {
    }

    [Token(Token = "0x6005671")]
    [Address(RVA = "0x12BE910", Offset = "0x12BD710", VA = "0x112BE910", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005672")]
    [Address(RVA = "0x12BEB90", Offset = "0x12BD990", VA = "0x112BEB90", Slot = "26")]
    protected override void Success(ChatLog log)
    {
    }

    [Token(Token = "0x6005673")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqChatMessageRoom()
    {
    }
  }
}
