// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGuildRaidRankingDamageRound_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000866")]
  public sealed class FlowNode_ReqGuildRaidRankingDamageRound_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGuildRaidRankingDamageRound.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400155C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400155D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002280")]
    [Address(RVA = "0xD84C70", Offset = "0xD83A70", VA = "0x10D84C70")]
    public FlowNode_ReqGuildRaidRankingDamageRound_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002281")]
    [Address(RVA = "0xD84980", Offset = "0xD83780", VA = "0x10D84980", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGuildRaidRankingDamageRound.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002282")]
    [Address(RVA = "0xD84550", Offset = "0xD83350", VA = "0x10D84550", Slot = "5")]
    public FlowNode_ReqGuildRaidRankingDamageRound.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGuildRaidRankingDamageRound.MP_Response) null;
    }
  }
}
