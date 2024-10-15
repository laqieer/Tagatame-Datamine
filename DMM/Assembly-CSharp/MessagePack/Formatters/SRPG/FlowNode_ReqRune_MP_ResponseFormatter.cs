// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqRune_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200085E")]
  public sealed class FlowNode_ReqRune_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqRune.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400154C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400154D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002268")]
    [Address(RVA = "0xD856C0", Offset = "0xD844C0", VA = "0x10D856C0")]
    public FlowNode_ReqRune_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002269")]
    [Address(RVA = "0xD853D0", Offset = "0xD841D0", VA = "0x10D853D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqRune.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600226A")]
    [Address(RVA = "0xD84FA0", Offset = "0xD83DA0", VA = "0x10D84FA0", Slot = "5")]
    public FlowNode_ReqRune.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqRune.MP_Response) null;
    }
  }
}
