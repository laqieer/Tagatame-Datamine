// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqChatMessageWorld
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014BB")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("System/ReqChat/ReqChatLogWorld", 32741)]
  public class FlowNode_ReqChatMessageWorld : FlowNode_ReqChatMessage
  {
    [Token(Token = "0x4004C18")]
    [FieldOffset(Offset = "0x24")]
    private int mChannel;
    [Token(Token = "0x4004C19")]
    [FieldOffset(Offset = "0x28")]
    private long mStartID;
    [Token(Token = "0x4004C1A")]
    [FieldOffset(Offset = "0x30")]
    private int mLimit;
    [Token(Token = "0x4004C1B")]
    [FieldOffset(Offset = "0x38")]
    private long mExcludeID;

    [Token(Token = "0x6005674")]
    [Address(RVA = "0x12BEE20", Offset = "0x12BDC20", VA = "0x112BEE20")]
    private void ResetParam()
    {
    }

    [Token(Token = "0x6005675")]
    [Address(RVA = "0x12BEE60", Offset = "0x12BDC60", VA = "0x112BEE60", Slot = "23")]
    public override void SetChatMessageInfo(
      int channel,
      long start_id,
      int limit,
      long exclude_id)
    {
    }

    [Token(Token = "0x6005676")]
    [Address(RVA = "0x12BEC70", Offset = "0x12BDA70", VA = "0x112BEC70", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005677")]
    [Address(RVA = "0x12BEE90", Offset = "0x12BDC90", VA = "0x112BEE90", Slot = "26")]
    protected override void Success(ChatLog log)
    {
    }

    [Token(Token = "0x6005678")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqChatMessageWorld()
    {
    }
  }
}
