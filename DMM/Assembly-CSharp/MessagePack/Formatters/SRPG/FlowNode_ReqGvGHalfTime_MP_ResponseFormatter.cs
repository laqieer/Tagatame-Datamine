// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGvGHalfTime_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009B9")]
  public sealed class FlowNode_ReqGvGHalfTime_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGvGHalfTime.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001802")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001803")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002679")]
    [Address(RVA = "0xE69C90", Offset = "0xE68A90", VA = "0x10E69C90")]
    public FlowNode_ReqGvGHalfTime_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600267A")]
    [Address(RVA = "0xE699A0", Offset = "0xE687A0", VA = "0x10E699A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGvGHalfTime.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600267B")]
    [Address(RVA = "0xE69570", Offset = "0xE68370", VA = "0x10E69570", Slot = "5")]
    public FlowNode_ReqGvGHalfTime.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGvGHalfTime.MP_Response) null;
    }
  }
}
