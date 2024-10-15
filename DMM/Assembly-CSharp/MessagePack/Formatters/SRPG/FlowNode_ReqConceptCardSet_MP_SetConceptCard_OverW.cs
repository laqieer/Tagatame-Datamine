// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqConceptCardSet_MP_SetConceptCard_OverWriteResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AB4")]
  public sealed class FlowNode_ReqConceptCardSet_MP_SetConceptCard_OverWriteResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqConceptCardSet.MP_SetConceptCard_OverWriteResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019F8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019F9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600296A")]
    [Address(RVA = "0xF04FB0", Offset = "0xF03DB0", VA = "0x10F04FB0")]
    public FlowNode_ReqConceptCardSet_MP_SetConceptCard_OverWriteResponseFormatter()
    {
    }

    [Token(Token = "0x600296B")]
    [Address(RVA = "0xF04CC0", Offset = "0xF03AC0", VA = "0x10F04CC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqConceptCardSet.MP_SetConceptCard_OverWriteResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600296C")]
    [Address(RVA = "0xF04890", Offset = "0xF03690", VA = "0x10F04890", Slot = "5")]
    public FlowNode_ReqConceptCardSet.MP_SetConceptCard_OverWriteResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqConceptCardSet.MP_SetConceptCard_OverWriteResponse) null;
    }
  }
}
