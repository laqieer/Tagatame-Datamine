// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqUnitRentalExec_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000882")]
  public sealed class FlowNode_ReqUnitRentalExec_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqUnitRentalExec.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001594")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001595")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022D4")]
    [Address(RVA = "0xD9D1F0", Offset = "0xD9BFF0", VA = "0x10D9D1F0")]
    public FlowNode_ReqUnitRentalExec_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60022D5")]
    [Address(RVA = "0xD9CF00", Offset = "0xD9BD00", VA = "0x10D9CF00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqUnitRentalExec.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022D6")]
    [Address(RVA = "0xD9CAD0", Offset = "0xD9B8D0", VA = "0x10D9CAD0", Slot = "5")]
    public FlowNode_ReqUnitRentalExec.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqUnitRentalExec.MP_Response) null;
    }
  }
}
