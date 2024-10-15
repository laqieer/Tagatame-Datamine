// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqLeagueMatchHistory_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A1F")]
  public sealed class FlowNode_ReqLeagueMatchHistory_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqLeagueMatchHistory.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018CE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018CF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027AB")]
    [Address(RVA = "0xE9A660", Offset = "0xE99460", VA = "0x10E9A660")]
    public FlowNode_ReqLeagueMatchHistory_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60027AC")]
    [Address(RVA = "0xE9A370", Offset = "0xE99170", VA = "0x10E9A370", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqLeagueMatchHistory.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027AD")]
    [Address(RVA = "0xE99F40", Offset = "0xE98D40", VA = "0x10E99F40", Slot = "5")]
    public FlowNode_ReqLeagueMatchHistory.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqLeagueMatchHistory.MP_Response) null;
    }
  }
}
