// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqRunePrideOpen_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B1B")]
  public sealed class FlowNode_ReqRunePrideOpen_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqRunePrideOpen.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AC6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AC7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A9F")]
    [Address(RVA = "0xF3A3E0", Offset = "0xF391E0", VA = "0x10F3A3E0")]
    public FlowNode_ReqRunePrideOpen_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002AA0")]
    [Address(RVA = "0xF3A0F0", Offset = "0xF38EF0", VA = "0x10F3A0F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqRunePrideOpen.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002AA1")]
    [Address(RVA = "0xF39CC0", Offset = "0xF38AC0", VA = "0x10F39CC0", Slot = "5")]
    public FlowNode_ReqRunePrideOpen.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqRunePrideOpen.MP_Response) null;
    }
  }
}
