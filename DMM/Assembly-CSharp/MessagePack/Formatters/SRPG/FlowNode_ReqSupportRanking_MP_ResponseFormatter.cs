// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqSupportRanking_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009B7")]
  public sealed class FlowNode_ReqSupportRanking_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqSupportRanking.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017FE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017FF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002673")]
    [Address(RVA = "0xE6BB80", Offset = "0xE6A980", VA = "0x10E6BB80")]
    public FlowNode_ReqSupportRanking_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002674")]
    [Address(RVA = "0xE6B890", Offset = "0xE6A690", VA = "0x10E6B890", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqSupportRanking.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002675")]
    [Address(RVA = "0xE6B460", Offset = "0xE6A260", VA = "0x10E6B460", Slot = "5")]
    public FlowNode_ReqSupportRanking.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqSupportRanking.MP_Response) null;
    }
  }
}
