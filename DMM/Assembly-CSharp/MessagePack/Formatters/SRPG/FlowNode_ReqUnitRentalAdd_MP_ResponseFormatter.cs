// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqUnitRentalAdd_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B26")]
  public sealed class FlowNode_ReqUnitRentalAdd_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqUnitRentalAdd.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001ADC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001ADD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002AC0")]
    [Address(RVA = "0xF3C2D0", Offset = "0xF3B0D0", VA = "0x10F3C2D0")]
    public FlowNode_ReqUnitRentalAdd_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002AC1")]
    [Address(RVA = "0xF3BFE0", Offset = "0xF3ADE0", VA = "0x10F3BFE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqUnitRentalAdd.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002AC2")]
    [Address(RVA = "0xF3BBB0", Offset = "0xF3A9B0", VA = "0x10F3BBB0", Slot = "5")]
    public FlowNode_ReqUnitRentalAdd.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqUnitRentalAdd.MP_Response) null;
    }
  }
}
