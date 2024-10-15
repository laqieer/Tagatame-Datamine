// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqWorldRaid_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008D0")]
  public sealed class FlowNode_ReqWorldRaid_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqWorldRaid.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001630")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001631")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023BE")]
    [Address(RVA = "0xDCB280", Offset = "0xDCA080", VA = "0x10DCB280")]
    public FlowNode_ReqWorldRaid_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60023BF")]
    [Address(RVA = "0xDCAF90", Offset = "0xDC9D90", VA = "0x10DCAF90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqWorldRaid.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023C0")]
    [Address(RVA = "0xDCAB60", Offset = "0xDC9960", VA = "0x10DCAB60", Slot = "5")]
    public FlowNode_ReqWorldRaid.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqWorldRaid.MP_Response) null;
    }
  }
}
