// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqChatMessageGuild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014B9")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("System/ReqChat/ReqChatLogGuild", 32741)]
  public class FlowNode_ReqChatMessageGuild : FlowNode_ReqChatMessage
  {
    [Token(Token = "0x4004C10")]
    [FieldOffset(Offset = "0x28")]
    private long mStartID;
    [Token(Token = "0x4004C11")]
    [FieldOffset(Offset = "0x30")]
    private int mLimit;
    [Token(Token = "0x4004C12")]
    [FieldOffset(Offset = "0x38")]
    private long mExcludeID;

    [Token(Token = "0x600566A")]
    [Address(RVA = "0x12BE7F0", Offset = "0x12BD5F0", VA = "0x112BE7F0")]
    private void ResetParam()
    {
    }

    [Token(Token = "0x600566B")]
    [Address(RVA = "0x12BE820", Offset = "0x12BD620", VA = "0x112BE820", Slot = "25")]
    public override void SetChatMessageInfo(long start_id, int limit, long exclude_id)
    {
    }

    [Token(Token = "0x600566C")]
    [Address(RVA = "0x12BE6E0", Offset = "0x12BD4E0", VA = "0x112BE6E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600566D")]
    [Address(RVA = "0x12BE850", Offset = "0x12BD650", VA = "0x112BE850", Slot = "26")]
    protected override void Success(ChatLog log)
    {
    }

    [Token(Token = "0x600566E")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqChatMessageGuild()
    {
    }
  }
}
