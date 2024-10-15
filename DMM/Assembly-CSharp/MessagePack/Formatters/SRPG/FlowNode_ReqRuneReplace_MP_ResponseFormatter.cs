// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqRuneReplace_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A2B")]
  public sealed class FlowNode_ReqRuneReplace_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqRuneReplace.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018E6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018E7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027CF")]
    [Address(RVA = "0xE9C550", Offset = "0xE9B350", VA = "0x10E9C550")]
    public FlowNode_ReqRuneReplace_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60027D0")]
    [Address(RVA = "0xE9C260", Offset = "0xE9B060", VA = "0x10E9C260", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqRuneReplace.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027D1")]
    [Address(RVA = "0xE9BE30", Offset = "0xE9AC30", VA = "0x10E9BE30", Slot = "5")]
    public FlowNode_ReqRuneReplace.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqRuneReplace.MP_Response) null;
    }
  }
}
