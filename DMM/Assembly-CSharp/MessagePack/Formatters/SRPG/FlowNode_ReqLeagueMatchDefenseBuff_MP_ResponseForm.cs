// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqLeagueMatchDefenseBuff_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007DF")]
  public sealed class FlowNode_ReqLeagueMatchDefenseBuff_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqLeagueMatchDefenseBuff.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400144E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400144F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020EB")]
    [Address(RVA = "0xD162B0", Offset = "0xD150B0", VA = "0x10D162B0")]
    public FlowNode_ReqLeagueMatchDefenseBuff_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60020EC")]
    [Address(RVA = "0xD15FC0", Offset = "0xD14DC0", VA = "0x10D15FC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqLeagueMatchDefenseBuff.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020ED")]
    [Address(RVA = "0xD15B90", Offset = "0xD14990", VA = "0x10D15B90", Slot = "5")]
    public FlowNode_ReqLeagueMatchDefenseBuff.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqLeagueMatchDefenseBuff.MP_Response) null;
    }
  }
}
