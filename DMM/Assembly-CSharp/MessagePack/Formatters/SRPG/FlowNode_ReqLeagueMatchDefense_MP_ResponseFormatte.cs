// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqLeagueMatchDefense_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009F4")]
  public sealed class FlowNode_ReqLeagueMatchDefense_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqLeagueMatchDefense.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001878")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001879")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600272A")]
    [Address(RVA = "0xE7F940", Offset = "0xE7E740", VA = "0x10E7F940")]
    public FlowNode_ReqLeagueMatchDefense_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600272B")]
    [Address(RVA = "0xE7F650", Offset = "0xE7E450", VA = "0x10E7F650", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqLeagueMatchDefense.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600272C")]
    [Address(RVA = "0xE7F220", Offset = "0xE7E020", VA = "0x10E7F220", Slot = "5")]
    public FlowNode_ReqLeagueMatchDefense.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqLeagueMatchDefense.MP_Response) null;
    }
  }
}
