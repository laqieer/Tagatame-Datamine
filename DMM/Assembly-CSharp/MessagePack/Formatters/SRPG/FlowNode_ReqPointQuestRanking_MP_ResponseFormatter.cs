// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqPointQuestRanking_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000971")]
  public sealed class FlowNode_ReqPointQuestRanking_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqPointQuestRanking.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001772")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001773")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025A1")]
    [Address(RVA = "0xE28F40", Offset = "0xE27D40", VA = "0x10E28F40")]
    public FlowNode_ReqPointQuestRanking_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60025A2")]
    [Address(RVA = "0xE28C50", Offset = "0xE27A50", VA = "0x10E28C50", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqPointQuestRanking.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025A3")]
    [Address(RVA = "0xE28820", Offset = "0xE27620", VA = "0x10E28820", Slot = "5")]
    public FlowNode_ReqPointQuestRanking.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqPointQuestRanking.MP_Response) null;
    }
  }
}
