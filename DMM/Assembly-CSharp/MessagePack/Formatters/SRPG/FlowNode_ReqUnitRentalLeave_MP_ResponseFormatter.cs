// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqUnitRentalLeave_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009BB")]
  public sealed class FlowNode_ReqUnitRentalLeave_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqUnitRentalLeave.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001806")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001807")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600267F")]
    [Address(RVA = "0xE6C5D0", Offset = "0xE6B3D0", VA = "0x10E6C5D0")]
    public FlowNode_ReqUnitRentalLeave_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002680")]
    [Address(RVA = "0xE6C2E0", Offset = "0xE6B0E0", VA = "0x10E6C2E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqUnitRentalLeave.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002681")]
    [Address(RVA = "0xE6BEB0", Offset = "0xE6ACB0", VA = "0x10E6BEB0", Slot = "5")]
    public FlowNode_ReqUnitRentalLeave.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqUnitRentalLeave.MP_Response) null;
    }
  }
}
