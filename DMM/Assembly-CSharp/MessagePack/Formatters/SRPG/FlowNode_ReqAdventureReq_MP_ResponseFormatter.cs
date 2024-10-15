// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqAdventureReq_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009EC")]
  public sealed class FlowNode_ReqAdventureReq_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqAdventureReq.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001868")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001869")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002712")]
    [Address(RVA = "0xE7C5B0", Offset = "0xE7B3B0", VA = "0x10E7C5B0")]
    public FlowNode_ReqAdventureReq_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002713")]
    [Address(RVA = "0xE7C2C0", Offset = "0xE7B0C0", VA = "0x10E7C2C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqAdventureReq.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002714")]
    [Address(RVA = "0xE7BE90", Offset = "0xE7AC90", VA = "0x10E7BE90", Slot = "5")]
    public FlowNode_ReqAdventureReq.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqAdventureReq.MP_Response) null;
    }
  }
}
