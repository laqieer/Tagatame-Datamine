// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqLeagueMatchOption_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A15")]
  public sealed class FlowNode_ReqLeagueMatchOption_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqLeagueMatchOption.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018BA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018BB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600278D")]
    [Address(RVA = "0xE9B0B0", Offset = "0xE99EB0", VA = "0x10E9B0B0")]
    public FlowNode_ReqLeagueMatchOption_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600278E")]
    [Address(RVA = "0xE9ADC0", Offset = "0xE99BC0", VA = "0x10E9ADC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqLeagueMatchOption.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600278F")]
    [Address(RVA = "0xE9A990", Offset = "0xE99790", VA = "0x10E9A990", Slot = "5")]
    public FlowNode_ReqLeagueMatchOption.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqLeagueMatchOption.MP_Response) null;
    }
  }
}
