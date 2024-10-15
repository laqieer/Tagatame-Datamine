// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqRuneEquip_MP_Response_OverWriteFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009F2")]
  public sealed class FlowNode_ReqRuneEquip_MP_Response_OverWriteFormatter : 
    IMessagePackFormatter<FlowNode_ReqRuneEquip.MP_Response_OverWrite>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001874")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001875")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002724")]
    [Address(RVA = "0xE81830", Offset = "0xE80630", VA = "0x10E81830")]
    public FlowNode_ReqRuneEquip_MP_Response_OverWriteFormatter()
    {
    }

    [Token(Token = "0x6002725")]
    [Address(RVA = "0xE81540", Offset = "0xE80340", VA = "0x10E81540", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqRuneEquip.MP_Response_OverWrite value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002726")]
    [Address(RVA = "0xE81110", Offset = "0xE7FF10", VA = "0x10E81110", Slot = "5")]
    public FlowNode_ReqRuneEquip.MP_Response_OverWrite Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqRuneEquip.MP_Response_OverWrite) null;
    }
  }
}
