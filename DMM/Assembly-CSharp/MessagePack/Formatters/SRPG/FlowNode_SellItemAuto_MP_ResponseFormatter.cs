// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_SellItemAuto_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AC6")]
  public sealed class FlowNode_SellItemAuto_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_SellItemAuto.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A1C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A1D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029A0")]
    [Address(RVA = "0xF0D5C0", Offset = "0xF0C3C0", VA = "0x10F0D5C0")]
    public FlowNode_SellItemAuto_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60029A1")]
    [Address(RVA = "0xF0D2D0", Offset = "0xF0C0D0", VA = "0x10F0D2D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_SellItemAuto.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029A2")]
    [Address(RVA = "0xF0CEA0", Offset = "0xF0BCA0", VA = "0x10F0CEA0", Slot = "5")]
    public FlowNode_SellItemAuto.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_SellItemAuto.MP_Response) null;
    }
  }
}
