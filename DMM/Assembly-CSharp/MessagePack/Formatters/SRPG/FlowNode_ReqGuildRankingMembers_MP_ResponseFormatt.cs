// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGuildRankingMembers_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A34")]
  public sealed class FlowNode_ReqGuildRankingMembers_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGuildRankingMembers.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018F8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018F9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027EA")]
    [Address(RVA = "0xEAAA00", Offset = "0xEA9800", VA = "0x10EAAA00")]
    public FlowNode_ReqGuildRankingMembers_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60027EB")]
    [Address(RVA = "0xEAA710", Offset = "0xEA9510", VA = "0x10EAA710", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGuildRankingMembers.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027EC")]
    [Address(RVA = "0xEAA2E0", Offset = "0xEA90E0", VA = "0x10EAA2E0", Slot = "5")]
    public FlowNode_ReqGuildRankingMembers.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGuildRankingMembers.MP_Response) null;
    }
  }
}
