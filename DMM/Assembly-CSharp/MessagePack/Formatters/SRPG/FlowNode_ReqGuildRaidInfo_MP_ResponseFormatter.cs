// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGuildRaidInfo_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000927")]
  public sealed class FlowNode_ReqGuildRaidInfo_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGuildRaidInfo.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016DE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016DF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024C3")]
    [Address(RVA = "0xDF5300", Offset = "0xDF4100", VA = "0x10DF5300")]
    public FlowNode_ReqGuildRaidInfo_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60024C4")]
    [Address(RVA = "0xDF5010", Offset = "0xDF3E10", VA = "0x10DF5010", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGuildRaidInfo.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024C5")]
    [Address(RVA = "0xDF4BE0", Offset = "0xDF39E0", VA = "0x10DF4BE0", Slot = "5")]
    public FlowNode_ReqGuildRaidInfo.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGuildRaidInfo.MP_Response) null;
    }
  }
}
