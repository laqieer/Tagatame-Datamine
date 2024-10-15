// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqRuneEquip_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009F1")]
  public sealed class FlowNode_ReqRuneEquip_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqRuneEquip.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001872")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001873")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002721")]
    [Address(RVA = "0xE80DE0", Offset = "0xE7FBE0", VA = "0x10E80DE0")]
    public FlowNode_ReqRuneEquip_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002722")]
    [Address(RVA = "0xE80AF0", Offset = "0xE7F8F0", VA = "0x10E80AF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqRuneEquip.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002723")]
    [Address(RVA = "0xE806C0", Offset = "0xE7F4C0", VA = "0x10E806C0", Slot = "5")]
    public FlowNode_ReqRuneEquip.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqRuneEquip.MP_Response) null;
    }
  }
}
