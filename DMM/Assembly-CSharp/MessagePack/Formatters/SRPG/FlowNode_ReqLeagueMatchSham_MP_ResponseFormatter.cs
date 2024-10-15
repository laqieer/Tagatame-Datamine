// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqLeagueMatchSham_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A09")]
  public sealed class FlowNode_ReqLeagueMatchSham_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqLeagueMatchSham.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018A2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018A3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002769")]
    [Address(RVA = "0xE9BB00", Offset = "0xE9A900", VA = "0x10E9BB00")]
    public FlowNode_ReqLeagueMatchSham_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600276A")]
    [Address(RVA = "0xE9B810", Offset = "0xE9A610", VA = "0x10E9B810", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqLeagueMatchSham.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600276B")]
    [Address(RVA = "0xE9B3E0", Offset = "0xE9A1E0", VA = "0x10E9B3E0", Slot = "5")]
    public FlowNode_ReqLeagueMatchSham.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqLeagueMatchSham.MP_Response) null;
    }
  }
}
