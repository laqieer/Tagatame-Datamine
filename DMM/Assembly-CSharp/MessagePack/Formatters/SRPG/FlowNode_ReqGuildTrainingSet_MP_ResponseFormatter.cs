// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGuildTrainingSet_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B04")]
  public sealed class FlowNode_ReqGuildTrainingSet_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGuildTrainingSet.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A98")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A99")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A5A")]
    [Address(RVA = "0xF1DA20", Offset = "0xF1C820", VA = "0x10F1DA20")]
    public FlowNode_ReqGuildTrainingSet_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002A5B")]
    [Address(RVA = "0xF1D730", Offset = "0xF1C530", VA = "0x10F1D730", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGuildTrainingSet.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A5C")]
    [Address(RVA = "0xF1D300", Offset = "0xF1C100", VA = "0x10F1D300", Slot = "5")]
    public FlowNode_ReqGuildTrainingSet.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGuildTrainingSet.MP_Response) null;
    }
  }
}
