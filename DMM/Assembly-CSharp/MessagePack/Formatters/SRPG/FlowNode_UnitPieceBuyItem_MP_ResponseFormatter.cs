// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_UnitPieceBuyItem_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200090F")]
  public sealed class FlowNode_UnitPieceBuyItem_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_UnitPieceBuyItem.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016AE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016AF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600247B")]
    [Address(RVA = "0xDE0CA0", Offset = "0xDDFAA0", VA = "0x10DE0CA0")]
    public FlowNode_UnitPieceBuyItem_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600247C")]
    [Address(RVA = "0xDE09B0", Offset = "0xDDF7B0", VA = "0x10DE09B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_UnitPieceBuyItem.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600247D")]
    [Address(RVA = "0xDE0580", Offset = "0xDDF380", VA = "0x10DE0580", Slot = "5")]
    public FlowNode_UnitPieceBuyItem.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_UnitPieceBuyItem.MP_Response) null;
    }
  }
}
