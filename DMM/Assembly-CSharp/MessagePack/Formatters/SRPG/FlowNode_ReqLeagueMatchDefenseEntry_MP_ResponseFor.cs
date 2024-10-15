// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqLeagueMatchDefenseEntry_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009D7")]
  public sealed class FlowNode_ReqLeagueMatchDefenseEntry_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqLeagueMatchDefenseEntry.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400183E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400183F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026D3")]
    [Address(RVA = "0xE6A6E0", Offset = "0xE694E0", VA = "0x10E6A6E0")]
    public FlowNode_ReqLeagueMatchDefenseEntry_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60026D4")]
    [Address(RVA = "0xE6A3F0", Offset = "0xE691F0", VA = "0x10E6A3F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqLeagueMatchDefenseEntry.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026D5")]
    [Address(RVA = "0xE69FC0", Offset = "0xE68DC0", VA = "0x10E69FC0", Slot = "5")]
    public FlowNode_ReqLeagueMatchDefenseEntry.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqLeagueMatchDefenseEntry.MP_Response) null;
    }
  }
}
