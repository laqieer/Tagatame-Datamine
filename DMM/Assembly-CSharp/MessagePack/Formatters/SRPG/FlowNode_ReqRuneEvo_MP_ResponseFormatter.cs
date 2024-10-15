// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqRuneEvo_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000888")]
  public sealed class FlowNode_ReqRuneEvo_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqRuneEvo.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015A0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015A1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022E6")]
    [Address(RVA = "0xD9BD50", Offset = "0xD9AB50", VA = "0x10D9BD50")]
    public FlowNode_ReqRuneEvo_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60022E7")]
    [Address(RVA = "0xD9BA60", Offset = "0xD9A860", VA = "0x10D9BA60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqRuneEvo.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022E8")]
    [Address(RVA = "0xD9B630", Offset = "0xD9A430", VA = "0x10D9B630", Slot = "5")]
    public FlowNode_ReqRuneEvo.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqRuneEvo.MP_Response) null;
    }
  }
}
