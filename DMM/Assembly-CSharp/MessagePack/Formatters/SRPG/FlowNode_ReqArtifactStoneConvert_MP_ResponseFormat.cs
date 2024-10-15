// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqArtifactStoneConvert_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000901")]
  public sealed class FlowNode_ReqArtifactStoneConvert_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqArtifactStoneConvert.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001692")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001693")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002451")]
    [Address(RVA = "0xDDCEC0", Offset = "0xDDBCC0", VA = "0x10DDCEC0")]
    public FlowNode_ReqArtifactStoneConvert_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002452")]
    [Address(RVA = "0xDDCBD0", Offset = "0xDDB9D0", VA = "0x10DDCBD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqArtifactStoneConvert.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002453")]
    [Address(RVA = "0xDDC7A0", Offset = "0xDDB5A0", VA = "0x10DDC7A0", Slot = "5")]
    public FlowNode_ReqArtifactStoneConvert.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqArtifactStoneConvert.MP_Response) null;
    }
  }
}
