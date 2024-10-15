// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqDrawCard_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A3B")]
  public sealed class FlowNode_ReqDrawCard_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqDrawCard.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001906")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001907")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027FF")]
    [Address(RVA = "0xEA9550", Offset = "0xEA8350", VA = "0x10EA9550")]
    public FlowNode_ReqDrawCard_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002800")]
    [Address(RVA = "0xEA9260", Offset = "0xEA8060", VA = "0x10EA9260", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqDrawCard.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002801")]
    [Address(RVA = "0xEA8E30", Offset = "0xEA7C30", VA = "0x10EA8E30", Slot = "5")]
    public FlowNode_ReqDrawCard.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqDrawCard.MP_Response) null;
    }
  }
}
