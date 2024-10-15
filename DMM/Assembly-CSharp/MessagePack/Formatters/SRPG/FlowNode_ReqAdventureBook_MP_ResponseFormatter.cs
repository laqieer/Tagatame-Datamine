// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqAdventureBook_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AA0")]
  public sealed class FlowNode_ReqAdventureBook_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqAdventureBook.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019D0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019D1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600292E")]
    [Address(RVA = "0xEEB580", Offset = "0xEEA380", VA = "0x10EEB580")]
    public FlowNode_ReqAdventureBook_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600292F")]
    [Address(RVA = "0xEEB290", Offset = "0xEEA090", VA = "0x10EEB290", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqAdventureBook.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002930")]
    [Address(RVA = "0xEEAE60", Offset = "0xEE9C60", VA = "0x10EEAE60", Slot = "5")]
    public FlowNode_ReqAdventureBook.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqAdventureBook.MP_Response) null;
    }
  }
}
