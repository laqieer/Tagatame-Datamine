// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqRuneDedicated_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000957")]
  public sealed class FlowNode_ReqRuneDedicated_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqRuneDedicated.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400173E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400173F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002553")]
    [Address(RVA = "0xE12280", Offset = "0xE11080", VA = "0x10E12280")]
    public FlowNode_ReqRuneDedicated_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002554")]
    [Address(RVA = "0xE11F90", Offset = "0xE10D90", VA = "0x10E11F90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqRuneDedicated.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002555")]
    [Address(RVA = "0xE11B60", Offset = "0xE10960", VA = "0x10E11B60", Slot = "5")]
    public FlowNode_ReqRuneDedicated.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqRuneDedicated.MP_Response) null;
    }
  }
}
