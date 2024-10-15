// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGuildRaid_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B2E")]
  public sealed class FlowNode_ReqGuildRaid_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGuildRaid.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AEC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AED")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002AD8")]
    [Address(RVA = "0xF601C0", Offset = "0xF5EFC0", VA = "0x10F601C0")]
    public FlowNode_ReqGuildRaid_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002AD9")]
    [Address(RVA = "0xF5FED0", Offset = "0xF5ECD0", VA = "0x10F5FED0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGuildRaid.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002ADA")]
    [Address(RVA = "0xF5FAA0", Offset = "0xF5E8A0", VA = "0x10F5FAA0", Slot = "5")]
    public FlowNode_ReqGuildRaid.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGuildRaid.MP_Response) null;
    }
  }
}
