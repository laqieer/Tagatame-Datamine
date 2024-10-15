// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqRecoverMonthly_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000870")]
  public sealed class FlowNode_ReqRecoverMonthly_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqRecoverMonthly.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001570")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001571")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600229E")]
    [Address(RVA = "0xD9B300", Offset = "0xD9A100", VA = "0x10D9B300")]
    public FlowNode_ReqRecoverMonthly_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600229F")]
    [Address(RVA = "0xD9B010", Offset = "0xD99E10", VA = "0x10D9B010", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqRecoverMonthly.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022A0")]
    [Address(RVA = "0xD9ABE0", Offset = "0xD999E0", VA = "0x10D9ABE0", Slot = "5")]
    public FlowNode_ReqRecoverMonthly.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqRecoverMonthly.MP_Response) null;
    }
  }
}
