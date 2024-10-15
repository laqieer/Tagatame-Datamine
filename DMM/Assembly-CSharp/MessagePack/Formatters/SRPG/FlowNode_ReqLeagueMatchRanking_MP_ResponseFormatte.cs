// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqLeagueMatchRanking_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000951")]
  public sealed class FlowNode_ReqLeagueMatchRanking_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqLeagueMatchRanking.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001732")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001733")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002541")]
    [Address(RVA = "0xE10390", Offset = "0xE0F190", VA = "0x10E10390")]
    public FlowNode_ReqLeagueMatchRanking_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002542")]
    [Address(RVA = "0xE100A0", Offset = "0xE0EEA0", VA = "0x10E100A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqLeagueMatchRanking.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002543")]
    [Address(RVA = "0xE0FC70", Offset = "0xE0EA70", VA = "0x10E0FC70", Slot = "5")]
    public FlowNode_ReqLeagueMatchRanking.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqLeagueMatchRanking.MP_Response) null;
    }
  }
}
