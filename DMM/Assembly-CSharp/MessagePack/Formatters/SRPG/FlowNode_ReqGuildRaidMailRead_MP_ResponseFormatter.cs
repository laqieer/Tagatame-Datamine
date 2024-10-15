// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGuildRaidMailRead_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000906")]
  public sealed class FlowNode_ReqGuildRaidMailRead_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGuildRaidMailRead.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400169C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400169D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002460")]
    [Address(RVA = "0xDDEDB0", Offset = "0xDDDBB0", VA = "0x10DDEDB0")]
    public FlowNode_ReqGuildRaidMailRead_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002461")]
    [Address(RVA = "0xDDEAC0", Offset = "0xDDD8C0", VA = "0x10DDEAC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGuildRaidMailRead.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002462")]
    [Address(RVA = "0xDDE690", Offset = "0xDDD490", VA = "0x10DDE690", Slot = "5")]
    public FlowNode_ReqGuildRaidMailRead.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGuildRaidMailRead.MP_Response) null;
    }
  }
}
