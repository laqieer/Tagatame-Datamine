﻿// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqPointQuestGuildReward_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000950")]
  public sealed class FlowNode_ReqPointQuestGuildReward_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqPointQuestGuildReward.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001730")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001731")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600253E")]
    [Address(RVA = "0xE11830", Offset = "0xE10630", VA = "0x10E11830")]
    public FlowNode_ReqPointQuestGuildReward_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600253F")]
    [Address(RVA = "0xE11540", Offset = "0xE10340", VA = "0x10E11540", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqPointQuestGuildReward.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002540")]
    [Address(RVA = "0xE11110", Offset = "0xE0FF10", VA = "0x10E11110", Slot = "5")]
    public FlowNode_ReqPointQuestGuildReward.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqPointQuestGuildReward.MP_Response) null;
    }
  }
}