// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqSellItemAutoCheck_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AB0")]
  public sealed class FlowNode_ReqSellItemAutoCheck_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqSellItemAutoCheck.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019F0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019F1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600295E")]
    [Address(RVA = "0xF0C120", Offset = "0xF0AF20", VA = "0x10F0C120")]
    public FlowNode_ReqSellItemAutoCheck_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600295F")]
    [Address(RVA = "0xF0BE30", Offset = "0xF0AC30", VA = "0x10F0BE30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqSellItemAutoCheck.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002960")]
    [Address(RVA = "0xF0BA00", Offset = "0xF0A800", VA = "0x10F0BA00", Slot = "5")]
    public FlowNode_ReqSellItemAutoCheck.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqSellItemAutoCheck.MP_Response) null;
    }
  }
}
