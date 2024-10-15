// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGuildRaidRankingDamageSummary_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A6E")]
  public sealed class FlowNode_ReqGuildRaidRankingDamageSummary_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGuildRaidRankingDamageSummary.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400196C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400196D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002898")]
    [Address(RVA = "0xEC23C0", Offset = "0xEC11C0", VA = "0x10EC23C0")]
    public FlowNode_ReqGuildRaidRankingDamageSummary_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002899")]
    [Address(RVA = "0xEC20D0", Offset = "0xEC0ED0", VA = "0x10EC20D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGuildRaidRankingDamageSummary.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600289A")]
    [Address(RVA = "0xEC1CA0", Offset = "0xEC0AA0", VA = "0x10EC1CA0", Slot = "5")]
    public FlowNode_ReqGuildRaidRankingDamageSummary.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGuildRaidRankingDamageSummary.MP_Response) null;
    }
  }
}
