// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqLeagueMatchShamBuff_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000841")]
  public sealed class FlowNode_ReqLeagueMatchShamBuff_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqLeagueMatchShamBuff.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001512")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001513")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002211")]
    [Address(RVA = "0xD6B160", Offset = "0xD69F60", VA = "0x10D6B160")]
    public FlowNode_ReqLeagueMatchShamBuff_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002212")]
    [Address(RVA = "0xD6AE70", Offset = "0xD69C70", VA = "0x10D6AE70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqLeagueMatchShamBuff.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002213")]
    [Address(RVA = "0xD6AA40", Offset = "0xD69840", VA = "0x10D6AA40", Slot = "5")]
    public FlowNode_ReqLeagueMatchShamBuff.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqLeagueMatchShamBuff.MP_Response) null;
    }
  }
}
